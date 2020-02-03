using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace YearBookViewer.DataObj
{
    public class DocumentFileHandler
    {
        public string Id { get; set; }
        public string FileName { get; set; }
        public Bitmap ImageBmp { get; set; }

        private static string DataLocation = Properties.Settings.Default.ImageStorage;


        public static Bitmap GetImageDocumentById(string Id)
        {
            Bitmap storedImage = null;

            using (MemoryStream ms = new MemoryStream())
            using (var db = new LiteDatabase(DataLocation))
            {
                db.FileStorage.Download(Id, ms);
                storedImage = new Bitmap(ms);
            }

            return storedImage;
        }

        public static bool AddNewImageDocument(DocumentFileHandler docFileHandler)
        {
            bool success = false;

            using (MemoryStream ms = new MemoryStream())
            using (var db = new LiteDatabase(DataLocation))
            {
                try
                {
                    docFileHandler.ImageBmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ms.Position = 0;

                    db.FileStorage.Upload(docFileHandler.Id, docFileHandler.FileName, ms);
                    success = true;
                }
                catch (Exception) { }
            }

            return success;
        }


        public static int DeleteAllFiles()
        {
            int count = 0;

            using (var db = new LiteDatabase(DataLocation))
            {
                List<LiteFileInfo> fileInfoList = db.FileStorage.FindAll().ToList();

                foreach (LiteFileInfo lfi in fileInfoList)
                {
                    db.FileStorage.Delete(lfi.Id);
                    count++;
                }
            }

            return count;
        }
    }
}
