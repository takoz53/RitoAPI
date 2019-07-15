using System;
using System.Collections.Generic;
using System.Text;

namespace RitoAPI.ChampionAPI
{
    [Serializable]
    public class ChampionStats
    {
        public double HP { get; set; }
        public double HPperLevel { get; set; }
        public double MP { get; set; }
        public double MPperLevel { get; set; }
        public double MoveSpeed { get; set; }
        public double Armor { get; set; }
        public double ArmorperLevel { get; set; }
        public double SpellBlock { get; set; }
        public double SpellBlockperLevel { get; set; }
        public double AttackRange { get; set; }
        public double HPRegen { get; set; }
        public double HPRegenperLevel { get; set; }
        public double MPRegen { get; set; }
        public double MPRegenperLevel { get; set; }
        public double Crit { get; set; }
        public double AttackDamage { get; set; }
        public double AttackDamageperLevel {get; set; }
        public double AttackSpeedOffset { get; set; }
        public double AttackSpeedperLevel { get; set; }
    }
}
