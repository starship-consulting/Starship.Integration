using System;
using Newtonsoft.Json;
using Starship.Integration.Billing;

namespace Starship.Integration.Zoho.Models {

    public class ZohoSubscription {

        public SubscriptionDetails ToSubscriptionDetails() {

            var status = GetStatus();

            return new SubscriptionDetails {
                SubscriptionId = Id,
                PlanId = Plan.Code,
                CustomerId = Customer.Id,
                BillingDate = NextBillingAt,
                SubscriptionEndDate = ExpiresAt,
                IsTrial = status == SubscriptionStatusTypes.Trial
            };
        }

        public SubscriptionStatusTypes GetStatus() {

            switch(Status) {
                
                case "active":
                    return SubscriptionStatusTypes.Active;
                
                case "live":
                    return SubscriptionStatusTypes.Live;
                
                case "future":
                    return SubscriptionStatusTypes.Future;
                
                case "trial":
                    return SubscriptionStatusTypes.Trial;
            }

            return SubscriptionStatusTypes.Unknown;
        }

        [JsonProperty("subscription_id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("child_invoice_id")]
        public string InvoiceId { get; set; }

        [JsonProperty("next_billing_at")]
        public DateTime? NextBillingAt { get; set; }

        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt { get; set; }

        [JsonProperty("plan")]
        public ZohoPlan Plan { get; set; }

        [JsonProperty("customer")]
        public ZohoCustomer Customer { get; set; }
    }
}