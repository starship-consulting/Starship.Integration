using System.Net.Http;

namespace Starship.Integration.Zoho.Requests {
    public class DeleteZohoPayment : ZohoSubscriptionsRequest<ZohoResponseMessage> {

        public DeleteZohoPayment(string paymentId)
            : base($"payments/{paymentId}", HttpMethod.Delete) {
        }
    }
}