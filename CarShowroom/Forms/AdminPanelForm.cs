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
    public partial class AdminPanelForm : Form
    {
        public CarDataBase carDatabase = new();
        public CustomerDataBase customerDatabase = new();
        public ApplicationDataBase applicationsDataBase = new();

        private CarShowroom.ProjectModel.ProjectModel projectModel;

        public AdminPanelForm(CarShowroom.ProjectModel.ProjectModel project)
        {

            InitializeComponent();

            carDatabase = project.CarDatabase;
            customerDatabase = project.CustomerDatabase;
            applicationsDataBase = project.ApplicationDatabase;

            projectModel = project;

            InitializeData();
            InitializeUI();
        }

        private void InitializeData()
        {
            carApplicationBindingSource.DataSource = applicationsDataBase.Applications;
            customerBindingSource.DataSource = customerDatabase.Customers;
            carBindingSource.DataSource = carDatabase.Cars;
        }

        private void InitializeUI()
        {
            adminTabControl.SelectedIndex = 0;
            MenuToogler(0);
        }
        private void RefreshAndSave(BindingSource source, object dataSource)
        {
            source.DataSource = null;
            source.DataSource = dataSource;
            projectModel.SaveData(projectModel.CarPath, projectModel.CustomerPath, projectModel.ApplicationPath);
        }

        private void MenuToogler(int index)
        {
            if (index == 0)
            {
                deleteCarToolStripMenuItem.Visible = true;
                deleteCustomerToolStripMenuItem.Visible = false;
                deleteApplicationToolStripMenuItem.Visible = false;
            }
            else if (index == 1)
            {
                deleteCarToolStripMenuItem.Visible = false;
                deleteCustomerToolStripMenuItem.Visible = true;
                deleteApplicationToolStripMenuItem.Visible = false;
            }
            else if (index == 2)
            {
                deleteCarToolStripMenuItem.Visible = false;
                deleteCustomerToolStripMenuItem.Visible = false;
                deleteApplicationToolStripMenuItem.Visible = true;
            }
        }
        private void AdminPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            projectModel.SaveData(projectModel.CarPath, projectModel.CustomerPath, projectModel.ApplicationPath);
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using NewCarForm newCarForm = new();
            var result = newCarForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                carDatabase.AddCar(newCarForm.carToAdd);
                RefreshAndSave(carBindingSource, carDatabase.Cars);
            }
        }

        private void closeAdminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (carBindingSource.Current is Car selectedCar)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete the car: {selectedCar.DisplayString()}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    carDatabase.RemoveCar(selectedCar);
                    RefreshAndSave(carBindingSource, carDatabase.Cars);
                }
            }
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerBindingSource.Current is Customer selectedCustomer)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete the customer: {selectedCustomer.ContactInfo}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    customerDatabase.RemoveCustomer(selectedCustomer);
                    RefreshAndSave(customerBindingSource, customerDatabase.Customers);
                }
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (carApplicationBindingSource.Current is CarApplication selectedApplication)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete the application: {selectedApplication.DisplayId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    if (applicationsDataBase.RemoveApplication(selectedApplication.Id))
                    {
                        RefreshAndSave(carApplicationBindingSource, applicationsDataBase.Applications);
                    }                  
                }
            }
        }

        private void adminTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adminTabControl.SelectedIndex == 0)
            {
                MenuToogler(0);
            }
            else if (adminTabControl.SelectedIndex == 1)
            {
                MenuToogler(1);
            }
            else if (adminTabControl.SelectedIndex == 2)
            {
                MenuToogler(2);
            }
        }
    }
}
