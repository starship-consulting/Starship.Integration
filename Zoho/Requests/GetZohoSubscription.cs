using System;
using System.Net.Http;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {

    public class GetZohoSubscription : ZohoSubscriptionsRequest<GetZohoSubscription.Response> {
        
        public GetZohoSubscription(string subscriptionId) : base("subscription/" + subscriptionId, HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonProperty("subscription")]
            public ZohoSubscription Subscription { get; set; }
        }
    }
}