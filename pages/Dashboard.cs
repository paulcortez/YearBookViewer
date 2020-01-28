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
        }
    }
}
