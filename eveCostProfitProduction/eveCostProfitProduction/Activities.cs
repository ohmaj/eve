using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class Activities
    {
        public Invention invention { get; set; }
        public Manufacturing manufacturing { get; set; }
        public Copying copying { get; set; }
        public ResearchMaterial research_material { get; set; }
        public ResearchTime research_time { get; set; }

    }
}