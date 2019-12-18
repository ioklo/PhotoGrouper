using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using PhotoGrouper.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoGrouper
{   
    public partial class MainForm : Form
    {   
        List<PhotoEntry> entries;
        bool bIsFolderActionRegistered;

        public MainForm()
        {
            entries = new List<PhotoEntry>();

            InitializeComponent();

            findDestFolderButton.Enabled = false;
            startButton.Enabled = false;

            UpdateFolderActionRegistered();            
        }

        internal async void StartSetOrigPath(string origPath)
        {
            origFolderTextBox.Text = origPath;
            destFolderTextBox.Text = origPath;

            findDestFolderButton.Enabled = false;
            await UpdateStatusListItemAsync();
            findDestFolderButton.Enabled = true;
        }

        private void UpdateFolderActionRegistered()
        {
            using var backgroundActionKey = Registry.CurrentUser.OpenSubKey(@"Software\Classes\Directory\Background\shell\PhotoGrouper");
            using var actionKey = Registry.CurrentUser.OpenSubKey(@"Software\Classes\Directory\shell\PhotoGrouper");

            bIsFolderActionRegistered = actionKey != null && backgroundActionKey != null;
            toggleRegisterFolderAction.Text = bIsFolderActionRegistered ? "컨텍스트 메뉴 해제" : "컨텍스트 메뉴 등록";
        }

        private void findOrigFolderButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new CommonOpenFileDialog();
            openFileDialog.IsFolderPicker = true;

            var result = openFileDialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                StartSetOrigPath(openFileDialog.FileName);
            }
        }

        private async ValueTask UpdateStatusListItemAsync()
        {
            try
            {
                string path = origFolderTextBox.Text;
                string destPath = destFolderTextBox.Text;

                startButton.Enabled = false;
                entries.Clear();
                var finder = new PhotoFinder();

                await foreach (var photoEntry in finder.Find(path))
                {
                    var item = new ListViewItem(photoEntry.OrigPath);
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Path.Combine(destPath, photoEntry.DestRelativePath)));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, photoEntry.Status.ToString()));

                    item.Tag = photoEntry;
                    statusListView.Items.Add(item);
                }

            }
            finally
            {
                startButton.Enabled = true;
            }
        }

        private void findDestFolderButton_Click(object sender, EventArgs e)
        {   
            var openFileDialog = new CommonOpenFileDialog();
            openFileDialog.IsFolderPicker = true;

            var result = openFileDialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                destFolderTextBox.Text = openFileDialog.FileName;

                foreach(ListViewItem item in statusListView.Items)
                {
                    var photoEntry = item.Tag as PhotoEntry;
                    item.SubItems[1].Text = Path.Combine(destFolderTextBox.Text, photoEntry.DestRelativePath);
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;

            var destFolderPath = destFolderTextBox.Text;

            foreach(ListViewItem item in statusListView.Items)
            {
                var entry = item.Tag as PhotoEntry;
                if (entry.Status != PhotoEntryStatus.Wait) continue;

                try
                {
                    await Task.Run(() =>
                    {
                        var destPath = Path.Combine(destFolderPath, entry.DestRelativePath);
                        var directoryName = Path.GetDirectoryName(destPath);
                        Directory.CreateDirectory(directoryName);

                        File.Move(entry.OrigPath, destPath);
                    });

                    entry.Status = PhotoEntryStatus.Success;
                }
                catch
                {
                    entry.Status = PhotoEntryStatus.Fail;
                }

                item.SubItems[2].Text = entry.Status.ToString();
            }

            startButton.Enabled = true;
        }

        private void toggleRegisterFolderAction_Click(object sender, EventArgs e)
        {
            void Register(string subKey)
            {
                try
                {
                    using var key = Registry.CurrentUser.CreateSubKey(subKey);
                    key.SetValue(string.Empty, "날짜로 사진 분류(&D)...");

                    using (var commandkey = key.CreateSubKey("command"))
                    {
                        var path = Assembly.GetEntryAssembly().Location;
                        commandkey.SetValue(string.Empty, $"\"{path}\" \"%V\"");
                    }
                }
                catch
                {

                }
            }

            if (!bIsFolderActionRegistered)
            {
                Register(@"Software\Classes\Directory\shell\PhotoGrouper");
                Register(@"Software\Classes\Directory\Background\shell\PhotoGrouper");
            }
            else
            {
                Registry.CurrentUser.DeleteSubKeyTree(@"Software\Classes\Directory\shell\PhotoGrouper", false);
                Registry.CurrentUser.DeleteSubKeyTree(@"Software\Classes\Directory\Background\shell\PhotoGrouper", false);
            } 
            
            UpdateFolderActionRegistered();
        }
    }
}
