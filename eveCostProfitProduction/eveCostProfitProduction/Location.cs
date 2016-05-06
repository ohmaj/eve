using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class Location
    {
        public string href { get; set; }
        public Station station { get; set; }
        public Region region { get; set; }
        public StarSystem solarSystem { get; set; }
        public Constellation constellation { get; set; }
    }
}