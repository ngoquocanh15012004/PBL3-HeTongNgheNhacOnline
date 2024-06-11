﻿namespace Music_Application.GUI
{
    partial class CollectionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playBt = new System.Windows.Forms.Button();
            this.playlistName = new System.Windows.Forms.Label();
            this.CollectionPic = new System.Windows.Forms.PictureBox();
            this.listPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.collectionName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CollectionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // playBt
            // 
            this.playBt.BackgroundImage = global::Music_Application.Properties.Resources.wplay;
            this.playBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playBt.FlatAppearance.BorderSize = 0;
            this.playBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.playBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.playBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBt.Location = new System.Drawing.Point(1002, 124);
            this.playBt.Name = "playBt";
            this.playBt.Size = new System.Drawing.Size(60, 60);
            this.playBt.TabIndex = 17;
            this.playBt.UseVisualStyleBackColor = true;
            this.playBt.Click += new System.EventHandler(this.playBt_Click);
            // 
            // playlistName
            // 
            this.playlistName.AutoSize = true;
            this.playlistName.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playlistName.Location = new System.Drawing.Point(56, -65);
            this.playlistName.Name = "playlistName";
            this.playlistName.Size = new System.Drawing.Size(158, 58);
            this.playlistName.TabIndex = 16;
            this.playlistName.Text = "label1";
            // 
            // CollectionPic
            // 
            this.CollectionPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CollectionPic.Location = new System.Drawing.Point(12, 9);
            this.CollectionPic.Name = "CollectionPic";
            this.CollectionPic.Size = new System.Drawing.Size(175, 175);
            this.CollectionPic.TabIndex = 15;
            this.CollectionPic.TabStop = false;
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.Location = new System.Drawing.Point(12, 192);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(1050, 400);
            this.listPanel.TabIndex = 14;
            // 
            // collectionName
            // 
            this.collectionName.AutoSize = true;
            this.collectionName.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.collectionName.Location = new System.Drawing.Point(193, 9);
            this.collectionName.Name = "collectionName";
            this.collectionName.Size = new System.Drawing.Size(158, 58);
            this.collectionName.TabIndex = 18;
            this.collectionName.Text = "label1";
            // 
            // CollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1077, 602);
            this.Controls.Add(this.collectionName);
            this.Controls.Add(this.playBt);
            this.Controls.Add(this.playlistName);
            this.Controls.Add(this.CollectionPic);
            this.Controls.Add(this.listPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CollectionForm";
            this.Text = "CollectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.CollectionPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playBt;
        private System.Windows.Forms.Label playlistName;
        private System.Windows.Forms.PictureBox CollectionPic;
        private System.Windows.Forms.FlowLayoutPanel listPanel;
        private System.Windows.Forms.Label collectionName;
    }
}