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
    public partial class AdminPanelForm : Form
    {
        private CarDataBase carDatabase = new();
        private CustomerDataBase customerDatabase = new();
        private ApplicationDataBase applicationsDataBase = new();

        public AdminPanelForm(CarDataBase carDb, CustomerDataBase customerDb, ApplicationDataBase appDb)
        {
            InitializeComponent();
            carDatabase = carDb;
            customerDatabase = customerDb;
            applicationsDataBase = appDb;
            InitializeData();
        }

        public void InitializeData()
        {
            carApplicationBindingSource.DataSource = applicationsDataBase.Applications;
            customerBindingSource.DataSource = customerDatabase.Customers;
            carBindingSource.DataSource = carDatabase.Cars;
        }

        private void AdminPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            carDatabase.SerializeData("CarDataBase.txt");
            customerDatabase.SerializeData("CustomerDataBase.txt");
            applicationsDataBase.SerializeData("ApplicationsDataBase.txt");
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using NewCarForm newCarForm = new();
            var result = newCarForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                carDatabase.AddCar(newCarForm.carToAdd);
                carBindingSource.DataSource = null;
                carBindingSource.DataSource = carDatabase.Cars;

                carDatabase.SerializeData("CarDataBase.txt");
            }
        }

        private void closeAdminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
