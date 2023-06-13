using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.CodeDom;

namespace TVMazeApp
{
    public partial class Form1 : Form
    {
        public static readonly string FAVORITES_PATH = Path.Combine(Environment.CurrentDirectory, "favorites");
        public static readonly string TOWATCH_PATH = Path.Combine(Environment.CurrentDirectory, "watchedList");
        public static readonly string WATCHED_PATH = Path.Combine(Environment.CurrentDirectory, "watchList");

        public Form1()
        {
            InitializeComponent();
            FileCreator();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchTb_Validating(object sender, CancelEventArgs e)
        {
            ValidateSearch();
        }

        private void recentBtn_Click(object sender, EventArgs e)
        {
            Hide();
            WatchlistForm form2 = new WatchlistForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ValidateSearch();
            if (string.IsNullOrEmpty(errorProvider1.GetError(searchTb)))
            {
                Hide();
                SearchForm form2 = new SearchForm(searchTb.Text);
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

        private void ValidateSearch()
        {
            if (string.IsNullOrEmpty(searchTb.Text)) { errorProvider1.SetError(searchTb, "Search query is required."); }
            else { errorProvider1.SetError(searchTb, ""); }
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            ValidateSearch();
        }

        private void FileCreator()
        {
            CheckFiles(FAVORITES_PATH);
            CheckFiles(WATCHED_PATH);
            CheckFiles(TOWATCH_PATH);
        }

        private void CheckFiles(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        private void LoadFavorites()
        {
            if (File.Exists(FAVORITES_PATH))
            {
                FileInfo fi = new FileInfo(FAVORITES_PATH);
                if (fi.Length > 0)
                {
                    FileStream fs = new FileStream(FAVORITES_PATH, FileMode.Open);
                    IFormatter formatter = new BinaryFormatter();
                    FavoritesAndWatchlist.FAVORITES = (List<ShowDetails>)formatter.Deserialize(fs);
                    fs.Close();
                }
            }
        }

        private void LoadWatchList()
        {
            if (File.Exists(TOWATCH_PATH))
            {
                FileInfo fi = new FileInfo(TOWATCH_PATH);
                if (fi.Length > 0)
                {
                    FileStream fs = new FileStream(TOWATCH_PATH, FileMode.Open);
                    IFormatter formatter = new BinaryFormatter();
                    FavoritesAndWatchlist.WATCHLIST = (List<ShowDetails>)formatter.Deserialize(fs);
                    fs.Close();
                }
            }
        }

        private void LoadWatchedList()
        {
            if (File.Exists(WATCHED_PATH))
            {
                FileInfo fi = new FileInfo(WATCHED_PATH);
                if (fi.Length > 0)
                {
                    FileStream fs = new FileStream(WATCHED_PATH, FileMode.Open);
                    IFormatter formatter = new BinaryFormatter();
                    FavoritesAndWatchlist.WATCHEDLIST = (List<ShowDetails>)formatter.Deserialize(fs);
                    fs.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFavorites();
            LoadWatchList();
            LoadWatchedList();
        }
    }
}
