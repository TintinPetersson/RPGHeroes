using RPGHeroes.Attributes;
using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPGHeroes.Heroes
{
    internal class Rogue: Hero
    {
        private int baseStrength = 2;
        private int baseDexterity = 6;
        private int baseIntelligence = 1;

        private int strengthOnLevelUp = 1;
        private int dexterityOnLevelUp = 4;
        private int intelligenceOnLevelUp = 1;

        public Rogue(string name)
        {
            Name = name;
            CharacterClass = "Rogue";

            TotalAttributes = new HeroAttribute { Strength = baseStrength, Dexterity = baseDexterity, Intelligence = baseIntelligence };
            LevelUpAttributes = new HeroAttribute { Strength = strengthOnLevelUp, Dexterity = dexterityOnLevelUp, Intelligence = intelligenceOnLevelUp };
            EligibleWeapons = new WeaponType[] { WeaponType.Dagger, WeaponType.Sword };
            EligibleArmors = new ArmorType[] { ArmorType.Leather, ArmorType.Mail };
        }
    }
}