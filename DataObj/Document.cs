using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace YearBookViewer.DataObj
{
    public class Document
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string DocumentTitle { get; set; }
        public string FolderDescription { get; set; }
        public string DocumentFolderPath { get; set; }
        public int TotalPages { get; set; }
        public List<DocumentPages> DocPages { get; set; }


        private static string DataLocation = Properties.Settings.Default.DataFile;
        private static string CollectionName = "documents";


        public static bool InsertUpdateDocument(Document document)
        {
            bool isSuccess = false;

            using (var db = new LiteDatabase(DataLocation))
            {
                var col = db.GetCollection<Document>(CollectionName);

                try
                {
                    col.Upsert(document);
                    isSuccess = true;
                }
                catch (Exception) { }
            }

            return isSuccess;
        }
    }
}
