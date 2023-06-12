using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVMazeApp
{
    public class ObjectGeneratorService
    {
        public static ShowDetails ShowDetailsCreator(dynamic obj)
        {
            int id = obj["id"];
            string title = obj["name"].ToString();
            string summary = obj["summary"].ToString();
            string type = obj["type"].ToString();
            string status = obj["status"].ToString();
            string premiered = obj["premiered"].ToString();
            string url = obj["url"].ToString();
            string image;
            string language = obj["language"];
            JToken imageToken = obj.SelectToken("image.medium");

            if (imageToken != null) { image = obj.image.medium; }
            else { image = "https://i0.wp.com/theperfectroundgolf.com/wp-content/uploads/2022/04/placeholder.png?fit=1200%2C800&ssl=1"; }

            return new ShowDetails(id, title, summary, type, status, premiered, url, image, language);
        }

        public static Show ShowCreator(JObject obj)
        {
            int id = (int)obj["show"]["id"];
            string title = obj["show"]["name"].ToString();
            double rating = (float)obj["score"];
            string premiered = obj["show"]["premiered"].ToString();
            string ended = obj["show"]["ended"].ToString();

            return new Show(id, title, rating, premiered, ended);
        }

        public static CastMember CastMemberCreator(JObject obj)
        {
            string name;
            string character;
            JToken nameToken = obj.SelectToken("person.name");
            JToken characterToken = obj.SelectToken("character.name");

            if(nameToken == null) { name = "Not available"; } 
            else { name = nameToken.ToString(); }

            if(characterToken == null) { character = "Not available"; }
            else { character = characterToken.ToString(); }

            return new CastMember(name, character);
        }

        public static Episode EpisodeCreator(JObject obj)
        {
            string name = obj["name"].ToString();
            int season = (int)obj["season"];
            int episode = (int)obj["number"];

            return new Episode(name, season, episode); 
        }
    }
}
