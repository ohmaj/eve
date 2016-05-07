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
        public List<Material> userBlueprint(string itemBlueprintIdString)
        {
            ParseBlueprints parseBlueprints = new ParseBlueprints();
            foreach (KeyValuePair<string,ItemBlueprint> blueprint in parseBlueprints.blueprintsDictionary())
            {
                if (itemBlueprintIdString == blueprint.Key)
                {
                    List<Material> userBlueprintMaterials = blueprint.Value.activities.manufacturing.materials;
                    return userBlueprintMaterials;
                }

            }
            Console.WriteLine("there was an error location your blueprint");
            List<Material> error = null;
            return error;
        }
    }
}