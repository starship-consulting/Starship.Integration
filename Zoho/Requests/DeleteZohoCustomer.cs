using System.Net.Http;

namespace Starship.Integration.Zoho.Requests {
    public class DeleteZohoCustomer : ZohoSubscriptionsRequest<ZohoResponseMessage> {

        public DeleteZohoCustomer(string customerId)
            : base($"customers/{customerId}", HttpMethod.Delete) {
        }
    }
}