﻿namespace Music_Application
{
    partial class ucMusicInQueue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMusicInQueue));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.removeBt = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playlistBt = new System.Windows.Forms.PictureBox();
            this.playBt = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.removeBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistBt)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(428, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trúc Nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Có Không Giữ Mất Đừng Tìm";
            // 
            // removeBt
            // 
            this.removeBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeBt.BackgroundImage")));
            this.removeBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBt.Location = new System.Drawing.Point(960, 14);
            this.removeBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeBt.Name = "removeBt";
            this.removeBt.Size = new System.Drawing.Size(24, 24);
            this.removeBt.TabIndex = 6;
            this.removeBt.TabStop = false;
            this.removeBt.Click += new System.EventHandler(this.removeBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // playlistBt
            // 
            this.playlistBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playlistBt.BackgroundImage")));
            this.playlistBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playlistBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistBt.Location = new System.Drawing.Point(999, 14);
            this.playlistBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playlistBt.Name = "playlistBt";
            this.playlistBt.Size = new System.Drawing.Size(24, 24);
            this.playlistBt.TabIndex = 8;
            this.playlistBt.TabStop = false;
            this.playlistBt.Click += new System.EventHandler(this.playlistBt_Click);
            // 
            // playBt
            // 
            this.playBt.ActiveImage = null;
            this.playBt.AllowAnimations = true;
            this.playBt.AllowBuffering = false;
            this.playBt.AllowToggling = false;
            this.playBt.AllowZooming = true;
            this.playBt.AllowZoomingOnFocus = false;
            this.playBt.BackColor = System.Drawing.Color.Transparent;
            this.playBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.playBt.ErrorImage = ((System.Drawing.Image)(resources.GetObject("playBt.ErrorImage")));
            this.playBt.FadeWhenInactive = false;
            this.playBt.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.playBt.ForeColor = System.Drawing.Color.Transparent;
            this.playBt.Image = ((System.Drawing.Image)(resources.GetObject("playBt.Image")));
            this.playBt.ImageActive = null;
            this.playBt.ImageLocation = null;
            this.playBt.ImageMargin = 0;
            this.playBt.ImageSize = new System.Drawing.Size(23, 23);
            this.playBt.ImageZoomSize = new System.Drawing.Size(24, 24);
            this.playBt.InitialImage = ((System.Drawing.Image)(resources.GetObject("playBt.InitialImage")));
            this.playBt.Location = new System.Drawing.Point(920, 14);
            this.playBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playBt.Name = "playBt";
            this.playBt.Rotation = 0;
            this.playBt.ShowActiveImage = true;
            this.playBt.ShowCursorChanges = true;
            this.playBt.ShowImageBorders = true;
            this.playBt.ShowSizeMarkers = false;
            this.playBt.Size = new System.Drawing.Size(24, 24);
            this.playBt.TabIndex = 19;
            this.playBt.ToolTipText = "";
            this.playBt.WaitOnLoad = false;
            this.playBt.Zoom = 0;
            this.playBt.ZoomSpeed = 10;
            this.playBt.Click += new System.EventHandler(this.playBt_Click);
            // 
            // ucMusicInQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.playBt);
            this.Controls.Add(this.playlistBt);
            this.Controls.Add(this.removeBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucMusicInQueue";
            this.Size = new System.Drawing.Size(1045, 49);
            ((System.ComponentModel.ISupportInitialize)(this.removeBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistBt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox removeBt;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox playlistBt;
        public Bunifu.UI.WinForms.BunifuImageButton playBt;
    }
}
