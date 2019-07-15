using System;
using System.Collections.Generic;
using System.Text;

namespace RitoAPI.Regions
{
    public class Region
    {
        [Flags]
        public enum Regions
        {
            en_US,
            en_GB,
            tr_TR,
            fr_FR
        }
    }
}
