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
            TempItemList tempItemList = new TempItemList();
            tempItemList.createTempItemList();
            Item item = getUserItemInput();
            StarSystem system = getUserStarSystemInput();
            double itemPrice = getHighestBuyPrice(system, item.id_str);
            SelectItemMaterials itemMaterials = new SelectItemMaterials();
            List<Material> materials = itemMaterials.getUserBlueprintMaterials(item.name);
            double materialsPrice = getMaterialsPrice(materials,system);
            Console.WriteLine(item.name+" Sells for: " + itemPrice.ToString());
            Console.WriteLine("The materials for your product sell for: "+ materialsPrice.ToString());
            Console.ReadKey();
        }

        public double getHighestBuyPrice(StarSystem system, string item)
        {
            SelectMarketBuyOrders getMarketOrders = new SelectMarketBuyOrders();
            var getConstellation = new DataParse<Constellation>(system.constellation.href);
            Constellation constellation = getConstellation.data;
            var getRegion = new DataParse<Region>(constellation.region.href);
            Region region = getRegion.data;
            MarketOrders marketOrders = getMarketOrders.getMarketOrders(region.id_str, item);
            LowestSellOrder lowestPrice = new LowestSellOrder();
            double price = lowestPrice.getLowestPrice (system, marketOrders);
            return price;
            

        }
        public double getlowestSellPrice(StarSystem system, string item)
        {
            SelectMarketSellOrders getMarketOrders = new SelectMarketSellOrders();
            var getConstellation = new DataParse<Constellation>(system.constellation.href);
            Constellation constellation = getConstellation.data;
            var getRegion = new DataParse<Region>(constellation.region.href);
            Region region = getRegion.data;
            MarketOrders marketOrders = getMarketOrders.getMarketOrders(region.id_str, item);
            LowestSellOrder lowestPrice = new LowestSellOrder();
            double price = lowestPrice.getLowestPrice(system, marketOrders);
            return price;


        }
        public double getMaterialsPrice(List<Material>materials,StarSystem system)
        {
            List<double> materialsPrice = new List<double>();
            foreach (Material material in materials)
            {
                double materialPricePerUnit = getlowestSellPrice(system, material.typeID);
                double materialQuantity = Convert.ToDouble(material.quantity);
                double materialNeededPrice = materialPricePerUnit*materialQuantity;
                materialsPrice.Add(materialNeededPrice);
            }
            double totalMaterials = materialsPrice.Sum();
            return totalMaterials;

        }
        public Item getUserItemInput()
        {
            Console.WriteLine("What are you producing: ");
            string userItemInput = Console.ReadLine();
            SelectItem selectItem = new SelectItem();
            Item item = selectItem.userItem(userItemInput);
            return item;

        }
        public StarSystem getUserStarSystemInput()
        {
            Console.WriteLine("Where are you buying and selling: ");
            string starSystemInput = Console.ReadLine();
            SelectStarSystem selectSystem = new SelectStarSystem();
            StarSystem system = selectSystem.userStarSystem(starSystemInput);
            return system;
        }
    }
}