using RPGHeroes.Items;
using RPGHeroes.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTests.ItemTests
{
    public class ArmorTests
    {
        [Fact]
        public void Constructor_InitializeArmor_ShouldCreateArmorWithCorrectName()
        {
            //Arrange
            Armor Armor = new Armor { Name = "Test" };
            string expected = "Test";

            //Act 
            string actual = Armor.Name;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeArmor_ShouldCreateArmorWithCorrectArmorAttribute()
        {
            //Arrange
            Armor Armor = new Armor { ArmorAttribute = new HeroAttribute(1, 1, 4) };
            HeroAttribute expected = new HeroAttribute(1, 1, 4);

            //Act 
            HeroAttribute actual = Armor.ArmorAttribute;

            //Assert
            Assert.Equivalent(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeArmor_ShouldCreateArmorWithSlotOfGivenArmorSlot()
        {
            //Arrange
            Armor Armor = new Armor { Slot = Slot.Body };
            Slot expected = Slot.Body;

            //Act 
            Slot actual = Armor.Slot;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeArmor_ShouldCreateArmorWithCorrectRequiredLevel()
        {
            //Arrange
            Armor Armor = new Armor { RequiredLevel = 2 };
            int expected = 2;

            //Act 
            int actual = Armor.RequiredLevel;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeArmor_ShouldCreateArmorWithCorrectArmorType()
        {
            //Arrange
            Armor Armor = new Armor { Type = ArmorType.Plate };
            ArmorType expected = ArmorType.Plate;

            //Act 
            ArmorType actual = Armor.Type;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
