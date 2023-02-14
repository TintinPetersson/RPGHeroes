using RPGHeroes.Attributes;
using RPGHeroes.Heroes;
using RPGHeroes.Items;

var newMage = new Mage("Big Mage");

Console.WriteLine(newMage.Display());

newMage.LevelUp();
newMage.LevelUp();

newMage.EquipWeapon(WeaponType.Staff, Slot.Weapon, 2, "Basic Staff", 22.5);
newMage.EquipArmor(ArmorType.Cloth, Slot.Head, 1, "Cloth Hat", new HeroAttribute(1, 1, 4));
newMage.EquipArmor(ArmorType.Cloth, Slot.Body, 1, "Cloth Robe", new HeroAttribute(1, 1, 8));
newMage.EquipArmor(ArmorType.Cloth, Slot.Legs, 1, "Cloth Pants", new HeroAttribute(1, 2, 8));

foreach (var item in newMage.Equipment)
{
    Console.WriteLine(item.Key + ": " + item.Value.Name);
}
Console.WriteLine("\n");
Console.WriteLine(newMage.Display());