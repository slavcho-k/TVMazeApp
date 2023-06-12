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
                shows.Add(ObjectGeneratorService.ShowCreator(obj));
            }

            return shows;
        }

        public async Task<ShowDetails> GetShowDetails(string id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"{url}/shows/{id}");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            dynamic showObject = JsonConvert.DeserializeObject<dynamic>(json);

            return ObjectGeneratorService.ShowDetailsCreator(showObject);
        }

        public async Task<List<CastMember>> GetShowCast(string id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"{url}/shows/{id}/cast");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            JArray array = JArray.Parse(json);
            List<CastMember> cast = new List<CastMember>();

            foreach (JObject obj in array)
            {
                cast.Add(ObjectGeneratorService.CastMemberCreator(obj));
            }

            return cast;
        }

        public async Task<List<Episode>> GetShowEpisodes(string id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"{url}/shows/{id}/episodes");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            JArray array = JArray.Parse(json);
            List<Episode> episodes = new List<Episode>();

            foreach (JObject obj in array)
            {
                episodes.Add(ObjectGeneratorService.EpisodeCreator(obj));
            }

            return episodes;
        }
    }
}
