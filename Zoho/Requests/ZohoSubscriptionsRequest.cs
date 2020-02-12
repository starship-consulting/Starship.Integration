using System.Net.Http;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {
    public abstract class ZohoSubscriptionsRequest<R> : ZohoRequest<R> where R : ZohoResponseMessage {

        protected ZohoSubscriptionsRequest(string resourcePath, HttpMethod method)
            : base("https://subscriptions.zoho.com/api/v1/" + resourcePath, method) {
        }
    }
}