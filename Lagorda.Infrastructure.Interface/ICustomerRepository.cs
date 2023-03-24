using Lagorda.Domain.Entity;
using System.Collections.Generic;

namespace Lagorda.Infrastructure.Interface
{
    public interface ICustomerRepository
    {
        int Create(Customer customer, out string message);
        bool Update(Customer customer, out string message);
        bool Delete(Customer customer, out string message);
        List<Customer> GetCustomers();
    }
}
