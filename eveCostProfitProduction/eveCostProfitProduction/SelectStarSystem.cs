using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace eveCostProfitProduction
{
    public class SelectStarSystem
    {
        public SelectStarSystem()
        {
        }
        public StarSystem userStarSystem(string userStarSystemInput)
        {
            string allsystemsJson = File.ReadAllText(@"allSystems.txt");
            AllSystems allSolarSystemsParse = JsonConvert.DeserializeObject<AllSystems>(allsystemsJson);
            List<SourceReferenceData> allStarSystems = allSolarSystemsParse.items;
            string userSelection = userStarSystemInput;
            foreach (SourceReferenceData starSystem in allStarSystems)
            {
                if (userSelection == starSystem.name)
                {
                    StarSystem system = getStarSystem(starSystem);
                    return system;
                }
            }
            Console.WriteLine("Did Not Find That Star System");
            return null;
        }
        public StarSystem getStarSystem(SourceReferenceData starSystem)
        {
            string selectedSystem = starSystem.id_str;
            DataParse<StarSystem> starSystemParse = new DataParse<StarSystem>("https://crest-tq.eveonline.com/solarsystems/" + selectedSystem + "/");
            StarSystem system = starSystemParse.data;
            return system;
        }
    }
}