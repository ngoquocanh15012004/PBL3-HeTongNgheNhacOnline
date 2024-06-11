﻿namespace Music_Application.Admin
{
    partial class AddCollectionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.playListLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.DGVSearch = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitBt = new System.Windows.Forms.Button();
            this.removeBt = new System.Windows.Forms.Button();
            this.DGVList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).BeginInit();
            this.SuspendLayout();
            // 
            // playListLabel
            // 
            this.playListLabel.AutoSize = true;
            this.playListLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playListLabel.ForeColor = System.Drawing.Color.White;
            this.playListLabel.Location = new System.Drawing.Point(15, 15);
            this.playListLabel.Name = "playListLabel";
            this.playListLabel.Size = new System.Drawing.Size(172, 24);
            this.playListLabel.TabIndex = 4;
            this.playListLabel.Text = "THÊM TUYỂN TẬP";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.nameTextBox.Location = new System.Drawing.Point(16, 81);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(601, 22);
            this.nameTextBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nhập tên tuyển tập";
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(804, 487);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(81, 31);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(813, 158);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(72, 30);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Tìm";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchTextBox.Location = new System.Drawing.Point(463, 161);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(345, 22);
            this.searchTextBox.TabIndex = 27;
            // 
            // DGVSearch
            // 
            this.DGVSearch.AllowUserToResizeRows = false;
            this.DGVSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DGVSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSearch.ColumnHeadersVisible = false;
            this.DGVSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVSearch.Location = new System.Drawing.Point(463, 192);
            this.DGVSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVSearch.Name = "DGVSearch";
            this.DGVSearch.ReadOnly = true;
            this.DGVSearch.RowHeadersVisible = false;
            this.DGVSearch.RowHeadersWidth = 51;
            this.DGVSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DGVSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DGVSearch.RowTemplate.Height = 24;
            this.DGVSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSearch.Size = new System.Drawing.Size(423, 290);
            this.DGVSearch.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Danh sách nhạc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Thêm nhạc vào tuyển tập";
            // 
            // submitBt
            // 
            this.submitBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBt.Location = new System.Drawing.Point(784, 33);
            this.submitBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBt.Name = "submitBt";
            this.submitBt.Size = new System.Drawing.Size(101, 36);
            this.submitBt.TabIndex = 34;
            this.submitBt.Text = "Submit";
            this.submitBt.UseVisualStyleBackColor = true;
            this.submitBt.Click += new System.EventHandler(this.submitBt_Click);
            // 
            // removeBt
            // 
            this.removeBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBt.Location = new System.Drawing.Point(360, 487);
            this.removeBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeBt.Name = "removeBt";
            this.removeBt.Size = new System.Drawing.Size(81, 31);
            this.removeBt.TabIndex = 35;
            this.removeBt.Text = "Xóa";
            this.removeBt.UseVisualStyleBackColor = true;
            this.removeBt.Click += new System.EventHandler(this.removeBt_Click);
            // 
            // DGVList
            // 
            this.DGVList.AllowUserToResizeRows = false;
            this.DGVList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DGVList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVList.ColumnHeadersVisible = false;
            this.DGVList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVList.Location = new System.Drawing.Point(20, 192);
            this.DGVList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVList.Name = "DGVList";
            this.DGVList.ReadOnly = true;
            this.DGVList.RowHeadersVisible = false;
            this.DGVList.RowHeadersWidth = 51;
            this.DGVList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DGVList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DGVList.RowTemplate.Height = 24;
            this.DGVList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVList.Size = new System.Drawing.Size(423, 290);
            this.DGVList.TabIndex = 36;
            // 
            // AddCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(933, 538);
            this.Controls.Add(this.DGVList);
            this.Controls.Add(this.removeBt);
            this.Controls.Add(this.submitBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playListLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCollectionForm";
            this.Text = "AddCollectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playListLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView DGVSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitBt;
        private System.Windows.Forms.Button removeBt;
        private System.Windows.Forms.DataGridView DGVList;
    }
}