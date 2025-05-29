using CarShowroom.Models;
using System.Net.Mail;
using System.Reflection;
using CarShowroom.ProjectModel;

namespace CarShowroom
{
    /// <summary> Main form of the car showroom application UI. </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Represents the project model containing all data and logic for the application.
        /// </summary>
        public CarShowroom.ProjectModel.ProjectModel Project = new("CarDataBase.txt", "CustomerDataBase.txt", "ApplicationsDataBase.txt");

        /// <summary> Constructor of MainForm class</summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeControlLayout();
            InitializeData();
        }

        /// <summary>
        /// Sets the initial visibility of certain UI controls.
        /// </summary>
        public void InitializeControlLayout()
        {
            AutoFindButton.Visible = false;
            CartPanel.Visible = false;
            CartButton.Visible = false;
        }

        /// <summary>
        /// Loads data, brand list, resets combo boxes, and updates UI based on login state.
        /// </summary>
        public void InitializeData()
        {
            LoadStorageInfo();
            LoadBrands();
            ResetComboBoxSelection();
            ToggleUserUI(Project.IsUserLoggedIn);
        }

        /// <summary>
        /// Loads car database and clears any selection in the DataGridView.
        /// </summary>
        public void LoadStorageInfo()
        {
            Project.LoadData();
            CarsDataGridView.ClearSelection();
        }

        /// <summary>
        /// Loads car brands into the brand ComboBox.
        /// </summary>
        public void LoadBrands()
        {
            Project.brands = Project.GetBrands();

            BindingSource brandsBindingSource = new BindingSource();
            brandsBindingSource.DataSource = Project.brands;

            BrandsComboBox.DataSource = brandsBindingSource;
        }

        private void ResetComboBoxSelection()
        {
            BrandsComboBox.Text = string.Empty;
            BrandsComboBox.SelectedIndex = -1;
            BrandLabel.Visible = true;
        }

        private void ToggleUserUI(bool loggedIn)
        {
            LogInToolStripMenuItem.Visible = !loggedIn;
            CreateAccountToolStripMenuItem.Visible = !loggedIn;
            UserNameToolStripMenuItem.Visible = loggedIn;
            SignOutToolStripMenuItem.Visible = loggedIn;
            AutoFindButton.Visible = loggedIn;
            CartButton.Visible = loggedIn;
            customizeToolStripMenuItem.Visible = !loggedIn;
            signOutToolStripMenuItemAdd.Visible = loggedIn;
            logInToolStripMenuItemU.Visible = !loggedIn;
        }

        private void FilterAndDisplayCars()
        {
            string brand = BrandsComboBox.SelectedItem as string ?? string.Empty;
            string model = ModelsComboBox.SelectedItem as string ?? string.Empty;
            string condition = ConditionComboBox.SelectedItem as string ?? string.Empty;

            int.TryParse(yearTextBox.Text.Trim(), out int yearInt);
            int.TryParse(minPriceTextBox.Text.Trim(), out int minPriceInt);
            int.TryParse(maxPriceTextBox.Text.Trim(), out int maxPriceInt);

            Project.filteredCars = Project.FilterCars(brand, model, yearInt, condition, minPriceInt, maxPriceInt).ToList();
            carBindingSource.DataSource = Project.filteredCars;
            CarsDataGridView.ClearSelection();
        }

        private void UpdateUIAfterLogIn()
        {
            UserNameToolStripMenuItem.Text = Project.CurrentCustomer.ContactInfo;
            ToggleUserUI(true);
        }

        private void UpdateUIAfterSignOut()
        {
            Project.CurrentCustomer = null;
            ToggleUserUI(false);
        }

        private void UpdateLabelVisibility(ComboBox comboBox, Label label)
        {
            label.Visible = string.IsNullOrWhiteSpace(comboBox.Text);
        }

        // UI events
        private void CreateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using NewUserForm newUserForm = new(Project);
            var result = newUserForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Project.CurrentCustomer = newUserForm.newCustomer;
                Project.CustomerDatabase = newUserForm.customerDataBase;

                UpdateUIAfterLogIn();
            }
        }
        private void LogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using LoginForm loginForm = new();
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Project.CurrentCustomer = loginForm.currentCustomer;

                UpdateUIAfterLogIn();
            }

            else if (result == DialogResult.Yes)
            {
                using AdminPanelForm adminForm = new(Project);
                adminForm.ShowDialog();

                Project.CarDatabase = adminForm.carDatabase;
                Project.CustomerDatabase = adminForm.customerDatabase;
                Project.ApplicationDatabase = adminForm.applicationsDataBase;

                carBindingSource.DataSource = null;
                carBindingSource.DataSource = Project.CarDatabase.Cars;

                LoadBrands();
            }
        }
        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUIAfterSignOut();
            InitializeControlLayout();
            Project.filteredCars.Clear();

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using NewUserForm newUserForm = new(Project);
            var result = newUserForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Project.CurrentCustomer = newUserForm.newCustomer;

                UpdateUIAfterLogIn();
            }
        }
        private void logInToolStripMenuItemU_Click(object sender, EventArgs e)
        {
            LogInToolStripMenuItem_Click(sender, e);
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            FilterAndDisplayCars();
        }
        private void AutoFindButton_Click(object sender, EventArgs e)
        {
           try
            {
                Project.filteredCars = Project.AutoFind();

                carBindingSource.DataSource = Project.filteredCars;
                CarsDataGridView.ClearSelection();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BrandsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrandLabel.Visible = false;
            string brand = BrandsComboBox.SelectedItem as string ?? string.Empty;

            ModelsComboBox.Items.Clear();
            ModelsComboBox.Text = string.Empty;

            foreach (var model in Project.GetModelsByBrand(brand))
            {
                ModelsComboBox.Items.Add(model);
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

            if (string.IsNullOrWhiteSpace(BrandsComboBox.Text))
            {
                ModelsComboBox.Items.Clear();
                ModelsComboBox.Text = string.Empty;
            }
        }
        private void ModelsComboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLabelVisibility(ModelsComboBox, ModelLabel);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Project.selectedCars.Clear();

            foreach (DataGridViewRow row in CarsDataGridView.SelectedRows)
            {
                if (row.DataBoundItem is Car car && !Project.selectedCars.Contains(car))
                    Project.selectedCars.Add(car);
            }
        }
        private void SubmitApplicationButton_Click(object sender, EventArgs e)
        {
            try
            {
                string result = Project.SubmitApplication(Project.selectedCars);
                MessageBox.Show($"Application submitted with ID: {result}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarsDataGridView.ClearSelection();
        }
        private void CartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Project.CurrentCustomer == null)
                {
                    MessageBox.Show("Please log in to view your applications.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CartPanel.Visible = true;
                var applications = Project.GetApplicationsByCustomerEmail(Project.CurrentCustomer.ContactInfo);
                CartTextBox.Text = string.Join(Environment.NewLine + Environment.NewLine, applications.Select(a => a.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading applications: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CloseCartButton_Click(object sender, EventArgs e)
        {
            CartPanel.Visible = false;
        }
        private void autoFindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoFindButton_Click(sender, e);
        }
        private void findACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterAndDisplayCars();
        }
        private void newApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmitApplicationButton_Click(sender, e);
        }
        private void signOutToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            SignOutToolStripMenuItem_Click(sender, e);

        }
        private void CarsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        private void myApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CartButton_Click(sender, e);
        }
    }
}
