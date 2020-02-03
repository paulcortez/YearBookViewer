using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace YearBookViewer.DataObj
{
    public class DocumentPages
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Content { get; set; }
        public byte[] ThumbImg { get; set; }
        public int Page { get; set; }
        public string ImageId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateEdited { get; set; }
    }

}
