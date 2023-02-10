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
        public List<HeroAttribute> Attributes { get; set; } = new List<HeroAttribute>();

        public HeroSetAttribute(int strength, int dexterity, int intelligence) 
        {
            Attributes.Add(new HeroAttribute(HeroAttributeType.Strength, strength));
            Attributes.Add(new HeroAttribute(HeroAttributeType.Dexterity, dexterity));
            Attributes.Add(new HeroAttribute(HeroAttributeType.Intelligence, intelligence));
        }

        public HeroSetAttribute(HeroSetAttribute copy)
        {
            Attributes = new List<HeroAttribute>(copy.Attributes);
        }

        public void Add(HeroSetAttribute append)
        {
            //Attributes = new List<HeroAttribute>(Attributes.Zip(append.Attributes, (attr1, attr2) => attr1 + attr2));
        }
    }
}