using RPGHeroes.Attributes;
using RPGHeroes.HeroAttributes;
using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    abstract class Hero
    {
        public int Level { get; private set; } = 1;
        protected string Name { get; set; }
        protected string CharacterCLass { get; set; }
        public HeroSetAttribute BaseAttributes { get; protected set; }
        public HeroSetAttribute TotalAttributes { get; protected set; }
        protected HeroSetAttribute LevelUpAttributes { get; set; }
        protected HeroAttributeType PrimaryAttribute { get; set; }
        public WeaponType[] EligibleWeapons { get; set; }
        public ArmorType[] EligibleArmors { get; set; }

        public abstract string PrintInfo();
        public void LevelUp()
        {
            Level++;
            BaseAttributes.Add(LevelUpAttributes);
        }
    }
}