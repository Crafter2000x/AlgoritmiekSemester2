using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein.Classes;

namespace Circustrein.UnitTests
{
    [TestClass]
    public class AnimalSortingTests
    {
        [TestMethod]
        public void AnimalSorting_Scenario_ExpectedBehavior()
        {
            // Arrange
            var animalsorting = new AnimalSorting();
            for (int i = 0; i < 6; i++)
            {
                // Add small meat animal
                animalsorting.Animals.Add(new Animal { Name = "MS", Diet = Animal.DietTypes.Carnivore, Size = Animal.SizeTypes.Small });
                animalsorting.Animals[animalsorting.Animals.Count - 1].SpaceAssign();
                // Add medium meat animal
                animalsorting.Animals.Add(new Animal { Name = "MM", Diet = Animal.DietTypes.Carnivore, Size = Animal.SizeTypes.Medium });
                animalsorting.Animals[animalsorting.Animals.Count - 1].SpaceAssign();
                // Add large meat animal
                animalsorting.Animals.Add(new Animal { Name = "ML", Diet = Animal.DietTypes.Carnivore, Size = Animal.SizeTypes.Large });
                animalsorting.Animals[animalsorting.Animals.Count - 1].SpaceAssign();

                // Add small plant animal
                animalsorting.Animals.Add(new Animal { Name = "PS", Diet = Animal.DietTypes.Herbivore, Size = Animal.SizeTypes.Small });
                animalsorting.Animals[animalsorting.Animals.Count - 1].SpaceAssign();
                // Add medium plant animal
                animalsorting.Animals.Add(new Animal { Name = "PM", Diet = Animal.DietTypes.Herbivore, Size = Animal.SizeTypes.Medium });
                animalsorting.Animals[animalsorting.Animals.Count - 1].SpaceAssign();
                // Add large plant animal
                animalsorting.Animals.Add(new Animal { Name = "PL", Diet = Animal.DietTypes.Herbivore, Size = Animal.SizeTypes.Large });
                animalsorting.Animals[animalsorting.Animals.Count - 1].SpaceAssign();
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
    }
}
