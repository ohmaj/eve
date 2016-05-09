using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class Location
    {
        public string href { get; set; }
        public SourceReferenceData station { get; set; }
        public SourceReferenceData region { get; set; }
        public SourceReferenceData solarSystem { get; set; }
        public SourceReferenceData constellation { get; set; }
    }
}