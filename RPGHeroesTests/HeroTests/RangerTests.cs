using RPGHeroes.Attributes;
using RPGHeroes.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTests.CharacterTests
{
    public class RangerTests
    {
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
            HeroAttribute actual = ranger.GetTotalAttributes();

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
        public void LevelUp_CallOnRanger_ShouldIncreaseAttributesAppropriatelyOnLevelUp()
        {
            // Arrange
            Ranger ranger = new Ranger("Ranger");
            HeroAttribute expected = new HeroAttribute(1 + 1, 7 + 5, 1 + 1);

            // Act
            ranger.LevelUp();
            HeroAttribute actual = ranger.GetTotalAttributes();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
