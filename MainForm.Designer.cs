namespace PhotoGrouper
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.origFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findOrigFolderButton = new System.Windows.Forms.Button();
            this.findDestFolderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.destFolderTextBox = new System.Windows.Forms.TextBox();
            this.statusListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toggleRegisterFolderAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // origFolderTextBox
            // 
            this.origFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.origFolderTextBox.Location = new System.Drawing.Point(12, 24);
            this.origFolderTextBox.Name = "origFolderTextBox";
            this.origFolderTextBox.Size = new System.Drawing.Size(443, 21);
            this.origFolderTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "원본 폴더";
            // 
            // findOrigFolderButton
            // 
            this.findOrigFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findOrigFolderButton.Location = new System.Drawing.Point(461, 24);
            this.findOrigFolderButton.Name = "findOrigFolderButton";
            this.findOrigFolderButton.Size = new System.Drawing.Size(91, 23);
            this.findOrigFolderButton.TabIndex = 2;
            this.findOrigFolderButton.Text = "찾아보기...";
            this.findOrigFolderButton.UseVisualStyleBackColor = true;
            this.findOrigFolderButton.Click += new System.EventHandler(this.findOrigFolderButton_Click);
            // 
            // findDestFolderButton
            // 
            this.findDestFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findDestFolderButton.Location = new System.Drawing.Point(461, 73);
            this.findDestFolderButton.Name = "findDestFolderButton";
            this.findDestFolderButton.Size = new System.Drawing.Size(91, 23);
            this.findDestFolderButton.TabIndex = 5;
            this.findDestFolderButton.Text = "찾아보기...";
            this.findDestFolderButton.UseVisualStyleBackColor = true;
            this.findDestFolderButton.Click += new System.EventHandler(this.findDestFolderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "대상 폴더";
            // 
            // destFolderTextBox
            // 
            this.destFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destFolderTextBox.Location = new System.Drawing.Point(12, 75);
            this.destFolderTextBox.Name = "destFolderTextBox";
            this.destFolderTextBox.Size = new System.Drawing.Size(443, 21);
            this.destFolderTextBox.TabIndex = 3;
            // 
            // statusListView
            // 
            this.statusListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.statusListView.FullRowSelect = true;
            this.statusListView.HideSelection = false;
            this.statusListView.Location = new System.Drawing.Point(12, 132);
            this.statusListView.Name = "statusListView";
            this.statusListView.Size = new System.Drawing.Size(540, 216);
            this.statusListView.TabIndex = 6;
            this.statusListView.UseCompatibleStateImageBehavior = false;
            this.statusListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "원본";
            this.columnHeader1.Width = 242;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "대상";
            this.columnHeader2.Width = 222;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "상태";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(396, 354);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "시작";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(477, 354);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "닫기";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "파일";
            // 
            // toggleRegisterFolderAction
            // 
            this.toggleRegisterFolderAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleRegisterFolderAction.Location = new System.Drawing.Point(12, 355);
            this.toggleRegisterFolderAction.Name = "toggleRegisterFolderAction";
            this.toggleRegisterFolderAction.Size = new System.Drawing.Size(146, 23);
            this.toggleRegisterFolderAction.TabIndex = 10;
            this.toggleRegisterFolderAction.Text = "button1";
            this.toggleRegisterFolderAction.UseVisualStyleBackColor = true;
            this.toggleRegisterFolderAction.Click += new System.EventHandler(this.toggleRegisterFolderAction_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(564, 386);
            this.Controls.Add(this.toggleRegisterFolderAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.statusListView);
            this.Controls.Add(this.findDestFolderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destFolderTextBox);
            this.Controls.Add(this.findOrigFolderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.origFolderTextBox);
            this.Name = "MainForm";
            this.Text = "사진 옮기기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox origFolderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findOrigFolderButton;
        private System.Windows.Forms.Button findDestFolderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destFolderTextBox;
        private System.Windows.Forms.ListView statusListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toggleRegisterFolderAction;
    }
}

