﻿using RPGHeroes.Attributes;
using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPGHeroes.Heroes
{
    internal class Warrior: Hero
    {
        private int baseStrength = 5;
        private int baseDexterity = 2;
        private int baseIntelligence = 1;

        private int strengthOnLevelUp = 3;
        private int dexterityOnLevelUp = 2;
        private int intelligenceOnLevelUp = 1;

        public Warrior(string name)
        {
            Name = name;
            CharacterClass = "Warrior";

            TotalAttributes = new HeroAttribute { Strength = baseStrength, Dexterity = baseDexterity, Intelligence = baseIntelligence };
            EligibleWeapons = new WeaponType[] { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword };
            EligibleArmors = new ArmorType[] { ArmorType.Mail, ArmorType.Plate };
            Equipment = new Dictionary<Slot, Item> { { Slot.Weapon, new Weapon() }, { Slot.Body, new Armor() }, { Slot.Head, new Armor() }, { Slot.Legs, new Armor() }, };
        }
        public override void LevelUp()
        {
            Level++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Congratulations {Name}.\nYou reached Level {Level}!\n");
            Console.ResetColor();

            TotalAttributes.UpdateTotalAttributes(strengthOnLevelUp, dexterityOnLevelUp, intelligenceOnLevelUp);
        }
    }
}
