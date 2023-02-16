using RPGHeroes.Attributes;
using RPGHeroes.Heroes;

namespace RPGHeroesTests
{
    public class CharacterTests
    {
        // MAGE
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
            HeroAttribute actual = mage.LevelUpAttributes;

            // Assert
            Assert.Equal(expected, actual);
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
        public void LevelUp_CallOnMage_ShouldIncreaseAttributesAppropriately()
        {
            // Arrange
            Mage mage = new Mage("Mage");
            HeroAttribute expected = new HeroAttribute(1 + 1, 1 + 1, 8 + 5);

            // Act
            mage.LevelUp();
            HeroAttribute actual = mage.LevelUpAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }


        //Ranger
        [Fact]
        public void Constructor_InitializeHeroWithName_ShouldCreateRangerAtLevelOne()
        {
            //Arrange
            Ranger character = new Ranger("Character");
            int expected = 1;

            //Act 
            int actual = character.Level;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeRanger_ShouldCreateRangerWithProperDefaultAttributes()
        {
            // Arrange
            Ranger ranger = new Ranger("Ranger");
            HeroAttribute expected = new HeroAttribute(1, 7, 1);

            // Act
            HeroAttribute actual = ranger.LevelUpAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LevelUp_CallOnNewRanger_ShouldIncreaseLevelToTwo()
        {
            // Arrange
            string name = "Character";
            Ranger character = new Ranger(name);
            int expected = 2;

            // Act
            character.LevelUp();
            int actual = character.Level;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LevelUp_CallOnRanger_ShouldIncreaseAttributesAppropriately()
        {
            // Arrange
            Ranger ranger = new Ranger("Ranger");
            HeroAttribute expected = new HeroAttribute(1 + 1, 7 + 5, 1 + 1);

            // Act
            ranger.LevelUp();
            HeroAttribute actual = ranger.LevelUpAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }

        //Rogue
        [Fact]
        public void Constructor_InitializeHeroWithName_ShouldCreateRogueAtLevelOne()
        {
            //Arrange
            Rogue character = new Rogue("Character");
            int expected = 1;

            //Act 
            int actual = character.Level;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeRogue_ShouldCreateRogueWithProperDefaultAttributes()
        {
            // Arrange
            Rogue rogue = new Rogue("Rogue");
            HeroAttribute expected = new HeroAttribute(2, 6, 1);

            // Act
            HeroAttribute actual = rogue.LevelUpAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LevelUp_CallOnNewRogue_ShouldIncreaseLevelToTwo()
        {
            // Arrange
            string name = "Character";
            Rogue character = new Rogue(name);
            int expected = 2;

            // Act
            character.LevelUp();
            int actual = character.Level;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LevelUp_CallOnRogue_ShouldIncreaseAttributesAppropriately()
        {
            // Arrange
            Rogue rogue = new Rogue("Rogue");
            HeroAttribute expected = new HeroAttribute(2 + 1, 6 + 4, 1 + 1);

            // Act
            rogue.LevelUp();
            HeroAttribute actual = rogue.LevelUpAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }


        //Warrior
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
            HeroAttribute actual = warrior.LevelUpAttributes;

            // Assert
            Assert.Equal(expected, actual);
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
        public void LevelUp_CallOnWarrior_ShouldIncreaseAttributesAppropriately()
        {
            // Arrange
            Warrior warrior = new Warrior("Warrior");
            HeroAttribute expected = new HeroAttribute(5 + 3, 2 + 2, 1 + 1);

            // Act
            warrior.LevelUp();
            HeroAttribute actual = warrior.LevelUpAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}