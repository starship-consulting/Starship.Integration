using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {

    public class GetZohoSubscriptionSubscriptionsByCustomer : ZohoSubscriptionsRequest<GetZohoSubscriptionSubscriptionsByCustomer.Response> {
        
        public GetZohoSubscriptionSubscriptionsByCustomer(string customerId) : base("subscriptions?customer_id=" + customerId, HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonProperty("subscriptions")]
            public List<ZohoSubscription> Subscriptions { get; set; }
        }
    }
}