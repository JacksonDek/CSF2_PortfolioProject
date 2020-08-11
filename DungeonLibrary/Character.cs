using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Character
    {
        private int _life;

        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }
        public int Charisma { get; set; }
        public int Speed { get; set; }

        public int Luck { get; set; }
        public int Stamina { get; set; }

        public int Life
        {
            get { return _life; }
            set { _life = value <= MaxLife ? value : MaxLife; }
        }

        public Character(string name, int hitChance, int block, int maxLife, int charisma, int speed, int luck, int life, int stamina)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Charisma = charisma;
            Speed = speed;

            Luck = luck;
            Life = life;
            Stamina = stamina;
        }

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }

        public virtual int CalcStamina()
        {
            return Stamina;
        }
    }
}
