namespace RPGHeroes.Characters
{
    public class Mage : Character
    {
        private int baseStr = 1;
        private int baseDex = 1;
        private int baseInt = 8;
        private int lvlUpStr = 1;
        private int lvlUpDex = 1;
        private int lvlUpInt = 5;

        public Mage(string name)
        {
            Name = name;
            CharacterClass = "Mage";
        }
    }
}
