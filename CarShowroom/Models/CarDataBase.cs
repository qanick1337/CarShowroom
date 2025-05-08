using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    class CarDataBase
    {
        public List<Car> Cars { get; set; }
        public CarDataBase()
        {
            Cars = new List<Car>();
        }
        public void GenerateTestData()
        {
            Cars.Add(new Car("Ferrari", "Daytona SP3", "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000));
            Cars.Add(new Car("Ferrari", "LaFerrari", "Italy", 2013, new Features("V12", 950, "Gasoline"), 5000000));
            Cars.Add(new Car("BMW", "M5", "Germany", 2020, new Features("V8", 635, "Gasoline"), 200000));
            Cars.Add(new Car("Lamborghini", "Sian", "Italy", 2020, new Features("V12", 819, "Hybrid"), 3200000));
            Cars.Add(new Car("Porsche", "911 Turbo S", "Germany", 2021, new Features("Flat-6", 640, "Gasoline"), 204000));
            Cars.Add(new Car("Bugatti", "Chiron Super Sport", "France", 2022, new Features("W16", 1578, "Gasoline"), 3900000));
            Cars.Add(new Car("Koenigsegg", "Jesko", "Sweden", 2021, new Features("V8", 1600, "Gasoline"), 3000000));
            Cars.Add(new Car("Tesla", "Model S Plaid", "USA", 2022, new Features("Tri-Motor", 1020, "Electric"), 135000));
            Cars.Add(new Car("Rimac", "Nevera", "Croatia", 2022, new Features("Quad-Motor", 1914, "Electric"), 2200000));
            Cars.Add(new Car("Aston Martin", "Valkyrie", "UK", 2021, new Features("V12 Hybrid", 1160, "Hybrid"), 3000000));
            Cars.Add(new Car("McLaren", "Speedtail", "UK", 2020, new Features("Hybrid V8", 1050, "Hybrid"), 2300000));
            Cars.Add(new Car("Chevrolet", "Corvette Z06", "USA", 2023, new Features("V8", 670, "Gasoline"), 110000));
            Cars.Add(new Car("Toyota", "GR Supra", "Japan", 2022, new Features("I6", 382, "Gasoline"), 55000));
            Cars.Add(new Car("Nissan", "GT-R Nismo", "Japan", 2021, new Features("V6", 600, "Gasoline"), 210000));
            Cars.Add(new Car("Mercedes-Benz", "AMG GT Black Series", "Germany", 2021, new Features("V8", 720, "Gasoline"), 325000));
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
        //public List<Car> FilterDataBase()
        //{
            
        //}

        public List<Car> GetCars()
        {
            return Cars;
        }
    }
}
