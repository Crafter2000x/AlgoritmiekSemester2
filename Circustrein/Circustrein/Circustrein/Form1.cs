using System;
using System.Collections.Generic;
using Circustrein.Classes;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Circustrein : Form
    {
        public List<Animal> Animals = new List<Animal>();
        public List<Wagon> Train = new List<Wagon>();
        private bool DoubleBreak;

        public Circustrein()
        {
            InitializeComponent();
        }

        private void AnimalAddSubmit_Click(object sender, EventArgs e)
        {
            AddAnimalToList();
        }

        private void OrderAnimals_Click(object sender, EventArgs e)
        {
            OrderIntoCarts();
        }

        private void AddAnimalToList() 
        {
            Animals.Add(new Animal
            {
                Name = AnimailAddName.Text,
                Diet = GetDiet(),
                Size = GetSize()
               
            });
            Animals[Animals.Count - 1].SpaceAssign();
            ListViewAnimal.Items.Add(Animals[Animals.Count -1].Name);
        }

        private Animal.DietTypes GetDiet() 
        {
            if (DietMeat.Checked)
            {
                return Animal.DietTypes.Carnivore;
            }
            else
            {
                return Animal.DietTypes.Herbivore;
            }
        }

        private Animal.SizeTypes GetSize()
        {
            if (SizeSmall.Checked)
            {
                return Animal.SizeTypes.Small;
            }
            else if (SizeMedium.Checked)
            {
                return Animal.SizeTypes.Medium;
            }
            else
            {
                return Animal.SizeTypes.Large;   
            }
        }

        private void OrderIntoCarts() 
        {
            Train.Clear();
            TrainList.Clear();
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
                        if (Train[Train.Count -1] == wagon)
                        {
                            // Add a new wagon
                            Train.Add(new Wagon());
                            // Add animal to new wagon
                            Train[Train.Count -1].StoredAnimals.Add(animal);
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

            DisplayTrain();
        }

        private void DisplayTrain() 
        {
            int counter = 1;
            foreach (Wagon wagon in Train)
            {
                TrainList.Text += "Wagon: "+ counter + " Current Size:" + wagon.CurrentSize + " Max Size: " + wagon.MaxSize;
                TrainList.Text += Environment.NewLine;
                foreach (Animal animal in wagon.StoredAnimals)
                {
                    TrainList.Text += "Name: " + animal.Name + " Size: " + animal.Size.ToString() + " Diet: " + animal.Diet.ToString();
                    TrainList.Text += Environment.NewLine;
                }

                TrainList.Text += Environment.NewLine;
                counter++;
            }
        }
    }
}
