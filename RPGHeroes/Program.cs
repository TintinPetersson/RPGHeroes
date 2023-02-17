using RPGHeroes.Attributes;
using RPGHeroes.Heroes;
using RPGHeroes.Items;

var newMage = new Mage("Big Mage");

Console.WriteLine(newMage.Display());

newMage.LevelUp();
newMage.LevelUp();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(newMage.EquipWeapon(new Weapon { Type = WeaponType.Staff, Slot = Slot.Weapon, RequiredLevel = 2, Name = "Basic Staff", WeaponDamage = 22.5 }));
Console.WriteLine(newMage.EquipArmor(new Armor { Type = ArmorType.Cloth, Slot = Slot.Head, RequiredLevel = 1, Name = "Cloth Hat", ArmorAttribute = new HeroAttribute(1, 1, 4) }));
Console.WriteLine(newMage.EquipArmor(new Armor { Type = ArmorType.Cloth, Slot = Slot.Body, RequiredLevel = 1, Name = "Cloth Robe", ArmorAttribute = new HeroAttribute(1, 1, 2) }));
Console.WriteLine(newMage.EquipArmor(new Armor { Type = ArmorType.Cloth, Slot = Slot.Legs, RequiredLevel = 1, Name = "Cloth Tights", ArmorAttribute = new HeroAttribute(1, 1, 7) }));
Console.WriteLine("\n");
Console.ResetColor();

foreach (var item in newMage.Equipment)
{
    Console.WriteLine(item.Key + ": " + item.Value.Name);
}
Console.WriteLine("\n");
Console.WriteLine(newMage.Display());