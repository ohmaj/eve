using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class LowestSellOrder
    {
        public LowestSellOrder()
        {

        }
        public double getLowestPrice(StarSystem system, MarketOrders orders)
        {
            List<double> priceOfOrders = new List<double>();
            foreach (Order order in orders.items)
            {
                var getTheLocation = new DataParse<Location>(order.location.href);
                Location theLocation = getTheLocation.data;
                var getLocationSystem = new DataParse<StarSystem>(theLocation.solarSystem.href);
                StarSystem locationSystem = getLocationSystem.data;
                if (locationSystem.name == system.name)
                {
                    priceOfOrders.Add(order.price);
                }
            }


            double ordersPriceAverage = priceOfOrders.Min();
            return ordersPriceAverage;
            
        }
    }
}