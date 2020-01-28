namespace YearBookViewer.pages
{
    partial class YearbookView
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
            this.pnlImageContainer = new System.Windows.Forms.Panel();
            this.imgContainer = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnSlideRight = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.btnSlideLeft = new System.Windows.Forms.Button();
            this.tbImageZoom = new System.Windows.Forms.TrackBar();
            this.pnlImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContainer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImageContainer
            // 
            this.pnlImageContainer.AutoScroll = true;
            this.pnlImageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnlImageContainer.Controls.Add(this.imgContainer);
            this.pnlImageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImageContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlImageContainer.Name = "pnlImageContainer";
            this.pnlImageContainer.Size = new System.Drawing.Size(1180, 743);
            this.pnlImageContainer.TabIndex = 0;
            // 
            // imgContainer
            // 
            this.imgContainer.Location = new System.Drawing.Point(0, 0);
            this.imgContainer.Name = "imgContainer";
            this.imgContainer.Size = new System.Drawing.Size(100, 50);
            this.imgContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgContainer.TabIndex = 0;
            this.imgContainer.TabStop = false;
            this.imgContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgContainer_MouseDown);
            this.imgContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgContainer_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbImageZoom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnRotateRight);
            this.panel2.Controls.Add(this.btnSlideRight);
            this.panel2.Controls.Add(this.btnRotateLeft);
            this.panel2.Controls.Add(this.btnSlideLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 743);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 45);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zoom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rotate";
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.FlatAppearance.BorderSize = 0;
            this.btnRotateRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRotateRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRotateRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotateRight.Image = global::YearBookViewer.Properties.Resources.RotateRight32;
            this.btnRotateRight.Location = new System.Drawing.Point(88, 6);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(32, 32);
            this.btnRotateRight.TabIndex = 0;
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.BtnRotateRight_Click);
            // 
            // btnSlideRight
            // 
            this.btnSlideRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSlideRight.FlatAppearance.BorderSize = 0;
            this.btnSlideRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSlideRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSlideRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlideRight.Image = global::YearBookViewer.Properties.Resources.ArrowRight32;
            this.btnSlideRight.Location = new System.Drawing.Point(593, 6);
            this.btnSlideRight.Name = "btnSlideRight";
            this.btnSlideRight.Size = new System.Drawing.Size(32, 32);
            this.btnSlideRight.TabIndex = 0;
            this.btnSlideRight.UseVisualStyleBackColor = true;
            this.btnSlideRight.Click += new System.EventHandler(this.BtnSlideRight_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.FlatAppearance.BorderSize = 0;
            this.btnRotateLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRotateLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRotateLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotateLeft.Image = global::YearBookViewer.Properties.Resources.RotateLeft32;
            this.btnRotateLeft.Location = new System.Drawing.Point(3, 6);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(32, 32);
            this.btnRotateLeft.TabIndex = 0;
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.BtnRotateLeft_Click);
            // 
            // btnSlideLeft
            // 
            this.btnSlideLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSlideLeft.FlatAppearance.BorderSize = 0;
            this.btnSlideLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSlideLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSlideLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlideLeft.Image = global::YearBookViewer.Properties.Resources.ArrowLeft32;
            this.btnSlideLeft.Location = new System.Drawing.Point(555, 6);
            this.btnSlideLeft.Name = "btnSlideLeft";
            this.btnSlideLeft.Size = new System.Drawing.Size(32, 32);
            this.btnSlideLeft.TabIndex = 0;
            this.btnSlideLeft.UseVisualStyleBackColor = true;
            this.btnSlideLeft.Click += new System.EventHandler(this.BtnSlideLeft_Click);
            // 
            // tbImageZoom
            // 
            this.tbImageZoom.Location = new System.Drawing.Point(187, 6);
            this.tbImageZoom.Maximum = 20;
            this.tbImageZoom.Name = "tbImageZoom";
            this.tbImageZoom.Size = new System.Drawing.Size(255, 45);
            this.tbImageZoom.TabIndex = 3;
            this.tbImageZoom.Value = 10;
            this.tbImageZoom.Scroll += new System.EventHandler(this.TbImageZoom_Scroll);
            // 
            // YearbookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlImageContainer);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "YearbookView";
            this.Size = new System.Drawing.Size(1180, 788);
            this.Load += new System.EventHandler(this.YearbookView_Load);
            this.pnlImageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgContainer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImageContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSlideLeft;
        private System.Windows.Forms.Button btnSlideRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnRotateLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbImageZoom;
    }
}
