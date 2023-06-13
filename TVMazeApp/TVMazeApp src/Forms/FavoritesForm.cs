using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVMazeApp
{
    [Serializable]
    public partial class FavoritesForm : Form
    {

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
            foreach (ShowDetails show in FavoritesAndWatchlist.FAVORITES)
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
                FavoritesAndWatchlist.RemoveShow(toDelete, FavoritesAndWatchlist.FAVORITES, Form1.FAVORITES_PATH);
            }
        }

        private void showPageBtn_Click(object sender, EventArgs e)
        {
            if (favoritesLb.SelectedIndex != -1)
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
