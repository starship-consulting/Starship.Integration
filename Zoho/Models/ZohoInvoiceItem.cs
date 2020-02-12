using System;
using Newtonsoft.Json;

namespace Starship.Integration.Zoho.Models {
    public class ZohoInvoiceItem {

        [JsonProperty("code")]
        public string Code { get; set; }

        //[JsonProperty("product_id")]
        //public string ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public float Price { get; set; }
    }
}