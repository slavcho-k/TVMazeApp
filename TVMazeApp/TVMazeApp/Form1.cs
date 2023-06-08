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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchTb_Validating(object sender, CancelEventArgs e)
        {
            Validate();
        }

        private void recentBtn_Click(object sender, EventArgs e)
        {
            Hide();
            RecentForm form2 = new RecentForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Validate();
            if (string.IsNullOrEmpty(errorProvider1.GetError(searchTb)))
            {
                Hide();
                SearchForm form2 = new SearchForm();
                form2.Closed += (s, args) => Close();
                form2.Show();
            }
        }

        private void favBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FavoritesForm form2 = new FavoritesForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void Validate()
        {
            if (string.IsNullOrEmpty(searchTb.Text)) { errorProvider1.SetError(searchTb, "Search query is required."); }
            else { errorProvider1.SetError(searchTb, ""); }
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }
    }
}
