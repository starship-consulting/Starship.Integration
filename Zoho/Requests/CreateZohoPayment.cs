using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {
    public class CreateZohoPayment : ZohoSubscriptionsRequest<ZohoResponseMessage> {
        
        public CreateZohoPayment() : base("payments", HttpMethod.Post) {
        }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("payment_mode")]
        public string PaymentMode { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("exchange_rate")]
        public float ExchangeRate { get; set; }

        [JsonProperty("bank_charges")]
        public float BankCharges { get; set; }

        [JsonProperty("tax_account_id")]
        public string TaxAccountId { get; set; }

        [JsonProperty("invoices")]
        public List<ZohoInvoicePayment> Invoices { get; set; }
    }
}