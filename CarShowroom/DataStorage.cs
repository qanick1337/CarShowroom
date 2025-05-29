using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShowroom.Models;

namespace CarShowroom
{
    public class DataStorage
    {
        private CarDataBase _carDatabase = new CarDataBase();
        private CustomerDataBase _customerDatabase = new CustomerDataBase();
        private ApplicationDataBase _applicationDatabase = new ApplicationDataBase();

        /// <summary> Car database </summary>
        public DataStorage(string carPath, string customerPath, string applicationPath)
        {
            if (!File.Exists(carPath))
            {
                CarsDataLoader();
                _carDatabase.SerializeData(carPath);
            }
            else
            {
                _carDatabase.DeserializeData(carPath);
            }

            if (!File.Exists(customerPath))
            {
                CustomersDataLoader();
                _customerDatabase.SerializeData(customerPath);
            }
            else
            {
                _customerDatabase.DeserializeData(customerPath);
            }

            if (!File.Exists(applicationPath))
            {
                ApplicationsDataLoader();
                _applicationDatabase.SerializeData(applicationPath);
            }
            else
            {
                _applicationDatabase.DeserializeData(applicationPath);
            }
        }

        private void CarsDataLoader()
        {
            _carDatabase.AddCar(new Car("Ferrari", "Daytona SP3", "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Lamborghini", "Aventador SVJ", "Italy", 2021, new Features("V12", 770, "Gasoline"), 500000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Bugatti", "Chiron Super Sport", "France", 2022, new Features("W16", 1600, "Gasoline"), 3800000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Porsche", "911 GT3 RS", "Germany", 2023, new Features("Flat-6", 518, "Gasoline"), 223800, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Tesla", "Model S Plaid", "USA", 2023, new Features("Electric", 1020, "Electric"), 135000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("BMW", "M5 CS", "Germany", 2022, new Features("V8", 627, "Gasoline"), 142000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Mercedes-Benz", "AMG GT Black Series", "Germany", 2021, new Features("V8", 720, "Gasoline"), 325000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Audi", "RS7 Sportback", "Germany", 2023, new Features("V8", 591, "Gasoline"), 123000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("McLaren", "765LT", "UK", 2021, new Features("V8", 755, "Gasoline"), 382500, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Chevrolet", "Corvette Z06", "USA", 2023, new Features("V8", 670, "Gasoline"), 110000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Ford", "Mustang Shelby GT500", "USA", 2022, new Features("V8", 760, "Gasoline"), 79500, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Dodge", "Challenger SRT Hellcat", "USA", 2022, new Features("V8", 717, "Gasoline"), 70000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Toyota", "Supra GR", "Japan", 2023, new Features("I6", 382, "Gasoline"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Nissan", "GT-R Nismo", "Japan", 2021, new Features("V6", 600, "Gasoline"), 210000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Lexus", "LC 500", "Japan", 2023, new Features("V8", 471, "Gasoline"), 94000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Aston Martin", "DB11", "UK", 2022, new Features("V8", 528, "Gasoline"), 205000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Jaguar", "F-Type R", "UK", 2023, new Features("V8", 575, "Gasoline"), 108500, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Koenigsegg", "Jesko", "Sweden", 2022, new Features("V8", 1600, "Gasoline"), 3000000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Pagani", "Huayra Roadster", "Italy", 2021, new Features("V12", 754, "Gasoline"), 3500000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Mazda", "MX-5 Miata", "Japan", 2023, new Features("I4", 181, "Gasoline"), 28000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Subaru", "WRX STI", "Japan", 2021, new Features("Flat-4", 310, "Gasoline"), 38000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Hyundai", "Ioniq 5", "South Korea", 2023, new Features("Electric", 320, "Electric"), 50000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Kia", "EV6 GT", "South Korea", 2023, new Features("Electric", 576, "Electric"), 62000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Peugeot", "508 PSE", "France", 2022, new Features("Hybrid", 355, "Hybrid"), 70000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Renault", "Megane E-Tech", "France", 2023, new Features("Electric", 218, "Electric"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Volvo", "XC90 Recharge", "Sweden", 2023, new Features("Hybrid", 455, "Hybrid"), 71000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Alfa Romeo", "Giulia Quadrifoglio", "Italy", 2022, new Features("V6", 505, "Gasoline"), 80000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Genesis", "G90", "South Korea", 2023, new Features("V6", 409, "Gasoline"), 90000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Cadillac", "CT5-V Blackwing", "USA", 2022, new Features("V8", 668, "Gasoline"), 92000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Lucid", "Air Grand Touring", "USA", 2023, new Features("Electric", 819, "Electric"), 125000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Rimac", "Nevera", "Croatia", 2022, new Features("Electric", 1914, "Electric"), 2200000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Honda", "Civic Type R", "Japan", 2023, new Features("I4", 315, "Gasoline"), 43000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mini", "John Cooper Works GP", "UK", 2021, new Features("I4", 306, "Gasoline"), 45000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Volkswagen", "Golf R", "Germany", 2023, new Features("I4", 315, "Gasoline"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Seat", "Leon Cupra", "Spain", 2022, new Features("I4", 300, "Gasoline"), 39000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Skoda", "Octavia RS", "Czech Republic", 2023, new Features("I4", 245, "Gasoline"), 37000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Citroen", "DS7 Crossback", "France", 2022, new Features("Hybrid", 300, "Hybrid"), 58000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Rolls-Royce", "Ghost", "UK", 2023, new Features("V12", 563, "Gasoline"), 315000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Bentley", "Continental GT", "UK", 2023, new Features("W12", 650, "Gasoline"), 250000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Jeep", "Grand Cherokee Trackhawk", "USA", 2021, new Features("V8", 707, "Gasoline"), 90000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Land Rover", "Range Rover Sport SVR", "UK", 2022, new Features("V8", 575, "Gasoline"), 115000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Maserati", "MC20", "Italy", 2023, new Features("V6", 621, "Gasoline"), 250000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Fiat", "500e", "Italy", 2023, new Features("Electric", 117, "Electric"), 33000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Polestar", "2", "Sweden", 2023, new Features("Electric", 476, "Electric"), 60000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("BYD", "Han EV", "China", 2023, new Features("Electric", 517, "Electric"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Zotye", "T700", "China", 2020, new Features("I4", 190, "Gasoline"), 25000, Car.CarCondition.Used));
            _carDatabase.AddCar(new Car("Tata", "Nexon EV", "India", 2023, new Features("Electric", 141, "Electric"), 21000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mahindra", "XUV700", "India", 2023, new Features("I4", 200, "Gasoline"), 26000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Renault", "Duster", "France", 2021, new Features("I4", 150, "Gasoline"), 18000, Car.CarCondition.Used));

            _carDatabase.AddCar(new Car("Ferrari", "296 GTB", "Italy", 2023, new Features("V6 Hybrid", 819, "Hybrid"), 320000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Lamborghini", "Revuelto", "Italy", 2024, new Features("V12 Hybrid", 1001, "Hybrid"), 600000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Porsche", "Taycan Turbo GT", "Germany", 2024, new Features("Electric", 1019, "Electric"), 230000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Audi", "Q8 e-tron", "Germany", 2023, new Features("Electric", 402, "Electric"), 75000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("BMW", "i7 M70", "Germany", 2024, new Features("Electric", 650, "Electric"), 170000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mercedes-Benz", "EQE SUV", "Germany", 2024, new Features("Electric", 402, "Electric"), 98000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("McLaren", "Artura", "UK", 2023, new Features("V6 Hybrid", 671, "Hybrid"), 237500, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Tesla", "Cybertruck AWD", "USA", 2024, new Features("Electric", 600, "Electric"), 79990, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Lucid", "Gravity", "USA", 2024, new Features("Electric", 800, "Electric"), 100000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Chevrolet", "Equinox EV", "USA", 2024, new Features("Electric", 290, "Electric"), 34000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Ford", "Explorer EV", "USA", 2024, new Features("Electric", 335, "Electric"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Hyundai", "Ioniq 6", "South Korea", 2023, new Features("Electric", 320, "Electric"), 47000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Kia", "EV9", "South Korea", 2024, new Features("Electric", 379, "Electric"), 62000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Toyota", "bZ4X", "Japan", 2023, new Features("Electric", 214, "Electric"), 43000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Subaru", "Solterra", "Japan", 2023, new Features("Electric", 215, "Electric"), 44000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Nissan", "Ariya e-4ORCE", "Japan", 2023, new Features("Electric", 389, "Electric"), 60000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mazda", "CX-90 PHEV", "Japan", 2024, new Features("Hybrid", 323, "Hybrid"), 56000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Genesis", "GV60", "South Korea", 2024, new Features("Electric", 429, "Electric"), 60000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Volvo", "EX90", "Sweden", 2024, new Features("Electric", 496, "Electric"), 80000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Peugeot", "e-3008", "France", 2024, new Features("Electric", 320, "Electric"), 50000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Renault", "Scenic E-Tech", "France", 2024, new Features("Electric", 218, "Electric"), 40000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Skoda", "Enyaq RS", "Czech Republic", 2024, new Features("Electric", 295, "Electric"), 61000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Volkswagen", "ID.7", "Germany", 2024, new Features("Electric", 282, "Electric"), 50000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Fiat", "600e", "Italy", 2024, new Features("Electric", 156, "Electric"), 38000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Citroen", "e-C4 X", "France", 2024, new Features("Electric", 156, "Electric"), 35000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Opel", "Mokka Electric", "Germany", 2024, new Features("Electric", 156, "Electric"), 36000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("MG", "MG4 XPower", "UK", 2023, new Features("Electric", 429, "Electric"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("BYD", "Seal", "China", 2024, new Features("Electric", 530, "Electric"), 48000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("XPeng", "G9", "China", 2024, new Features("Electric", 543, "Electric"), 60000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Nio", "ET5", "China", 2024, new Features("Electric", 480, "Electric"), 55000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Chery", "Omoda 5 EV", "China", 2024, new Features("Electric", 204, "Electric"), 32000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Tata", "Curvv EV", "India", 2024, new Features("Electric", 220, "Electric"), 28000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mahindra", "XUV.e8", "India", 2024, new Features("Electric", 250, "Electric"), 30000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Honda", "Prologue", "Japan", 2024, new Features("Electric", 288, "Electric"), 48000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Acura", "ZDX", "Japan", 2024, new Features("Electric", 500, "Electric"), 60000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Cadillac", "Lyriq", "USA", 2024, new Features("Electric", 500, "Electric"), 63000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Buick", "Electra E5", "USA", 2024, new Features("Electric", 340, "Electric"), 40000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Rolls-Royce", "Spectre", "UK", 2024, new Features("Electric", 577, "Electric"), 420000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Lotus", "Eletre R", "UK", 2024, new Features("Electric", 905, "Electric"), 120000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Alfa Romeo", "Tonale PHEV", "Italy", 2024, new Features("Hybrid", 285, "Hybrid"), 54000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Aston Martin", "Valhalla", "UK", 2024, new Features("V8 Hybrid", 937, "Hybrid"), 800000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Koenigsegg", "Gemera", "Sweden", 2024, new Features("Hybrid", 1700, "Hybrid"), 1700000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Pagani", "Utopia", "Italy", 2023, new Features("V12", 864, "Gasoline"), 2500000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Tesla", "Model 3 Performance Highland", "USA", 2024, new Features("Electric", 510, "Electric"), 56000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Rivian", "R2", "USA", 2025, new Features("Electric", 450, "Electric"), 47000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Fisker", "Ocean Extreme", "USA", 2023, new Features("Electric", 550, "Electric"), 69000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Dacia", "Spring Electric", "Romania", 2024, new Features("Electric", 65, "Electric"), 21000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Smart", "Hashtag 1 Brabus", "Germany", 2024, new Features("Electric", 422, "Electric"), 47000, Car.CarCondition.New));

            _carDatabase.AddCar(new Car("Ferrari", "SF90 Stradale", "Italy", 2024, new Features("V8 Hybrid", 986, "Hybrid"), 515000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Lamborghini", "Huracán Tecnica", "Italy", 2024, new Features("V10", 640, "Gasoline"), 244795, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Bugatti", "Chiron Super Sport", "France", 2024, new Features("W16", 1578, "Gasoline"), 3900000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Porsche", "911 Dakar", "Germany", 2024, new Features("Flat-6", 473, "Gasoline"), 222000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mercedes-AMG", "GT 63 S E Performance", "Germany", 2024, new Features("V8 Hybrid", 831, "Hybrid"), 205000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("BMW", "XM Label Red", "Germany", 2024, new Features("V8 Hybrid", 738, "Hybrid"), 185000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Audi", "RS6 Avant Performance", "Germany", 2024, new Features("V8", 621, "Gasoline"), 130000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("McLaren", "750S", "UK", 2024, new Features("V8", 740, "Gasoline"), 324000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Tesla", "Model Y Long Range", "USA", 2024, new Features("Electric", 384, "Electric"), 49990, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Ford", "Mustang Dark Horse", "USA", 2024, new Features("V8", 500, "Gasoline"), 60000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Chevrolet", "Corvette E-Ray", "USA", 2024, new Features("V8 Hybrid", 655, "Hybrid"), 104000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Dodge", "Hornet R/T", "USA", 2024, new Features("Hybrid", 288, "Hybrid"), 41000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Lucid", "Air Sapphire", "USA", 2024, new Features("Electric", 1234, "Electric"), 250000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Ram", "1500 REV", "USA", 2024, new Features("Electric", 654, "Electric"), 70000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Hyundai", "Santa Fe Hybrid", "South Korea", 2024, new Features("Hybrid", 226, "Hybrid"), 42000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Kia", "Sportage Plug-In Hybrid", "South Korea", 2024, new Features("Hybrid", 261, "Hybrid"), 39000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Toyota", "Crown Signia", "Japan", 2024, new Features("Hybrid", 243, "Hybrid"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Subaru", "Crosstrek Wilderness", "Japan", 2024, new Features("Boxer", 182, "Gasoline"), 32000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Honda", "CR-V Hybrid", "Japan", 2024, new Features("Hybrid", 204, "Hybrid"), 35000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mazda", "MX-30 R-EV", "Japan", 2024, new Features("Hybrid", 170, "Hybrid"), 35000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Genesis", "G90 E-Supercharger", "South Korea", 2024, new Features("V6 Hybrid", 409, "Hybrid"), 100000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Peugeot", "408 Hybrid", "France", 2024, new Features("Hybrid", 225, "Hybrid"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Renault", "Austral E-Tech", "France", 2024, new Features("Hybrid", 200, "Hybrid"), 37000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Volkswagen", "Tiguan eHybrid", "Germany", 2024, new Features("Hybrid", 272, "Hybrid"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Cupra", "Tavascan", "Spain", 2024, new Features("Electric", 340, "Electric"), 53000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Skoda", "Superb iV", "Czech Republic", 2024, new Features("Hybrid", 204, "Hybrid"), 42000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("BYD", "Atto 3", "China", 2024, new Features("Electric", 204, "Electric"), 35000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("XPeng", "P7i", "China", 2024, new Features("Electric", 475, "Electric"), 51000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Nio", "EC7", "China", 2024, new Features("Electric", 653, "Electric"), 70000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Changan", "Deepal S7", "China", 2024, new Features("Electric", 258, "Electric"), 28000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Tata", "Nexon EV", "India", 2024, new Features("Electric", 143, "Electric"), 20000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mahindra", "Thar.e", "India", 2024, new Features("Electric", 250, "Electric"), 30000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Cadillac", "Escalade IQ", "USA", 2025, new Features("Electric", 750, "Electric"), 130000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Acura", "Integra Type S", "Japan", 2024, new Features("I4 Turbo", 320, "Gasoline"), 51000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Buick", "Envista", "USA", 2024, new Features("I3 Turbo", 137, "Gasoline"), 23000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Rolls-Royce", "Ghost Black Badge", "UK", 2024, new Features("V12", 592, "Gasoline"), 400000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Lotus", "Emira", "UK", 2024, new Features("V6", 400, "Gasoline"), 98000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Alfa Romeo", "Giulia Quadrifoglio 100th Anniversario", "Italy", 2024, new Features("V6", 505, "Gasoline"), 87000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Aston Martin", "DB12", "UK", 2024, new Features("V8", 671, "Gasoline"), 245000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Pagani", "Huayra Codalunga", "Italy", 2023, new Features("V12", 840, "Gasoline"), 7000000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Koenigsegg", "Jesko Absolut", "Sweden", 2024, new Features("V8", 1600, "Gasoline"), 3500000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Tesla", "Roadster (2nd Gen)", "USA", 2025, new Features("Electric", 1000, "Electric"), 200000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Rivian", "R1X", "USA", 2025, new Features("Electric", 850, "Electric"), 95000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Fisker", "Ronin", "USA", 2025, new Features("Electric", 1000, "Electric"), 385000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Dacia", "Bigster", "Romania", 2025, new Features("Hybrid", 145, "Hybrid"), 25000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Smart", "#3 Brabus", "Germany", 2024, new Features("Electric", 428, "Electric"), 49000, Car.CarCondition.New));
            
            _carDatabase.AddCar(new Car("Polestar", "Polestar 3", "Sweden", 2024, new Features("Electric", 517, "Electric"), 85000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Faraday Future", "FF 91", "USA", 2024, new Features("Electric", 1050, "Electric"), 180000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("VinFast", "VF 9", "Vietnam", 2024, new Features("Electric", 402, "Electric"), 75000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("BYD", "Tang EV", "China", 2024, new Features("Electric", 517, "Electric"), 60000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("XPeng", "G6", "China", 2024, new Features("Electric", 543, "Electric"), 55000, Car.CarCondition.New));

            _carDatabase.AddCar(new Car("Peugeot", "e-208 GTi", "France", 2025, new Features("Electric", 237, "Electric"), 35000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Tata", "Altroz Facelift", "India", 2025, new Features("I4", 86, "Gasoline"), 8300, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("BMW", "Concept Speedtop", "Germany", 2025, new Features("V8", 530, "Gasoline"), 250000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Porsche", "911 Flachbau", "Germany", 2025, new Features("Flat-6", 640, "Gasoline"), 200000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Kalmar", "9X9", "Estonia", 2025, new Features("V6 Twin-Turbo", 930, "Gasoline"), 1500000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Audi", "A6 e-tron", "Germany", 2025, new Features("Electric", 362, "Electric"), 65000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("BMW", "i7", "Germany", 2025, new Features("Electric", 536, "Electric"), 120000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Tesla", "Model 3", "USA", 2025, new Features("Electric", 450, "Electric"), 42000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Genesis", "G70", "South Korea", 2024, new Features("I4 Turbo", 300, "Gasoline"), 40000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Alfa Romeo", "Giulia Quadrifoglio", "Italy", 2024, new Features("V6", 505, "Gasoline"), 80000, Car.CarCondition.New));

            _carDatabase.AddCar(new Car("BYD", "Dolphin Surf", "China", 2025, new Features("Electric", 204, "Electric"), 23000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Kia", "EV9", "South Korea", 2024, new Features("Electric", 379, "Electric"), 65000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Hyundai", "Santa Fe XRT", "South Korea", 2024, new Features("I4 Turbo", 277, "Gasoline"), 40000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Toyota", "4Runner Hybrid", "Japan", 2025, new Features("Hybrid", 270, "Hybrid"), 52000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mazda", "CX-70", "Japan", 2025, new Features("I6", 280, "Gasoline"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Volkswagen", "Tiguan", "Germany", 2025, new Features("I4", 184, "Gasoline"), 30000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Volvo", "EX90", "Sweden", 2025, new Features("Electric", 496, "Electric"), 80000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Cadillac", "Escalade IQ", "USA", 2025, new Features("Electric", 750, "Electric"), 130000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Audi", "Q6 e-tron", "Germany", 2025, new Features("Electric", 375, "Electric"), 65000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("BMW", "X3", "Germany", 2025, new Features("I4", 248, "Gasoline"), 50000, Car.CarCondition.New));

            _carDatabase.AddCar(new Car("Polestar", "4", "Sweden", 2025, new Features("Electric", 544, "Electric"), 55000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Volvo", "EX30", "Sweden", 2025, new Features("Electric", 268, "Electric"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mercedes-Benz", "GLE 450e", "Germany", 2025, new Features("Hybrid", 381, "Hybrid"), 71000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Toyota", "Prius Plug-In Hybrid", "Japan", 2025, new Features("Hybrid", 220, "Hybrid"), 33000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Honda", "Civic Hybrid", "Japan", 2025, new Features("Hybrid", 200, "Hybrid"), 29000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Chevrolet", "Equinox EV", "USA", 2025, new Features("Electric", 300, "Electric"), 30000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Ford", "Expedition Hybrid", "USA", 2025, new Features("Hybrid", 430, "Hybrid"), 60000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Nissan", "Kicks", "Japan", 2025, new Features("I4", 122, "Gasoline"), 22000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mini", "Hardtop", "UK", 2025, new Features("I3", 134, "Gasoline"), 29000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mazda", "CX-50 Hybrid", "Japan", 2025, new Features("Hybrid", 187, "Hybrid"), 34000, Car.CarCondition.New));

            _carDatabase.AddCar(new Car("Aston Martin", "Valhalla", "UK", 2025, new Features("V8 Hybrid", 937, "Hybrid"), 800000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Ferrari", "12Cilindri Spider", "Italy", 2025, new Features("V12", 830, "Gasoline"), 510000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Maserati", "GranCabrio Folgore", "Italy", 2025, new Features("Electric", 761, "Electric"), 180000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Lamborghini", "Revuelto", "Italy", 2025, new Features("V12 Hybrid", 1001, "Hybrid"), 600000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("McLaren", "Artura", "UK", 2025, new Features("V6 Hybrid", 671, "Hybrid"), 240000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Bugatti", "Tourbillon", "France", 2025, new Features("W16 Hybrid", 1800, "Hybrid"), 3000000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Koenigsegg", "Gemera", "Sweden", 2025, new Features("I3 Hybrid", 1700, "Hybrid"), 1700000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Pagani", "Utopia", "Italy", 2025, new Features("V12", 852, "Gasoline"), 2000000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Rolls-Royce", "Spectre", "UK", 2025, new Features("Electric", 577, "Electric"), 400000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Bentley", "Flying Spur Hybrid", "UK", 2025, new Features("V6 Hybrid", 536, "Hybrid"), 220000, Car.CarCondition.New));

            _carDatabase.AddCar(new Car("Toyota", "Sienna", "Japan", 2025, new Features("Hybrid", 245, "Hybrid"), 35000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Chrysler", "Pacifica Hybrid", "USA", 2025, new Features("Hybrid", 260, "Hybrid"), 40000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Kia", "Carnival Hybrid", "South Korea", 2025, new Features("Hybrid", 290, "Hybrid"), 41000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Honda", "Odyssey", "Japan", 2025, new Features("V6", 280, "Gasoline"), 37000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Hyundai", "Staria", "South Korea", 2025, new Features("I4", 177, "Diesel"), 32000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Mercedes-Benz", "V-Class", "Germany", 2025, new Features("I4", 190, "Diesel"), 60000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Ford", "Transit Custom", "USA", 2025, new Features("I4", 130, "Diesel"), 35000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Volkswagen", "Multivan", "Germany", 2025, new Features("Hybrid", 218, "Hybrid"), 45000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Renault", "Trafic", "France", 2025, new Features("I4", 150, "Diesel"), 30000, Car.CarCondition.New));

            _carDatabase.AddCar(new Car("Peugeot", "Traveller", "France", 2025, new Features("I4", 150, "Diesel"), 32000, Car.CarCondition.New));
            _carDatabase.AddCar(new Car("Citroen", "SpaceTourer", "France", 2025, new Features("I4", 150, "Diesel"), 31000, Car.CarCondition.New));
        }

        private void CustomersDataLoader()
        {
            _customerDatabase.AddCustomer(new Customer("vovchik@gmail.com", "pupkinHarosh", new List<string> { "Ferrari", "BMW" }, new List<string> { "Daytona SP3", "M3" }, 10000, 7890000));
            _customerDatabase.AddCustomer(new Customer("john.doe@example.com", "Secure123!", new List<string> { "BMW", "Audi" }, new List<string> { "X5", "A4" }, 25000, 60000));
            _customerDatabase.AddCustomer(new Customer("emma.wilson@example.com", "Emma2025#", new List<string> { "Tesla" }, new List<string> { "Model 3" }, 35000, 55000));
            _customerDatabase.AddCustomer(new Customer("liam.smith@example.com", "L1amPass!", new List<string> { "Toyota", "Honda" }, new List<string> { "Camry", "Civic" }, 18000, 32000));
            _customerDatabase.AddCustomer(new Customer("olivia.james@example.com", "Olivia#88", new List<string> { "Mercedes" }, new List<string> { "C-Class" }, 40000, 70000));
            _customerDatabase.AddCustomer(new Customer("noah.jordan@example.com", "Noah7890!", new List<string> { "Ferrari" }, new List<string> { "488 GTB" }, 200000, 350000));
            _customerDatabase.AddCustomer(new Customer("ava.thomas@example.com", "AvaPass2025!", new List<string> { "Audi", "Porsche" }, new List<string> { "Q7", "Cayenne" }, 50000, 100000));
            _customerDatabase.AddCustomer(new Customer("oliver.brown@example.com", "Ol1v3rPass!", new List<string> { "Tesla" }, new List<string> { "Model X" }, 80000, 120000));
            _customerDatabase.AddCustomer(new Customer("sophia.martin@example.com", "Sophia@99", new List<string> { "BMW" }, new List<string> { "i8" }, 70000, 130000));
            _customerDatabase.AddCustomer(new Customer("elijah.miller@example.com", "EliM#1234", new List<string> { "Toyota", "Nissan" }, new List<string> { "Land Cruiser", "Altima" }, 25000, 40000));
            _customerDatabase.AddCustomer(new Customer("isabella.moore@example.com", "Isab3llaPass!", new List<string> { "Porsche" }, new List<string> { "Taycan" }, 100000, 150000));

            _customerDatabase.AddCustomer(new Customer("james.taylor@example.com", "Jamest@2025", new List<string> { "Lamborghini" }, new List<string> { "Huracan" }, 180000, 300000));
            _customerDatabase.AddCustomer(new Customer("mia.anderson@example.com", "Mia!Secure1", new List<string> { "Honda", "Mazda" }, new List<string> { "CR-V", "CX-5" }, 22000, 35000));
            _customerDatabase.AddCustomer(new Customer("benjamin.jackson@example.com", "Ben@Pass99", new List<string> { "Mercedes", "Audi" }, new List<string> { "GLE", "RS6" }, 70000, 110000));
            _customerDatabase.AddCustomer(new Customer("amelia.white@example.com", "Amelia$123", new List<string> { "Tesla" }, new List<string> { "Model S" }, 85000, 120000));
            _customerDatabase.AddCustomer(new Customer("lucas.harris@example.com", "Luc@2025!", new List<string> { "BMW", "Mercedes" }, new List<string> { "M3", "E-Class" }, 50000, 90000));
            _customerDatabase.AddCustomer(new Customer("harper.clark@example.com", "Harp3r#", new List<string> { "Toyota" }, new List<string> { "Corolla" }, 15000, 22000));
            _customerDatabase.AddCustomer(new Customer("henry.lewis@example.com", "Henry_123", new List<string> { "Ferrari" }, new List<string> { "Roma" }, 230000, 300000));
            _customerDatabase.AddCustomer(new Customer("evelyn.walker@example.com", "EveLyn@1", new List<string> { "Lamborghini" }, new List<string> { "Urus" }, 200000, 280000));
            _customerDatabase.AddCustomer(new Customer("alexander.hall@example.com", "Alex#789", new List<string> { "BMW" }, new List<string> { "X6" }, 55000, 85000));
            _customerDatabase.AddCustomer(new Customer("abigail.young@example.com", "Abi2025!", new List<string> { "Audi" }, new List<string> { "A6" }, 45000, 75000));

            _customerDatabase.AddCustomer(new Customer("jack.king@example.com", "Jack_444", new List<string> { "Porsche" }, new List<string> { "911" }, 90000, 140000));
            _customerDatabase.AddCustomer(new Customer("charlotte.scott@example.com", "CharPass!", new List<string> { "Mercedes" }, new List<string> { "S-Class" }, 95000, 130000));
            _customerDatabase.AddCustomer(new Customer("daniel.green@example.com", "DanielP@ss", new List<string> { "Toyota", "Honda" }, new List<string> { "RAV4", "Pilot" }, 20000, 30000));
            _customerDatabase.AddCustomer(new Customer("sofia.adams@example.com", "Sofia@22", new List<string> { "Tesla" }, new List<string> { "Model Y" }, 55000, 75000));
            _customerDatabase.AddCustomer(new Customer("michael.baker@example.com", "M1keSecure", new List<string> { "Audi" }, new List<string> { "RS7" }, 100000, 130000));
            _customerDatabase.AddCustomer(new Customer("ella.nelson@example.com", "Ella$2025", new List<string> { "BMW", "Porsche" }, new List<string> { "M4", "Macan" }, 65000, 110000));
            _customerDatabase.AddCustomer(new Customer("sebastian.carter@example.com", "Seb@123", new List<string> { "Ferrari" }, new List<string> { "Portofino" }, 220000, 310000));
            _customerDatabase.AddCustomer(new Customer("avery.mitchell@example.com", "Avery!88", new List<string> { "Toyota" }, new List<string> { "Yaris" }, 12000, 18000));
            _customerDatabase.AddCustomer(new Customer("logan.roberts@example.com", "Logan2025", new List<string> { "Mercedes" }, new List<string> { "GLS" }, 80000, 105000));
            _customerDatabase.AddCustomer(new Customer("lily.turner@example.com", "Lily#Pass", new List<string> { "Tesla" }, new List<string> { "Roadster" }, 180000, 250000));


            _customerDatabase.AddCustomer(new Customer("jacob.phillips@example.com", "Jacob@88", new List<string> { "Audi" }, new List<string> { "A8" }, 75000, 115000));
            _customerDatabase.AddCustomer(new Customer("grace.campbell@example.com", "Grace$123", new List<string> { "Lamborghini" }, new List<string> { "Aventador" }, 300000, 450000));
            _customerDatabase.AddCustomer(new Customer("ethan.parker@example.com", "Eth@n2025", new List<string> { "BMW" }, new List<string> { "5 Series" }, 40000, 70000));
            _customerDatabase.AddCustomer(new Customer("victoria.evans@example.com", "VicToria#", new List<string> { "Toyota" }, new List<string> { "Supra" }, 35000, 55000));
            _customerDatabase.AddCustomer(new Customer("mason.edwards@example.com", "Mason2025!", new List<string> { "Ferrari" }, new List<string> { "F8 Tributo" }, 250000, 330000));
            _customerDatabase.AddCustomer(new Customer("scarlett.collins@example.com", "Scar@33", new List<string> { "Porsche" }, new List<string> { "Panamera" }, 90000, 140000));
            _customerDatabase.AddCustomer(new Customer("logan.stewart@example.com", "LoganP@ss", new List<string> { "Audi", "Tesla" }, new List<string> { "e-tron", "Model S" }, 85000, 125000));
            _customerDatabase.AddCustomer(new Customer("chloe.sanchez@example.com", "Chloe!123", new List<string> { "Mercedes" }, new List<string> { "GLA" }, 30000, 45000));
            _customerDatabase.AddCustomer(new Customer("aiden.morris@example.com", "AidenP@ss!", new List<string> { "Toyota" }, new List<string> { "Highlander" }, 28000, 40000));
            _customerDatabase.AddCustomer(new Customer("nora.rogers@example.com", "Nora2025!", new List<string> { "BMW" }, new List<string> { "3 Series" }, 35000, 55000));
        }

        private void ApplicationsDataLoader()
        {
            _applicationDatabase.AddApplication("vovchik@gmail.com", new List<Car> { new Car("Ferrari", "Daytona SP3", "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("john.doe@example.com", new List<Car> { new Car("BMW", "M5 CS", "Germany", 2022, new Features("V8", 627, "Gasoline"), 142000, Car.CarCondition.Used) });
            _applicationDatabase.AddApplication("emma.wilson@example.com", new List<Car> { new Car("Tesla", "Model S Plaid", "USA", 2023, new Features("Electric", 1020, "Electric"), 135000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("liam.smith@example.com", new List<Car> { new Car("Toyota", "Crown Signia", "Japan", 2024, new Features("Hybrid", 243, "Hybrid"), 45000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("olivia.james@example.com", new List<Car> { new Car("Mercedes-Benz", "AMG GT Black Series", "Germany", 2021, new Features("V8", 720, "Gasoline"), 325000, Car.CarCondition.Used) });
            _applicationDatabase.AddApplication("noah.jordan@example.com", new List<Car> { new Car("Ferrari", "Daytona SP3", "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("ava.thomas@example.com", new List<Car> { new Car("Porsche", "911 GT3 RS", "Germany", 2023, new Features("Flat-6", 518, "Gasoline"), 223800, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("oliver.brown@example.com", new List<Car> { new Car("Tesla", "Model X", "USA", 2023, new Features("Electric", 1020, "Electric"), 135000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("sophia.martin@example.com", new List<Car> { new Car("BMW", "M5 CS", "Germany", 2022, new Features("V8", 627, "Gasoline"), 142000, Car.CarCondition.Used) });
            _applicationDatabase.AddApplication("elijah.miller@example.com", new List<Car> { new Car("Toyota", "Crown Signia", "Japan", 2024, new Features("Hybrid", 243, "Hybrid"), 45000, Car.CarCondition.New) });

            _applicationDatabase.AddApplication("isabella.moore@example.com", new List<Car> { new Car("Porsche", "911 GT3 RS", "Germany", 2023, new Features("Flat-6", 518, "Gasoline"), 223800, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("james.taylor@example.com", new List<Car> { new Car("Lamborghini", "Aventador SVJ", "Italy", 2021, new Features("V12", 770, "Gasoline"), 500000, Car.CarCondition.Used) });
            _applicationDatabase.AddApplication("mia.anderson@example.com", new List<Car> { new Car("Honda", "CR-V Hybrid", "Japan", 2024, new Features("Hybrid", 204, "Hybrid"), 35000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("benjamin.jackson@example.com", new List<Car> { new Car("Mercedes-Benz", "AMG GT Black Series", "Germany", 2021, new Features("V8", 720, "Gasoline"), 325000, Car.CarCondition.Used) });
            _applicationDatabase.AddApplication("amelia.white@example.com", new List<Car> { new Car("Tesla", "Model S Plaid", "USA", 2023, new Features("Electric", 1020, "Electric"), 135000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("lucas.harris@example.com", new List<Car> { new Car("BMW", "M5 CS", "Germany", 2022, new Features("V8", 627, "Gasoline"), 142000, Car.CarCondition.Used) });
            _applicationDatabase.AddApplication("harper.clark@example.com", new List<Car> { new Car("Toyota", "Crown Signia", "Japan", 2024, new Features("Hybrid", 243, "Hybrid"), 45000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("henry.lewis@example.com", new List<Car> { new Car("Ferrari", "Daytona SP3", "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("evelyn.walker@example.com", new List<Car> { new Car("Lamborghini", "Aventador SVJ", "Italy", 2021, new Features("V12", 770, "Gasoline"), 500000, Car.CarCondition.Used) });
            _applicationDatabase.AddApplication("alexander.hall@example.com", new List<Car> { new Car("BMW", "M5 CS", "Germany", 2022, new Features("V8", 627, "Gasoline"), 142000, Car.CarCondition.Used) });

            _applicationDatabase.AddApplication("abigail.young@example.com", new List<Car> { new Car("Audi", "RS7 Sportback", "Germany", 2023, new Features("V8", 591, "Gasoline"), 123000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("jack.king@example.com", new List<Car> { new Car("Porsche", "911 GT3 RS", "Germany", 2023, new Features("Flat-6", 518, "Gasoline"), 223800, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("charlotte.scott@example.com", new List<Car> { new Car("Mercedes-Benz", "AMG GT Black Series", "Germany", 2021, new Features("V8", 720, "Gasoline"), 325000, Car.CarCondition.Used) });
            _applicationDatabase.AddApplication("daniel.green@example.com", new List<Car> { new Car("Toyota", "Crown Signia", "Japan", 2024, new Features("Hybrid", 243, "Hybrid"), 45000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("sofia.adams@example.com", new List<Car> { new Car("Tesla", "Model S Plaid", "USA", 2023, new Features("Electric", 1020, "Electric"), 135000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("michael.baker@example.com", new List<Car> { new Car("Audi", "RS7 Sportback", "Germany", 2023, new Features("V8", 591, "Gasoline"), 123000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("ella.nelson@example.com", new List<Car> { new Car("BMW", "M5 CS", "Germany", 2022, new Features("V8", 627, "Gasoline"), 142000, Car.CarCondition.Used) });
            _applicationDatabase.AddApplication("sebastian.carter@example.com", new List<Car> { new Car("Ferrari", "Daytona SP3", "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("avery.mitchell@example.com", new List<Car> { new Car("Toyota", "Crown Signia", "Japan", 2024, new Features("Hybrid", 243, "Hybrid"), 45000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("logan.roberts@example.com", new List<Car> { new Car("Mercedes-Benz", "AMG GT Black Series", "Germany", 2021, new Features("V8", 720, "Gasoline"), 325000, Car.CarCondition.Used) });

            _applicationDatabase.AddApplication("lily.turner@example.com", new List<Car> { new Car("Tesla", "Roadster (2nd Gen)", "USA", 2025, new Features("Electric", 1000, "Electric"), 200000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("jacob.phillips@example.com", new List<Car> { new Car("Audi", "RS7 Sportback", "Germany", 2023, new Features("V8", 591, "Gasoline"), 123000, Car.CarCondition.New) });
            _applicationDatabase.AddApplication("grace.campbell@example.com", new List<Car> { new Car("Lamborghini", "Aventador SVJ", "Italy", 2021, new Features("V12", 770, "Gasoline"), 500000, Car.CarCondition.Used) });
            _applicationDatabase.AddApplication("ethan.parker@example.com", new List<Car> { new Car("BMW", "M5 CS", "Germany", 2022, new Features("V8", 627, "Gasoline"), 142000, Car.CarCondition.Used) });
        }
    }
}
