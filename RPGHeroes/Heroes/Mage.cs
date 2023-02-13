using RPGHeroes.Attributes;
using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    internal class Mage: Hero
    {
        private int baseStrength = 1;
        private int baseDexterity = 1;
        private int baseIntelligence = 8;

        private int strengthOnLevelUp = 1;
        private int dexterityOnLevelUp = 1;
        private int intelligenceOnLevelUp = 5;

        public Mage(string name)
        {
            Name = name;
            CharacterClass = "Mage";


            TotalAttributes = new HeroAttribute { Strength = baseStrength, Dexterity = baseDexterity, Intelligence = baseIntelligence };
            LevelUpAttributes = new HeroAttribute { Strength = strengthOnLevelUp, Dexterity = dexterityOnLevelUp, Intelligence = intelligenceOnLevelUp };
            EligibleWeapons = new WeaponType[] { WeaponType.Staff, WeaponType.Wand };
            EligibleArmors = new ArmorType[] { ArmorType.Cloth };
        }
    }
}