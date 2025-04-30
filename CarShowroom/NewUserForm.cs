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

        private void Find_button_Click(object sender, EventArgs e)
        {
            string userName = UserNameTextBox.Text.Trim();
            string userEmail = UserMailTextBox.Text.Trim();
            string userMinimumBudget = minPriceTextBox.Text.Trim();
            string userMaximumBudget = maxPriceTextBox.Text.Trim();

            double.TryParse(userMinimumBudget, out double userMinimumBudgetInt);
            double.TryParse(userMaximumBudget, out double userMaximumBudgetInt);

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(userMinimumBudget) || string.IsNullOrEmpty(userMaximumBudget))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
        }
    }
}
