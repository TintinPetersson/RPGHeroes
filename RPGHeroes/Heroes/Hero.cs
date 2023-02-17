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
    public abstract class Hero
    {
        public int Level { get; protected set; } = 1;
        protected string Name { get; set; }
        protected string CharacterClass { get; set; }
        public Dictionary<Slot, Item> Equipment { get; set; }
        public HeroAttribute LevelUpAttributes { get; set; }
        public WeaponType[] EligibleWeapons { get; set; }
        public ArmorType[] EligibleArmors { get; set; }


        public abstract void LevelUp();
        public string EquipWeapon(Weapon weapon)
        {
            if (!EligibleWeapons.Contains(weapon.Type))
            {
                throw new InvalidWeaponException(CharacterClass + "cannot equip this weapon type.");
            }
            if (Level < weapon.RequiredLevel)
            {
                throw new InvalidWeaponException("Hero's level is not high enough.");
            }

            var newWeapon = new Weapon { Name = weapon.Name, RequiredLevel = weapon.RequiredLevel, Slot = Slot.Weapon, Type = weapon.Type, WeaponDamage = weapon.WeaponDamage };
            Equipment.Remove(weapon.Slot);
            Equipment.Add(weapon.Slot, newWeapon);

            return "New Weapon Equipped!";
        }
        public string EquipArmor(Armor armor)
        {
            if (!EligibleArmors.Contains(armor.Type))
            {
                throw new InvalidArmorException("Character cannot equip this armor type.");
            }
            if (Level < armor.RequiredLevel)
            {
                throw new InvalidArmorException("Character's level is not high enough.");
            }

            var newArmor = new Armor { Name = armor.Name, RequiredLevel = armor.RequiredLevel, Slot = Slot.Weapon, Type = armor.Type, ArmorAttribute = armor.ArmorAttribute };

            Equipment.Remove(armor.Slot);
            Equipment.Add(armor.Slot, newArmor);

            return "New Armor Equipped!";
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
        public double Damage()
        {
            double weaponDPS = 1;

            var weapon = ((Weapon)Equipment[Slot.Weapon]);

            if (weapon.Name != null)
            {
                if(CharacterClass == "Mage") return weapon.WeaponDamage * (1 + ((double)GetTotalAttributes().Intelligence / 100));
                if (CharacterClass == "Ranger") return weapon.WeaponDamage * (1 + ((double)GetTotalAttributes().Dexterity / 100));
                if (CharacterClass == "Rogue") return weapon.WeaponDamage * (1 + ((double)GetTotalAttributes().Dexterity / 100));
                if (CharacterClass == "Warrior") return weapon.WeaponDamage * (1 + ((double)GetTotalAttributes().Strength / 100));
            }
            if (CharacterClass == "Mage") return weaponDPS + ((double)GetTotalAttributes().Intelligence / 100);
            if (CharacterClass == "Ranger") return weaponDPS + ((double)GetTotalAttributes().Dexterity / 100);
            if (CharacterClass == "Rogue") return weaponDPS + ((double)GetTotalAttributes().Dexterity / 100);
            if (CharacterClass == "Warrior") return weaponDPS + ((double)GetTotalAttributes().Strength / 100);

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