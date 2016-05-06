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

        public string getUserStarSystemInput()
        {
            Console.WriteLine("Where are you buying and selling: ");
            string starSystemInput = Console.ReadLine();
            return starSystemInput;
        }
        public StarSystem userStarSystem()
        {
            DataParse<AllStarSystems> allSolarSystemsParse = new DataParse<AllStarSystems>("https://crest-tq.eveonline.com/solarsystems/");
            List<SourceReferenceData> allStarSystems = allSolarSystemsParse.data.items;
            string userSelection = getUserStarSystemInput();
            foreach (SourceReferenceData starSystem in allStarSystems)
            {
                if (userSelection == starSystem.name)
                {
                    StarSystem system = getStarSystem(starSystem);
                    return system;
                }
            }
            Console.WriteLine("Did Not Find That Star System");
            return userStarSystem();
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