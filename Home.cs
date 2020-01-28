using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearBookViewer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        public void Navigate(UserControl page)
        {
            if (pnlMainContainer.Controls.Count > 0)
                pnlMainContainer.Controls.Clear();

            page.Dock = DockStyle.Fill;
            page.Tag = this;

            pnlMainContainer.Controls.Add(page);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GoFullscreen(true);
            Navigate(new pages.Dashboard());
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Navigate(new pages.Dashboard());
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Navigate(new pages.SettingsAndMaintenance());
        }
    }
}
