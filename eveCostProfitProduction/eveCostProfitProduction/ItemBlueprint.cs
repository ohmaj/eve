﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class ItemBlueprint
    {
        public Activities activities { get; set; }
        public string blueprintTypeID { get; set; }
        public string maxProductionLimit { get; set; }
    }
}