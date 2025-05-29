using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    /// <summary> 
    /// Customer class representing a customer in the car showroom application.
    /// </summary>
    public class Customer
    {
        /// <summary> Contact information of the customer, email address.</summary>
        public string ContactInfo { get; set; }

        /// <summary> Password for the customer's account.</summary>
        public string Password { get; set; }

        /// <summary> List of desired car brands.</summary>
        public List<string> DesiredBrands { get; set; }

        /// <summary> List of desired car models.</summary>
        public List<string> DesiredBrandsModels { get; set; }

        /// <summary> Minimum budget for purchasing a car.</summary>
        public double MinBudget { get; set; } = 0.0;

        /// <summary> Maximum budget for purchasing a car.</summary>
        public double MaxBudget { get; set; } = 0.0;

        /// <summary> Display property for desired brands.</summary>
        public string DesiredBrandsDisplay
        {
            get
            {
                if (DesiredBrands != null)
                    return string.Join(", ", DesiredBrands);
                else
                    return string.Empty;
            }
        }

        /// <summary> Display property for desired models.</summary>
        public string DesiredModelsDisplay
        {
            get
            {
                if (DesiredBrandsModels != null)
                    return string.Join(", ", DesiredBrandsModels);
                else
                    return string.Empty;
            }
        }

        ///<summary> Default constructor for Customer class.</summary>
        public Customer()
        {
            ContactInfo = "unknown";
            Password = "unknown";
            DesiredBrands = new List<string> { "unknown brand", "unknown brand" };
            DesiredBrandsModels = new List<string> { "unknown model", "unknown model" };
            MinBudget = 0.0;
            MaxBudget = 0.0;
        }

        ///<summary> Constructor for Customer class with contact info and password.</summary>
        public Customer(string contactInfo, string password)
        {
            ContactInfo = contactInfo;
            Password = password;
            DesiredBrands = new List<string> { "unknown brand", "unknown brand" };
            DesiredBrandsModels = new List<string> { "unknown model", "unknown model" };
            MinBudget = 0.0;
            MaxBudget = 0.0;
        }

        ///<summary> Constructor for Customer class with contact info, password, and budget.</summary>
        public Customer(string contactInfo, string password, double minBudget, double maxBudget)
        {
            ContactInfo = contactInfo;
            Password = password;
            MinBudget = minBudget;
            MaxBudget = maxBudget;
            DesiredBrands = new List<string> { "unknown brand", "unknown brand" };
            DesiredBrandsModels = new List<string> { "unknown model", "unknown model" };
        }

        /// <summary> Main constructor for Customer class with all properties.</summary>
        public Customer(string contactInfo, string password, List<string> desiredBrands, List<string> desiredBrandsModels, double minBudget, double maxBudget)
        {
            ContactInfo = contactInfo;
            Password = password;
            DesiredBrands = desiredBrands ?? new List<string>();
            DesiredBrandsModels = desiredBrandsModels ?? new List<string>();
            MinBudget = minBudget;
            MaxBudget = maxBudget;
        }

        /// <summary> Method to validate customer data.</summary>
        public bool CustomerValidator()
        {
            if (string.IsNullOrEmpty(ContactInfo) || string.IsNullOrEmpty(Password))
            {
                throw new ArgumentNullException("Contact info and password cannot be empty.");
            }
            if (!IsValidEmail(ContactInfo))
            {
                throw new ArgumentException("Invalid email format.");
            }
            if (Password.Length < 8)
            {
                throw new ArgumentException("Password must be at least 8 characters long.");
            }
            if (MinBudget < 0 || MaxBudget < 0)
            {
                throw new ArgumentOutOfRangeException("Budget values cannot be negative.");
            }
            if (MinBudget > MaxBudget)
            {
                throw new ArgumentOutOfRangeException("Minimum budget cannot be greater than maximum budget.");
            }
            return true;
        }
        /// <summary> Method to validate login data.</summary>
        public bool ValidateLoginData()
        {
            if (string.IsNullOrEmpty(ContactInfo) || string.IsNullOrEmpty(Password))
            {
                throw new ArgumentException("Contact info and password cannot be empty.");
            }
            if (!IsValidEmail(ContactInfo))
            {
                throw new ArgumentException("Invalid email format.");
            }
            return true;
        }

        /// <summary> Method to check if the custome's e-mail is valid'.</summary>
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
