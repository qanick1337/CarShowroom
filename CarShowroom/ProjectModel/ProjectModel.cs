using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShowroom.Models;

namespace CarShowroom.ProjectModel
{
    /// <summary> 
    /// Class that represent a project
    /// </summary>
    public class ProjectModel
    {
        ///  <summary> Car database </summary>
        public CarDataBase CarDatabase { get; private set; }

        /// <summary> Customer's database</summary>
        public CustomerDataBase CustomerDatabase { get; private set; }

        /// <summary> Customer's applications database </summary>
        public ApplicationDataBase ApplicationDatabase { get; private set; }

        /// <summary> Current application customer </summary>
        public Customer? CurrentCustomer {  get; private set; }

        /// <summary> Method to get status about current customer.</summary>
        public bool IsUserLoggedIn => CurrentCustomer != null;

        ///<summary> List of brands </summary>
        public List<string> brands;


        /// <summary> List of filtered cars that will be displayed </summary>
        public List<Car> filteredCars = new List<Car>();

        /// <summary> List of selected cars </summary>
        public List<Car> selectedCars = new List<Car>();



        /// <summary> </summary>

        private string _carPath;
        private string _customerPath;
        private string _applicationPath;

        /// <summary> Default constructor for ProjectModel.</summary>
        public ProjectModel(string carPath, string customerPath, string applicationPath)
        {
            CarDatabase = new CarDataBase();
            CustomerDatabase = new CustomerDataBase();
            ApplicationDatabase = new ApplicationDataBase();

            _carPath = carPath;
            _customerPath = customerPath;
            _applicationPath = applicationPath;

            DataStorage dataStorage = new DataStorage(_carPath, _customerPath, _applicationPath);
        }

        /// <summary> Method to load data from storage.</summary>
        public void LoadData()
        {   
            CarDatabase.DeserializeData(_carPath);
            CustomerDatabase.DeserializeData(_customerPath);
            ApplicationDatabase.DeserializeData(_applicationPath);
        }

        /// <summary> Method to save data to storage.</summary>
        public void SaveData(string carPath, string customerPath, string applicationPath)
        {
            CarDatabase.SerializeData(carPath);
            CustomerDatabase.SerializeData(customerPath);
            ApplicationDatabase.SerializeData(applicationPath);
        }

        /// <summary> Method to get brands.</summary>
        public List<string> GetBrands()
        {
            if (CarDatabase.Cars.Count == 0)
                return new List<string>();

           List<string> brands = CarDatabase.Cars
               .Select(car => car.Brand)
               .Distinct()
               .OrderBy(brand => brand)
               .ToList();
            return brands;
        }

        /// <summary> Method to get models of selected brand.</summary>
        public List<string> GetModelsByBrand(string brand)
        {
            if (CarDatabase.Cars.Count == 0 || string.IsNullOrEmpty(brand))
                return new List<string>();
            List<string> models = CarDatabase.Cars
                .Where(car => car.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                .Select(car => car.Model)
                .Distinct()
                .OrderBy(model => model)
                .ToList();
            return models;
        }

        /// <summary> Method to filter the cars.</summary>
        public List<Car> FilterCars(string brand, string model, int year, string condition, int minPrice, int maxPrice)
        {
            filteredCars = CarDatabase.FilterDataBase(brand, model, year, condition, minPrice, maxPrice);
            return filteredCars;
        }

        /// <summary> Method to auto find via customer info.</summary>  
        public List<Car> AutoFind()
        {
            if (CurrentCustomer == null)
                return new List<Car>();

            List<Car> filteredCars = new List<Car>();

            var brands = CurrentCustomer.DesiredBrands ?? new List<string>();
            var models = CurrentCustomer.DesiredBrandsModels ?? new List<string>();
            double minBudget = CurrentCustomer.MinBudget;
            double maxBudget = CurrentCustomer.MaxBudget;

            filteredCars = CarDatabase.Cars
                .Where(car =>
                    (brands.Count == 0 || brands.Any(b => string.Equals(car.Brand, b, StringComparison.OrdinalIgnoreCase))) &&
                    (models.Count == 0 || models.Any(m => string.Equals(car.Model, m, StringComparison.OrdinalIgnoreCase))) &&
                    car.Price >= minBudget &&
                    car.Price <= maxBudget)
                .ToList();
            return filteredCars;
        }

        /// <summary> Method to set customer.</summary>
        public void LogIn(Customer customer)
        {
            CurrentCustomer = customer;
        }

        /// <summary> Method to log out the current customer.</summary>
        public void LogOut()
        {
            CurrentCustomer = null;
        }

        public string SubmitApplication(List<Car> selectedCars)
        {
            if (CurrentCustomer == null)
            {
                throw new InvalidOperationException("You need to log in.");
            }
            else if (selectedCars == null || selectedCars.Count == 0)
            {
                throw new InvalidOperationException("You need to select at least one car.");
            }

            CarApplication application = ApplicationDatabase.AddApplication(CurrentCustomer.ContactInfo, new List<Car>(selectedCars));
            ApplicationDatabase.SerializeData(_applicationPath);

            return application.DisplayId;
        }
    }
}
