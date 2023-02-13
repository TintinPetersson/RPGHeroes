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
            EligibleWeapons = new WeaponType[] { WeaponType.Staff, WeaponType.Wand };
            EligibleArmors = new ArmorType[] { ArmorType.Cloth };
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