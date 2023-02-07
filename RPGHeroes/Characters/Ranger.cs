namespace RPGHeroes.Characters
{
    public class Ranger : Character
    {
        private int baseStr = 1;
        private int baseDex = 7;
        private int baseInt = 1;
        private int lvlUpStr = 1;
        private int lvlUpDex = 5;
        private int lvlUpInt = 1;


        public Ranger(string name)
        {
            Name = name;
            CharacterClass = "Ranger";
        }
    }
}
