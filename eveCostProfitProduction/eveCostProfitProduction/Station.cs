using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class Station
    {
        public double reprocessingEfficiency { get; set; }
        public double officeRentalCost { get; set; }
        public double maxShipVolumeDockable { get; set; }
        public double reprocessingStationsTake { get; set; }
        public StarSystem system { get; set; }
        public List<Service> services { get; set; }
        public Race race { get; set; }
        public Owner owner { get; set; }
        public Position position { get; set; }
        public Type type { get; set; }
        public string name { get; set; }
    }
}