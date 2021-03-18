﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Model
{
    public class CustomerDTO
    {
        public int customerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public int CreditStanding { get; set; }
    }
}
