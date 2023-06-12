using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVMazeApp
{
    public class Favorites
    {
        public static List<ShowDetails> SHOW_DETAILS = new List<ShowDetails>();

        public static void AddShowToFavorites(ShowDetails showDetails)
        {
            SHOW_DETAILS.Add(showDetails);
        }

        public static void RemoveShowFromFavorites(ShowDetails showDetails)
        {
            SHOW_DETAILS.Remove(showDetails);
        }
    }
}
