using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YearBookViewer.pages
{
    public partial class Dashboard : UserControl
    {
        private List<DataObj.Document> documents = new List<DataObj.Document>();

        public Dashboard()
        {
            InitializeComponent();
        }



        private void Dashboard_Load(object sender, EventArgs e)
        {
            //LoadSourceDocumentPath();

            //treeView1.Nodes.Add("hello");
            //TreeNode treeNode = new TreeNode("meme");
            //treeView1.Nodes.Add("haha").Nodes.Add(treeNode);
            //treeView1.Nodes.Add("haha");

            List<DataObj.DocumentPages> documentPages = null;

            documents = DataObj.Document.GetAllDocument();

            foreach(DataObj.Document document in documents)
            {
                if (documentPages == null)
                    documentPages = document.DocPages;

                LinkLabel linkLabel = new LinkLabel()
                {
                    Text = document.DocumentTitle,
                    LinkColor = Color.White,
                    LinkBehavior = LinkBehavior.HoverUnderline,
                    Width = flpDocumentList.Width - 25,
                    Height = 32,
                    Tag = document.DocPages,
                    Font = new Font("Segoe UI", 12F)
                };

                linkLabel.Click += LinkLabel_Click;

                flpDocumentList.Controls.Add(linkLabel);
            }

            if (documentPages != null)
                PopulateFlpDocumentPage(documentPages);
        }

        private void LinkLabel_Click(object sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;

            PopulateFlpDocumentPage((List<DataObj.DocumentPages>)linkLabel.Tag);   
        }

        private void PopulateFlpDocumentPage(List<DataObj.DocumentPages> documentPages)
        {
            if (flpDocumentPages.Controls.Count > 0)
                flpDocumentPages.Controls.Clear();

            foreach (DataObj.DocumentPages docPage in documentPages)
            {
                Panel panel = new Panel()
                {
                    Size = new Size(200, 200),
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = docPage
                };

                PictureBox pic = new PictureBox()
                {
                    Image = docPage.GetThumbnailImage(),
                    Size = docPage.GetThumbnailImage().Size,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(0, 0),
                    Tag = docPage
                };

                panel.Controls.Add(pic);
                panel.Click += Panel_Click;
                pic.Click += Pic_Click;

                flpDocumentPages.Controls.Add(panel);
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            DataObj.DocumentPages documentPage = (DataObj.DocumentPages)((PictureBox)sender).Tag;

            ((Home)this.Tag).Navigate(new pages.YearbookView(documentPage.ParentDocument, documentPage.Page));
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            DataObj.DocumentPages documentPage = (DataObj.DocumentPages)((Panel)sender).Tag;

            ((Home)this.Tag).Navigate(new pages.YearbookView(documentPage.ParentDocument, documentPage.Page));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<DataObj.DocumentPages> foundDocuments = DataObj.DocumentPages.GetDocumentContainsInContent(txtSearch.Text);

            PopulateFlpDocumentPage(foundDocuments);
        }
    }
}
