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

namespace CarShowroom
{
    public partial class NewUserForm : Form
    {
        public CustomerDataBase customerDataBase = new();
        public Customer newCustomer;

        List<string> userBrands = new List<string>();
        List<string> userModels = new List<string>();
        public NewUserForm()
        {
            InitializeComponent();
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
            customerDataBase.DeserializeData("CustomerDataBase.txt");

            string userMail = UserMailTextBox.Text.Trim();
            string userPassword = UserPasswordTextBox.Text.Trim();

            double.TryParse(minPriceTextBox.Text.Trim(), out double userMinimumBudgetInt);
            double.TryParse(maxPriceTextBox.Text.Trim(), out double userMaximumBudgetInt);

            Customer customerToCheck = new Customer(userMail, userPassword, userBrands, userModels, userMinimumBudgetInt, userMaximumBudgetInt);
            customerToCheck.CustomerValidator();

            if (customerToCheck.CustomerValidator())
            {
                newCustomer = customerToCheck;
                customerDataBase.AddCustomer(customerToCheck);
                customerDataBase.SerializeData("CustomerDataBase.txt");

                MessageBox.Show("User added successfully!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RetryButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
    }
}
