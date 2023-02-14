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

            LevelUpAttributes = new HeroAttribute (baseStrength, baseDexterity, baseIntelligence);
            EligibleWeapons = new WeaponType[] { WeaponType.Dagger, WeaponType.Sword };
            EligibleArmors = new ArmorType[] { ArmorType.Leather, ArmorType.Mail };
            Equipment = new Dictionary<Slot, Item> { { Slot.Weapon, new Weapon() }, { Slot.Body, new Armor() }, { Slot.Head, new Armor() }, { Slot.Legs, new Armor() }, };
        }
        public override void LevelUp()
        {
            Level++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Congratulations {Name}.\nYou reached Level {Level}!\n");
            Console.ResetColor();

            LevelUpAttributes.UpdateLevelUpAttributes(strengthOnLevelUp, dexterityOnLevelUp, intelligenceOnLevelUp);
        }
    }
}