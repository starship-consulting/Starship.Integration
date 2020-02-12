using System;
using Newtonsoft.Json;

namespace Starship.Integration.Zoho.Models {

    public class ZohoCustomer {

        [JsonProperty("customer_id")]
        public string Id { get; set; }
        
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}