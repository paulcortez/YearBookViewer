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


        public YearbookView()
        {
            InitializeComponent();
        }


        private void YearbookView_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\paul\Pictures\56184176_417009035749531_6089027164773023744_n.jpg");
            imgContainer.Image = img;
            imgContainer.Size = img.Size;
            OriginalSize = img.Size;

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

        }

        private void BtnSlideRight_Click(object sender, EventArgs e)
        {

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
