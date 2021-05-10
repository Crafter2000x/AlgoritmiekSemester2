using System;
using Circustrein.Classes;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Circustrein : Form
    {
        AnimalSorting AnimalSorting = new AnimalSorting();

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
            TrainList.Clear();
            AnimalSorting.OrderIntoCarts();
            DisplayTrain();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            AnimalSorting.Animals.Clear();
            AnimalSorting.Train.Clear();
            TrainList.Clear();
            ListViewAnimal.Clear();
        }

        private DietTypes GetDiet() 
        {
            if (DietMeat.Checked)
            {
                return DietTypes.Carnivore;
            }
            else
            {
                return DietTypes.Herbivore;
            }
        }

        private SizeTypes GetSize()
        {
            if (SizeSmall.Checked)
            {
                return SizeTypes.Small;
            }
            else if (SizeMedium.Checked)
            {
                return SizeTypes.Medium;
            }
            else
            {
                return SizeTypes.Large;   
            }
        }

        private void AddAnimalToList()
        {
            AnimalSorting.Animals.Add(new Animal
            {
                Name = AnimailAddName.Text,
                Diet = GetDiet(),
                Size = GetSize()

            });
            ListViewAnimal.Items.Add(AnimalSorting.Animals[AnimalSorting.Animals.Count - 1].Name);
        }

        private void DisplayTrain() 
        {
            int counter = 1;
            foreach (Wagon wagon in AnimalSorting.Train)
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
