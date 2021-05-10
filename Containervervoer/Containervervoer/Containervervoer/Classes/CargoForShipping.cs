using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Containervervoer.Classes
{
    public class CargoForShipping
    {
        public int ShipmentId { get; set; }
        public List<Container> Containers = new List<Container>();

        public void AddContainer(int type, int weight) 
        {
            Containers.Add(new Container { ContainerId = Containers.Count + 1, ContainerType = DecideContainerType(type), Weight = weight });
        }

        private Container.ContainerTypes DecideContainerType(int type) 
        {
            switch (type)
            {
                case 1:
                    return Container.ContainerTypes.Regular;
                case 2:
                    return Container.ContainerTypes.Cooling;
                case 3:
                    return Container.ContainerTypes.Valuable;
                case 4:
                    return Container.ContainerTypes.CoolingValuable;
                default:
                    return Container.ContainerTypes.Regular;
            }
        }

        public void SortShipment() 
        {
            //Custom sort with linq
            Containers.OrderBy(s =>
            s.ContainerType == Container.ContainerTypes.Cooling ? 1 :
            s.ContainerType == Container.ContainerTypes.CoolingValuable ? 2 :
            s.ContainerType == Container.ContainerTypes.Regular ? 3 :
            s.ContainerType == Container.ContainerTypes.Valuable ? 4 :
            5).ThenByDescending(s => s.Weight);
        }

        public int GiveCooled() 
        {
            int cooled = new int();

            foreach (var item in Containers)
            {
                if (item.ContainerType == Container.ContainerTypes.Cooling || item.ContainerType == Container.ContainerTypes.CoolingValuable)
                {
                    cooled++;
                }
            }
            return cooled;
        }

        public int GiveValuable() 
        {
            int valuable = new int();

            foreach (var item in Containers)
            {
                if (item.ContainerType == Container.ContainerTypes.Valuable || item.ContainerType == Container.ContainerTypes.CoolingValuable)
                {
                    valuable++;
                }
            }
            return valuable;
        }

        public int GiveRegular() 
        {
            int regular = new int();

            foreach (var item in Containers)
            {
                if (item.ContainerType == Container.ContainerTypes.Regular)
                {
                    regular++;
                }
            }
            return regular;
        }

        public int GiveTotal()
        {
            return Containers.Count;
        }

        public int GiveTotalWeight() 
        {
            int weight = new int();

            foreach (var item in Containers)
            {
                weight += item.Weight;
            }

            return weight;
        }


    }

}
