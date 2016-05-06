using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class AverageUnitCostItemInLocation
    {
         public AverageUnitCostItemInLocation()
        {

        }
        public Item useritem(string userSelection)
        {
            SelectItem userItem = new SelectItem();
            Item item = userItem.userItem(userSelection);
            return item;
        }
        public StarSystem userSystem()
        {
            SelectStarSystem userSystem = new SelectStarSystem();
            StarSystem starSystem = userSystem.userStarSystem();
            return starSystem;
        }

    }
}