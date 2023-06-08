namespace TVMazeApp
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
            this.recentBtn = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(48, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "TV Maze App";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(548, 235);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(155, 29);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // recentBtn
            // 
            this.recentBtn.Location = new System.Drawing.Point(303, 400);
            this.recentBtn.Name = "recentBtn";
            this.recentBtn.Size = new System.Drawing.Size(199, 38);
            this.recentBtn.TabIndex = 2;
            this.recentBtn.Text = "Recently searched";
            this.recentBtn.UseVisualStyleBackColor = true;
            this.recentBtn.Click += new System.EventHandler(this.recentBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.exitBtn.Location = new System.Drawing.Point(572, 400);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(199, 38);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(94, 239);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(432, 22);
            this.searchTb.TabIndex = 4;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            this.searchTb.Validating += new System.ComponentModel.CancelEventHandler(this.searchTb_Validating);
            // 
            // favBtn
            // 
            this.favBtn.Location = new System.Drawing.Point(26, 400);
            this.favBtn.Name = "favBtn";
            this.favBtn.Size = new System.Drawing.Size(199, 38);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.favBtn);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.recentBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TVMazeApp";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button recentBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button favBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

