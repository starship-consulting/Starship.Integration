using System;
using Newtonsoft.Json;

namespace Starship.Integration.Billing {

    public class SubscriptionDetails {

        [JsonProperty(PropertyName="subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty(PropertyName="customerId")]
        public string CustomerId { get; set; }

        [JsonProperty(PropertyName="isTrial")]
        public bool IsTrial { get; set; }

        [JsonProperty(PropertyName="subscriptionEndDate")]
        public DateTime? SubscriptionEndDate { get; set; }

        [JsonProperty(PropertyName="billingDate")]
        public DateTime? BillingDate { get; set; }

        [JsonProperty(PropertyName="planId")]
        public string PlanId { get; set; }
    }
}