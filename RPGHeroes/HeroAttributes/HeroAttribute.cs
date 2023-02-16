using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGHeroes.Heroes;

namespace RPGHeroes.Attributes
{
    public class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttribute(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public void UpdateLevelUpAttributes(int strength, int dexterity, int intelligence)
        {
            Strength += strength;
            Dexterity += dexterity;
            Intelligence += intelligence;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is HeroAttribute))
            {
                return false;
            }

            return Strength == this.Strength && Dexterity == this.Dexterity && Intelligence == this.Intelligence;
        }
    }
}