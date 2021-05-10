using System;
using System.Collections.Generic;
using System.Text;

namespace Containervervoer.Classes
{
    public class StorageGrid
    {
        public int ContainerHeight { get; set; }

        public int ContainerWidth { get; set; }

        public int CurrentContainer { get; set; }

        public int CurrentCoolContainer { get; set; }

        public int CurrentValuableContainer { get; set; }

        public int MaximumWeight { get; set; }

        public int CurrentWeight { get; set; }

        public int LeftWeight { get; set; }

        public int RightWeight { get; set; }

        private List<int> RightColumns = new List<int>();

        private List<int> LeftColumns = new List<int>();

        private List<int> MiddleColumns = new List<int>();

        public List<StorageRow> StorageRows = new List<StorageRow>();

        public void GenerateStorageGrid()
        {
            CurrentContainer = 0;
            CurrentCoolContainer = 0;
            CurrentValuableContainer = 0;
            MaximumWeight = (ContainerHeight * ContainerWidth) * 150000;
            CurrentWeight = 0;
            LeftWeight = 0;
            RightWeight = 0;

            // if there is a even split in the middle
            if ((Convert.ToDecimal(ContainerWidth) / 2 % 1) == 0)
            {
                int Column = 1;
                for (int i = 0; i < ContainerWidth; i++)
                {
                    if (Column <= ContainerWidth/2)
                    {
                        LeftColumns.Add(Column);
                    }
                    else
                    {
                        RightColumns.Add(Column);
                    }
                    Column++;
                }
            }
            // if there is a uneven split in the middle
            else
            {
                int Column = 1;
                for (int i = 0; i < ContainerWidth; i++)
                {
                    if (Column < Math.Round(Convert.ToDecimal(ContainerWidth) /2))
                    {
                        LeftColumns.Add(Column);
                    }
                    else if (Column == Math.Round(Convert.ToDecimal(ContainerWidth) / 2))
                    {
                        MiddleColumns.Add(Column);
                    }
                    else
                    {
                        RightColumns.Add(Column);
                    }
                    Column++;
                }
            }

            for (int i = 0; i < ContainerHeight; i++)
            {
                StorageRow storagerow = new StorageRow { Row = i + 1};

                if (i == 0)
                {
                    storagerow.CoolingRow = true;
                }


                for (int ii = 0; ii < ContainerWidth; ii++)
                {
                    StorageColumn storagecolumn = new StorageColumn { Column = ii + 1, CurrentWeight = 0, CurrentContainer = 0 };
                    foreach (int item in LeftColumns)
                    {
                        if (item == storagecolumn.Column)
                        {
                            storagecolumn.ShipZone = 0;
                        }
                    }

                    foreach (int item in MiddleColumns)
                    {
                        if (item == storagecolumn.Column)
                        {
                            storagecolumn.ShipZone = 1;
                        }
                    }

                    foreach (int item in RightColumns)
                    {
                        if (item == storagecolumn.Column)
                        {
                            storagecolumn.ShipZone = 2;
                        }
                    }
                    storagerow.StorageColumns.Add(storagecolumn);
                }
                StorageRows.Add(storagerow);
            }

        }

        public int GiveBestShipLocation() 
        {

        }

        public StorageRow ReturnCoolingRow() 
        {
            foreach (StorageRow item in StorageRows)
            {
                if (item.CoolingRow == true)
                {
                    return item;
                }
            }

            return null;
        }

        public void AddContainerToColumn(Container container, StorageColumn storageColumn) 
        {
            switch (container.ContainerType)
            {
                case Container.ContainerTypes.Cooling:
                    CurrentCoolContainer += 1;
                    break;
                case Container.ContainerTypes.CoolingValuable:
                    break;
                case Container.ContainerTypes.Regular:
                    break;
                case Container.ContainerTypes.Valuable:
                    break;
                default:
                    break;
            }

            switch (storageColumn.ShipZone)
            {
                case 0:
                    LeftWeight += container.Weight;
                    break;
                case 2:
                    RightWeight += container.Weight;
                    break;
            }

            CurrentContainer += 1;
            CurrentWeight += container.Weight;
            storageColumn.CurrentWeight += container.Weight;
            storageColumn.Containers.Add(container);
        }
    }

}
