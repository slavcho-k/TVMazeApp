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
    public partial class FavoritesForm : Form
    {
        List<ShowDetails> favorites;

        public FavoritesForm()
        {
            InitializeComponent();
            favoritesLb.Font = new Font(favoritesLb.Font.FontFamily, 14);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => Close();
            form1.Show();
        }

        private void FavoritesForm_Load(object sender, EventArgs e)
        {
            favorites = FavoritesAndWatchlist.FAVORITES;
            foreach (ShowDetails show in favorites)
            {
                favoritesLb.Items.Add(show);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if(favoritesLb.SelectedIndex != -1)
            {
                ShowDetails toDelete = favoritesLb.SelectedItem as ShowDetails;
                favoritesLb.Items.Remove(toDelete);
                FavoritesAndWatchlist.FAVORITES.Remove(toDelete);
            }
        }

        private void showPageBtn_Click(object sender, EventArgs e)
        {
            if(favoritesLb.SelectedIndex != -1)
            {
                ShowDetails show = favoritesLb.SelectedItem as ShowDetails;
                Hide();
                DetailsForm form2 = new DetailsForm(show.id.ToString(), "from favorites");
                form2.Closed += (s, args) => Close();
                form2.Show();
            }
        }
    }
}
