using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace eveCostProfitProduction
{
    class TempItemList
    {
        public TempItemList()
        {

        }
        public void createTempItemList()
        {
            string ItemsJson = new WebClient().DownloadString("https://crest-tq.eveonline.com/types/");
            string systemsJson = new WebClient().DownloadString("https://crest-tq.eveonline.com/solarsystems/");
            File.WriteAllText(@"allItems.txt", ItemsJson);
            File.WriteAllText(@"allSystems.txt", systemsJson);
        }

    }
}
