﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {

        private int _minDamage;

        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public bool IsTwoHanded { get; set; }
        public int BonusHitChance { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }

        public Weapon(string name, int minDamage, int maxDamage, bool isTwoHanded, int bonusHitChance)
        {
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            IsTwoHanded = isTwoHanded;
            BonusHitChance = bonusHitChance;
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1} to {2} damage\nHit Modifier: {3}%\n{4}",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance >= 0 ? string.Format("+{0}", BonusHitChance) : string.Format("{0}", BonusHitChance),
                IsTwoHanded ? "This " + Name + " requires both hands to wield" : "This " + Name + " leaves one hand free");
        }

    }
}
