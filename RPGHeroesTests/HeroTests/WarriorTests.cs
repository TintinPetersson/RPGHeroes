using RPGHeroes.Attributes;
using RPGHeroes.Heroes;

namespace RPGHeroesTests.CharacterTests
{
    public class WarriorTests
    {
        [Fact]
        public void Constructor_InitializeHeroWithName_ShouldCreateWarriorAtLevelOne()
        {
            //Arrange
            Warrior character = new Warrior("Character");
            int expected = 1;

            //Act 
            int actual = character.Level;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeWarrior_ShouldCreateWarriorWithProperDefaultAttributes()
        {
            // Arrange
            Warrior warrior = new Warrior("Warrior");
            HeroAttribute expected = new HeroAttribute(5, 2, 1);

            // Act
            HeroAttribute actual = warrior.GetTotalAttributes();

            // Assert
            Assert.Equivalent(expected, actual);
        }
        [Fact]
        public void LevelUp_CallOnNewWarrior_ShouldIncreaseLevelToTwo()
        {
            // Arrange
            string name = "Character";
            Warrior character = new Warrior(name);
            int expected = 2;

            // Act
            character.LevelUp();
            int actual = character.Level;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LevelUp_CallOnWarrior_ShouldIncreaseAttributesAppropriatelyOnLevelUp()
        {
            // Arrange
            Warrior warrior = new Warrior("Warrior");
            HeroAttribute expected = new HeroAttribute(5 + 3, 2 + 2, 1 + 1);

            // Act
            warrior.LevelUp();
            HeroAttribute actual = warrior.GetTotalAttributes();

            // Assert
            Assert.Equivalent(expected, actual);
        }
    }
}
