using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVMazeApp
{
    public class FavoritesAndWatchlist
    {
        public static List<ShowDetails> FAVORITES = new List<ShowDetails>();
        public static List<ShowDetails> WATCHLIST = new List<ShowDetails>();
        public static List<ShowDetails> WATCHEDLIST = new List<ShowDetails>();

        public static void AddShowToFavorites(ShowDetails showDetails)
        {
            bool found = false;
            foreach(ShowDetails show in FAVORITES)
            {
                if (show.id == showDetails.id) { found = true; break; }
            }

            if (!found) { FAVORITES.Add(showDetails); }
        }

        public static void AddShowToWatchlist(ShowDetails showDetails)
        {
            bool found = false;
            foreach (ShowDetails show in WATCHLIST)
            {
                if (show.id == showDetails.id) { found = true; break; }
            }

            foreach(ShowDetails show in WATCHEDLIST)
            {
                if (show.id == showDetails.id) { found = true; break; }
            }

            if (!found) { WATCHLIST.Add(showDetails); }
        }
    }
}
