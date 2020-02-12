using System;
using Newtonsoft.Json;

namespace Starship.Integration.Zoho.Models {

    public class ZohoPayment {

        [JsonProperty("payment_id")]
        public string Id { get; set; }
    }
}