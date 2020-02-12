using System;

namespace Starship.Integration.Billing {

    public class SubscriptionPlan {

        public string SubscriptionId { get; set; }

        public string PlanId { get; set; }

        public DateTime TrialPeriod { get; set; }
    }
}