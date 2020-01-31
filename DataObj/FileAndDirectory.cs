using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace YearBookViewer.DataObj
{
    public class FileAndDirectory
    {
        [BsonId]
        public int Id { get; set; }
        public bool isFile { get; set; }
        public string filename { get; set; }
        public string filepath { get; set; }
        public bool scanned { get; set; }
        public DateTime lastScanned { get; set; }
    }
}
