using System;
using System.Net.Http;

namespace Starship.Integration.Zoho.Requests {

    public class CancelZohoSubscription : ZohoSubscriptionsRequest<CancelZohoSubscription.Response> {

        public CancelZohoSubscription(string subscriptionId) : base("subscriptions/" + subscriptionId, HttpMethod.Post) {
        }

        public class Response : ZohoResponseMessage {
        }
    }
}