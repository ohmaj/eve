using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class Order
    {
        public string volume_str { get; set; }
        public bool buy { get; set; }
        public string issued { get; set; }
        public double price { get; set; }
        public int volumeEntered { get; set; }
        public int minVolume { get; set; }
        public int volume { get; set; }
        public string range { get; set; }
        public string href { get; set; }
        public string duration_str { get; set; }
        public SourceReferenceData location { get; set; }
        public int duration { get; set; }
        public string minVolume_str { get; set; }
        public string volumeEntered_str { get; set; }
        public SourceReferenceData type { get; set; }
        public object id { get; set; }
        public string id_str { get; set; }
    }
}