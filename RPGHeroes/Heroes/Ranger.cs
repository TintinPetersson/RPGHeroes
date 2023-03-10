using RPGHeroes.Attributes;
using RPGHeroes.Items;

namespace RPGHeroes.Heroes
{
    public class Ranger: Hero
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

            LevelUpAttributes = new HeroAttribute(baseStrength, baseDexterity, baseIntelligence);
            EligibleWeapons = new WeaponType[] { WeaponType.Bow };
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
