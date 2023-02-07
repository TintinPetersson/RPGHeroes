using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPGHeroes.Characters
{
    internal class Warrior: Hero
    {
        private int baseStrength = 5;
        private int baseDexterity = 2;
        private int baseIntelligence = 1;

        public Warrior(string name)
        {
            Name = name;
            CharacterCLass = "Warrior";
        }
    }
}
