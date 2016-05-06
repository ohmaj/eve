using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class Manufacturing
    {
        public List<Material> materials { get; set; }
        public List<Product> products { get; set; }
        public List<Skill> skills { get; set; }
        public string time { get; set; }
    }
}