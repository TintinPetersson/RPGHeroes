using RPGHeroes.Attributes;
using RPGHeroes.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTests.CharacterTests
{
    public class RogueTests
    {
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
            HeroAttribute actual = rogue.GetTotalAttributes();

            // Assert
            Assert.Equivalent(expected, actual);
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
        public void LevelUp_CallOnRogue_ShouldIncreaseAttributesAppropriatelyOnLevelUp()
        {
            // Arrange
            Rogue rogue = new Rogue("Rogue");
            HeroAttribute expected = new HeroAttribute(2 + 1, 6 + 4, 1 + 1);

            // Act
            rogue.LevelUp();
            HeroAttribute actual = rogue.GetTotalAttributes();

            // Assert
            Assert.Equivalent(expected, actual);
        }
    }
}
