using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    /// <summary>
    /// Class representing a customer database in the car showroom application.
    /// </summary>
    public class CustomerDataBase
    {
        /// <summary> List of customers in the database. </summary>
        public List<Customer> Customers { get; set; }

        /// <summary> Default constructor for CustomerDataBase.</summary>
        public CustomerDataBase()
        {
            Customers = new List<Customer>();
        }

        /// <summary> Method to add a customer to the database.</summary>
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        /// <summary> Method to remove a customer from the database.</summary>
        public void RemoveCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }

        /// <summary> Method to generate test data for the customer database.</summary>
        public void GenerateData()
        {
            Customers.Add(new Customer("vovchik@gmail.com", "pupkinHarosh", new List<string> { "Ferrari", "BMW" }, new List<string> { "Daytona SP3", "M3" }, 10000, 7890000));
            Customers.Add(new Customer("sigmaboy@usamail.com", "UsaUsaUsa", new List<string> {}, new List<string> {}, 10000, 10000000));
        }

        /// <summary> Method to serialize the customer data to a file in JSON format.</summary>
        public void SerializeData(string path)
        {
            string jsonCustomers = JsonSerializer.Serialize(Customers);
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

                    Customers = customers;
                }
                else
                {
                    GenerateData();
                    SerializeData(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with reading file:" + ex.Message);
                Customers = new List<Customer>();
            }
        }

        /// <summary> Method to get a customer by their email and password.</summary>
        public Customer GetCustomerByData(string userMail, string userPassword)
        {
            foreach (var customer in Customers)
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
