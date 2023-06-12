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
        List<CastMember> castMembers;
        List<Episode> episodes;
        Scene scene;
        string id;
        string searchQuery;
        int ticks;
        ApiService apiService;

        public DetailsForm(string id, string searchQuery)
        {
            InitializeComponent();
            scene = new Scene();
            apiService = new ApiService();
            DoubleBuffered = true;
            GenerateBalls();
            ticks = 0;
            SetVisibility(false);
            loadingLabel.Text = "Loading";
            summaryBox.Size = new Size(580, 117);
            summaryBox.Font = new Font(summaryBox.Font.FontFamily, 11);
            summaryBox.ReadOnly = true;
            summaryBox.ScrollBars = ScrollBars.Vertical;
            summaryBox.Multiline = true;
            castLb.Font = new Font(castLb.Font.FontFamily, 10);
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
            castMembers = await apiService.GetShowCast(id);
            episodes = await apiService.GetShowEpisodes(id);
            SetShowDetails();
            SetCastDetails();
            SetEpisodes();
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

            if (showDetails != null && castMembers != null && episodes != null)
            {
                scene.RemoveAll();
                Invalidate();
                SetVisibility(true);
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

        private void SetVisibility(bool visible)
        {
            langLabel.Visible = visible;
            premieredLabel.Visible = visible;
            summaryBox.Visible = visible;
            castLabel.Visible = visible;
            episodesLabel.Visible = visible;
            castLb.Visible = visible;
            episodesLb.Visible = visible;
            typeLabel.Visible = visible;
            addToFBtn.Visible = visible;
            addToWlBtn.Visible = visible;
            loadingLabel.Visible = !visible;
        }

        private void SetShowDetails()
        {
            DrawPicture(showDetails.image);
            showTitleLabel.Text = showDetails.title;
            showTitleLabel.Font = new Font(showTitleLabel.Font.FontFamily, 22);
            langLabel.Text = $"Language: {showDetails.language}";
            premieredLabel.Text = $"Premiered: {showDetails.premiered}";
            summaryBox.Text = showDetails.description;
            typeLabel.Text = $"Type: {showDetails.type}";
        }

        private void SetCastDetails()
        {
            foreach(CastMember castMember in castMembers)
            {
                castLb.Items.Add(castMember);
            }
        }

        private void SetEpisodes()
        {
            foreach(Episode episode in episodes)
            {
                episodesLb.Items.Add(episode);
            }
        }
    }
}
