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

            //AverageUnitCostItemInLocation test = new AverageUnitCostItemInLocation();
            //string userSelection = getUserItemInput();
            //Item testItem = test.useritem(userSelection);
            //AverageUnitCostItemInLocation testBlueprint = new AverageUnitCostItemInLocation();
            //Item testItemBlueprint = testBlueprint.useritem(userSelection+" Blueprint");
            //StarSystem testSystem = test.userSystem();
            //Console.WriteLine(testItem.id_str);
            //Console.WriteLine(testItemBlueprint.id_str);
            //Console.WriteLine(testSystem.id_str);
            Blueprints test = new Blueprints();
            Console.WriteLine(test.CreateBlueprints());
            Console.ReadKey();

        }
        public string getUserItemInput()
        {
            Console.WriteLine("What are you producing: ");
            string itemInput = Console.ReadLine();
            return itemInput;
        }
    }
}