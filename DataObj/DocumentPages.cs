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
    public class DocumentPages
    {
        [BsonId]
        public int Id { get; set; }
        public string Content { get; set; }
        public byte[] ThumbImg { get; set; }
        public int Page { get; set; }
        public string ImageId { get; set; }
        public ObjectId ParentDocument { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateEdited { get; set; }

        private static string DataLocation = Properties.Settings.Default.DataFile;
        private static string CollectionName = "documentPages";


        public Image GetThumbnailImage()
        {
            Image img = null;

            using (MemoryStream ms = new MemoryStream(this.ThumbImg))
            {
                img = Image.FromStream(ms);
            }

            return img;
        }

        public static DocumentPages GetDocumentById(ObjectId objectId)
        {
            DocumentPages doc = new DocumentPages();

            using (var db = new LiteDatabase(DataLocation))
            {
                var col = db.GetCollection<DocumentPages>(CollectionName);

                doc = col.FindById(objectId);
            }

            return doc;
        }

        public static bool InsertUpdateDocument(DocumentPages documentPages)
        {
            bool isSuccess = false;

            using (var db = new LiteDatabase(DataLocation))
            {
                var col = db.GetCollection<DocumentPages>(CollectionName);

                try
                {
                    col.Upsert(documentPages);
                    isSuccess = true;
                }
                catch (Exception) { }
            }

            return isSuccess;
        }



        public static Size ImageResize(Size size, bool fitToSquare, int targetWidthHeight)
        {
            Size newSize = new Size();
            decimal ratio = 0;

            if (fitToSquare)
            {
                if (size.Width > size.Height)
                    ratio = (decimal)targetWidthHeight / (decimal)size.Width;
                else
                    ratio = (decimal)targetWidthHeight / (decimal)size.Height;
            }
            else
                ratio = (decimal)targetWidthHeight / (decimal)size.Width;

            newSize.Width = (int)((decimal)size.Width * ratio);
            newSize.Height = (int)((decimal)size.Height * ratio);

            return newSize;
        }

        public static byte[] ConvertImageToByte(Image img, Size actualSize)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Bitmap bmp = new Bitmap(img, actualSize);
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.ToArray();
        }

        public static byte[] ConvertImageToByte(Bitmap img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.ToArray();
        }
    }
}
