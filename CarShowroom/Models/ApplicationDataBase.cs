using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    public class ApplicationDataBase
    {
        public List<CarApplication> Applications = new();

        public CarApplication AddApplication(string email, List<Car> cars)
        {
            int userApplicationsCount = Applications.Count(a => a.CustomerEmail == email);

            int id = GenerateId(email, userApplicationsCount);

            var newApplication = new CarApplication(id, email, cars);
            Applications.Add(newApplication);
            return newApplication;
        }

        private int GenerateId(string email, int index)
        {
            int hash = Math.Abs(email.GetHashCode()); 
            return hash + index;
        }

        public void SerializeData(string path)
        {
            string jsonApplications = JsonSerializer.Serialize(Applications);
            File.WriteAllText(path, jsonApplications);
        }

        public void DeserializeData(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    var applications = JsonSerializer.Deserialize<List<CarApplication>>(json);

                    Applications = applications;
                }
                else
                {
                    Applications = new List<CarApplication>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with reading file:" + ex.Message);
                Applications = new List<CarApplication>();
            }
        }

        public void GenerateTestData()
        {
            AddApplication("vovchik@gmail.com", new List<Car> { new Car("Ferrari", "Daytona SP3", "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000, "new")});
            AddApplication("sigmaboy@usamail.com", new List<Car> { new Car("Tesla", "Model S Plaid", "USA", 2022, new Features("Tri-Motor", 1020, "Electric"), 135000, "new"), new Car("Rimac", "Nevera", "Croatia", 2022, new Features("Quad-Motor", 1914, "Electric"), 2200000, "new") });
        }
    }
}
