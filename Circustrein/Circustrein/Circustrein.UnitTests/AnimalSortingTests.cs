using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein.Classes;

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
                animalsorting.Animals.Add(new Animal { Name = "MS", Diet = DietTypes.Carnivore, Size = SizeTypes.Small });
                // Add medium meat animal
                animalsorting.Animals.Add(new Animal { Name = "MM", Diet = DietTypes.Carnivore, Size = SizeTypes.Medium });
                // Add large meat animal
                animalsorting.Animals.Add(new Animal { Name = "ML", Diet = DietTypes.Carnivore, Size = SizeTypes.Large });

                // Add small plant animal
                animalsorting.Animals.Add(new Animal { Name = "PS", Diet = DietTypes.Herbivore, Size = SizeTypes.Small });
                // Add medium plant animal
                animalsorting.Animals.Add(new Animal { Name = "PM", Diet = DietTypes.Herbivore, Size = SizeTypes.Medium });
                // Add large plant animal
                animalsorting.Animals.Add(new Animal { Name = "PL", Diet = DietTypes.Herbivore, Size = SizeTypes.Large });
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

            animalsorting.Animals.Add(new Animal { Name = "H1", Size = SizeTypes.Small, Diet = DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H1", Size = SizeTypes.Small, Diet = DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H1", Size = SizeTypes.Small, Diet = DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H1", Size = SizeTypes.Small, Diet = DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H1", Size = SizeTypes.Small, Diet = DietTypes.Herbivore });

            animalsorting.Animals.Add(new Animal { Name = "H3", Size = SizeTypes.Medium, Diet = DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H3", Size = SizeTypes.Medium, Diet = DietTypes.Herbivore });
            animalsorting.Animals.Add(new Animal { Name = "H3", Size = SizeTypes.Medium, Diet = DietTypes.Herbivore });

            animalsorting.Animals.Add(new Animal { Name = "H1", Size = SizeTypes.Large, Diet = DietTypes.Herbivore });

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
