using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class SelectItem
    {
        public SelectItem()
        {
        }

        
        public Item userItem(string userSelection)
        {
            DataParse<AllItems> allItemParse = new DataParse<AllItems>("https://crest-tq.eveonline.com/types/");
            List<SourceReferenceData> allItems = allItemParse.data.items;
            foreach (SourceReferenceData item in allItems)
            {
                if (userSelection == item.name)
                {
                    Item itemType = getItem(item);
                    return itemType;
                }
            }
            Console.WriteLine("Did Not Find that Item");
            return userItem(userSelection);
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