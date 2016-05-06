using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class Galaxy
    {
        public string totalCount_str { get; set; }
        public List<SourceReferenceData> items { get; set; }
        public int pageCount { get; set; }
        public string pageCount_str { get; set; }
        public int totalCount { get; set; }
    }
}