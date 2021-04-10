using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein.Classes
{
    public class Animal
    {
        public enum DietTypes
        {
            Carnivore,
            Herbivore
        }
        public enum SizeTypes
        {
            Small = 1,
            Medium = 2,
            Large = 3
        }

        public string Name { get; set; }
        
        public DietTypes Diet { get; set; }
        
        public SizeTypes Size { get; set; }

        public int Space { get; set;}

        public void SpaceAssign() 
        {
            switch (Size)
            {
                case SizeTypes.Small:
                    Space = 1;
                    break;

                case SizeTypes.Medium:
                    Space = 3;
                    break;

                case SizeTypes.Large:
                    Space = 5;
                    break;
            }
        }

    }
}
