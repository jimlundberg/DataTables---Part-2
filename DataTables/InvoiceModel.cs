using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTables
{
    public class InvoiceModel
    {
        [JsonProperty(PropertyName = "ID")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "InvoiceNumber")]
        public int InvoiceNumber { get; set; }

        [JsonProperty(PropertyName = "Amount")]
        public double Amount { get; set; }
        [JsonProperty(PropertyName = "CostCategory")]
        public string CostCategory { get; set; }
        [JsonProperty(PropertyName = "Period")]
        public string Period { get; set; }
        

    }


}
