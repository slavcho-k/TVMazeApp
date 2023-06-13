using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TVMazeApp
{
    [Serializable]
    public class ShowDetails
    {
        public int id { get; set; }
        public string title { get; set; }  
        public string description { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string premiered { get; set; }
        public string officialSite { get; set; }
        public string image { get; set; }
        public string language { get; set; }

        public ShowDetails(int id, string title, string description, string type, string status, string premiered, string officialSite, string image, string language)
        {
            this.id = id;
            this.title = title;
            this.type = type;
            this.status = status;
            this.officialSite = officialSite;
            this.language = language;
            this.image = image;
            SetDescription(description);
            SetPremiered(premiered);
        }

        private void SetDescription(string description)
        {
            this.description = Regex.Replace(description, @"</?(?:p|b)>", "");
        }

        private void SetPremiered(string premiered)
        {
            if (premiered == null || premiered.Length == 0) { this.premiered = "Info not available"; }
            else { this.premiered = premiered; }
        }

        public override string ToString()
        {
            return $"{id} - {title}";
        }

        public String ToStringFavorites()
        {
            return $"{id}\t{title}\t{premiered}";
        }
    }
}
