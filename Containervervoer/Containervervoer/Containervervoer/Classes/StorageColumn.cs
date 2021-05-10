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

        //0 = left 1 = middle 2 = right
        public int ShipZone { get; set; }

        public List<Container> Containers = new List<Container>();
    }
}
