using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RitoAPI.ChampionAPI;
using RitoAPI.Regions;

namespace RitoAPI.Requesthandler
{
    public class RequestHandler
    {
        private HttpWebRequest webRequest;
        private HttpWebResponse webResponse;
        public string CurrentVersion { get; set; }

        public RequestHandler()
        {
            GetCurrentVersion();
        }

        private void GetCurrentVersion()
        {
            string responseText = String.Empty;

            webRequest = (HttpWebRequest)WebRequest.Create($"https://ddragon.leagueoflegends.com/realms/euw.json");

            webResponse = (HttpWebResponse)webRequest.GetResponse();
            using (var reader = new System.IO.StreamReader(webResponse.GetResponseStream(), ASCIIEncoding.UTF8))
            {
                responseText = reader.ReadToEnd();
            }
            webResponse.Dispose();

            if (responseText == String.Empty)
            {
                throw new Exception("Couldn't fetch Version!");
            }

            var versions = JsonConvert.DeserializeObject<string[]>(responseText);
            CurrentVersion = versions[0];
        }

        public ICollection<Champion> RequestChampionData(Region.Regions region)
        {
            string responseText = String.Empty;
            
            string regionName = Enum.GetName(typeof(Region.Regions), region);

            webRequest = (HttpWebRequest) WebRequest.Create($"http://ddragon.leagueoflegends.com/cdn/{CurrentVersion}/data/{regionName}/champion.json");

            webResponse = (HttpWebResponse) webRequest.GetResponse();
            using (var reader = new System.IO.StreamReader(webResponse.GetResponseStream(), ASCIIEncoding.UTF8))
            {
                responseText = reader.ReadToEnd();
            }
            webResponse.Dispose();

            if (responseText == String.Empty)
            {
                throw new Exception("Couldn't fetch Champions!");
            }

            var championList = JsonConvert.DeserializeObject<ChampionList>(responseText);
            ICollection<Champion> champions = new List<Champion>();
            foreach (var champion in championList.Champions)
            {
                champions.Add(champion.Value);
            }
            return champions;
        }
    }
}
