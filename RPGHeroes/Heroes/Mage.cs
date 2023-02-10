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
            CharacterCLass = "Mage";

            PrimaryAttribute = HeroAttributeType.Intelligence;
            BaseAttributes = new HeroSetAttribute( baseStrength, baseDexterity, baseIntelligence);
            TotalAttributes = new HeroSetAttribute(BaseAttributes);
            LevelUpAttributes = new HeroSetAttribute(strengthOnLevelUp, dexterityOnLevelUp, intelligenceOnLevelUp);
            EligibleWeapons = new WeaponType[] { WeaponType.Staff, WeaponType.Wand };
            EligibleArmors = new ArmorType[] { ArmorType.Cloth };
        }

        public override string PrintInfo()
        {
            return $"Hero Name: ~ {Name} ~ \nHero Class: {CharacterCLass}\nLevel: {Level} \nAttributes: {TotalAttributes.Attributes[0].Type}";
        }
    }
}