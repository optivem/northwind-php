﻿using System;

namespace Optivem.EShop.Basket.Core.Application.Customers.Responses
{
    public class CreateCustomerResponse
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}