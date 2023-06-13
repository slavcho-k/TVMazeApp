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
    public partial class WatchlistForm : Form
    {
        List<ShowDetails> watchList;
        List<ShowDetails> watchedList;

        public WatchlistForm()
        {
            InitializeComponent();
            toWatchLb.Font = new Font(toWatchLb.Font.FontFamily, 11);
            watchedLb.Font = new Font(toWatchLb.Font.FontFamily, 11);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form2 = new Form1();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void WatchlistForm_Load(object sender, EventArgs e)
        {
            /*watchList = FavoritesAndWatchlist.WATCHLIST;
            watchedList = FavoritesAndWatchlist.WATCHEDLIST;*/

            foreach(ShowDetails show in FavoritesAndWatchlist.WATCHLIST)
            {
                toWatchLb.Items.Add(show);
            }

            foreach(ShowDetails show in FavoritesAndWatchlist.WATCHEDLIST)
            {
                watchedLb.Items.Add(show);
            }
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            if(toWatchLb.SelectedIndex != -1)
            {
                ShowDetails selected = toWatchLb.SelectedItem as ShowDetails;
                toWatchLb.Items.Remove(selected);
                watchedLb.Items.Add(selected);

                //FavoritesAndWatchlist.WATCHLIST.Remove(selected);
                FavoritesAndWatchlist.RemoveShow(selected, FavoritesAndWatchlist.WATCHLIST, Form1.TOWATCH_PATH);
                //FavoritesAndWatchlist.WATCHEDLIST.Add(selected);
                FavoritesAndWatchlist.AddShow(selected, FavoritesAndWatchlist.WATCHEDLIST, Form1.WATCHED_PATH);
            }
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            if (watchedLb.SelectedIndex != -1)
            {
                ShowDetails selected = watchedLb.SelectedItem as ShowDetails;
                watchedLb.Items.Remove(selected);
                toWatchLb.Items.Add(selected);

                //FavoritesAndWatchlist.WATCHEDLIST.Remove(selected);
                FavoritesAndWatchlist.RemoveShow(selected, FavoritesAndWatchlist.WATCHEDLIST, Form1.WATCHED_PATH);
                //FavoritesAndWatchlist.WATCHLIST.Add(selected);
                FavoritesAndWatchlist.AddShow(selected, FavoritesAndWatchlist.WATCHLIST, Form1.TOWATCH_PATH);
            }
        }

        private void toWatchLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(toWatchLb.SelectedIndex != -1) { watchedLb.ClearSelected(); }
        }

        private void watchedLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(watchedLb.SelectedIndex != -1) { toWatchLb.ClearSelected(); }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (toWatchLb.SelectedIndex != -1)
            {
                ShowDetails selected = toWatchLb.SelectedItem as ShowDetails;
                toWatchLb.Items.Remove(selected);
                //FavoritesAndWatchlist.WATCHLIST.Remove(selected);
                FavoritesAndWatchlist.RemoveShow(selected, FavoritesAndWatchlist.WATCHLIST, Form1.TOWATCH_PATH);
            }

            if(watchedLb.SelectedIndex != -1)
            {
                ShowDetails selected = watchedLb.SelectedItem as ShowDetails;
                watchedLb.Items.Remove(selected);
                //FavoritesAndWatchlist.WATCHEDLIST.Remove(selected);
                FavoritesAndWatchlist.RemoveShow(selected, FavoritesAndWatchlist.WATCHEDLIST, Form1.WATCHED_PATH);
            }
        }
    }
}
