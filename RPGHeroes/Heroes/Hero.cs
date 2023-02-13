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
        protected string CharacterClass { get; set; }
        protected HeroSetAttribute BaseAttributes { get; set; }
        protected HeroSetAttribute TotalAttributes { get; set; }
        protected HeroSetAttribute LevelUpAttributes { get; set; }
        protected HeroAttributeType PrimaryAttribute { get; set; }
        public WeaponType[] EligibleWeapons { get; set; }
        public ArmorType[] EligibleArmors { get; set; }

        public void LevelUp()
        {
            Level++;
            UpdateTotalAttributes();
        }
        private void UpdateTotalAttributes()
        {
            for (int i = 0; i < TotalAttributes.Attributes.Count; i++)
            {
                TotalAttributes.Attributes[i].Value += LevelUpAttributes.Attributes[i].Value;
            }
        }
        public override string ToString()
        {
            return
                $"Name: {Name}\n" +
                $"Level: {Level}\n" +
                $"Class: {CharacterClass}\n" +
                $"Strength: {TotalAttributes.GetAttributeValue(HeroAttributeType.Strength)}\n" +
                $"Dexterity: {TotalAttributes.GetAttributeValue(HeroAttributeType.Dexterity)}\n" +
                $"Intelligence: {TotalAttributes.GetAttributeValue(HeroAttributeType.Intelligence)}\n";
        }
    }
}