using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace TVMazeApp
{
    public class ApiService
    {
        private HttpClient httpClient;
        private readonly string url = "https://api.tvmaze.com";

        public ApiService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Show>> GetShows(string searchQuery)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url + "/search/shows?q=" + searchQuery);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            JArray array = JArray.Parse(json);
            List<Show> shows = new List<Show>();

            foreach(JObject obj in array )
            {
                
                shows.Add(ShowCreator(obj));
            }

            return shows;
        }

        public Show ShowCreator(JObject obj)
        {
            int id = (int)obj["show"]["id"];
            string title = obj["show"]["name"].ToString();
            double rating = (float)obj["score"];
            string premiered = obj["show"]["premiered"].ToString();
            string ended = obj["show"]["ended"].ToString();
         
            return new Show(id, title, rating, premiered, ended);
        }
    }
}
