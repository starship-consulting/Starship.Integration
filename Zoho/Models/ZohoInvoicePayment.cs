using System;
using Newtonsoft.Json;

namespace Starship.Integration.Zoho.Models {

    public class ZohoInvoicePayment {

        public ZohoInvoicePayment() {
        }

        public ZohoInvoicePayment(string invoiceId, float amount) {
            InvoiceId = invoiceId;
            Amount = amount;
        }

        [JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }

        [JsonProperty("amount_applied")]
        public float Amount { get; set; }
    }
}