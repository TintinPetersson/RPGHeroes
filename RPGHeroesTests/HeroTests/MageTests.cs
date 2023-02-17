using RPGHeroes.Attributes;
using RPGHeroes.Heroes;

namespace RPGHeroesTests.CharacterTests
{
    public class MageTests
    {
        [Fact]
        public void Constructor_InitializeHeroWithName_ShouldCreateMageAtLevelOne()
        {
            //Arrange
            Mage character = new Mage("Character");
            int expected = 1;

            //Act 
            int actual = character.Level;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeMage_ShouldCreateMageWithProperDefaultAttributes()
        {
            // Arrange
            Mage mage = new Mage("Mage");
            HeroAttribute expected = new HeroAttribute(1, 1, 8);

            // Act
            HeroAttribute actual = mage.GetTotalAttributes();

            // Assert
            Assert.Equivalent(expected, actual);
        }
        [Fact]
        public void LevelUp_CallOnNewMage_ShouldIncreaseLevelToTwo()
        {
            // Arrange
            string name = "Character";
            Mage character = new Mage(name);
            int expected = 2;

            // Act
            character.LevelUp();
            int actual = character.Level;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LevelUp_CallOnMage_ShouldIncreaseAttributesAppropriatelyOnLevelUp()
        {
            // Arrange
            Mage mage = new Mage("Mage");
            HeroAttribute expected = new HeroAttribute(1 + 1, 1 + 1, 8 + 5);

            // Act
            mage.LevelUp();
            HeroAttribute actual = mage.GetTotalAttributes();

            // Assert
            Assert.Equivalent(expected, actual);
        }
    }
}
