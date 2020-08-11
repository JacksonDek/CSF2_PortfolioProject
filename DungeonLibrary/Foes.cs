using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Foe : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }

        public Foe(string name, int hitChance, int block, int maxLife, int charisma, int speed, int luck, int life, int stamina, int maxDamage, int minDamage, string description)
            : base(name, hitChance, block, maxLife, charisma, speed, luck, life, stamina)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        public override string ToString()
        {
            return string.Format("*****{0}*****\n{1}\n{2}",
                Name,
                Description,
                Life > MaxLife / 2 ? "The " + Name + " seems to be uninjured" : "The " + Name + " seems to be close to death.");
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }

    }
}
