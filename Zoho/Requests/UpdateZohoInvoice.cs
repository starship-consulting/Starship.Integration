using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {
    public class UpdateZohoInvoice : ZohoSubscriptionsRequest<ZohoResponseMessage> {
        
        public UpdateZohoInvoice(string invoiceId) : base("invoices/" + invoiceId + "/lineitems", HttpMethod.Post) {
        }

        [JsonProperty("invoice_items")]
        public List<ZohoInvoiceItem> Items { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}