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
    /// <summary>
    /// Form that allows customers to log in to their account.
    /// </summary>  
    public partial class LoginForm : Form
    {
        private CustomerDataBase customerDataBase = new();
        public Customer currentCustomer;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string contactInfo = UserMailTextBox.Text.Trim();
            string password = UserPasswordTextBox.Text.Trim();

            if (contactInfo == "admin" && password == "adminAutoMatcher")
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
                return;
            }

            bool validationResult = new Customer(contactInfo, password).ValidateLoginData();

            customerDataBase.DeserializeData("CustomerDataBase.txt");

            

            if (validationResult)
            {
                Customer customerFromDB = customerDataBase.GetCustomerByData(contactInfo, password);

                if (customerFromDB != null)
                {
                    currentCustomer = customerFromDB;
                    MessageBox.Show("Login successful!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
            }

        }

        private void LoginCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
