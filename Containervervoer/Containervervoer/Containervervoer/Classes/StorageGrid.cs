using System;
using System.Collections.Generic;
using System.Text;

namespace Containervervoer.Classes
{
    public class StorageGrid
    {
        public int ContainerHeight { get; set; }

        public int ContainerWidth { get; set; }

        public int ContainerStack { get; set; }

        public int MaximumContainer { get; set; }

        public int CurrentContainer { get; set; }

        public int MaximumCoolContainer { get; set; }

        public int CurrentCoolContainer { get; set; }

        public int CurrentValuableContainer { get; set; }

        public int MaximumWeight { get; set; }

        public int CurrentWeight { get; set; }

        public int FrontWeight { get; set; }

        public int BackWeight { get; set; }

        public List<StorageRow> StorageRows = new List<StorageRow>();

        public void GenerateStorageGrid()
        {
            MaximumContainer = (ContainerHeight * ContainerWidth) * ContainerStack;
            CurrentContainer = 0;
            MaximumCoolContainer = ContainerWidth;
            CurrentCoolContainer = 0;
            CurrentValuableContainer = 0;
            MaximumWeight = MaximumContainer * 30000;
            CurrentWeight = 0;
            FrontWeight = 0;
            BackWeight = 0;

            for (int i = 0; i < ContainerHeight; i++)
            {
                StorageRow storagerow = new StorageRow { Row = i + 1, CurrentWeight = 0, CurrentContainer = 0, };

                if (i == 0)
                {
                    storagerow.CoolingRow = true;
                }


                for (int ii = 0; ii < ContainerWidth; ii++)
                {
                    storagerow.StorageColumns.Add(new StorageColumn { Column = ii + 1, CurrentWeight = 0, CurrentContainer = 0, MaximumStack = ContainerStack });
                }

                StorageRows.Add(storagerow);
            }

        }
    }

}
