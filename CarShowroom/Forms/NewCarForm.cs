using System;
using CarShowroom.Models;
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
    public partial class NewCarForm : Form
    {
        public Car carToAdd = new();
        public NewCarForm()
        {
            InitializeComponent();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            string brand = BrandTextBox.Text.Trim();
            string model = ModelTextBox.Text.Trim();
            string originCountry = OriginCountryTextBox.Text.Trim();
            int.TryParse(yearTextBox.Text.Trim(), out int yearInt);
            int.TryParse(priceTextBox.Text.Trim(), out int priceInt);
            string condition = ConditionComboBox.SelectedItem as string ?? string.Empty;

            Car.CarCondition carCondition = condition == "New" ? Car.CarCondition.New : Car.CarCondition.Used;


            string engine = engineTextBox.Text.Trim();
            int.TryParse(horsePowerTextBox.Text.Trim(), out int horsePowerInt);
            string fuelType = fuelTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(brand) ||
                string.IsNullOrWhiteSpace(model) ||
                string.IsNullOrWhiteSpace(originCountry) ||
                string.IsNullOrWhiteSpace(engine) ||
                string.IsNullOrWhiteSpace(fuelType))
            {
                MessageBox.Show("Please, fill all text fields");
                return;
            }

            if (yearInt > DateTime.Now.Year)
            {
                MessageBox.Show("Please, enter a valid year");
                return;
            }
            if (horsePowerInt <= 0)
            {
                MessageBox.Show("Please, enter a valid horse power");
                return;
            }
            if (priceInt <= 0)
            {
                MessageBox.Show("Please, enter a valid price");
                return;

            }
            if (condition != "New" && condition != "Used")
            {
                MessageBox.Show("Please, select a valid condition");
                return;
            }

            carToAdd = new(brand, model, originCountry, yearInt, new Features(engine, horsePowerInt, fuelType), priceInt, carCondition);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
