using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Starship.Integration.Billing {

    public interface IsSubscriptionProvider {

        Task<SubscriptionDetails> GetSubscriptionAsync(string subscriptionId);

        Task<List<SubscriptionDetails>> GetCustomerSubscriptionsAsync(string customerId);

        Task CancelSubscriptionAsync(string subscriptionId);

        Task ChangeCustomerEmailAsync(string oldEmail, string newEmail);
    }
}