using RPGHeroes.Attributes;
using RPGHeroes.CustomExceptions;
using RPGHeroes.Heroes;
using RPGHeroes.Items;


namespace RPGHeroesTests.ItemTests
{
    public class HeroEquipmentTests
    {
        [Fact]
        public void EquipItem_CallOnWeaponWithTooHighLevelRequirement_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Weapon testAxe = new Weapon { Name = "Test Axe", RequiredLevel = 2, Slot = Slot.Weapon, Type = WeaponType.Axe, WeaponDamage = 30.5 };

            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => testWarrior.EquipWeapon(testAxe));
        }

        [Fact]
        public void EquipItem_CallOnArmorWithTooHighLevelRequirement_ShouldThrowInvalidArmorException()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Armor testPlateBody = new Armor { Name = "Common plate body armor", RequiredLevel = 2, Slot = Slot.Body, Type = ArmorType.Plate, ArmorAttribute = new HeroAttribute(1, 0, 0) };

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => testWarrior.EquipArmor(testPlateBody));
        }

        [Fact]
        public void EquipItem_CallOnWrongWeaponType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Weapon testBow = new Weapon { Name = "Common bow", RequiredLevel = 1, Type = WeaponType.Bow, Slot = Slot.Weapon , WeaponDamage = 12.0 };

            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => testWarrior.EquipWeapon(testBow));
        }

        [Fact]
        public void EquipItem_CallOnWrongArmorType_ShouldThrowInvalidArmorException()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Armor testClothHead = new Armor { Name = "Common Cloth", RequiredLevel = 1, Slot = Slot.Body, Type = ArmorType.Cloth, ArmorAttribute = new HeroAttribute(1, 0, 0) };

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => testWarrior.EquipArmor(testClothHead));
        }

        [Fact]
        public void EquipItem_CallOnValidWeapon_ShouldReturnSuccessMessage()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Weapon testAxe = new Weapon { Name = "Test Axe", RequiredLevel = 1, Slot = Slot.Weapon, Type = WeaponType.Axe, WeaponDamage = 7.0 };
            string expected = "New Weapon Equipped!";

            // Act
            string actual = testWarrior.EquipWeapon(testAxe);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EquipItem_CallOnValidArmor_ShouldReturnSuccessMessage()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Armor testPlateBody = new Armor { Name = "Common plate body armor", RequiredLevel = 1, Slot = Slot.Body, Type = ArmorType.Plate, ArmorAttribute = new HeroAttribute(1, 0, 0) };
            string expected = "New Armor Equipped!";

            // Act
            string actual = testWarrior.EquipArmor(testPlateBody);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_CallOnCharacterWithNoWeapon_ShouldReturnUnarmedDamage()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            double expected = 1 * (1 + (5.0 / 100.0));

            // Act
            double actual = testWarrior.Damage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_CallOnCharacterWithWeapon_ShouldReturnDamage()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Weapon testAxe = new Weapon { Name = "Test Axe", RequiredLevel = 1, Slot = Slot.Weapon, Type = WeaponType.Axe, WeaponDamage = 7.0 };
            testWarrior.EquipWeapon(testAxe);

            double expected = 7  * (1 + (5.0 / 100.0));


            // Act
            double actual = testWarrior.Damage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_CallOnCharacterWithWeaponAndArmor_ShouldReturnDamage()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Weapon testAxe = new Weapon { Name = "Test Axe", RequiredLevel = 1, Slot = Slot.Weapon, Type = WeaponType.Axe, WeaponDamage = 7 };
            Armor testPlateBody = new Armor { Name = "Common plate body armor", RequiredLevel = 1, Slot = Slot.Body, Type = ArmorType.Plate, ArmorAttribute = new HeroAttribute(1, 0, 0) };
            testWarrior.EquipWeapon(testAxe);
            testWarrior.EquipArmor(testPlateBody);

            double expected = 7  * (1 + ((5.0 + 1.0) / 100.0));

            // Act
            double actual = testWarrior.Damage();

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void NoItemEquipped_CallOnGetAttributes_ShouldDisplayCorrectAttributes()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            HeroAttribute expected = testWarrior.GetTotalAttributes();

            // Act
            HeroAttribute actual = new HeroAttribute(5, 2, 1);

            // Assert
            Assert.Equivalent(expected, actual);
        }
        [Fact]
        public void EquipItem_CallOnValidOnePieceOfArmor_ShouldDisplayCorrectAttributes()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Armor testPlateBody = new Armor { Name = "Common plate body armor", RequiredLevel = 1, Slot = Slot.Body, Type = ArmorType.Plate, ArmorAttribute = new HeroAttribute(2, 0, 0) };
            testWarrior.EquipArmor(testPlateBody);

            HeroAttribute expected = new HeroAttribute(5 + 2, 2, 1);

            // Act
            HeroAttribute actual = testWarrior.GetTotalAttributes();

            // Assert
            Assert.Equivalent(expected, actual);
        }
        [Fact]
        public void EquipItem_CallOnValidTwoPiecesOfArmor_ShouldDisplayCorrectAttributes()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Armor testPlateBody = new Armor { Name = "Common plate body armor", RequiredLevel = 1, Slot = Slot.Body, Type = ArmorType.Plate, ArmorAttribute = new HeroAttribute(2, 0, 0) };
            Armor testPlateHelmet = new Armor { Name = "Common plate helmet", RequiredLevel = 1, Slot = Slot.Head, Type = ArmorType.Plate, ArmorAttribute = new HeroAttribute(1, 0, 0) };
            testWarrior.EquipArmor(testPlateBody);
            testWarrior.EquipArmor(testPlateHelmet);

            HeroAttribute expected = new HeroAttribute(5 + 3 , 2, 1);

            // Act
            HeroAttribute actual = testWarrior.GetTotalAttributes();

            // Assert
            Assert.Equivalent(expected, actual);
        }
        [Fact]
        public void EquipItem_CallOnValidArmor_ShouldDisplayCorrectAttributesAfterSwitchingArmorOnSameSlot()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Armor testPlateBody = new Armor { Name = "Common plate body armor", RequiredLevel = 1, Slot = Slot.Body, Type = ArmorType.Plate, ArmorAttribute = new HeroAttribute(2, 0, 0) };
            Armor testPlateBodySecond = new Armor { Name = "Superior plate body armor", RequiredLevel = 1, Slot = Slot.Body, Type = ArmorType.Plate, ArmorAttribute = new HeroAttribute(1, 0, 0) };
            testWarrior.EquipArmor(testPlateBody);
            testWarrior.EquipArmor(testPlateBodySecond);

            HeroAttribute expected = new HeroAttribute(5 + 1, 2, 1);

            // Act
            HeroAttribute actual = testWarrior.GetTotalAttributes();

            // Assert
            Assert.Equivalent(expected, actual);
        }
        [Fact]
        public void EquipItem_CallOnValidWeapon_ShouldDisplayCorrectDamageAfterSwitchingWeapon()
        {
            // Arrange
            Warrior testWarrior = new Warrior("Warrior");
            Weapon testAxeFirst = new Weapon { Name = "Test Axe", RequiredLevel = 1, Slot = Slot.Weapon, Type = WeaponType.Axe, WeaponDamage = 5 };
            Weapon testAxeSecond = new Weapon { Name = "Test Axe Superior", RequiredLevel = 1, Slot = Slot.Weapon, Type = WeaponType.Axe, WeaponDamage = 7 };

            testWarrior.EquipWeapon(testAxeFirst);
            testWarrior.EquipWeapon(testAxeSecond);

            double expected = 7 * (1 + (5  / 100.0));

            // Act
            double actual = testWarrior.Damage();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
