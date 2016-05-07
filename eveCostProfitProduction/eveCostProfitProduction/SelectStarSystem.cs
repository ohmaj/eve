using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eveCostProfitProduction
{
    public class SelectStarSystem
    {
        public SelectStarSystem()
        {
        }
        public StarSystem userStarSystem(string userStarSystemInput)
        {
            DataParse<AllStarSystems> allSolarSystemsParse = new DataParse<AllStarSystems>("https://crest-tq.eveonline.com/solarsystems/");
            List<SourceReferenceData> allStarSystems = allSolarSystemsParse.data.items;
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
            return userStarSystem(userStarSystemInput);
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