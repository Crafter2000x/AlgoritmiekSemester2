using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein.Classes;
using System.Collections.Generic;

namespace Circustrein.UnitTests
{
    [TestClass]
    public class AnimalSortingTests
    {
        [TestMethod]
        public void AnimalSorting_SixOfEach_19Wagons()
        {
            // Arrange
            var animalsorting = new AnimalSorting();
            for (int i = 0; i < 6; i++)
            {
                // Add small meat animal
                animalsorting.Animals.Add(new Animal { Name = "MS", Diet = Animal.DietTypes.Carnivore, Size = Animal.SizeTypes.Small });
                // Add medium meat animal
                animalsorting.Animals.Add(new Animal { Name = "MM", Diet = Animal.DietTypes.Carnivore, Size = Animal.SizeTypes.Medium });
                // Add large meat animal
                animalsorting.Animals.Add(new Animal { Name = "ML", Diet = Animal.DietTypes.Carnivore, Size = Animal.SizeTypes.Large });

                // Add small plant animal
                animalsorting.Animals.Add(new Animal { Name = "PS", Diet = Animal.DietTypes.Herbivore, Size = Animal.SizeTypes.Small });
                // Add medium plant animal
                animalsorting.Animals.Add(new Animal { Name = "PM", Diet = Animal.DietTypes.Herbivore, Size = Animal.SizeTypes.Medium });
                // Add large plant animal
                animalsorting.Animals.Add(new Animal { Name = "PL", Diet = Animal.DietTypes.Herbivore, Size = Animal.SizeTypes.Large });
            }
            // Act
            animalsorting.OrderIntoCarts();
            // Assert
            bool lenghtcheck = false;
            if (animalsorting.Train.Count == 19)
            {
                lenghtcheck = true;
            }
            Assert.IsTrue(lenghtcheck);
        }

        [TestMethod]
        public void AnyWagonsLeft_YesThereAre_ReturnTrue() 
        {
            // Arrange
            AnimalSorting animalSorting = new AnimalSorting();

            Wagon Wagon1 = new Wagon();
            Wagon Wagon2 = new Wagon();

            // Act
            animalSorting.Train.Add(Wagon1);
            animalSorting.Train.Add(Wagon2);

            var result = animalSorting.AnyWagonsLeft(Wagon1);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AnyWagonsLeft_NoThereArent_ReturnFalse()
        {
            // Arrange
            AnimalSorting animalSorting = new AnimalSorting();

            Wagon Wagon1 = new Wagon();
            Wagon Wagon2 = new Wagon();

            // Act
            animalSorting.Train.Add(Wagon1);
            animalSorting.Train.Add(Wagon2);

            var result = animalSorting.AnyWagonsLeft(Wagon2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AnimalSorting_config1_2Wagons()
        {
            // Arrange
            var animalsorting = new AnimalSorting();

            animalsorting.Animals.Add(new Animal { Name = "H1", Size = Animal.SizeTypes.Small, Diet = Animal.DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H1", Size = Animal.SizeTypes.Small, Diet = Animal.DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H1", Size = Animal.SizeTypes.Small, Diet = Animal.DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H1", Size = Animal.SizeTypes.Small, Diet = Animal.DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H1", Size = Animal.SizeTypes.Small, Diet = Animal.DietTypes.Herbivore });

            animalsorting.Animals.Add(new Animal { Name = "H3", Size = Animal.SizeTypes.Medium, Diet = Animal.DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H3", Size = Animal.SizeTypes.Medium, Diet = Animal.DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H3", Size = Animal.SizeTypes.Medium, Diet = Animal.DietTypes.Herbivore });

            animalsorting.Animals.Add(new Animal { Name = "H1", Size = Animal.SizeTypes.Large, Diet = Animal.DietTypes.Herbivore });

            // Act
            animalsorting.OrderIntoCarts();

            // Assert
            bool lenghtcheck = false;
            if (animalsorting.Train.Count == 2)
            {
                lenghtcheck = true;
            }
            Assert.IsTrue(lenghtcheck);
        }
    }
}
