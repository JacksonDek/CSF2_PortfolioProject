using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        public HouseRace CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int hitChance, int block, int maxLife, int charisma, int speed, int luck, int stamina, int life, HouseRace characterRace, Weapon equippedWeapon)
            : base(name, hitChance, block, maxLife, charisma, speed, luck, life, stamina)
        {
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            switch (CharacterRace)
            {
                case HouseRace.Baratheon:
                    MaxLife += 10;
                    Life += 10;
                    HitChance -= 5;
                    Charisma -= 5;
                    break;
                case HouseRace.Greyjoy:
                    Block -= 5;
                    EquippedWeapon.MaxDamage += 2;
                    Charisma -= 10;
                    Luck -= 7;
                    break;
                case HouseRace.Lannistar:
                    Block += 5;
                    EquippedWeapon.MaxDamage += 3;
                    MaxLife -= 2;
                    Luck -= 7;
                    Charisma += 1;
                    HitChance += 3;
                    break;
                case HouseRace.Stark:
                    Block += 10;
                    MaxLife += 5;
                    Life += 5;
                    Charisma += 1;
                    Luck -= 4;
                    EquippedWeapon.MinDamage += 3;
                    HitChance += 5;
                    break;
                case HouseRace.Targaryeon:
                    Block -= 4;
                    Charisma += 4;
                    Luck -= 1;
                    MaxLife += 5;
                    Life += 5;
                    HitChance -= 3;
                    break;
                case HouseRace.Wildling:
                    Speed -= 3;
                    Charisma -= 8;
                    EquippedWeapon.MaxDamage += 5;
                    EquippedWeapon.MinDamage += 2;
                    HitChance += 3;
                    MaxLife += 4;
                    Life += 3;
                    break;
            }
        }

        public override string ToString()
        {
            //This is how you place a description for an enum instead of just the value of that enum
            string description = "";

            switch (CharacterRace)
            {
                case HouseRace.Baratheon:
                    description = "You're from the House Baratheon. Knownw for their ability to fight in the front lines. As strong as their house sigil the boar, The Baratheons are not the most intelegent family. Where their strength on the field of battle is above others, their ability to lead their people is rather lack luster.";
                    break;
                case HouseRace.Greyjoy:
                    description = "You're from the House Greyjoy. Known for their strength on the sea and ability the strong sense of leadership. The Greyjoys are a rather unlucky group, but they make up for their overall charismatic personas.";
                    break;
                case HouseRace.Lannistar:
                    description = "You're from the House Lannistar. Known for their good looks and strong hand in battle, the Lannistars are lacking in a charimatic charm. They are a lucky family being blessed with the gift of extreme welath.";
                    break;
                case HouseRace.Stark:
                    description = "You're from the House Stark. Known for their strong leadership and overwhelming strength, the Starks are an extremely unlucky House. Battling through adverstity at every turn. The Stark house is of the most nobel in Westeros.";
                    break;
                case HouseRace.Targaryeon:
                    description = "You're from the House Targaryon. After being bannished from the Kingdom of Westeros, the Taragyons have become an extremely charismatic group. Their are a less experienced group in battle, but do not underestimate their will power and desire to regain the kingdom. ";
                    break;
                case HouseRace.Wildling:
                    description = "From beyond the wall you emerge, The Wildlings are a savage and powerful family. Due to this extreme strength, the Wildlings lack some of the basic knowledge of most people.";
                    break;
            }//end switch

            return string.Format("-=-= {0} =-=-\nLife: {1} of {2}\nHit Chance: {3}%\nWeapon\n{4}\nBlock: {5}%\nLuck: {6}\nSpeed: {7}\nStamina {8}\nCharisma {9}\n{10}",
                Name,
                Life,
                MaxLife,
                CalcHitChance(),
                EquippedWeapon,
                Block,
                Luck,
                Speed,
                Stamina,
                Charisma,
                description);

        }//end ToString()

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }

        public override int CalcDamage()
        {
            return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }

        //TODO CalcBlock() & CalcStamina()

        //public override int CalcStamina()
        //{
        //    return Stamina - 
        //}

        //public override int CalcBlock()
        //{
        //    if (EquippedWeapon.IsTwoHanded)
        //    {
        //        EquippedWeapon.MinDamage += 1;
        //        EquippedWeapon.MaxDamage = EquippedWeapon.MaxDamage + (EquippedWeapon.MaxDamage / 4);
        //        Block -= 10;
        //    }
        //}


    }//end Class
}
