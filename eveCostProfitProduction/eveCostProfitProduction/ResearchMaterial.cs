using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class ResearchMaterial
    {
        public List<Dictionary<string, string>> materials { get; set; }
        public List<Dictionary<string, string>> skills { get; set; }
        public string time { get; set; }
     }
}