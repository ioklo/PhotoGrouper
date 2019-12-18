using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGrouper.Model
{
    enum PhotoEntryStatus
    {
        Wait,
        Success,
        Fail,
    }

    class PhotoEntry
    {
        public string OrigPath { get; }
        public string DestRelativePath { get; }
        public PhotoEntryStatus Status { get; set; }

        public PhotoEntry(string origPath, string destRelativePath, PhotoEntryStatus status)
        {
            OrigPath = origPath;
            DestRelativePath = destRelativePath;
            Status = status;
        }
    }

}
