using System;

namespace Starship.Integration.Billing {

    public enum SubscriptionStatusTypes {
        Unknown = 0,
        Active,
        Live,
        Future,
        Trial
    }
}