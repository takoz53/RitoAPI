﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RitoAPI.ChampionAPI
{
    [Serializable]
    public class ChampionImage
    {
        public string Full { get; set; }
        public string Sprite { get; set; }
        public string Group { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }
    }
}
