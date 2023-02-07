namespace RPGHeroes.Characters
{
    public class Rogue : Character
    {
        private int baseStr = 2;
        private int baseDex = 6;
        private int baseInt = 1;
        private int lvlUpStr = 1;
        private int lvlUpDex = 4;
        private int lvlUpInt = 1;


        public Rogue(string name)
        {
            Name = name;
            CharacterClass = "Rogue";
        }
    }
}
