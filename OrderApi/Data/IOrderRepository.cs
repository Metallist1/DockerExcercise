using System.Collections.Generic;
using OrderApi.Model;

namespace OrderApi.Data
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetByCustomer(int customerId);
    }
}
