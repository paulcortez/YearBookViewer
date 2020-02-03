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
    public partial class SettingsAndMaintenance : UserControl
    {
        public SettingsAndMaintenance()
        {
            InitializeComponent();
        }


        private void LoadSourceDocumentPath()
        {
            try 
            { 
                txtSourceDocumentPath.Text = DataObj.AppSetting.GetSettingsByKey(DataObj.AppSetting.SettingKeys.SOURCEDOCUMENTLOCATION.ToString()).Value.ToString();
                lblSourceDocumentPath.Text = DataObj.AppSetting.GetSettingsByKey(DataObj.AppSetting.SettingKeys.SOURCEDOCUMENTLOCATION.ToString()).Value.ToString();
            }
            catch (Exception) { }
        }


        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value  
            progressBar1.Maximum = Directory.GetFiles(Dir, "*.jpg", SearchOption.AllDirectories).Length + Directory.GetDirectories(Dir, "**", SearchOption.AllDirectories).Length;
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
            string[] Files = Directory.GetFiles(dir, "*.jpg");

            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
                UpdateProgress();


                string folder = Path.GetFileName(Path.GetDirectoryName(file));
                string folder1 = Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(file)));

                TreeNode node = treeView2.Nodes.Cast<TreeNode>().Where(c => c.Text == ((folder1 == "" ? "" : folder1 + " - ")) + folder).FirstOrDefault();

                if (node == null)
                {
                    TreeNode newNode = treeView2.Nodes.Add(((folder1 == "" ? "" : folder1 + " - ")) + folder);
                    newNode.Tag = Path.GetDirectoryName(file);
                    newNode.Nodes.Add(fi.Name).Tag = fi.FullName;
                }
                else
                    node.Nodes.Add(fi.Name).Tag = fi.FullName;

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


        private void SettingsAndMaintenance_Load(object sender, EventArgs e)
        {
            LoadSourceDocumentPath();
        }


        private void VsMainContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(vsMainContainer.SelectedIndex)
            {
                case 0:
                    LoadSourceDocumentPath();
                    break;
            }
        }

        private void BtnBrowseDocLocation_Click(object sender, EventArgs e)
        {
            if(fbdBrowseDocLocation.ShowDialog() == DialogResult.OK)
                txtSourceDocumentPath.Text = fbdBrowseDocLocation.SelectedPath;
        }

        private void BtnSaveDocLocation_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtSourceDocumentPath.Text))
            {
                MessageBox.Show("Error in Path. Make sure that selected path exist.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DataObj.AppSetting.InsertUpdateSettings(new DataObj.AppSetting() { Key = DataObj.AppSetting.SettingKeys.SOURCEDOCUMENTLOCATION.ToString(), Value = txtSourceDocumentPath.Text }))
            {
                MessageBox.Show("Successfully updated settings", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSourceDocumentPath();
            }
            else
                MessageBox.Show("Failed to update settings", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string directoryPath = lblSourceDocumentPath.Text;

            LoadDirectory(directoryPath);
        }

        private void lnkSourceDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vsMainContainer.SelectedIndex = 0;
        }

        private void lnkScanDocFormSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vsMainContainer.SelectedIndex = 1;
        }

        private void btnStartReading_Click(object sender, EventArgs e)
        {
            foreach(TreeNode tn in treeView2.Nodes)
            {
                int page = 1;

                txtReadLog.AppendText("Creating document " + tn.Text.ToString() + Environment.NewLine);

                foreach (TreeNode tn1 in tn.Nodes)
                {
                    txtReadLog.AppendText("\t Reading page " + page.ToString() + Environment.NewLine);
                }

                txtReadLog.AppendText("saving all as single document " + tn.Text.ToString() + Environment.NewLine);
            }
        }
    }
}
