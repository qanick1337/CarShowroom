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
    ///  Class to manage car applications list
    /// </summary>
    public class ApplicationDataBase
    {
        private List<CarApplication> _applications;

        /// <summary> Read-only property to access the list of applications. </summary>
        public IReadOnlyList<CarApplication> Applications => _applications.AsReadOnly();

        /// <summary> Default constructor for ApplicationDataBase. Initializes the applications list. </summary>
        public ApplicationDataBase()
        {
            _applications = new List<CarApplication>();
        }

        /// <summary> Method to add a new application. </summary>
        public CarApplication AddApplication(string email, List<Car> cars)
        {
            Guid id = Guid.NewGuid();
            CarApplication newApplication = new CarApplication(id, email, cars);
            _applications.Add(newApplication);
            return newApplication;
        }

        /// <summary> Method to remove an application by its ID. </summary>
        public bool RemoveApplication(Guid id)
        {
            var application = _applications.FirstOrDefault(app => app.Id == id);
            if (application != null)
            {
                _applications.Remove(application);
                return true;
            }
            return false;
        }

        /// <summary> Method to save the applications list to a file in JSON format. </summary>
        public void SerializeData(string path)
        {
            string jsonApplications = JsonSerializer.Serialize(_applications);
            File.WriteAllText(path, jsonApplications);
        }

        /// <summary>  Method to read the applications list from a file in JSON format. </summary>
        public void DeserializeData(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    var applications = JsonSerializer.Deserialize<List<CarApplication>>(json);

                    _applications = applications ?? new List<CarApplication>();
                }
                else
                {
                    GenerateTestData();
                    SerializeData(path);
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error with reading : " + ex.Message, ex);
            }
        }

        /// <summary> Method to generate test data for applications</summary>
        public void GenerateTestData()
        {
            AddApplication("vovchik@gmail.com", new List<Car> { new Car("Ferrari", "Daytona SP3",
                "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000, Car.CarCondition.New)});
            AddApplication("sigmaboy@usamail.com", new List<Car> { new Car("Tesla", "Model S Plaid",
                "USA", 2022, new Features("Tri-Motor", 1020, "Electric"), 135000, Car.CarCondition.New),
                new Car("Rimac", "Nevera", "Croatia", 2022, new Features("Quad-Motor", 1914, "Electric"), 2200000, Car.CarCondition.New) });
        }
    }
}
