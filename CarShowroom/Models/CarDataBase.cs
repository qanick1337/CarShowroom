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
            Cars.Add(new Car("Ferrari", "Daytona SP3", "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000, "new"));
            Cars.Add(new Car("Ferrari", "LaFerrari", "Italy", 2013, new Features("V12", 950, "Gasoline"), 5000000, "used"));
            Cars.Add(new Car("BMW", "M5", "Germany", 2020, new Features("V8", 635, "Gasoline"), 200000, "used"));
            Cars.Add(new Car("Lamborghini", "Sian", "Italy", 2020, new Features("V12", 819, "Hybrid"), 3200000, "used"));
            Cars.Add(new Car("Porsche", "911 Turbo S", "Germany", 2021, new Features("Flat-6", 640, "Gasoline"), 204000, "used"));
            Cars.Add(new Car("Bugatti", "Chiron Super Sport", "France", 2022, new Features("W16", 1578, "Gasoline"), 3900000, "new"));
            Cars.Add(new Car("Koenigsegg", "Jesko", "Sweden", 2021, new Features("V8", 1600, "Gasoline"), 3000000, "new"));
            Cars.Add(new Car("Tesla", "Model S Plaid", "USA", 2022, new Features("Tri-Motor", 1020, "Electric"), 135000, "new"));
            Cars.Add(new Car("Rimac", "Nevera", "Croatia", 2022, new Features("Quad-Motor", 1914, "Electric"), 2200000, "new"));
            Cars.Add(new Car("Aston Martin", "Valkyrie", "UK", 2021, new Features("V12 Hybrid", 1160, "Hybrid"), 3000000, "new"));
            Cars.Add(new Car("McLaren", "Speedtail", "UK", 2020, new Features("Hybrid V8", 1050, "Hybrid"), 2300000, "used"));
            Cars.Add(new Car("Chevrolet", "Corvette Z06", "USA", 2023, new Features("V8", 670, "Gasoline"), 110000, "new"));
            Cars.Add(new Car("Toyota", "GR Supra", "Japan", 2022, new Features("I6", 382, "Gasoline"), 55000, "new"));
            Cars.Add(new Car("Nissan", "GT-R Nismo", "Japan", 2021, new Features("V6", 600, "Gasoline"), 210000, "used"));
            Cars.Add(new Car("Mercedes-Benz", "AMG GT Black Series", "Germany", 2021, new Features("V8", 720, "Gasoline"), 325000, "used"));
            Cars.Add(new Car("Audi", "RS6 Avant", "Germany", 2021, new Features("V8", 591, "Gasoline"), 120000, "used"));
            Cars.Add(new Car("Ford", "GT", "USA", 2020, new Features("V6", 660, "Gasoline"), 500000, "used"));
            Cars.Add(new Car("Honda", "NSX Type S", "Japan", 2022, new Features("V6 Hybrid", 600, "Hybrid"), 171000, "new"));
            Cars.Add(new Car("Mazda", "RX-7 Spirit R", "Japan", 2002, new Features("Rotary", 276, "Gasoline"), 80000, "used"));
            Cars.Add(new Car("Subaru", "WRX STI", "Japan", 2019, new Features("Flat-4", 310, "Gasoline"), 45000, "used"));
            Cars.Add(new Car("Dodge", "Challenger Hellcat", "USA", 2022, new Features("V8", 797, "Gasoline"), 70000, "new"));
            Cars.Add(new Car("Aston Martin", "DB11", "UK", 2020, new Features("V12", 630, "Gasoline"), 200000, "used"));
            Cars.Add(new Car("McLaren", "765LT", "UK", 2021, new Features("V8", 755, "Gasoline"), 385000, "used"));
            Cars.Add(new Car("Lexus", "LFA", "Japan", 2012, new Features("V10", 552, "Gasoline"), 400000, "used"));
            Cars.Add(new Car("Ferrari", "F8 Tributo", "Italy", 2020, new Features("V8", 710, "Gasoline"), 280000, "used"));
            Cars.Add(new Car("Pagani", "Huayra Roadster BC", "Italy", 2021, new Features("V12", 791, "Gasoline"), 3500000, "new"));
            Cars.Add(new Car("Bentley", "Continental GT Speed", "UK", 2021, new Features("W12", 650, "Gasoline"), 250000, "used"));
            Cars.Add(new Car("Alfa Romeo", "Giulia Quadrifoglio", "Italy", 2021, new Features("V6", 505, "Gasoline"), 80000, "used"));
            Cars.Add(new Car("Volkswagen", "Golf R", "Germany", 2022, new Features("I4", 315, "Gasoline"), 45000, "new"));
            Cars.Add(new Car("Bugatti", "Divo", "France", 2020, new Features("W16", 1500, "Gasoline"), 5800000, "used"));
            Cars.Add(new Car("Volkswagen", "Passat", "Germany", 2022, new Features("I4", 174, "Gasoline"), 30000, "new"));
            Cars.Add(new Car("Hyundai", "Santa Fe", "South Korea", 2021, new Features("V6", 290, "Gasoline"), 40000, "used"));
            Cars.Add(new Car("Kia", "EV6 GT", "South Korea", 2023, new Features("Dual Motor", 576, "Electric"), 61000, "new"));
            Cars.Add(new Car("Ford", "Mustang Mach-E", "USA", 2022, new Features("Dual Motor", 480, "Electric"), 65000, "new"));
            Cars.Add(new Car("Tesla", "Cybertruck", "USA", 2024, new Features("Tri-Motor", 845, "Electric"), 85000, "new"));
            Cars.Add(new Car("Chevrolet", "Tahoe", "USA", 2023, new Features("V8", 420, "Gasoline"), 65000, "new"));
            Cars.Add(new Car("Honda", "Civic Type R", "Japan", 2023, new Features("I4 Turbo", 315, "Gasoline"), 45000, "new"));
            Cars.Add(new Car("Nissan", "Z", "Japan", 2023, new Features("V6", 400, "Gasoline"), 41000, "new"));
            Cars.Add(new Car("Mazda", "CX-5", "Japan", 2022, new Features("I4", 187, "Gasoline"), 32000, "new"));
            Cars.Add(new Car("Mercedes-Benz", "EQS", "Germany", 2023, new Features("Dual Motor", 516, "Electric"), 102000, "new"));
            Cars.Add(new Car("Audi", "Q7", "Germany", 2022, new Features("V6", 335, "Gasoline"), 60000, "new"));
            Cars.Add(new Car("Porsche", "Cayenne Turbo GT", "Germany", 2023, new Features("V8", 631, "Gasoline"), 180000, "new"));
            Cars.Add(new Car("Volvo", "XC90 Recharge", "Sweden", 2023, new Features("Hybrid", 455, "Hybrid"), 70000, "new"));
            Cars.Add(new Car("Jaguar", "I-Pace", "UK", 2022, new Features("Dual Motor", 394, "Electric"), 73000, "new"));
            Cars.Add(new Car("Land Rover", "Defender 110", "UK", 2023, new Features("V8", 518, "Gasoline"), 90000, "new"));
            Cars.Add(new Car("Bentley", "Bentayga Hybrid", "UK", 2023, new Features("Hybrid", 443, "Hybrid"), 160000, "new"));
            Cars.Add(new Car("Ferrari", "296 GTB", "Italy", 2023, new Features("V6 Hybrid", 819, "Hybrid"), 320000, "new"));
            Cars.Add(new Car("Lamborghini", "Revuelto", "Italy", 2024, new Features("V12 Hybrid", 1015, "Hybrid"), 600000, "new"));
            Cars.Add(new Car("Fiat", "500e", "Italy", 2023, new Features("Electric", 118, "Electric"), 28000, "new"));
            Cars.Add(new Car("Peugeot", "208 GT", "France", 2022, new Features("I4", 155, "Gasoline"), 35000, "new"));
            Cars.Add(new Car("Renault", "Megane E-Tech", "France", 2023, new Features("Electric", 220, "Electric"), 45000, "new"));
            Cars.Add(new Car("Bugatti", "Bolide", "France", 2024, new Features("W16", 1825, "Gasoline"), 4300000, "new"));
            Cars.Add(new Car("Koenigsegg", "Gemera", "Sweden", 2023, new Features("Hybrid", 1700, "Hybrid"), 1700000, "new"));
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
        public List<Car> FilterDataBase(string Brand, int minPrice, int maxPrice)
        {
            if (minPrice == 0 && maxPrice == 0)
            {
                return Cars;
            }
            else
            {
                var filteredCars = Cars
                    .Where(car => (car.Brand.Contains(Brand)) && (car.Price >= minPrice) && (car.Price <= maxPrice))
                    .ToList();
                return filteredCars;
            }
        }

        public List<Car> GetCars()
        {
            return Cars;
        }
    }
}
