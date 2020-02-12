using System.Net.Http;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {
    public class CreateZohoCharge : ZohoSubscriptionsRequest<CreateZohoCharge.Response> {

        public CreateZohoCharge(string subscriptionId)
            : base($"subscriptions/{subscriptionId}/charge", HttpMethod.Post) {
        }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        
        public class Response : ZohoResponseMessage {

            [JsonProperty("subscription")]
            public ZohoSubscription Subscription { get; set; }

            [JsonProperty("invoice")]
            public ZohoInvoice Invoice { get; set; }
        }
    }
}