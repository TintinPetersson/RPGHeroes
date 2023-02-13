using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Attributes
{
    enum HeroAttributeType
    {
        Strength,
        Dexterity,
        Intelligence
    }
    internal class HeroAttribute
    {
        public HeroAttributeType Type { get; set; }
        public int Value { get; set; } = 0;

        public HeroAttribute(HeroAttributeType type, int value)
        {
            Type = type;
            Value = value;
        }

        public HeroAttribute(HeroAttribute copy)
        {
            Type = copy.Type;
            Value = copy.Value;
        }
    }
}