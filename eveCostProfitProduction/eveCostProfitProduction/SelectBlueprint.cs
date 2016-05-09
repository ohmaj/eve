using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class SelectBlueprint
    {
        public SelectBlueprint()
        {
        }
        public ItemBlueprint userBlueprint(string itemBlueprintIdString)
        {
            Blueprints parseBlueprints = new Blueprints();
            foreach (KeyValuePair<string,ItemBlueprint> blueprint in parseBlueprints.blueprintsDictionary())
            {
                if (itemBlueprintIdString == blueprint.Key)
                {
                    ItemBlueprint userBlueprint = blueprint.Value;
                    return userBlueprint;
                }

            }
            Console.WriteLine("there was an error locating your blueprint");
            return null;
        }
    }
}