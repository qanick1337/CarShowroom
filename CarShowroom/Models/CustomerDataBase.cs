using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    class CustomerDataBase
    {
        public List<Customer> Customers { get; set; }

        public CustomerDataBase()
        {
            Customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }

        public void GenerateData()
        {
            Customers.Add(new Customer("pupkin_vasyl@gmail.com", "pupkinHarosh", new List<string> { "Ferrari", "BMW" }, new List<string> { "Daytona SP3", "M3" }, 10000, 10000));
            Customers.Add(new Customer("pupkin_vasyl@gmail.com", "pupkinHarosh", new List<string> { "Ferrari", "BMW" }, new List<string> { "Daytona SP3", "M3" }, 10000, 10000));
        }

        public void SerializeData(string path)
        {
            string jsonCustomers = JsonSerializer.Serialize(Customers);
            File.WriteAllText(path, jsonCustomers);
        }

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
                    Customers = new List<Customer>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with reading file:" + ex.Message);
                Customers = new List<Customer>();
            }
        }

        public bool isUserExist(string userMail, string userPassword)
        {
            foreach (var customer in Customers)
            {
                if (customer.ContactInfo == userMail && customer.Password == userPassword)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
