using CarShowroom.Models;
using System.Net.Mail;

namespace CarShowroom
{
    public partial class MainForm : Form
    {

        private CarDataBase carDatabase;
        private Customer currentCustomer;
        public MainForm()
        {
            InitializeComponent();
            InitializeTestData();
        }

        public void InitializeTestData()
        {
            carDatabase = new CarDataBase();
            carDatabase.DeserializeData("CarDataBase.txt");

            currentCustomer = new Customer("Ivan", new MailAddress("ivan@gmail.com"), new List<string> { }, 40000000, 50000000000);
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

            var filteredCars = carDatabase.Cars
                .Where(car => (car.Brand.Contains(brand)) && (yearInt == 0 || car.ReleaseYear == yearInt))
                .Where(car => currentCustomer.DesiredBrands.Contains(car.Brand) && car.Price <= currentCustomer.MaxBudget)
                .ToList();

            carBindingSource.DataSource = filteredCars;
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            SearchCars();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewUserForm().ShowDialog();
        }
    }
}
//data gride view
