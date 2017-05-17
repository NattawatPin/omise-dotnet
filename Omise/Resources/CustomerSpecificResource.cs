﻿using Omise.Models;

namespace Omise.Resources
{
    public class CustomerSpecificResource : BaseResource<Customer>,
    IRetrievable<Customer>
    {
        public readonly CustomerSpecificCardResource Cards;

        public CustomerSpecificResource(IRequester requester, string customerId)
            : base(requester, Endpoint.Api, $"/customers/${customerId}")
        {
            Cards = new CustomerSpecificCardResource(requester, customerId);
        }
    }
}
