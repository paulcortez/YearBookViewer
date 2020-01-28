namespace YearBookViewer.pages
{
    partial class SettingsAndMaintenance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.fbdBrowseDocLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.vsMainContainer = new YearBookViewer.ViewStack();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveDocLocation = new System.Windows.Forms.Button();
            this.btnBrowseDocLocation = new System.Windows.Forms.Button();
            this.txtSourceDocumentPath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.vsMainContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.panel1.Size = new System.Drawing.Size(220, 768);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(25, 70);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 15);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Source Document";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance";
            // 
            // vsMainContainer
            // 
            this.vsMainContainer.Controls.Add(this.tabPage1);
            this.vsMainContainer.Controls.Add(this.tabPage2);
            this.vsMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vsMainContainer.Location = new System.Drawing.Point(220, 0);
            this.vsMainContainer.Name = "vsMainContainer";
            this.vsMainContainer.SelectedIndex = 0;
            this.vsMainContainer.Size = new System.Drawing.Size(1146, 768);
            this.vsMainContainer.TabIndex = 1;
            this.vsMainContainer.SelectedIndexChanged += new System.EventHandler(this.VsMainContainer_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1138, 740);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSaveDocLocation);
            this.panel3.Controls.Add(this.btnBrowseDocLocation);
            this.panel3.Controls.Add(this.txtSourceDocumentPath);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(1138, 665);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Please specify source document location";
            // 
            // btnSaveDocLocation
            // 
            this.btnSaveDocLocation.Location = new System.Drawing.Point(748, 38);
            this.btnSaveDocLocation.Name = "btnSaveDocLocation";
            this.btnSaveDocLocation.Size = new System.Drawing.Size(90, 23);
            this.btnSaveDocLocation.TabIndex = 3;
            this.btnSaveDocLocation.Text = "Save";
            this.btnSaveDocLocation.UseVisualStyleBackColor = true;
            this.btnSaveDocLocation.Click += new System.EventHandler(this.BtnSaveDocLocation_Click);
            // 
            // btnBrowseDocLocation
            // 
            this.btnBrowseDocLocation.Location = new System.Drawing.Point(652, 38);
            this.btnBrowseDocLocation.Name = "btnBrowseDocLocation";
            this.btnBrowseDocLocation.Size = new System.Drawing.Size(90, 23);
            this.btnBrowseDocLocation.TabIndex = 3;
            this.btnBrowseDocLocation.Text = "Browse...";
            this.btnBrowseDocLocation.UseVisualStyleBackColor = true;
            this.btnBrowseDocLocation.Click += new System.EventHandler(this.BtnBrowseDocLocation_Click);
            // 
            // txtSourceDocumentPath
            // 
            this.txtSourceDocumentPath.Location = new System.Drawing.Point(26, 38);
            this.txtSourceDocumentPath.Name = "txtSourceDocumentPath";
            this.txtSourceDocumentPath.ReadOnly = true;
            this.txtSourceDocumentPath.Size = new System.Drawing.Size(620, 23);
            this.txtSourceDocumentPath.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1138, 75);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Source Document Settings";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1138, 740);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SettingsAndMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.vsMainContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsAndMaintenance";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.SettingsAndMaintenance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.vsMainContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ViewStack vsMainContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseDocLocation;
        private System.Windows.Forms.TextBox txtSourceDocumentPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSaveDocLocation;
        private System.Windows.Forms.FolderBrowserDialog fbdBrowseDocLocation;
    }
}
