using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace YearBookViewer.DataObj
{
    public class Document
    {
        [BsonId]
        public int Id { get; set; }
        public string DocumentTitle { get; set; }
        public string FolderDescription { get; set; }
        public string DocumentFolderPath { get; set; }
        public int TotalPages { get; set; }
        public List<DocumentPages> DocPages { get; set; }

    }
}
