using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace eveCostProfitProduction
{
    public class SelectItem
    {
        public SelectItem()
        {
        }

        
        public Item userItem(string userSelection)
        {
            string allItemsJson = File.ReadAllText(@"allItems.txt");
            AllStarSystems allItemParse = JsonConvert.DeserializeObject<AllStarSystems>(allItemsJson);
            List<SourceReferenceData> allItems = allItemParse.items;
            foreach (SourceReferenceData item in allItems)
            {
                if (userSelection == item.name)
                {
                    Item itemType = getItem(item);
                    return itemType;
                }
            }
            Console.WriteLine("Did Not Find that Item");
            return null;
        }
        public Item getItem(SourceReferenceData item)
        {
            string selectedItem = item.id_str;
            DataParse<Item> itemParse = new DataParse<Item>("https://crest-tq.eveonline.com/types/" + selectedItem + "/");
            Item userItem = itemParse.data;
            return userItem;
        }
        
            
    }
}