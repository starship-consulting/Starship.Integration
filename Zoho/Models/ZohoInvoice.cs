using System;
using Newtonsoft.Json;

namespace Starship.Integration.Zoho.Models {
    public class ZohoInvoice {

        [JsonProperty("invoice_id")]
        public string Id { get; set; }
    }
}