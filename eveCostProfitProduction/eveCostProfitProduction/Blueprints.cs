using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using YamlDotNet.Core.Events;
using YamlDotNet.Core.Tokens;
using YamlDotNet.Core;
using YamlDotNet;
using System.IO;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using Newtonsoft.Json;

namespace eveCostProfitProduction
{
    public class Blueprints
    {
        public Blueprints()
        {

        }
        public string CreateBlueprints()
        {
            
            var deserializer = new Deserializer();
            var result = deserializer.Deserialize(new StreamReader(@"blueprints.yaml"));
            return result.ToString();
        }
    }
}