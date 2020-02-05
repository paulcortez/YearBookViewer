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
        [BsonRef("documentPages")]
        public List<DocumentPages> DocPages { get; set; }


        private static string DataLocation = Properties.Settings.Default.DataFile;
        private static string CollectionName = "documents";


        public static List<Document> GetAllDocument()
        {
            List<Document> documentList = null;

            BsonMapper mapper = new BsonMapper();

            mapper.Entity<Document>().
                DbRef(c => c.DocPages, "documentPages");

            using (var db = new LiteDatabase(DataLocation, mapper))
            {
                var col = db.GetCollection<Document>(CollectionName);

                documentList = col.Include(c => c.DocPages).FindAll().ToList();
            }

            return documentList;
        }

        public static Document GetDocumentById(ObjectId documentId)
        {
            Document document = null;

            BsonMapper mapper = new BsonMapper();

            mapper.Entity<Document>().
                DbRef(c => c.DocPages, "documentPages");

            using (var db = new LiteDatabase(DataLocation, mapper))
            {
                var col = db.GetCollection<Document>(CollectionName);

                document = col.Include(c => c.DocPages).FindById(documentId);
            }

            return document;
        }


        public static bool InsertUpdateDocument(Document document)
        {
            bool isSuccess = false;

            using (var db = new LiteDatabase(DataLocation))
            {
                var col = db.GetCollection<Document>(CollectionName);

                try
                {
                    col.Upsert(document);
                    col.EnsureIndex(c => c.DocPages);
                    isSuccess = true;
                }
                catch (Exception) { }
            }

            return isSuccess;
        }
    }
}
