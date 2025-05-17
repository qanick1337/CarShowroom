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
        private CustomerDataBase customerDataBase = new();

        public NewUserForm()
        {
            InitializeComponent();
        }
        List<string> userBrands = new List<string>();

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

            if (!string.IsNullOrEmpty(model) && !userBrands.Contains(model))
            {
                userBrands.Add(model);
                FavoriteModelsListBox.Items.Add(model);
                UserModelsTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid model name or the model already exists.");
            }
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            customerDataBase.DeserializeData("CustomerDataBase.txt");

            string userMail = UserMailTextBox.Text.Trim();
            string userPassword = UserPasswordTextBox.Text.Trim();

            double.TryParse(minPriceTextBox.Text.Trim(), out double userMinimumBudgetInt);
            double.TryParse(maxPriceTextBox.Text.Trim(), out double userMaximumBudgetInt);

            new Customer(userMail, userPassword, userBrands, userBrands, userMinimumBudgetInt, userMaximumBudgetInt).CustomerValidator();

        }
    }
}
