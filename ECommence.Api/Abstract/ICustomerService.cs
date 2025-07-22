using ECommence.Api.Models;
using System.Collections.Generic;

namespace ECommence.Api.Abstract
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        List<Customer> GetAllCustomers();
    }
}
