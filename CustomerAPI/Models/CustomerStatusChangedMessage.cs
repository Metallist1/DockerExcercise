
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Models
{
    public class CustomerStatusChangedMessage
    {
        public int CustomerId { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
