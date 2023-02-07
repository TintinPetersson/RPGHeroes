using RPGHeroes.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.HeroAttributes
{
    internal class HeroSetAttribute
    {
        public List<HeroAttribute> attributes { get; set; } = new List<HeroAttribute>();

        public HeroSetAttribute(int strength, int dexterity, int intelligence) 
        {
            attributes.Add(new HeroAttribute(HeroAttributeType.Strength, strength));
            attributes.Add(new HeroAttribute(HeroAttributeType.Dexterity, dexterity));
            attributes.Add(new HeroAttribute(HeroAttributeType.Intelligence, intelligence));
        }
    }
}