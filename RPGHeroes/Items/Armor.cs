using RPGHeroes.Attributes;

namespace RPGHeroes.Items
{
    public enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }
    public class Armor : Item
    {
        public ArmorType Type { get; set; }
        public HeroAttribute ArmorAttribute { get; set; }
    }
}