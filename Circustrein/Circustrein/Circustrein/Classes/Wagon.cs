using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein.Classes
{
    public class Wagon
    {
        public List<Animal> StoredAnimals = new List<Animal>();

        public int MaxSize { get;}
        public int CurrentSize { get; set; }

        public Wagon() 
        {
            MaxSize = 10;
            CurrentSize = 0;     
        }
    }
}
