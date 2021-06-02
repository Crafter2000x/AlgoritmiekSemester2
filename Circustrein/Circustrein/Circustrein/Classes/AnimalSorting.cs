using System.Collections.Generic;
using System.Linq;

namespace Circustrein.Classes
{
    public class AnimalSorting
    {
        private List<Animal> Animals = new List<Animal>();
        private List<Wagon> Train = new List<Wagon>();

        public void OrderIntoCarts()
        {
            Train.Clear();

            //Custom sort with linq
            IEnumerable<Animal> query = Animals.OrderBy(s => s.Diet).ThenBy(s =>
            s.Size == SizeTypes.Medium ? 1: 
            s.Size == SizeTypes.Large ? 2:
            s.Size == SizeTypes.Small ? 3:
            4);


            foreach (Animal animal in query)
            {
                // Are there any wagons?
                if (Train.Count == 0)
                {
                    // Add a new wagon
                    Train.Add(new Wagon());

                    // Add animal to new wagon
                    if (Train[0].AddAnimalToCart(animal))
                    {
                        // Endpoint
                        continue;
                    }
                }

                foreach (Wagon wagon in Train)
                {
                    if (wagon.DoesAnimalFit(animal) == true && animal.Diet == DietTypes.Carnivore)
                    {
                        if (wagon.DoesCartHaveEqualOrSmaller(animal) == false && wagon.DoesCartHaveEqualOrBiggerMeat(animal) == false)
                        {
                            wagon.AddAnimalToCart(animal);
                            break;
                        }

                    }

                    if (wagon.DoesAnimalFit(animal) == true && animal.Diet == DietTypes.Herbivore)
                    {
                        if (wagon.DoesCartHaveEqualOrBiggerMeat(animal) == false)
                        {
                            wagon.AddAnimalToCart(animal);
                            break;
                        }
                    }

                    if (AnyWagonsLeft(wagon) == false)
                    {
                        Train.Add(new Wagon());
                        if (Train[Train.Count - 1].AddAnimalToCart(animal)){break;}
                    }
                }
            }
        }

        public bool AnyWagonsLeft(Wagon wagon)
        {
            if (Train[Train.Count - 1] == wagon)
            {
                return false;
            }

            return true;

        }

        public void ClearList() 
        {
            Animals.Clear();
            Train.Clear();
        }

        public void AddWagon(Wagon wagon) 
        {
            Train.Add(wagon);
        }

        public void AddToAnimals(Animal animal) 
        {
            Animals.Add(animal);
        }

        public List<Wagon> GiveTrainList() 
        {
            return Train;
        }
    }
}
