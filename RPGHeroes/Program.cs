using RPGHeroes.Heroes;
using RPGHeroes.Items;

var newMage = new Mage("Big Mage");
var newRogue = new Rogue("Big Rogue");

newMage.LevelUp();
newMage.LevelUp();

newMage.EquipWeapon(WeaponType.Staff, Slot.Weapon, 2, "Basic Staff", 22.5);
newMage.EquipArmor(ArmorType.Cloth, Slot.Head, 1, "Cloth Hat");
newMage.EquipArmor(ArmorType.Cloth, Slot.Body, 1, "Cloth Robe");
newMage.EquipArmor(ArmorType.Cloth, Slot.Legs, 1, "Cloth Pants");

foreach (var item in newMage.Equipment)
{
    Console.WriteLine(item.Key + ": " + item.Value.Name);
}
Console.WriteLine("\n");


newRogue.EquipWeapon(WeaponType.Dagger, Slot.Weapon, 1, "Basic Dagger", 25.5);

Console.WriteLine(newMage.Display());
Console.WriteLine(newRogue.Display());
