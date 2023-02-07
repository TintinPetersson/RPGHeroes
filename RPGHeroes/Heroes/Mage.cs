using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Characters
{
    internal class Mage: Hero
    {
        private int baseStrength = 1;
        private int baseDexterity = 1;
        private int baseIntelligence = 8;

        public Mage(string name)
        {
            Name = name;
            CharacterCLass = "Mage";
        }
    }
}
