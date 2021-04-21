using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein.Classes;

namespace Circustrein.UnitTests
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void DoesAnimalFit_CantFit_ReturnFalse() 
        {
            // Arrange
            Wagon wagon = new Wagon();

            Animal animal = new Animal {Name = "Monkey", Size = Animal.SizeTypes.Large, Diet = Animal.DietTypes.Carnivore };

            // Act
            wagon.CurrentSize = 10;

            var result = wagon.DoesAnimalFit(animal);

            // Assert

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void DoesAnimalFit_CanFit_ReturnTrue()
        {
            // Arrange
            Wagon wagon = new Wagon();

            Animal animal = new Animal { Name = "Monkey", Size = Animal.SizeTypes.Large, Diet = Animal.DietTypes.Carnivore };

            // Act

            var result = wagon.DoesAnimalFit(animal);

            // Assert

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DoesCartHaveEqualOrSmaller_HasEqualOrSmaller_ReturnTrue()
        {
            // Arrange
            Wagon wagon = new Wagon();

            Animal animal = new Animal { Name = "Monkey", Size = Animal.SizeTypes.Large, Diet = Animal.DietTypes.Carnivore };
            Animal animal1 = new Animal { Name = "Deer", Size = Animal.SizeTypes.Medium, Diet = Animal.DietTypes.Herbivore };


            // Act
            wagon.StoredAnimals.Add(animal1);
            wagon.CurrentSize += (int)animal1.Size;

            var result = wagon.DoesCartHaveEqualOrSmaller(animal);

            // Assert

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DoesCartHaveEqualOrSmaller_HasNotEqualOrSmaller_ReturnFalse()
        {
            // Arrange
            Wagon wagon = new Wagon();

            Animal animal = new Animal { Name = "Lizard", Size = Animal.SizeTypes.Medium, Diet = Animal.DietTypes.Carnivore };
            Animal animal1 = new Animal { Name = "Zebra", Size = Animal.SizeTypes.Large, Diet = Animal.DietTypes.Herbivore };


            // Act
            wagon.StoredAnimals.Add(animal1);
            wagon.CurrentSize += (int)animal1.Size;

            var result = wagon.DoesCartHaveEqualOrSmaller(animal);

            // Assert

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void DoesCartHaveEqualOrBiggerMeat_HasEqualOrBiggerMeat_ReturnTrue() 
        {
            // Arrange
            Wagon wagon = new Wagon();

            Animal animal = new Animal { Name = "Cow", Size = Animal.SizeTypes.Medium, Diet = Animal.DietTypes.Herbivore };
            Animal animal1 = new Animal { Name = "Dino", Size = Animal.SizeTypes.Large, Diet = Animal.DietTypes.Carnivore };


            // Act
            wagon.StoredAnimals.Add(animal1);
            wagon.CurrentSize += (int)animal1.Size;

            var result = wagon.DoesCartHaveEqualOrBiggerMeat(animal);

            // Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesCartHaveEqualOrBiggerMeat_HasNotEqualOrBiggerMeat_ReturnFalse()
        {
            // Arrange
            Wagon wagon = new Wagon();

            Animal animal = new Animal { Name = "Cow", Size = Animal.SizeTypes.Medium, Diet = Animal.DietTypes.Herbivore };
            Animal animal1 = new Animal { Name = "Dino", Size = Animal.SizeTypes.Large, Diet = Animal.DietTypes.Herbivore };


            // Act
            wagon.StoredAnimals.Add(animal1);
            wagon.CurrentSize += (int)animal1.Size;

            var result = wagon.DoesCartHaveEqualOrBiggerMeat(animal);

            // Assert

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimalToCart_CartCanAdd_ReturnTrue()
        {
            // Arrange
            Wagon wagon = new Wagon();

            Animal animal = new Animal { Name = "Cow", Size = Animal.SizeTypes.Medium, Diet = Animal.DietTypes.Herbivore };

            // Act

            var result = wagon.AddAnimalToCart(animal);

            // Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddAnimalToCart_CartCantAdd_ReturnFalse()
        {
            // Arrange
            Wagon wagon = new Wagon();

            Animal animal = new Animal { Name = "Cow", Size = Animal.SizeTypes.Medium, Diet = Animal.DietTypes.Herbivore };

            wagon.CurrentSize = 8;

            // Act

            var result = wagon.AddAnimalToCart(animal);

            // Assert

            Assert.IsFalse(result);
        }
    }
}
