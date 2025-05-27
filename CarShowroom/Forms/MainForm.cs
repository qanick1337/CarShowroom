using CarShowroom.Models;
using System.Net.Mail;
using System.Reflection;
using CarShowroom.ProjectModel;

namespace CarShowroom
{
    public partial class MainForm : Form
    {
        //public CarShowroom.ProjectModel.ProjectModel Project = new("CarDataBase.txt", "CustomerDataBase.txt", "ApplicationsDataBase.txt");

        private CarDataBase carDatabase;
        private CustomerDataBase customerDatabase;
        private ApplicationDataBase applicationsDataBase;

        private List<string> brands;
        private Customer currentCustomer;

        private List<Car> filteredCars = new List<Car>();

        private List<Car> selectedCars = new List<Car>();

        private bool isUserLoggedIn = false;
        public MainForm()
        {
            InitializeComponent();
            InitializeControlLayout();
            InitializeData();

        }

        public void InitializeData()
        {
            LoadDataBases();
            //GenerateTestData();
            LoadBrands();
            ResetComboBoxSelection();
            UpdateMenuVisibility();
        }
        public void InitializeControlLayout()
        {
            AutoFindButton.Visible = false;
        }

        // Load data from files
        public void LoadDataBases()
        {
            carDatabase = new CarDataBase();
            carDatabase.DeserializeData("CarDataBase.txt");

            customerDatabase = new CustomerDataBase();
            customerDatabase.DeserializeData("CustomerDataBase.txt");

            applicationsDataBase = new ApplicationDataBase();
            applicationsDataBase.DeserializeData("ApplicationsDataBase.txt");
        }
        public void LoadBrands()
        {
            brands = carDatabase.Cars
               .Select(car => car.Brand)
               .Distinct()
               .OrderBy(brand => brand)
               .ToList();

            BindingSource brandsBindingSource = new BindingSource();
            brandsBindingSource.DataSource = brands;

            BrandsComboBox.DataSource = brandsBindingSource;
        }
        private void ResetComboBoxSelection()
        {
            BrandsComboBox.Text = string.Empty;
            BrandsComboBox.SelectedIndex = -1;
            BrandLabel.Visible = true;
        }
        private void UpdateMenuVisibility()
        {
            SignOutToolStripMenuItem.Visible = false;
            UserNameToolStripMenuItem.Visible = false;
        }

        //Work with test data 
        public void GenerateTestData()
        {
            carDatabase = new CarDataBase();
            carDatabase.GenerateTestData();
            carDatabase.SerializeData("CarDataBase.txt");

            customerDatabase = new CustomerDataBase();
            customerDatabase.GenerateData();
            customerDatabase.SerializeData("CustomerDataBase.txt");

            applicationsDataBase = new ApplicationDataBase();
            applicationsDataBase.GenerateTestData();
            applicationsDataBase.SerializeData("ApplicationsDataBase.txt");
        }
        // Menu items
        private void CreateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using NewUserForm newUserForm = new();
            var result = newUserForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                currentCustomer = newUserForm.newCustomer;
                customerDatabase = newUserForm.customerDataBase;
                isUserLoggedIn = true;

