using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Items
{
    enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }
    internal class Armor : Item
    {
        public ArmorType Type { get; set; }
    }
}