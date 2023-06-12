namespace TVMazeApp
{
    partial class DetailsForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loadingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showTitleLabel = new System.Windows.Forms.Label();
            this.langLabel = new System.Windows.Forms.Label();
            this.premieredLabel = new System.Windows.Forms.Label();
            this.summaryBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(11, 11);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(91, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.loadingLabel.Location = new System.Drawing.Point(315, 131);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(0, 55);
            this.loadingLabel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 210);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // showTitleLabel
            // 
            this.showTitleLabel.AutoSize = true;
            this.showTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.showTitleLabel.Location = new System.Drawing.Point(192, 39);
            this.showTitleLabel.Name = "showTitleLabel";
            this.showTitleLabel.Size = new System.Drawing.Size(0, 55);
            this.showTitleLabel.TabIndex = 4;
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.langLabel.Location = new System.Drawing.Point(198, 95);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(85, 20);
            this.langLabel.TabIndex = 5;
            this.langLabel.Text = "Language:";
            // 
            // premieredLabel
            // 
            this.premieredLabel.AutoSize = true;
            this.premieredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.premieredLabel.Location = new System.Drawing.Point(388, 95);
            this.premieredLabel.Name = "premieredLabel";
            this.premieredLabel.Size = new System.Drawing.Size(85, 20);
            this.premieredLabel.TabIndex = 6;
            this.premieredLabel.Text = "Premiered:";
            // 
            // summaryBox
            // 
            this.summaryBox.Location = new System.Drawing.Point(192, 131);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(580, 20);
            this.summaryBox.TabIndex = 7;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeLabel.Location = new System.Drawing.Point(611, 95);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(47, 20);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "Type:";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.premieredLabel);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.showTitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.backBtn);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DetailsForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label showTitleLabel;
        private System.Windows.Forms.Label langLabel;
        private System.Windows.Forms.Label premieredLabel;
        private System.Windows.Forms.TextBox summaryBox;
        private System.Windows.Forms.Label typeLabel;
    }
}