using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace YearBookViewer.DataObj
{
    public class DocPage
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocumentID { get; set; }
        public string DateOnDoc { get; set; }
        public string DocTitle { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }
        public byte[] ThumbImg { get; set; }
        public int Page { get; set; }
        public string DocumentOwner { get; set; }
        public string ImageId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateEdited { get; set; }


        //private static string DataLocation = String.Format(@"{0}\{1}", Properties.Settings.Default.DataLocation, Properties.Settings.Default.DataFile);
        //private static string CollectionName = "docPages";
    }
}
