using CustomerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Data.DBInitializers
{
    public class CustomerAPIContext : DbContext
    {
        public CustomerAPIContext(DbContextOptions<CustomerAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
