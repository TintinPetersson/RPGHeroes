using RPGHeroes.Items;

namespace RPGHeroesTests.ItemTests
{
    public class WeaponTests
    {
        [Fact]
        public void Constructor_InitializeWeapon_ShouldCreateWeaponWithCorrectName()
        {
            //Arrange
            Weapon weapon = new Weapon { Name = "Test"};
            string expected = "Test";

            //Act 
            string actual = weapon.Name;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeWeapon_ShouldCreateWeaponWithCorrectWeaponDamage()
        {
            //Arrange
            Weapon weapon = new Weapon { WeaponDamage = 100};
            double expected = 100;

            //Act 
            double actual = weapon.WeaponDamage;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeWeapon_ShouldCreateWeaponWithSlotOfWeapon()
        {
            //Arrange
            Weapon weapon = new Weapon { Slot = Slot.Weapon };
            Slot expected = Slot.Weapon;

            //Act 
            Slot actual = weapon.Slot;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeWeapon_ShouldCreateWeaponWithCorrectRequiredLevel()
        {
            //Arrange
            Weapon weapon = new Weapon { RequiredLevel = 2 };
            int expected = 2;

            //Act 
            int actual = weapon.RequiredLevel;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_InitializeWeapon_ShouldCreateWeaponWithCorrectWeaponType()
        {
            //Arrange
            Weapon weapon = new Weapon { Type = WeaponType.Staff };
            WeaponType expected = WeaponType.Staff;

            //Act 
            WeaponType actual = weapon.Type;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
