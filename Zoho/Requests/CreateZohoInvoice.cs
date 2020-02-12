using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {
    public class CreateZohoInvoice : ZohoSubscriptionsRequest<CreateZohoInvoice.Response> {
        
        public CreateZohoInvoice() : base("invoices", HttpMethod.Post) {
        }
        
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("invoice_date")]
        public string Date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("invoice_items")]
        public List<ZohoInvoiceItem> Items { get; set; }
        
        public class Response : ZohoResponseMessage {

            [JsonProperty("invoice")]
            public ZohoInvoice Invoice { get; set; }
        }
    }
}