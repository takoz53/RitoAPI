using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitoAPI.VersionAPI
{
    [Serializable]
    public class VersionList
    {
        [JsonProperty("n")]
        public Version VersionItems { get; set; }
        [JsonProperty("v")]
        public string VersionGeneral { get; set; }
        [JsonProperty("l")]
        public string Language { get; set; }
        public string CDN { get; set; }
        [JsonProperty("dd")]
        public string DataDragon { get; set; }
        public string LG { get; set; }
        public string CSS { get; set; }
        public int ProfileIconMax { get; set; }
        public object Store { get; set; }

    }
}
