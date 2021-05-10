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

        public void LoadShipment(CargoForShipping CargoToShip) 
        {
            List<Container> UnableToStore = new List<Container>();
            bool AddedSuccessfully = new bool();

            CargoToShip.SortShipment();

            foreach (Container container in CargoToShip.Containers) 
            {
                if (container.Weight + Storagegrid.CurrentWeight > Storagegrid.MaximumWeight)
                {
                    // Maximum capacity reached
                    UnableToStore.Add(container);
                    continue;
                }

                switch (container.ContainerType)
                {
                    case Container.ContainerTypes.Cooling:

                        foreach (StorageColumn column in Storagegrid.ReturnCoolingRow().StorageColumns)
                        {
                           
                        }
                        continue;

                    case Container.ContainerTypes.CoolingValuable:
                        break;
                    case Container.ContainerTypes.Regular:
                        break;
                    case Container.ContainerTypes.Valuable:
                        break;
                    default:
                        break;
                }



            }
        
        
        
        }

    }
}
