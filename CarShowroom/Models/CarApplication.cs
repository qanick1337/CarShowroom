using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    /// <summary>
    ///  Class representing a car application submitted by a customer.
    /// </summary>
    public class CarApplication
    {
        /// <summary> Unique identifier for the application. </summary>
        public Guid Id { get; }

        /// <summary> Read-only property to get a short display ID for the application. </summary> 
        public string DisplayId
        {
            get { return Id.ToString().Substring(0, 8); }
        }

        /// <summary> Email of the customer who submitted the application. </summary> 
        public string CustomerEmail { get; set; }

        /// <summary> List of cars included in the application. </summary>
        public List<Car> Cars { get; set; }

        /// <summary> Read-only property to get a string representation of the cars in the application. </summary>
        public string CarsDisplay
        {
            get
            {
                if (Cars != null)
                    return string.Join(", ", Cars);
                else
                    return string.Empty;
            }
        }

        /// <summary> Default constructor for CarApplication. </summary>
        public CarApplication(Guid id, string customerEmail, List<Car> cars)
        {
            Id = id;
            CustomerEmail = customerEmail;
            Cars = cars;
        }

    }
}
