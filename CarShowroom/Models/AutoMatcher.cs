using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    public class AutoMatcher
    {
        public List<Car> MatchCars(Customer customer, List<Car> cars)
        {
            return cars.Where(car =>
                customer.DesiredBrands.Contains(car.Brand) &&
                car.Price <= customer.MaxBudget
            ).ToList();

                
        }
    }

}
