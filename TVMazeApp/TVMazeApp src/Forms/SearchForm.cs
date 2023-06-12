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
        List<Show> shows;
        ApiService apiService;
        string searchQuery;
        string id;

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

            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Rating", "Rating");
            dataGridView1.Columns.Add("Premiered", "Premiered");
            dataGridView1.Columns.Add("Ended", "Ended");
            dataGridView1.Columns["ID"].Width = 50;
            dataGridView1.Columns["Title"].Width = 75;
            dataGridView1.Columns["Rating"].Width = 25;
            dataGridView1.Columns["Premiered"].Width = 35;
            dataGridView1.Columns["Ended"].Width = 75;

            foreach (Show show in shows)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells["ID"].Value = show.id; 
                dataGridView1.Rows[rowIndex].Cells["Title"].Value = show.title;
                dataGridView1.Rows[rowIndex].Cells["Rating"].Value = show.rating.ToString();
                dataGridView1.Rows[rowIndex].Cells["Premiered"].Value = show.premiered;
                dataGridView1.Rows[rowIndex].Cells["Ended"].Value = show.ended;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;
                DataGridViewCell idCell = dataGridView.Rows[e.RowIndex].Cells["ID"];

                if (idCell.Value != null) 
                { 
                    id = idCell.Value.ToString();
                    Hide();
                    DetailsForm form2 = new DetailsForm(id, searchQuery);
                    form2.Closed += (s, args) => Close();
                    form2.Show();
                }
            }
        }
    }
}

