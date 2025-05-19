using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    public class CarApplication
    {
        public int Id { get; set; }
        public string CustomerEmail { get; set; }
        public List<Car> Cars { get; set; }

        public CarApplication(int id, string customerEmail, List<Car> cars)
        {
            Id = id;
            CustomerEmail = customerEmail;
            Cars = cars;
        }
    }
}
