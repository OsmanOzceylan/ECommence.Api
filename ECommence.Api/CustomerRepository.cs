using Dapper;

using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace ECommence.Api
{
    public class CustomerRepository
    {
        public string _connectionString = "Server=OSMANOZCEYLAN\\SQLEXPRESS;Database=Master;Trusted_Connection=True;Encrypt=False;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public List<Customer> GetCustomers()
        {
            string CustomerİnfoQuery = "SELECT CustomerID, CompanyName, ContactName, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers ";

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var customers = conn.Query<Customer>(CustomerİnfoQuery).ToList();

                return customers;
            }
           
        }
    }
}


