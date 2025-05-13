using CarShowroom.Models;
using System.Net.Mail;

namespace CarShowroom
{
    public partial class MainForm : Form
    {

        private CarDataBase carDatabase;
        public MainForm()
        {
            InitializeComponent();
            InitializeTestData();
        }

        public void InitializeTestData()
        {
            carDatabase = new CarDataBase();
            carDatabase.DeserializeData("CarDataBase.txt");

            for (int i = 0; i < carDatabase.Cars.Count; i++)
            {
                if (!BrandsComboBox.Items.Contains(carDatabase.Cars[i].Brand))
                {
                    BrandsComboBox.Items.Add(carDatabase.Cars[i].Brand);
                }
            }
        }

        private void SearchCars()
        {
            string brand = BrandsComboBox.SelectedItem as string ?? string.Empty;
            brandTextBox.Text = brand;

            string yearText = yearTextBox.Text.Trim();
            string minPrice = minPriceTextBox.Text.Trim();
            string maxPrice = maxPriceTextBox.Text.Trim();

            int.TryParse(yearText, out int yearInt);
            int.TryParse(maxPrice, out int maxPriceInt);
            int.TryParse(minPrice, out int minPriceInt);

            var filteredCars = carDatabase.FilterDataBase(brand, minPriceInt, maxPriceInt).ToList();

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

        private void BrandsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrandLabel.Visible = false;
            string brand = BrandsComboBox.SelectedItem as string ?? string.Empty;

            ModelsComboBox.Items.Clear();
            ModelsComboBox.Text = string.Empty;

            foreach (var car in carDatabase.Cars)
            {
                if (car.Brand == brand && !ModelsComboBox.Items.Contains(car.Model))
                {
                    ModelsComboBox.Items.Add(car.Model);
                }
            }
        }
    }
}
//data gride view
