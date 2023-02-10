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
            CharacterCLass = "Warrior";
        }
        public override string PrintInfo()
        {
            return $"Hero Name: ~ {Name} ~ \nHero Class: {CharacterCLass}";
        }

    }
}
