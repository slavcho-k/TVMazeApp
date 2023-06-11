using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TVMazeApp
{
    public partial class SearchForm : Form
    {
        Scene scene;
        int ticks;
        int secs;
        List<Show> shows;
        ApiService apiService;
        string searchQuery;

        public SearchForm(string searchQuery)
        {
            InitializeComponent();
            scene = new Scene();
            ticks = 0;
            this.searchQuery = searchQuery;
            dataGridView1.Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GenerateBalls();
            DoubleBuffered = true;
            secs = 0;
            timer1.Start();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
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

        private void SearchForm_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawAll(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            secs++;
            if (ticks == 2)
            {
                scene.Pulse();
                Invalidate();
                ticks = 0;
            }

            if (shows != null)
            {
                scene.RemoveAll();
                Invalidate();
                loadingLabel.Visible = false;
                dataGridView1.Visible = true;
            }
        }

        private async void SearchForm_Load(object sender, EventArgs e)
        {
            apiService = new ApiService();
            shows = await apiService.GetShows(searchQuery);

            DataGridCreator();
        }

        private void DataGridCreator()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Score", "Score");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns["Score"].Width = 50;

            foreach (Show show in shows)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells["Title"].Value = show.title;
                dataGridView1.Rows[rowIndex].Cells["Score"].Value = show.rating.ToString();
                dataGridView1.Rows[rowIndex].Cells["Description"].Value = show.description;
            }

            PopulateAllRows();
            MakeRowsReadonly();
        }

        private void PopulateAllRows()
        {
            int desiredRowCount = dataGridView1.Height / dataGridView1.RowTemplate.Height;

            int currentRowCount = dataGridView1.Rows.Count;
            int emptyRowCount = desiredRowCount - currentRowCount;

            for (int i = 0; i < emptyRowCount; i++)
            {
                dataGridView1.Rows.Add();
            }
        }

        private void MakeRowsReadonly()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.ReadOnly = true;
            }
        }
    }
}

