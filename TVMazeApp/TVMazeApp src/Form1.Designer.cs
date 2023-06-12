﻿namespace TVMazeApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.watchBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.favBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F);
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "TV Maze App";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(439, 191);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(116, 24);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // watchBtn
            // 
            this.watchBtn.Location = new System.Drawing.Point(227, 325);
            this.watchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(149, 31);
            this.watchBtn.TabIndex = 2;
            this.watchBtn.Text = "Watchlist";
            this.watchBtn.UseVisualStyleBackColor = true;
            this.watchBtn.Click += new System.EventHandler(this.recentBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.exitBtn.Location = new System.Drawing.Point(429, 325);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(149, 31);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(91, 194);
            this.searchTb.Margin = new System.Windows.Forms.Padding(2);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(325, 20);
            this.searchTb.TabIndex = 4;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            this.searchTb.Validating += new System.ComponentModel.CancelEventHandler(this.searchTb_Validating);
            // 
            // favBtn
            // 
            this.favBtn.Location = new System.Drawing.Point(20, 325);
            this.favBtn.Margin = new System.Windows.Forms.Padding(2);
            this.favBtn.Name = "favBtn";
            this.favBtn.Size = new System.Drawing.Size(149, 31);
            this.favBtn.TabIndex = 5;
            this.favBtn.Text = "Favorites";
            this.favBtn.UseVisualStyleBackColor = true;
            this.favBtn.Click += new System.EventHandler(this.favBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.favBtn);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.watchBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "TVMazeApp";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button watchBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button favBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

