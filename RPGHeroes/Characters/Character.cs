namespace RPGHeroes.Characters
{
    public abstract class Character
    {
        public int Level { get; private set; } = 1;
        protected string Name { get; set; }
        protected string CharacterClass { get; set; }

        public void LevelUp()
        {
            Level++;
        }
    }
}
