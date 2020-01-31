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
        public Dashboard()
        {
            InitializeComponent();
        }


        private void LoadSourceDocumentPath()
        {
            try { lblSourceDocumentPath.Text = DataObj.AppSetting.GetSettingsByKey(DataObj.AppSetting.SettingKeys.SOURCEDOCUMENTLOCATION.ToString()).Value.ToString(); }
            catch (Exception) { }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //LoadSourceDocumentPath();

            //treeView1.Nodes.Add("hello");
            //TreeNode treeNode = new TreeNode("meme");
            //treeView1.Nodes.Add("haha").Nodes.Add(treeNode);
            //treeView1.Nodes.Add("haha");

            string directoryPath = @"C:\Centralite\";

            LoadDirectory(directoryPath);
        }

        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value  
            progressBar1.Maximum = Directory.GetFiles(Dir, "*.*", SearchOption.AllDirectories).Length + Directory.GetDirectories(Dir, "**", SearchOption.AllDirectories).Length;
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadSubDirectories(Dir, tds);
            LoadFiles(Dir, tds);
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {

                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadSubDirectories(subdirectory, tds);
                LoadFiles(subdirectory, tds);
                UpdateProgress();

            }
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
                UpdateProgress();

            }
        }

        private void UpdateProgress()
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                progressBar1.CreateGraphics().DrawString(percent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));

                Application.DoEvents();
            }
        }
    }
}
