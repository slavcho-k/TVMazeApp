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
            HttpResponseMessage response = await httpClient.GetAsync($"{url}/search/shows?q={searchQuery}");
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

        public async Task<ShowDetails> GetShowDetails(string id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"{url}/shows/{id}");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            dynamic showObject = JsonConvert.DeserializeObject<dynamic>(json);

            return ShowDetailsCreator(showObject);
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

        public ShowDetails ShowDetailsCreator(dynamic showObject)
        {
            int id = showObject["id"];
            string title = showObject["name"].ToString();
            string summary = showObject["summary"].ToString();
            string type = showObject["type"].ToString();
            string status = showObject["status"].ToString();
            string premiered = showObject["premiered"].ToString();
            string url = showObject["url"].ToString();
            string image;
            string language = showObject["language"];
            JToken imageToken = showObject.SelectToken("image.medium");

            if(imageToken != null)
            {
                image = showObject.image.medium;
            } else
            {
                image = "https://i0.wp.com/theperfectroundgolf.com/wp-content/uploads/2022/04/placeholder.png?fit=1200%2C800&ssl=1";
            }

            return new ShowDetails(id, title, summary, type, status, premiered, url, image, language);
        }
    }
}
