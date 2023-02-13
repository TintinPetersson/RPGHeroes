using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.CustomExceptions
{
    internal class InvalidArmorException : Exception
    {
        public InvalidArmorException(string problem)
            : base($"Unable to equip armor piece: {problem}")
        {

        }
    }
}
