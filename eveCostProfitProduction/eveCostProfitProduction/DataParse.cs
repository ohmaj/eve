using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;

namespace eveCostProfitProduction
{
    public class DataParse<T>
    {
        public string source;
        public T data;
    
        public DataParse(string source)
        {
            this.source = source;
            this.data = parse(this.source);

        }
        public T parse(string source)
        {
            string json = new WebClient().DownloadString(source);
            T dataParsed = JsonConvert.DeserializeObject<T>(json);
            return dataParsed;
        }
    }
}