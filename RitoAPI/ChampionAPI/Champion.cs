using System;
using System.Collections.Generic;
using System.Text;

namespace RitoAPI.ChampionAPI
{
    [Serializable]
    public class Champion
    {
        public string Version { get; set; }
        public string ID { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Blurb { get; set; }
        public ChampionInfo Info { get; set; }
        public ChampionImage Image { get; set; }
        public ICollection<string> Tags { get; set; }
        public string Partype { get; set; }
        public ChampionStats Stats { get; set; }
    }
}