using CarShowroom.Models;
using System.Net.Mail;

namespace CarShowroom
{
    public partial class MainForm : Form
    {

        private List<Car> carDatabase;
        private Customer currentCustomer;
        public MainForm()
        {
            InitializeComponent();
            InitializeTestData();
        }

        public void InitializeTestData()
        {
            carDatabase = new List<Car> {
                new Car("Ferrari", "Daytona SP3", "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000),
                new Car("Ferrari", "LaFerrari", "Italy", 2013, new Features("V12", 950, "Gasoline"), 5000000),
                new Car("BMW", "M5", "Germany", 2020, new Features("V8", 635, "Gasoline"), 200000),
                new Car("Lamborghini", "Sian", "Italy", 2020, new Features("V12", 819, "Hybrid"), 3200000),
                new Car("Porsche", "911 Turbo S", "Germany", 2021, new Features("Flat-6", 640, "Gasoline"), 204000),
                new Car("Bugatti", "Chiron Super Sport", "France", 2022, new Features("W16", 1578, "Gasoline"), 3900000),
                new Car("Koenigsegg", "Jesko", "Sweden", 2021, new Features("V8", 1600, "Gasoline"), 3000000),
                new Car("Tesla", "Model S Plaid", "USA", 2022, new Features("Tri-Motor", 1020, "Electric"), 135000),
                new Car("Rimac", "Nevera", "Croatia", 2022, new Features("Quad-Motor", 1914, "Electric"), 2200000),
                new Car("Aston Martin", "Valkyrie", "UK", 2021, new Features("V12 Hybrid", 1160, "Hybrid"), 3000000),
                new Car("McLaren", "Speedtail", "UK", 2020, new Features("Hybrid V8", 1050, "Hybrid"), 2300000),
                new Car("Chevrolet", "Corvette Z06", "USA", 2023, new Features("V8", 670, "Gasoline"), 110000),
                new Car("Toyota", "GR Supra", "Japan", 2022, new Features("I6", 382, "Gasoline"), 55000),
                new Car("Nissan", "GT-R Nismo", "Japan", 2021, new Features("V6", 600, "Gasoline"), 210000),
                new Car("Mercedes-Benz", "AMG GT Black Series", "Germany", 2021, new Features("V8", 720, "Gasoline"), 325000)
            };

            currentCustomer = new Customer("Ivan", new MailAddress("ivan@gmail.com"), new List<string> { }, 40000000);
        }

        private void SearchCars()
        {
            string brand = brandTextBox.Text.Trim();
            string yearText = yearTextBox.Text.Trim();
            string maxPrice = maxPriceTextBox.Text.Trim();

            

            int.TryParse(yearText, out int yearInt);
            double.TryParse(maxPrice, out double maxPriceInt);

            currentCustomer.DesiredBrands = new List<string> { brand };
            currentCustomer.MaxBudget = maxPriceInt;

            var filteredCars = carDatabase
                .Where(car => (car.Brand.Contains(brand, StringComparison.OrdinalIgnoreCase)) && (yearInt == 0 || car.ReleaseYear == yearInt))
                .Where(car => currentCustomer.DesiredBrands.Contains(car.Brand) && car.Price <= currentCustomer.MaxBudget)
                .ToList();

            listBox1.Items.Clear();
            if (filteredCars.Any())
            {
                foreach (var car in filteredCars)
                {
                    listBox1.Items.Add(car.ToString());
                }
            }
            else
            {
                listBox1.Items.Add("No results found.");
            }
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            SearchCars();
        }

        
    }
}
