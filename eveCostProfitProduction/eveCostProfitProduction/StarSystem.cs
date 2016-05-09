using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class StarSystem
    {
        public SystemStats stats { get; set; }
        public List<Planet> planets { get; set; }
        public List<Stargate> stargates { get; set; }
        public string securityClass { get; set; }
        public string href { get; set; }
        public string id_str { get; set; }
        public double securityStatus { get; set; }
        public Position position { get; set; }
        public Sovereignty sovereignty { get; set; }
        public ConstellationsReference constellation { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }
}