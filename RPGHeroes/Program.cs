using RPGHeroes.Heroes;

var newMage = new Mage("Big Mage");
var newWarrior = new Warrior("Big Warrior");

newMage.LevelUp();
newMage.LevelUp();
newWarrior.LevelUp();

Console.WriteLine(newMage.ToString());
Console.WriteLine(newWarrior.ToString());