using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eveCostProfitProduction
{
    class SelectItemMaterials
    {
        public SelectItemMaterials()
        {

        }
        public List<Material> getUserBlueprintMaterials(string itemNameString)
        {
            SelectItem selectItem = new SelectItem();
            Item itemBlueprint = selectItem.userItem(itemNameString + " Blueprint");
            SelectBlueprint selectBlueprint = new SelectBlueprint();
            ItemBlueprint blueprint = selectBlueprint.userBlueprint(itemBlueprint.id_str);
            List<Material> blueprintMaterials = blueprint.activities.manufacturing.materials;
            return blueprintMaterials;
        }
    }
}
