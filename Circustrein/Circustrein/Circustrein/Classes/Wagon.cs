using System.Collections.Generic;

namespace Circustrein.Classes
{
    public class Wagon
    {
        public int MaxSize { get; }
        public int CurrentSize { get; set; }
        private List<Animal> StoredAnimals = new List<Animal>();

        public bool DoesAnimalFit(Animal animal)
        {
            if ((int)animal.Size + CurrentSize > MaxSize)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public bool DoesCartHaveEqualOrSmaller(Animal animal) 
        {
            foreach (Animal Animal in StoredAnimals)
            {
                if ((int)Animal.Size <= (int)animal.Size)
                {
                    return true;
                }
            }

            return false;
        }

        public bool DoesCartHaveEqualOrBiggerMeat(Animal animal) 
        {
            foreach (Animal Animal in StoredAnimals)
            {
                if ((int)Animal.Size >= (int)animal.Size && Animal.Diet == DietTypes.Carnivore)
                {
                    return true;
                }
            }

            return false;
        }

        public bool AddAnimalToCart(Animal animal) 
        {
            if (DoesAnimalFit(animal) == true && animal.Diet == DietTypes.Carnivore)
            {
                if (DoesCartHaveEqualOrSmaller(animal) == false && DoesCartHaveEqualOrBiggerMeat(animal) == false)
                {
                    StoredAnimals.Add(animal);
                    CurrentSize += (int)animal.Size;
                    return true;
                }
            }

            if (DoesAnimalFit(animal) == true && animal.Diet == DietTypes.Herbivore)
            {
                if (DoesCartHaveEqualOrBiggerMeat(animal) == false)
                {
                    StoredAnimals.Add(animal);
                    CurrentSize += (int)animal.Size;
                    return true;
                }
            }
            return false;
        }

        public List<Animal> AnimalsInCart() 
        {
            return StoredAnimals;
        }

        public Wagon() 
        {
            MaxSize = 10;
            CurrentSize = 0;     
        }
    }
}
