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
        protected HeroAttribute LevelUpAttributes { get; set; }
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

            var newWeapon = new Weapon { Name = name, RequiredLevel = requiredLevel, Slot = Slot.Weapon, Type = weapon, WeaponDamage = damage };
            Equipment.Remove(slot);
            Equipment.Add(slot, newWeapon);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("New Weapon Equipped!\n");
            Console.ResetColor();
        }
        public void EquipArmor(ArmorType armor, Slot slot, int requiredLevel, string name, HeroAttribute attributes)
        {
            if (!EligibleArmors.Contains(armor))
            {
                throw new InvalidArmorException("Character cannot equip this armor type.");
            }
            if (Level < requiredLevel)
            {
                throw new InvalidArmorException("Character's level is not high enough.");
            }

            var newArmor = new Armor { Name = name, RequiredLevel = requiredLevel, Slot = Slot.Weapon, Type = armor, ArmorAttribute = attributes };

            Equipment.Remove(slot);
            Equipment.Add(slot, newArmor);

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("New Armor Equipped!\n");
            Console.ResetColor();
        }
        public HeroAttribute GetTotalAttributes()
        {
            var totalAttributes = LevelUpAttributes;

            foreach (var item in Equipment) 
            {
                if (item.Key != Slot.Weapon)
                {
                    if(((Armor)item.Value).ArmorAttribute != null)
                    {
                        totalAttributes.Strength += ((Armor)item.Value).ArmorAttribute.Strength;
                        totalAttributes.Dexterity += ((Armor)item.Value).ArmorAttribute.Dexterity;
                        totalAttributes.Intelligence += ((Armor)item.Value).ArmorAttribute.Intelligence;
                    }
                }
            }

            return totalAttributes;
        }
        private double Damage()
        {
            double weaponDPS = 1;

            var weapon = ((Weapon)Equipment[Slot.Weapon]);

            if (weapon.Name != null)
            {
                if(CharacterClass == "Mage") return weaponDPS += weapon.WeaponDamage * (1 + GetTotalAttributes().Intelligence / 100);
                if (CharacterClass == "Ranger") return weaponDPS += weapon.WeaponDamage * (1 + GetTotalAttributes().Dexterity / 100);
                if (CharacterClass == "Rogue") return weaponDPS += weapon.WeaponDamage * (1 + GetTotalAttributes().Dexterity / 100);
                if (CharacterClass == "Warrior") return weaponDPS += weapon.WeaponDamage * (1 + GetTotalAttributes().Strength / 100);
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
                $"Strength: {GetTotalAttributes().Strength}\n" +
                $"Dexterity: {GetTotalAttributes().Dexterity}\n" +
                $"Intelligence: {GetTotalAttributes().Intelligence}\n" +
                $"Damage: {Damage()}\n";
        }
    }
}