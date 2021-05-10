using System;
using System.Collections.Generic;
using System.Text;

namespace Containervervoer.Classes
{
    public class Container
    {
        public enum ContainerTypes
        {
            Cooling,
            Regular,
            Valuable,
            CoolingValuable,
        }

        public int ContainerId { get; set; }
        public ContainerTypes ContainerType { get; set; }
        public int Weight { get; set; }

        private string ReturnTypeToText()
        {
            switch (ContainerType)
            {
                case ContainerTypes.Cooling:
                    return "Cooling";
                case ContainerTypes.Regular:
                    return "Regualr";
                case ContainerTypes.Valuable:
                    return "Valuable";
                case ContainerTypes.CoolingValuable:
                    return "Cooling and Valuable";
                default:
                    return null;
            }
        }

        public override string ToString()
        {
            return "Container ID: " + ContainerId + " Container type: " + ReturnTypeToText() + " Weight: " + Weight;
        }
    }
}
