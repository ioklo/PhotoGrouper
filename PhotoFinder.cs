using ExifLib;
using PhotoGrouper.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PhotoGrouper
{
    class PhotoFinder
    {
        void FindSync(string path, Channel<PhotoEntry> channel)
        {
            try
            {
                var infos = new Dictionary<string, List<(string from, string to)>>();

                foreach (var file in Directory.GetFiles(path, "*.jpg"))
                {
                    try
                    {
                        using (var reader = new ExifReader(file))
                        {
                            if (reader.GetTagValue<DateTime>(ExifTags.DateTime, out var dateTime))
                            {
                                var dest = Path.Combine(dateTime.ToShortDateString(), Path.GetFileName(file));

                                channel.Writer.TryWrite(new PhotoEntry(file, dest, PhotoEntryStatus.Wait));
                            }
                        }
                    }
                    catch
                    {
                        channel.Writer.TryWrite(new PhotoEntry(file, "EXIF 읽기 실패", PhotoEntryStatus.Fail));
                    }
                }
            }
            finally
            {
                channel.Writer.Complete();
            }
        }

        public async IAsyncEnumerable<PhotoEntry> Find(string path)
        {
            var channel = Channel.CreateUnbounded<PhotoEntry>();
            var findTask = Task.Run(() => FindSync(path, channel));

            while(await channel.Reader.WaitToReadAsync())
            {
                if (!channel.Reader.TryRead(out var photoEntry)) break;
                yield return photoEntry;
            }
        }
    }
}
