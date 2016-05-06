using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class Constellation
    {
        public Position position { get; set; }
        public Region region { get; set; }
        public List<StarSystem> systems { get; set; }
        public string name { get; set; }
    }
}