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
    public partial class LoginForm : Form
    {
        private CustomerDataBase customerDataBase = new();
        private Customer currentCustomer;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string contactInfo = UserMailTextBox.Text.Trim();
            string password = UserPasswordTextBox.Text.Trim();

            currentCustomer = new Customer(contactInfo, password);
            currentCustomer.ValidateLoginData();

            if (currentCustomer.ValidateLoginData())
            {
                customerDataBase.DeserializeData("CustomerDataBase.txt");
                if (customerDataBase.isUserExist(currentCustomer.ContactInfo, currentCustomer.Password))
                {
                    MessageBox.Show("Login successful!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }
    }
}
