using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TVMazeApp
{
    public class FavoritesAndWatchlist
    {
        public static List<ShowDetails> FAVORITES = new List<ShowDetails>();
        public static List<ShowDetails> WATCHLIST = new List<ShowDetails>();
        public static List<ShowDetails> WATCHEDLIST = new List<ShowDetails>();
        
        public static void AddShow(ShowDetails showDetails, List<ShowDetails> list, string path)
        {
            bool found = false;
            foreach(ShowDetails show in list)
            {
                if (show.id == showDetails.id) { found = true; break; }
            }

            if (!found)
            {
                list.Add(showDetails);
                Save(path, list);
            }
        }

        public static void RemoveShow(ShowDetails showDetails, List<ShowDetails> list, string path)
        {
            list.Remove(showDetails); 
            Save(path, list);
        }

        private static void Save(string path, List<ShowDetails> list)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, list);
            fs.Close();
        }
    }
}
