using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.CustomExceptions
{
    internal class InvalidWeaponException : Exception
    {
        public InvalidWeaponException(string problem)
            : base($"Unable to equip weapon: {problem}")
        {

        }
    }
}
