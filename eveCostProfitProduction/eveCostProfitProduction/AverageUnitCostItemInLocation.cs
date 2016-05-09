using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class AverageUnitCostItemInLocation
    {
        MarketOrders marketOrders;
        StarSystem system;
        public AverageUnitCostItemInLocation(StarSystem system,MarketOrders marketOrders)
        {
            this.marketOrders = marketOrders;
            this.system = system;

        }
        
        public double getOrderAverage()
        {
            LowestSellOrder lowest = new LowestSellOrder();
            return lowest.getLowestPrice(system, marketOrders);
        }

    }
}