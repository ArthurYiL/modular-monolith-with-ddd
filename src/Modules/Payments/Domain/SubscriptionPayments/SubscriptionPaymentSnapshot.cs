﻿using CompanyName.MyMeetings.Modules.Payments.Domain.Payers;
using CompanyName.MyMeetings.Modules.Payments.Domain.Subscriptions;

namespace CompanyName.MyMeetings.Modules.Payments.Domain.SubscriptionPayments
{
    public class SubscriptionPaymentSnapshot
    {
        public SubscriptionPaymentSnapshot(PayerId payerId, SubscriptionPeriod subscriptionPeriod, string countryCode)
        {
            PayerId = payerId;
            SubscriptionPeriod = subscriptionPeriod;
            CountryCode = countryCode;
        }

        public PayerId PayerId { get; }

        public SubscriptionPeriod SubscriptionPeriod { get; }

        public string CountryCode { get; }
    }
}