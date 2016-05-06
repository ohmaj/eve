using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
     public class Region
    {
        public string description { get; set; }
        public MarketBuyOrders marketBuyOrders { get; set; }
        public List<Constellation> constellations { get; set; }
        public MarketOrders marketOrders { get; set; }
        public string id_str { get; set; }
        public MarketSellOrders marketSellOrders { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }
}