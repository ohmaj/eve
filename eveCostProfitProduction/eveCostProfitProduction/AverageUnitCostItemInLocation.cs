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
        public Item useritem(string userItemInput)
        {
            SelectItem userItem = new SelectItem();
            Item item = userItem.userItem(userItemInput);
            return item;
        }
        public StarSystem userSystem(string userStarSystemInput)
        {
            SelectStarSystem userSystem = new SelectStarSystem();
            StarSystem starSystem = userSystem.userStarSystem(userStarSystemInput);
            return starSystem;
        }

    }
}