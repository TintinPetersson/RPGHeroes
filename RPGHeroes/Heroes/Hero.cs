using RPGHeroes.Attributes;
using RPGHeroes.CustomExceptions;
using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RPGHeroes.Heroes
{
    abstract class Hero
    {
        public int Level { get; protected set; } = 1;
        protected string Name { get; set; }
        protected string CharacterClass { get; set; }
        public Dictionary<Slot, Item> Equipment { get; set; }
        protected HeroAttribute TotalAttributes { get; set; }
        public WeaponType[] EligibleWeapons { get; set; }
        public ArmorType[] EligibleArmors { get; set; }

        public abstract void LevelUp();
        public void EquipWeapon(WeaponType weapon, Slot slot, int requiredLevel, string name, double damage)
        {
            if (!EligibleWeapons.Contains(weapon))
            {
                throw new InvalidWeaponException(CharacterClass + "cannot equip this weapon type.");
            }
            if (Level < requiredLevel)
            {
                throw new InvalidWeaponException("Hero's level is not high enough.");
            }

            var newWeapon = new Weapon { Name = name, RequiredLevel = requiredLevel, Slot = Slot.Weapon, Type = weapon, Damage = damage };
            Equipment.Remove(slot);
            Equipment.Add(slot, newWeapon);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("New Weapon Equipped!\n");
            Console.ResetColor();
        }
        public void EquipArmor(ArmorType armor, Slot slot, int requiredLevel, string name)
        {
            if (!EligibleArmors.Contains(armor))
            {
                throw new InvalidArmorException("Character cannot equip this armor type.");
            }
            if (Level < requiredLevel)
            {
                throw new InvalidArmorException("Character's level is not high enough.");
            }

            var newArmor = new Armor { Name = name, RequiredLevel = requiredLevel, Slot = Slot.Weapon, Type = armor };
            Equipment.Remove(slot);
            Equipment.Add(slot, newArmor);

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("New Armor Equipped!\n");
            Console.ResetColor();
        }

        private double Damage()
        {
            double weaponDPS = 1;

            var weapon = ((Weapon)Equipment[Slot.Weapon]);

            if (weapon.Name != null)
            {
                if(CharacterClass == "Mage") return weaponDPS += weapon.Damage * (1 + TotalAttributes.Intelligence / 100);
                if (CharacterClass == "Ranger") return weaponDPS += weapon.Damage * (1 + TotalAttributes.Dexterity / 100);
                if (CharacterClass == "Rogue") return weaponDPS += weapon.Damage * (1 + TotalAttributes.Dexterity / 100);
                if (CharacterClass == "Warrior") return weaponDPS += weapon.Damage * (1 + TotalAttributes.Strength / 100);
            }
            return weaponDPS;
        }

        public string Display()
        {
            return
                $"<<<<< STATS >>>>>\n\n" +
                $"Name: {Name}\n" +
                $"Level: {Level} \n" +
                $"Class: {CharacterClass}\n" +
                $"Strength: {TotalAttributes.Strength} \n" +
                $"Dexterity: {TotalAttributes.Dexterity}\n" +
                $"Intelligence: {TotalAttributes.Intelligence}\n" +
                $"Damage: {Damage()}\n";
        }
    }
}