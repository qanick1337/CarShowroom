using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace CarShowroom.Models
{
    /// <summary>
    /// Class representing a customer database in the car showroom application.
    /// </summary>
    public class CustomerDataBase
    {
        private List<Customer> _customers;
        /// <summary> Read-only property to access the list of customers.</summary>
        public IReadOnlyList<Customer> Customers => _customers.AsReadOnly();

        /// <summary> Default constructor for CustomerDataBase.</summary>
        public CustomerDataBase()
        {
            _customers = new List<Customer>();
        }

        /// <summary> Method to add a customer to the database.</summary>
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        /// <summary> Method to remove a customer from the database.</summary>
        public void RemoveCustomer(Customer customer)
        {
            _customers.Remove(customer);
        }

        /// <summary> Method to generate test data for the customer database.</summary>
        public void GenerateData()
        {
            _customers.Add(new Customer("vovchik@gmail.com", "pupkinHarosh", new List<string> { "Ferrari", "BMW" }, new List<string> { "Daytona SP3", "M3" }, 10000, 7890000));
            _customers.Add(new Customer("sigmaboy@usamail.com", "UsaUsaUsa", new List<string> {}, new List<string> {}, 10000, 10000000));
        }

        /// <summary> Method to serialize the customer data to a file in JSON format.</summary>
        public void SerializeData(string path)
        {
            string jsonCustomers = JsonSerializer.Serialize(_customers);
            File.WriteAllText(path, jsonCustomers);
        }

        /// <summary> Method to deserialize the customer data from a file in JSON format.</summary>
        public void DeserializeData(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    var customers = JsonSerializer.Deserialize<List<Customer>>(json);

                    _customers = customers;
                }
                else
                {
                    GenerateData();
                    SerializeData(path);
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error with reading : " + ex.Message, ex); ;
            }
        }

        /// <summary> Method to get a customer by their email and password.</summary>
        public Customer GetCustomerByData(string userMail, string userPassword)
        {
            foreach (var customer in _customers)
            {
                if (customer.ContactInfo == userMail && customer.Password == userPassword)
                {
                    return customer;
                }
            }
            return null;
        }
    }
}
