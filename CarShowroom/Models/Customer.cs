using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    public class Customer
    {
        public string ContactInfo { get; set; }
        public string Password { get; set; }
        public List<string> DesiredBrands { get; set; }
        public List<string> DesiredBrandsModels { get; set; }
        public double MinBudget { get; set; }
        public double MaxBudget { get; set; }

        // Default constructor
        public Customer()
        {
            DesiredBrands = new List<string>();
            DesiredBrandsModels = new List<string>();
        }


        public Customer(string contactInfo, string password)
        {
            ContactInfo = contactInfo;
            Password = password;

            DesiredBrands = new List<string>();
            DesiredBrandsModels = new List<string>();
        }


        public Customer(string contactInfo, string password, double minBudget, double maxBudget)
        {
            MinBudget = minBudget;
            MaxBudget = maxBudget;

            ContactInfo = contactInfo;
            Password = password;

            DesiredBrands = new List<string>();
            DesiredBrandsModels = new List<string>();
        }

        // Main constructor
        public Customer(string contactInfo, string password, List<string> desiredBrands, List<string> desiredBrandsModels, double minBudget, double maxBudget)
        {
            ContactInfo = contactInfo;
            Password = password;
            DesiredBrands = desiredBrands ?? new List<string>();
            DesiredBrandsModels = desiredBrandsModels ?? new List<string>();
            MinBudget = minBudget;
            MaxBudget = maxBudget;
        }

        public bool CustomerValidator()
        {
            if (string.IsNullOrEmpty(ContactInfo) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Contact info and password cannot be empty.");
                return false;
            }
            if (!IsValidEmail(ContactInfo))
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }
            if (MinBudget < 0 || MaxBudget < 0)
            {
                MessageBox.Show("Budget cannot be negative.");
                return false;
            }
            if (MinBudget > MaxBudget)
            {
                MessageBox.Show("Minimum budget cannot be greater than maximum budget.");
                return false;
            }
            return true;
        }

        public bool ValidateLoginData()
        {
            if (string.IsNullOrEmpty(ContactInfo) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Contact info and password cannot be empty.");
                return false;
            }
            if (!IsValidEmail(ContactInfo))
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; 
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }  
    }
}
