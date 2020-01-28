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
            try { txtSourceDocumentPath.Text = DataObj.AppSetting.GetSettingsByKey(DataObj.AppSetting.SettingKeys.SOURCEDOCUMENTLOCATION.ToString()).Value.ToString(); }
            catch (Exception) { }
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
    }
}
