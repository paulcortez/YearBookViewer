using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearBookViewer.pages
{
    public partial class YearbookView : UserControl
    {
        private Point clickPosition;
        private Point scrollPosition;
        private Size OriginalSize;

        private List<DataObj.DocumentPages> documentPages = new List<DataObj.DocumentPages>();
        private int currentPage = 0;


        public YearbookView()
        {
            InitializeComponent();
        }

        public YearbookView(LiteDB.ObjectId documentId, int pageNo = 1)
        {
            InitializeComponent();

            documentPages = DataObj.Document.GetDocumentById(documentId).DocPages;
            currentPage = pageNo;

            if (pageNo == 1)
                btnSlideLeft.Enabled = false;
            
            if(documentPages.Count == 1)
            {
                btnSlideLeft.Enabled = false;
                btnSlideRight.Enabled = false;
            }
        }


        private void LoadYearBookView()
        {
            if (currentPage >= 0 && currentPage <= documentPages.Count)
            {
                Image img = DataObj.DocumentFileHandler.GetImageDocumentById(documentPages.Where(c => c.Page == currentPage).SingleOrDefault().ImageId);

                imgContainer.Image = img;
                imgContainer.Size = img.Size;
                OriginalSize = img.Size;
            }
        }


        private void YearbookView_Load(object sender, EventArgs e)
        {
            LoadYearBookView();
        }

        private void ImgContainer_MouseDown(object sender, MouseEventArgs e)
        {
            this.clickPosition = e.Location;
        }

        private void ImgContainer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.SuspendLayout();
                this.scrollPosition += (Size)clickPosition - (Size)e.Location;
                this.pnlImageContainer.AutoScrollPosition = scrollPosition;
                this.ResumeLayout(false);
            }
        }

        private void BtnRotateLeft_Click(object sender, EventArgs e)
        {
            imgContainer.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            imgContainer.Size = new Size(imgContainer.Height, imgContainer.Width);
            imgContainer.Refresh();
        }

        private void BtnRotateRight_Click(object sender, EventArgs e)
        {
            imgContainer.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            imgContainer.Size = new Size(imgContainer.Height, imgContainer.Width);
            imgContainer.Refresh();
        }

        private void BtnSlideLeft_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadYearBookView();

            btnSlideRight.Enabled = true;
            btnSlideLeft.Enabled = true;

            if (currentPage == 1)
                btnSlideLeft.Enabled = false;

            
        }

        private void BtnSlideRight_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadYearBookView();

            btnSlideRight.Enabled = true;
            btnSlideLeft.Enabled = true;

            if (currentPage == documentPages.Count)
                btnSlideRight.Enabled = false;

            
        }

        private void TbImageZoom_Scroll(object sender, EventArgs e)
        {
            double scale = (double)tbImageZoom.Value / 10D;

            this.SuspendLayout();
            imgContainer.Size = new Size((int)(OriginalSize.Width * scale), (int)(OriginalSize.Height * scale));
            this.ResumeLayout();
        }
    }
}
