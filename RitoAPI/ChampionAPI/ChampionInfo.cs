using System;
using System.Collections.Generic;
using System.Text;

namespace RitoAPI.ChampionAPI
{
    [Serializable]
    public class ChampionInfo
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Magic { get; set; }
        public int Difficulty { get; set; }
    }
}
