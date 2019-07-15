using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RitoAPI.ChampionGGAPI
{
    [Serializable]
    public class ChampionGGList
    {
        //a78246a3fc1744098c760aade205de61
        [JsonProperty("data")] private ICollection<ChampionGG> Champions { get; set; }

    }
}
