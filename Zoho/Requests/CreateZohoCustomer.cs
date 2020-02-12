using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {
    public class CreateZohoCustomer : ZohoSubscriptionsRequest<CreateZohoCustomer.Response> {

        public CreateZohoCustomer()
            : base($"customers", HttpMethod.Post) {

            CustomFields = new List<ZohoCustomField>();
        }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("custom_fields")]
        public List<ZohoCustomField> CustomFields { get; set; }
        
        
        public class Response : ZohoResponseMessage {
            
            [JsonProperty("customer")]
            public ZohoCustomer Customer { get; set; }
        }
    }
}