using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TVMazeApp
{
    public partial class DetailsForm : Form
    {
        ShowDetails showDetails;
        Scene scene;
        string id;
        string searchQuery;
        int ticks;

        public DetailsForm(string id, string searchQuery)
        {
            InitializeComponent();
            scene = new Scene();
            this.DoubleBuffered = true;
            GenerateBalls();
            ticks = 0;
            loadingLabel.Text = "Loading";
            langLabel.Visible = false;
            premieredLabel.Visible = false;
            summaryBox.Visible = false;
            summaryBox.Multiline = true;
            summaryBox.Size = new Size(580, 117);
            summaryBox.Font = new Font(summaryBox.Font.FontFamily, 11);
            summaryBox.ReadOnly = true;
            summaryBox.ScrollBars = ScrollBars.Vertical;
            typeLabel.Visible = false;
            this.searchQuery = searchQuery;
            this.id = id;
            timer1.Start();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            SearchForm form1 = new SearchForm(searchQuery);
            form1.Closed += (s, args) => Close();
            form1.Show();
        }

        private void GenerateBalls()
        {
            int x = Width / 2;
            int y = Height / 2;
            Point p = new Point(x, y);

            scene.AddBall(new Ball(15, p));
            scene.AddBall(new Ball(10, new Point(p.X - 40, p.Y)));
            scene.AddBall(new Ball(20, new Point(p.X + 50, p.Y)));
        }

        private async void DetailsForm_Load(object sender, EventArgs e)
        {
            ApiService apiService = new ApiService();
            showDetails = await apiService.GetShowDetails(id);
            DrawPicture(showDetails.image);
            showTitleLabel.Text = showDetails.title;
            showTitleLabel.Font = new Font(showTitleLabel.Font.FontFamily, 22);
            langLabel.Text = $"Language: {showDetails.language}";
            premieredLabel.Text =  $"Premiered: {showDetails.premiered}";
            summaryBox.Text = showDetails.description;
            typeLabel.Text = $"Type: {showDetails.type}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 2)
            {
                scene.Pulse();
                Invalidate();
                ticks = 0;
            }

            if (showDetails != null)
            {
                scene.RemoveAll();
                Invalidate();
                loadingLabel.Visible = false;
                langLabel.Visible = true;
                premieredLabel.Visible = true;
                summaryBox.Visible = true;
                typeLabel.Visible = true;
            }
        }

        private void DetailsForm_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawAll(e.Graphics);
        }

        private void DrawPicture(string imageUrl)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);
                    using (var stream = new System.IO.MemoryStream(imageData))
                    {
                        pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
