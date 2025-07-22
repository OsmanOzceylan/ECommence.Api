using ECommence.Api.Models;
using System.Collections.Generic;

namespace ECommence.Api.Abstract
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        List<Customer> GetCustomers();
    }
}
