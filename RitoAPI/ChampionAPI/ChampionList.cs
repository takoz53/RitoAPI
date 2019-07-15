using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RitoAPI.ChampionAPI
{
    public class ChampionList
    {
        public string Type { get; set; }
        public string Format { get; set; }
        public string Version { get; set; }
        [JsonProperty("data")]
        public Dictionary<string, Champion> Champions { get; set; }
    }
}
