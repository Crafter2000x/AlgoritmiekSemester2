using System;
using System.Collections.Generic;
using System.Text;

namespace Containervervoer.Classes
{
    public class CargoShip
    {
        public string ShipName { get; set; }

        public bool IsShipValid { get; }

        public StorageGrid Storagegrid = new StorageGrid();

    }
}
