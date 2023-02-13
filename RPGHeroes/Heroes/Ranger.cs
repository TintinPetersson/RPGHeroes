﻿using RPGHeroes.Attributes;
using RPGHeroes.HeroAttributes;
using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPGHeroes.Heroes
{
    internal class Ranger: Hero
    {
        private int baseStrength = 1;
        private int baseDexterity = 7;
        private int baseIntelligence = 1;

        private int strengthOnLevelUp = 1;
        private int dexterityOnLevelUp = 5;
        private int intelligenceOnLevelUp = 1;

        public Ranger(string name)
        {
            Name = name;
            CharacterClass = "Ranger";

            PrimaryAttribute = HeroAttributeType.Intelligence;
            BaseAttributes = new HeroSetAttribute(baseStrength, baseDexterity, baseIntelligence);
            TotalAttributes = new HeroSetAttribute(BaseAttributes);
            LevelUpAttributes = new HeroSetAttribute(strengthOnLevelUp, dexterityOnLevelUp, intelligenceOnLevelUp);
            EligibleWeapons = new WeaponType[] { WeaponType.Bow };
            EligibleArmors = new ArmorType[] { ArmorType.Leather, ArmorType.Mail };
        }
    }
}
