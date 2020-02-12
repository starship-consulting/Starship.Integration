using System.Net.Http;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {
    public class CreateZohoSubscription : ZohoSubscriptionsRequest<CreateZohoSubscription.Response> {

        public CreateZohoSubscription()
            : base("subscriptions", HttpMethod.Post) {
        }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("starts_at")]
        public string StartDate { get; set; }

        [JsonProperty("plan")]
        public ZohoPlan Plan { get; set; }

        [JsonProperty("create_backdated_invoice")]
        public bool IsBackdated { get; set; }

        [JsonProperty("auto_collect")]
        public bool AutoCollect { get; set; }

        [JsonProperty("end_of_term")]
        public bool EndOfTerm { get; set; }

        [JsonProperty("payment_gateway")]
        public string PaymentGateway { get; set; }
        
        public class Response : ZohoResponseMessage {

            [JsonProperty("subscription")]
            public ZohoSubscription Subscription { get; set; }
        }
    }
}