using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eveCostProfitProduction
{
    class SelectMarketBuyOrders
    {
        public SelectMarketBuyOrders()
        {

        }
        public MarketOrders getMarketOrders(string region, string item)
        {                                                     
            var orders = new DataParse<MarketOrders>("https://crest-tq.eveonline.com/market/"+region+"/orders/buy/?type=https://crest-tq.eveonline.com/types/" + item+ "/");
            MarketOrders marketOrders = orders.data;
            return marketOrders;
        }
    }
}
