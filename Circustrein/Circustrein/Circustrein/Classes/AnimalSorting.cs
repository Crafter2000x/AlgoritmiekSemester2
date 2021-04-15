using System.Collections.Generic;

namespace Circustrein.Classes
{
    public class AnimalSorting
    {
        public List<Animal> Animals = new List<Animal>();
        public List<Wagon> Train = new List<Wagon>();
        private bool DoubleBreak;


        public void OrderIntoCarts()
        {
            Train.Clear();
            Animals.Sort((x, y) => x.Space.CompareTo(y.Space));

            foreach (Animal animal in Animals)
            {
                // Are there any wagons?
                if (Train.Count == 0)
                {
                    // Add a new wagon
                    Train.Add(new Wagon());
                    // Add animal to new wagon
                    Train[0].StoredAnimals.Add(animal);
                    Train[0].CurrentSize += animal.Space;
                    continue;
                }

                foreach (Wagon wagon in Train)
                {
                    // Does the animal fit?
                    if (wagon.CurrentSize + animal.Space > wagon.MaxSize)
                    {
                        // Any wagons left?
                        if (Train[Train.Count - 1] == wagon)
                        {
                            // Add a new wagon
                            Train.Add(new Wagon());
                            // Add animal to new wagon
                            Train[Train.Count - 1].StoredAnimals.Add(animal);
                            Train[Train.Count - 1].CurrentSize += animal.Space;
                            break;
                        }
                        else
                        {
                            //Select next wagon
                            continue;
                        }
                    }

                    // Is this animal a meat eater?
                    if (animal.Diet == Animal.DietTypes.Carnivore)
                    {
                        foreach (Animal Storedanimal in wagon.StoredAnimals)
                        {
                            // Does the wagon have a animal equal or smaller?
                            if ((int)Storedanimal.Size <= (int)animal.Size)
                            {
                                // Any wagons left?
                                if (Train[Train.Count - 1] == wagon)
                                {
                                    // Add a new wagon
                                    Train.Add(new Wagon());
                                    // Add animal to new wagon
                                    Train[Train.Count - 1].StoredAnimals.Add(animal);
                                    Train[Train.Count - 1].CurrentSize += animal.Space;

                                    DoubleBreak = true;
                                    break;
                                }
                                else
                                {
                                    //Select next wagon
                                    break;
                                }
                            }

                            // Does the cart have a animal equal or bigger that eats meat?
                            if ((int)Storedanimal.Size >= (int)animal.Size && Storedanimal.Diet == Animal.DietTypes.Carnivore)
                            {
                                // Any wagons left?
                                if (Train[Train.Count - 1] == wagon)
                                {
                                    // Add a new wagon
                                    Train.Add(new Wagon());
                                    // Add animal to new wagon
                                    Train[Train.Count - 1].StoredAnimals.Add(animal);
                                    Train[Train.Count - 1].CurrentSize += animal.Space;

                                    DoubleBreak = true;
                                    break;
                                }
                                else
                                {
                                    //Select next wagon
                                    break;
                                }
                            }

                            // Add animal to wagon
                            wagon.StoredAnimals.Add(animal);
                            wagon.CurrentSize += animal.Space;
                            DoubleBreak = true;
                            break;
                        }

                        if (DoubleBreak == true)
                        {
                            DoubleBreak = false;
                            break;
                        }
                    }
                    else if (animal.Diet != Animal.DietTypes.Carnivore)
                    {
                        foreach (Animal Storedanimal in wagon.StoredAnimals)
                        {
                            // Does the cart have a animal equal or bigger that eats meat?
                            if ((int)Storedanimal.Size >= (int)animal.Size && Storedanimal.Diet == Animal.DietTypes.Carnivore)
                            {
                                // Any wagons left?
                                if (Train[Train.Count - 1] == wagon)
                                {
                                    // Add a new wagon
                                    Train.Add(new Wagon());
                                    // Add animal to new wagon
                                    Train[Train.Count - 1].StoredAnimals.Add(animal);
                                    Train[Train.Count - 1].CurrentSize += animal.Space;

                                    DoubleBreak = true;
                                    break;
                                }
                                else
                                {
                                    //Select next wagon
                                    break;
                                }
                            }

                            // Add animal to wagon
                            wagon.StoredAnimals.Add(animal);
                            wagon.CurrentSize += animal.Space;

                            DoubleBreak = true;
                            break;
                        }

                        if (DoubleBreak == true)
                        {
                            DoubleBreak = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}
