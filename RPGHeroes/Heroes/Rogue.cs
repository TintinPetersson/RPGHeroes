using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPGHeroes.Characters
{
    internal class Rogue: Hero
    {
        private int baseStrength = 2;
        private int baseDexterity = 6;
        private int baseIntelligence = 1;

        public Rogue(string name)
        {
            Name = name;
            CharacterCLass = "Rogue";
        }
    }
}