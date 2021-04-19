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
            Medium = 3,
            Large = 5
        }

        public string Name { get; set; }
        
        public DietTypes Diet { get; set; }
        
        public SizeTypes Size { get; set; }


    }
}
