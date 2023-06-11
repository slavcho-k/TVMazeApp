using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVMazeApp
{
    public class Show
    {
        public double rating { get; set; }
        public string title { get; set; }
        public int id { get; set; }
        public string premiered { get; set; }
        public string ended { get; set; }

        public Show(int id, string title, double rating, string premiered, string ended)
        {
            this.id = id;
            double r = Math.Round(rating * 100, 2);
            SetRating(rating);
            this.title = title;
            SetPremiered(premiered);
            SetEnded(ended);
        }

        public override string ToString()
        {
            return $"{title} - {rating}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private void SetPremiered(string premiered)
        {
            if (premiered == null || premiered.Length == 0) { this.premiered = "Info not available"; }
            else { this.premiered = premiered; }
        }

        private void SetEnded(string ended)
        {
            if (ended == null || ended.Length == 0) {this.ended = "Info not available"; }
            else { this.ended = ended; }
        }

        private void SetRating(double rating)
        {
            double r = Math.Round(rating * 100, 2);

            if (r >= 100) { this.rating = 100; }
            else { this.rating = r; }
        }
    }
}
