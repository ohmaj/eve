﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class MarketOrders
    {
        public string totalCount_str { get; set; }
        public List<Order> items { get; set; }
        public int pageCount { get; set; }
        public string pageCount_str { get; set; }
        public int totalCount { get; set; }
    }

    public class MarketBuyOrders
    {
        public string totalCount_str { get; set; }
        public List<Order> items { get; set; }
        public int pageCount { get; set; }
        public string pageCount_str { get; set; }
        public int totalCount { get; set; }
    }

    public class MarketSellOrders
    {
        public string totalCount_str { get; set; }
        public List<Order> items { get; set; }
        public int pageCount { get; set; }
        public string pageCount_str { get; set; }
        public int totalCount { get; set; }
    }
}