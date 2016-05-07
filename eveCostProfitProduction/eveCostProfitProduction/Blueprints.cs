using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;


namespace eveCostProfitProduction
{
    public class ParseBlueprints
    {
        public ParseBlueprints()
        {

        }
        public Dictionary<string, ItemBlueprint> blueprintsDictionary()
        {
            
            var deserializer = new Deserializer(null, null ,true);
            Dictionary<string,ItemBlueprint> result = deserializer.Deserialize<Dictionary<string,ItemBlueprint>>(new StreamReader(@"blueprints.yaml"));
            return result;
        }
    }
}