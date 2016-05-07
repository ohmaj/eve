using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace eveCostProfitProduction
{
    public class UserInterface
    {
        
        public void run()
        {
            string itemName = getUserItemInput();
            List<Material> materials = getUserBlueprintMaterials(itemName);
            foreach (Material material in materials)
            {
                Console.WriteLine(material.quantity +": "+material.typeID);
            }
            Console.ReadKey();

        }
        public List<Material> getUserBlueprintMaterials(string itemNameString)
        {
            SelectItem selectItem = new SelectItem();
            Item itemBlueprint = selectItem.userItem(itemNameString+" Blueprint");

            SelectBlueprint selectBlueprint = new SelectBlueprint();
            List<Material> blueprintMaterials = selectBlueprint.userBlueprint(itemBlueprint.id_str);
            return blueprintMaterials;
        }
        public string getUserItemInput()
        {
            Console.WriteLine("What are you producing: ");
            string userItemInput = Console.ReadLine();
            return userItemInput;
        }
        public string getUserStarSystemInput()
        {
            Console.WriteLine("Where are you buying and selling: ");
            string starSystemInput = Console.ReadLine();
            return starSystemInput;
        }
    }
}