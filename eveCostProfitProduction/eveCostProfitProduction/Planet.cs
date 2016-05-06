using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class Planet
    {
        public string href { get; set; }
        public List<Moon> moons { get; set; }
    }
}