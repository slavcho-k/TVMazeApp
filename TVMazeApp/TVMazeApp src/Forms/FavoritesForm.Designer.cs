namespace TVMazeApp
{
    partial class FavoritesForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.favoritesLb = new System.Windows.Forms.ListBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.showPageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(9, 10);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(91, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // favoritesLb
            // 
            this.favoritesLb.FormattingEnabled = true;
            this.favoritesLb.Location = new System.Drawing.Point(115, 36);
            this.favoritesLb.Name = "favoritesLb";
            this.favoritesLb.Size = new System.Drawing.Size(372, 303);
            this.favoritesLb.TabIndex = 2;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(498, 306);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(91, 23);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // showPageBtn
            // 
            this.showPageBtn.Location = new System.Drawing.Point(498, 266);
            this.showPageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.showPageBtn.Name = "showPageBtn";
            this.showPageBtn.Size = new System.Drawing.Size(91, 23);
            this.showPageBtn.TabIndex = 4;
            this.showPageBtn.Text = "Show page";
            this.showPageBtn.UseVisualStyleBackColor = true;
            this.showPageBtn.Click += new System.EventHandler(this.showPageBtn_Click);
            // 
            // FavoritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.showPageBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.favoritesLb);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FavoritesForm";
            this.Text = "FavoritesForm";
            this.Load += new System.EventHandler(this.FavoritesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ListBox favoritesLb;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button showPageBtn;
    }
}