                UpdateUIAfterLogIn();
            }
            else if (result == DialogResult.Retry)
            {
                using LoginForm loginForm = new();
                var logresult = loginForm.ShowDialog();

                if (logresult == DialogResult.OK)
                {
                    currentCustomer = loginForm.currentCustomer;
                    isUserLoggedIn = true;

                    UpdateUIAfterLogIn();
                }
            }
        }
        private void LogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using LoginForm loginForm = new();
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                currentCustomer = loginForm.currentCustomer;
                isUserLoggedIn = true;

                UpdateUIAfterLogIn();
            }
            else if (result == DialogResult.Retry)
            {
                using NewUserForm newUserForm = new();
                var newresult = newUserForm.ShowDialog();
                if (newresult == DialogResult.OK)
                {
                    currentCustomer = newUserForm.newCustomer;
                    isUserLoggedIn = true;
                    UpdateUIAfterLogIn();
                }
            }
            else if (result == DialogResult.Yes)
            {
                using AdminPanelForm adminForm = new(carDatabase, customerDatabase, applicationsDataBase);
                adminForm.ShowDialog();

                 carDatabase = adminForm.carDatabase;
                 customerDatabase = adminForm.customerDatabase;
                 applicationsDataBase = adminForm.applicationsDataBase;

                carBindingSource.DataSource = null;
                carBindingSource.DataSource = carDatabase.Cars;

                LoadBrands();
            }
        }
        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentCustomer = null;
            isUserLoggedIn = false;

            LogInToolStripMenuItem.Visible = true;
            CreateAccountToolStripMenuItem.Visible = true;

            UserNameToolStripMenuItem.Visible = false;
            SignOutToolStripMenuItem.Visible = false;

            InitializeControlLayout();

            filteredCars.Clear();

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using NewUserForm newUserForm = new();
            var result = newUserForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                currentCustomer = newUserForm.newCustomer;
                isUserLoggedIn = true;

                UpdateUIAfterLogIn();
            }
            else if (result == DialogResult.Retry)
            {
                using LoginForm loginForm = new();
                var logresult = loginForm.ShowDialog();

                if (logresult == DialogResult.OK)
                {
                    currentCustomer = loginForm.currentCustomer;
                    isUserLoggedIn = true;

                    UpdateUIAfterLogIn();
                }
            }
        }
        private void logInToolStripMenuItemU_Click(object sender, EventArgs e)
        {
            using LoginForm loginForm = new();
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                currentCustomer = loginForm.currentCustomer;
                isUserLoggedIn = true;

                UpdateUIAfterLogIn();
            }
            else if (result == DialogResult.Retry)
            {
                using NewUserForm newUserForm = new();
                var newresult = newUserForm.ShowDialog();
                if (newresult == DialogResult.OK)
                {
                    currentCustomer = newUserForm.newCustomer;
                    isUserLoggedIn = true;
                    UpdateUIAfterLogIn();
                }
            }
        }
        private void UpdateUIAfterLogIn()
        {
            LogInToolStripMenuItem.Visible = false;
            CreateAccountToolStripMenuItem.Visible = false;
            UserNameToolStripMenuItem.Text = currentCustomer.ContactInfo;
            UserNameToolStripMenuItem.Visible = true;
            SignOutToolStripMenuItem.Visible = true;

            Find_button.Location = new Point(159, 167);
            AutoFindButton.Visible = true;
        }

        // Find cars
        private void Find_button_Click(object sender, EventArgs e)
        {

            string brand = BrandsComboBox.SelectedItem as string ?? string.Empty;
            string model = ModelsComboBox.SelectedItem as string ?? string.Empty;
            string condition = ConditionComboBox.SelectedItem as string ?? string.Empty;

            int.TryParse(yearTextBox.Text.Trim(), out int yearInt);
            int.TryParse(minPriceTextBox.Text.Trim(), out int minPriceInt);
            int.TryParse(maxPriceTextBox.Text.Trim(), out int maxPriceInt);

            filteredCars = carDatabase.FilterDataBase(brand, model, yearInt, condition, minPriceInt, maxPriceInt).ToList();

            carBindingSource.DataSource = filteredCars;
            dataGridView1.ClearSelection();

        }
        private void AutoFindButton_Click(object sender, EventArgs e)
        {
            var brands = currentCustomer.DesiredBrands ?? new List<string>();
            var models = currentCustomer.DesiredBrandsModels ?? new List<string>();
            double minBudget = currentCustomer.MinBudget;
            double maxBudget = currentCustomer.MaxBudget;

            filteredCars = carDatabase.Cars
                .Where(car =>
                    (brands.Count == 0 || brands.Any(b => string.Equals(car.Brand, b, StringComparison.OrdinalIgnoreCase))) &&
                    (models.Count == 0 || models.Any(m => string.Equals(car.Model, m, StringComparison.OrdinalIgnoreCase))) &&
                    car.Price >= minBudget &&
                    car.Price <= maxBudget)
                .ToList();

            carBindingSource.DataSource = filteredCars;
            dataGridView1.ClearSelection();
        }

        //UI changes
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
        private void ConditionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConditionLabel.Visible = false;
        }
        private void ConditionComboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLabelVisibility(ConditionComboBox, ConditionLabel);
        }
        private void BrandsComboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLabelVisibility(BrandsComboBox, BrandLabel);
        }
        private void ModelsComboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLabelVisibility(ModelsComboBox, ModelLabel);
        }
        private void UpdateLabelVisibility(ComboBox comboBox, Label label)
        {
            label.Visible = string.IsNullOrWhiteSpace(comboBox.Text);
        }

        //DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectedCars.Clear();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.DataBoundItem is Car car)
                {
                    if (!selectedCars.Contains(car))
                    {
                        selectedCars.Add(car);
                    }
                }
            }
        }
        //private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        //{
        //    MessageBox.Show($"Error: {e.Exception.Message}", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    e.ThrowException = false;
        //}

        //Car Applications
        private void SubmitApplicationButton_Click(object sender, EventArgs e)
        {
            if (currentCustomer == null)
            {
                MessageBox.Show("Please log in to submit an application.");
                return;
            }

            if (selectedCars.Count == 0)
            {
                MessageBox.Show("Please select at least one car before submitting.");
                return;
            }

            CarApplication application = applicationsDataBase.AddApplication(currentCustomer.ContactInfo, new List<Car>(selectedCars));
            applicationsDataBase.SerializeData("ApplicationsDataBase.txt");
            MessageBox.Show($"Application submitted with ID: {application.Id}");

            selectedCars.Clear();

            dataGridView1.ClearSelection();

        }
    }
}
