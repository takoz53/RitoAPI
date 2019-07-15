using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitoAPI.VersionAPI
{
    [Serializable]
    public class Version
    {
        public string Item { get; set; }
        public string Rune { get; set; }
        public string Mastery { get; set; }
        public string Summoner { get; set; }
        public string Champion { get; set; }
        public string ProfileIcon { get; set; }
        public string Map { get; set; }
        public string Language { get; set; }
        public string Sticker { get; set; }
    }
}
