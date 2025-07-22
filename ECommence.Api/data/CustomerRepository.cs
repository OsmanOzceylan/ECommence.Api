using Dapper;
using ECommence.Api.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ECommence.Api.Abstract;

namespace ECommence.Api.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string _connectionString = "Server=OSMANOZCEYLAN\\SQLEXPRESS;Database=Master;Trusted_Connection=True;Encrypt=False;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public List<Customer> GetCustomers()
        {
            string query = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, [Address], City, [Region], PostalCode, Country, Phone, Fax FROM Customers";

            using (var conn = GetConnection())
            {
                conn.Open();
                var customers = conn.Query<Customer>(query).ToList();
                return customers;
            }
        }

        public void AddCustomer(Customer customer)
        {
            string query = @"
            INSERT INTO Customers 
            (CustomerID, CompanyName, ContactName, ContactTitle, [Address], City, [Region], PostalCode, Country, Phone, Fax)
            VALUES 
            (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax)";

            using (var conn = GetConnection())
            {
                conn.Open();
                conn.Execute(query, customer);
            }
        }
    }
}
