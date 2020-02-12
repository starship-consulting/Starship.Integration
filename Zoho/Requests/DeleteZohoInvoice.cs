using System.Net.Http;

namespace Starship.Integration.Zoho.Requests {
    public class DeleteZohoInvoice : ZohoSubscriptionsRequest<ZohoResponseMessage> {

        public DeleteZohoInvoice(string invoiceId)
            : base($"invoices/{invoiceId}", HttpMethod.Delete) {
        }
    }
}