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
        public string Name { get; set; }
        public MailAddress ContactInfo { get; set; }
        public List<string> DesiredBrands { get; set; }
        public double MaxBudget { get; set; }

        public Customer(string name, MailAddress contactInfo, List<string> desiredBrands, double maxBudget)
        {
            Name = name;
            ContactInfo = contactInfo;
            DesiredBrands = desiredBrands;
            MaxBudget = maxBudget;
        }
    }
}
