﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Containervervoer.Classes
{
    public class StorageRow
    {
        public int Row { get; set; }

        public bool CoolingRow { get; set; }

        public List<StorageColumn> StorageColumns = new List<StorageColumn>();
    }
}
