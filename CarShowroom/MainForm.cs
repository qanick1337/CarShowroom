using CarShowroom.Models;
using System.Net.Mail;

namespace CarShowroom
{
    public partial class MainForm : Form
    {

        private CarDataBase carDatabase;
        private CustomerDataBase customerDatabase;
        private List<string> brands;
        private bool isUserLoggedIn = false;
        public MainForm()
        {
            InitializeComponent();
            InitializeData();
        }

        public void InitializeData()
        {
            carDatabase = new CarDataBase();
            carDatabase.DeserializeData("CarDataBase.txt");

            customerDatabase = new CustomerDataBase();
            customerDatabase.GenerateData();
            customerDatabase.SerializeData("CustomerDataBase.txt");
            //customerDatabase.DeserializeData("CustomerDataBase.txt");

            brands = carDatabase.Cars.Select(car => car.Brand).Distinct().ToList();
            BrandLabel.Visible = true;


            BindingSource brandsBindingSource = new BindingSource();
            brandsBindingSource.DataSource = brands;
            BrandsComboBox.DataSource = brandsBindingSource;
            BrandsComboBox.Text = string.Empty;
            BrandsComboBox.SelectedIndex = -1;
            BrandLabel.Visible = true;
        }

        private void SearchCars()
        {
            string brand = BrandsComboBox.SelectedItem as string ?? string.Empty;
            string model = ModelsComboBox.SelectedItem as string ?? string.Empty;
            string condition = ConditionComboBox.SelectedItem as string ?? string.Empty;

            int.TryParse(yearTextBox.Text.Trim(), out int yearInt);
            int.TryParse(minPriceTextBox.Text.Trim(), out int minPriceInt);
            int.TryParse(maxPriceTextBox.Text.Trim(), out int maxPriceInt);

            var filteredCars = carDatabase.FilterDataBase(brand, model, yearInt, condition, minPriceInt, maxPriceInt).ToList();

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

        private void BrandsComboBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BrandsComboBox.Text))
            {
                BrandLabel.Visible = true;
            }
            else
            {
                BrandLabel.Visible = false;
            }
        }

        private void ModelsComboBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ModelsComboBox.Text))
            {
                ModelLabel.Visible = true;
            }
            else
            {
                ModelLabel.Visible = false;
            }
        }

        private void ConditionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConditionLabel.Visible = false;
        }

        private void ConditionComboBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ConditionComboBox.Text))
            {
                ConditionLabel.Visible = true;
            }
            else
            {
                ConditionLabel.Visible = false;
            }
        }
    }
}
