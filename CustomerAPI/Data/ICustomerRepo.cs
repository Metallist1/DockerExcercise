using CustomerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Data
{
    public interface ICustomerRepo
    {
        Customer ReadById(int customerID);
        Customer CreateCustomer(Customer customerToCreate);
        Customer EditCustomer(Customer customerToEdit);
        Customer DeleteCustomer(int customerID);

    }
}
