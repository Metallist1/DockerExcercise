using CustomerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Data.DBInitializers
{
    public class DBInitializer : IDbInitializer
    {
        public void Initialize(CustomerAPIContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            // Look for any Products
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Nedas", Email = "nedassurkus@gmail.com", Phone = "91421433",  ShippingAddress = "Middle of nowhere 34", BillingAddress = "Esbjerg, Denmark" , CreditStanding = 200 },
                new Customer { Name = "Jakub", Email = "Jakub@gmail.com", Phone = "123456789",  ShippingAddress = "Poland lmao", BillingAddress = "Esbjerg, Denmark" , CreditStanding = 0 }
            };

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }
    }
}
