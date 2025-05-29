using CarShowroom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarShowroom.ProjectModel;

namespace CarShowroom
{
    /// <summary>
    /// Form that allows customers to create account.
    /// </summary>
    public partial class NewUserForm : Form
    {
        /// <summary> Database for customers </summary>
        public CustomerDataBase customerDataBase = new();

        /// <summary> New customer that will be created </summary>
        public Customer newCustomer;

        public CarShowroom.ProjectModel.ProjectModel projectModel;

        List<string> userBrands = new List<string>();
        List<string> userModels = new List<string>();
        public NewUserForm(CarShowroom.ProjectModel.ProjectModel project)
        {
            InitializeComponent();
            projectModel = project;
        }

        private void AddBrandButton_Click(object sender, EventArgs e)
        {
            string brand = UserBrandsTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(brand) && !userBrands.Contains(brand))
            {
                userBrands.Add(brand);
                FavoriteBrandsListBox.Items.Add(brand);
                UserBrandsTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid brand name or the brand already exists.");
            }
        }

        private void AddModelTextBox_Click(object sender, EventArgs e)
        {
            string model = UserModelsTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(model) && !userModels.Contains(model))
            {
                userModels.Add(model);
                FavoriteModelsListBox.Items.Add(model);
                UserModelsTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid model name or the model already exists.");
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            customerDataBase.DeserializeData(projectModel.CustomerPath);

            string userMail = UserMailTextBox.Text.Trim();
            string userPassword = UserPasswordTextBox.Text.Trim();

            string minBudgetStr = minPriceTextBox.Text.Trim();
            string maxBudgetStr = maxPriceTextBox.Text.Trim();

            if (!double.TryParse(minBudgetStr, out double userMinimumBudgetDouble) || !double.TryParse(maxBudgetStr, out double userMaximumBudgetDouble))
            {
                MessageBox.Show("Minimum and maximum budget must be valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer customerToCheck = new Customer(userMail, userPassword, userBrands, userModels, userMinimumBudgetDouble, userMaximumBudgetDouble);

            try
            {
                if (customerToCheck.CustomerValidator())
                {
                    newCustomer = customerToCheck;
                    customerDataBase.AddCustomer(customerToCheck);
                    customerDataBase.SerializeData(projectModel.CustomerPath);

                    MessageBox.Show("User added successfully!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
