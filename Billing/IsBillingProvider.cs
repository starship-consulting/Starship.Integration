using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Starship.Integration.People;

namespace Starship.Integration.Billing {

    public interface IsBillingProvider {
        
        JToken GetSessionToken(string customerId);

        JToken GetCheckoutToken(IsPerson person, string billingId = "", string plan = "");

        //SubscriptionDetails GetSubscription(IsPerson person, string planId = "");
        
        List<SubscriptionPlan> GetPlans();
        
        void CancelSubscription(string subscriptionId);

        void ChangeCustomerEmail(string oldEmail, string newEmail);
    }
}