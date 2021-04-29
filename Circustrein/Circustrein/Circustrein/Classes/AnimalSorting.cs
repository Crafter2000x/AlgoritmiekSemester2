using System.Collections.Generic;
using System.Linq;

namespace Circustrein.Classes
{
    public class AnimalSorting
    {
        public List<Animal> Animals = new List<Animal>();
        public List<Wagon> Train = new List<Wagon>();

        public void OrderIntoCarts()
        {
            Train.Clear();

            //Custom sort with linq
            IEnumerable<Animal> query = Animals.OrderBy(s => s.Diet).ThenBy(s =>
            s.Size == Animal.SizeTypes.Medium ? 1: 
            s.Size == Animal.SizeTypes.Large ? 2:
            s.Size == Animal.SizeTypes.Small ? 3:
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
                    // Does the animal fit?
                    if (wagon.DoesAnimalFit(animal))
                    {
                        // Is this animal a meat eater?
                        if (animal.Diet == Animal.DietTypes.Carnivore)
                        {
                            // Does this wagon have a animal equal or smaller?
                            if (!wagon.DoesCartHaveEqualOrSmaller(animal))
                            {
                                // Does this wagon have a animal bigger or equal that eats meat?
                                if (!wagon.DoesCartHaveEqualOrBiggerMeat(animal))
                                {
                                    // Add animal to selected wagon
                                    if (wagon.AddAnimalToCart(animal))
                                    {
                                        // Endpoint
                                        break;
                                    }
                                }

                                // Any wagons left?
                                if (!AnyWagonsLeft(wagon))
                                {
                                    // Add new wagon
                                    Train.Add(new Wagon());

                                    // Add animal to new wagon
                                    if (Train[Train.Count - 1].AddAnimalToCart(animal))
                                    {
                                        // Endpoint
                                        break;
                                    } 
                                }
                                else
                                {
                                    // Select next wagon
                                    continue;

                                }
                            }

                            // Any wagons left?
                            if (!AnyWagonsLeft(wagon))
                            {
                                // Add new wagon
                                Train.Add(new Wagon());

                                // Add animal to new wagon
                                if (Train[Train.Count - 1].AddAnimalToCart(animal))
                                {
                                    // Endpoint
                                    break;
                                }
                            }
                            else
                            {
                                // Select next wagon
                                continue;

                            }

                        }

                        // Does this wagon have a animal bigger or equal that eats meat?
                        if (!wagon.DoesCartHaveEqualOrBiggerMeat(animal))
                        {
                            // Add animal to selected wagon
                            if (wagon.AddAnimalToCart(animal))
                            {
                                // Endpoint
                                break;
                            }

                            
                        }

                    }

                    // Any wagons left?
                    if (!AnyWagonsLeft(wagon))
                    {
                        // Add new wagon
                        Train.Add(new Wagon());

                        // Add animal to new wagon
                        if (Train[Train.Count - 1].AddAnimalToCart(animal))
                        {
                            // Endpoint
                            break;
                        }
                    }
                    else
                    {
                        // Select next wagon
                        continue;

                    }
                }

                // Endpoint
                continue;

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
    }
}
