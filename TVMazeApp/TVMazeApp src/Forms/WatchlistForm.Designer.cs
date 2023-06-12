namespace TVMazeApp
{
    partial class WatchlistForm
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
            this.toWatchLb = new System.Windows.Forms.ListBox();
            this.watchedLb = new System.Windows.Forms.ListBox();
            this.rightBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.toWatchLabel = new System.Windows.Forms.Label();
            this.watchedLabel = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(11, 11);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(91, 23);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // toWatchLb
            // 
            this.toWatchLb.FormattingEnabled = true;
            this.toWatchLb.Location = new System.Drawing.Point(42, 68);
            this.toWatchLb.Name = "toWatchLb";
            this.toWatchLb.Size = new System.Drawing.Size(317, 329);
            this.toWatchLb.TabIndex = 3;
            this.toWatchLb.SelectedIndexChanged += new System.EventHandler(this.toWatchLb_SelectedIndexChanged);
            // 
            // watchedLb
            // 
            this.watchedLb.FormattingEnabled = true;
            this.watchedLb.Location = new System.Drawing.Point(439, 68);
            this.watchedLb.Name = "watchedLb";
            this.watchedLb.Size = new System.Drawing.Size(317, 329);
            this.watchedLb.TabIndex = 4;
            this.watchedLb.SelectedIndexChanged += new System.EventHandler(this.watchedLb_SelectedIndexChanged);
            // 
            // rightBtn
            // 
            this.rightBtn.Location = new System.Drawing.Point(387, 121);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(28, 33);
            this.rightBtn.TabIndex = 5;
            this.rightBtn.Text = ">";
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.Location = new System.Drawing.Point(387, 297);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(28, 33);
            this.leftBtn.TabIndex = 6;
            this.leftBtn.Text = "<";
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // toWatchLabel
            // 
            this.toWatchLabel.AutoSize = true;
            this.toWatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.toWatchLabel.Location = new System.Drawing.Point(38, 44);
            this.toWatchLabel.Name = "toWatchLabel";
            this.toWatchLabel.Size = new System.Drawing.Size(77, 20);
            this.toWatchLabel.TabIndex = 7;
            this.toWatchLabel.Text = "To watch";
            // 
            // watchedLabel
            // 
            this.watchedLabel.AutoSize = true;
            this.watchedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.watchedLabel.Location = new System.Drawing.Point(436, 44);
            this.watchedLabel.Name = "watchedLabel";
            this.watchedLabel.Size = new System.Drawing.Size(75, 20);
            this.watchedLabel.TabIndex = 8;
            this.watchedLabel.Text = "Watched";
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(605, 417);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(150, 22);
            this.removeBtn.TabIndex = 9;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // WatchlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.watchedLabel);
            this.Controls.Add(this.toWatchLabel);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.watchedLb);
            this.Controls.Add(this.toWatchLb);
            this.Controls.Add(this.backBtn);
            this.Name = "WatchlistForm";
            this.Text = "WatchlistForm";
            this.Load += new System.EventHandler(this.WatchlistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ListBox toWatchLb;
        private System.Windows.Forms.ListBox watchedLb;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Label toWatchLabel;
        private System.Windows.Forms.Label watchedLabel;
        private System.Windows.Forms.Button removeBtn;
    }
}