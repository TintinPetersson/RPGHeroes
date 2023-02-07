using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPGHeroes.Characters
{
    internal class Ranger: Hero
    {
        private int baseStrength = 1;
        private int baseDexterity = 7;
        private int baseIntelligence = 1;

        public Ranger(string name)
        {
            Name = name;
            CharacterCLass = "Ranger";
        }
    }
}
