using RPGHeroes.Attributes;
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
        protected string CharacterClass { get; set; }
        protected HeroAttribute TotalAttributes { get; set; }
        protected HeroAttribute LevelUpAttributes { get; set; }
        public WeaponType[] EligibleWeapons { get; set; }
        public ArmorType[] EligibleArmors { get; set; }

        public void LevelUp()
        {
            Level++;
            TotalAttributes.UpdateTotalAttributes(LevelUpAttributes.Strength, LevelUpAttributes.Dexterity, LevelUpAttributes.Intelligence);
        }
        public override string ToString()
        {
            return
                $"Name: {Name}\n" +
                $"Level: {Level} \n" +
                $"Class: {CharacterClass}\n" +
                $"Strength: {TotalAttributes.Strength} \n" +
                $"Dexterity: {TotalAttributes.Dexterity}\n" +
                $"Intelligence: {TotalAttributes.Intelligence}\n";
        }
    }
}