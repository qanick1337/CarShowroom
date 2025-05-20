using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    public class CarDataBase
    {
        public List<Car> Cars { get; set; }
        public CarDataBase()
        {
            Cars = new List<Car>();
        }
        public void GenerateTestData()
        {
            Cars.Add(new Car("Ferrari", "Daytona SP3", "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000, "new"));
            Cars.Add(new Car("Ferrari", "LaFerrari", "Italy", 2013, new Features("V12", 950, "Gasoline"), 5000000, "used"));
            Cars.Add(new Car("BMW", "M5", "Germany", 2020, new Features("V8", 635, "Gasoline"), 200000, "used"));
            Cars.Add(new Car("Lamborghini", "Sian", "Italy", 2020, new Features("V12", 819, "Hybrid"), 3200000, "used"));
            Cars.Add(new Car("Porsche", "911 Turbo S", "Germany", 2021, new Features("Flat-6", 640, "Gasoline"), 204000, "used"));
            Cars.Add(new Car("Bugatti", "Chiron Super Sport", "France", 2022, new Features("W16", 1578, "Gasoline"), 3900000, "new"));
            Cars.Add(new Car("Koenigsegg", "Jesko", "Sweden", 2021, new Features("V8", 1600, "Gasoline"), 3000000, "new"));
            Cars.Add(new Car("Tesla", "Model S Plaid", "USA", 2022, new Features("Tri-Motor", 1020, "Electric"), 135000, "new"));
            Cars.Add(new Car("Rimac", "Nevera", "Croatia", 2022, new Features("Quad-Motor", 1914, "Electric"), 2200000, "new"));
        }
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void RemoveCar(Car car)
        {
            Cars.Remove(car);
        }
        public void SerializeData(string path)
        {
            string jsonCars = JsonSerializer.Serialize(Cars);
            File.WriteAllText(path, jsonCars);
        }
        public void DeserializeData(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path); 
                    var cars = JsonSerializer.Deserialize<List<Car>>(json);

                    Cars = cars;
                }
                else
                {
                    Cars = new List<Car>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with reading file:" + ex.Message);
                Cars = new List<Car>();
            }
        }
        public List<Car> FilterDataBase(string brand, string model, int year,string condition, int minPrice, int maxPrice)
        {
            var filteredCars = Cars.Where(car =>
                (string.IsNullOrEmpty(brand) || car.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(model) || car.Model.Equals(model, StringComparison.OrdinalIgnoreCase)) &&
                (year == 0 || car.ReleaseYear == year) &&
                (string.IsNullOrEmpty(condition) || condition.Equals("All", StringComparison.OrdinalIgnoreCase) || car.Condition.Equals(condition, StringComparison.OrdinalIgnoreCase)) &&
                (minPrice == 0 || car.Price >= minPrice) &&
                (maxPrice == 0 || car.Price <= maxPrice)).ToList();
            return filteredCars;
        }

        public List<Car> GetCars()
        {
            return Cars;
        }
    }
}
