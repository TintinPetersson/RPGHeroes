namespace RPGHeroes.Characters
{
    public class Warrior : Character
    {
        private int baseStr = 5;
        private int baseDex = 2;
        private int baseInt = 1;
        private int lvlUpStr = 3;
        private int lvlUpDex = 2;
        private int lvlUpInt = 1;


        public Warrior(string name)
        {
            Name = name;
            CharacterClass = "Warrior";
        }
    }
}
