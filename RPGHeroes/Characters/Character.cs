using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Characters
{
    abstract class Character
    {
        public int Level { get; private set; } = 1;
        protected string Name { get; set; }
        protected string CharacterCLass { get; set; }
    }
}
