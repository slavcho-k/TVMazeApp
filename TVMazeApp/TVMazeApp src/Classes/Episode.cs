using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVMazeApp
{
    public class Episode
    {
        string name { get; set; }
        int season { get; set; }
        int episode { get; set; }

        public Episode(string name, int season, int episode)
        {
            this.name = name;
            this.season = season;
            this.episode = episode;
        }

        public override string ToString()
        {
            return $"S{season} E{episode} - {name}";
        }
    }
}
