using System;
using System.Collections.Generic;
using System.Text;

namespace Containervervoer.Classes
{
    public class StorageColumn
    {
        public int Column { get; set; }

        public int CurrentWeight { get; set; }

        public int CurrentContainer { get; set; }

        public int MaximumStack { get; set; }

        public List<Container> Containers = new List<Container>();
    }
}
