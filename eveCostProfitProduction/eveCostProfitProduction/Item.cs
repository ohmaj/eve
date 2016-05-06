using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class Item
    {
        public GraphicID graphicID { get; set; }
        public double capacity { get; set; }
        public string description { get; set; }
        public string portionSize_str { get; set; }
        public int iconID { get; set; }
        public int portionSize { get; set; }
        public string iconID_str { get; set; }
        public double volume { get; set; }
        public Dogma dogma { get; set; }
        public double radius { get; set; }
        public string id_str { get; set; }
        public bool published { get; set; }
        public double mass { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }
}
