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
    /// Class representing a database of cars.
    /// </summary>
    public class CarDataBase
    {
        /// <summary> List of cars in the database.</summary>
        private List<Car> _cars;

        /// <summary> Read-only property to access the list of cars.</summary>
        public IReadOnlyList<Car> Cars => _cars.AsReadOnly();


        /// <summary> Constructor to initialize the car database.</summary>
        public CarDataBase()
        {
            _cars = new List<Car>();
        }
        /// <summary> Method to generate test data for the car database.</summary>
        public void GenerateTestData()
        {
           for (int i = 0; i < 50; i++)
            {   
                if(i % 2 == 0)
                    _cars.Add(new Car($"Brand{i}", $"Model{i}", "USA", 2000 + i, new Features("V6", 300 + i * 10, "Petrol"), 10000 + i * 1000, Car.CarCondition.New));
                else
                    _cars.Add(new Car($"Brand{i}", $"Model{i}", "USA", 2000 + i, new Features("V12", 300 + i * 10, "Petrol"), 10000 + i * 1000, Car.CarCondition.Used));
            }
        }

        /// <summary> Method of adding new car in database. </summary>
        public void AddCar(Car car)
        {
            _cars.Add(car);
        }
        /// <summary> Method of removing car from database. </summary>
        public void RemoveCar(Car car)
        {
            _cars.Remove(car);
        }

        /// <summary> Method of generating test data for the car database.</summary>
        public void SerializeData(string path)
        {
            string jsonCars = JsonSerializer.Serialize(_cars);
            File.WriteAllText(path, jsonCars);
        }
        /// <summary> Method of reading data from storage and initialization of the car database.</summary>
        public void DeserializeData(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    var cars = JsonSerializer.Deserialize<List<Car>>(json);

                    _cars = cars ?? new List<Car>();
                }
                else
                {
                    GenerateTestData();
                    SerializeData(path);
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error with reading : " + ex.Message, ex); ;
            }
        }
        /// <summary> Filtreation of the car database based on the provided criteria. </summary>
        public List<Car> FilterDataBase(string brand, string model, int year, string condition, int minPrice, int maxPrice)
        {
            var filteredCars = _cars.Where(car =>
                (string.IsNullOrEmpty(brand) || car.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(model) || car.Model.Equals(model, StringComparison.OrdinalIgnoreCase)) &&
                (year == 0 || car.ReleaseYear == year) &&
                (string.IsNullOrEmpty(condition) || condition.Equals("All", StringComparison.OrdinalIgnoreCase) ||
                    car.Condition.ToString().Equals(condition, StringComparison.OrdinalIgnoreCase)) &&
                (minPrice == 0 || car.Price >= minPrice) &&
                (maxPrice == 0 || car.Price <= maxPrice)).ToList();
            return filteredCars;
        }
    }
}
