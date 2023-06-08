using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVMazeApp
{
    public partial class SearchForm : Form
    {
        Scene scene;

        public SearchForm()
        {
            InitializeComponent();
            scene = new Scene();
            GenerateBalls();
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
            int x = Width / 2 ;
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
    }
}
