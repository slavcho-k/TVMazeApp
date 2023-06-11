using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVMazeApp
{
    public class Show
    {
        public double rating { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public int id { get; set; }

        public Show(int id, string title, double rating, string description, string image)
        {
            this.id = id;
            this.rating = Math.Round(rating * 100, 2);
            this.title = title;
            this.description = description;
            this.image = image;
        }

        public override string ToString()
        {
            return $"{title} {rating} \n {description}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
