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
    /// <summary>
    /// Form for adding or editing car details in the car showroom application.
    /// </summary>
    public partial class NewCarForm : Form
    {
        /// <summary> Car object to be added or edited.</summary>
        public Car carToAdd = new();

        /// <summary>
        /// Constructor for NewCarForm in add mode.
        /// </summary>
        public NewCarForm()
        {
            InitializeComponent();
            InitializeAddMode();
        }

        /// <summary>
        /// Constructor for NewCarForm in edit mode with a selected car.
        /// </summary>
        public NewCarForm(Car selectedCar)
        {
            InitializeComponent();
            InitializeEditMode(selectedCar);
        }

        private void InitializeAddMode()
        {
            NewCarLabel.Text = "Add New Car";
            AddCarButton.Visible = true;
            SaveCarDetails.Visible = false;
            ConditionComboBox.SelectedIndex = 0;
        }

        private void InitializeEditMode(Car selectedCar)
        {
            BrandTextBox.Text = selectedCar.Brand;
            ModelTextBox.Text = selectedCar.Model;
            OriginCountryTextBox.Text = selectedCar.OriginCountry;
            yearTextBox.Text = selectedCar.ReleaseYear.ToString();
            engineTextBox.Text = selectedCar.Features.Engine;
            horsePowerTextBox.Text = selectedCar.Features.HorsePowers.ToString();
            fuelTextBox.Text = selectedCar.Features.FuelType;
            priceTextBox.Text = selectedCar.Price.ToString();
            ConditionComboBox.SelectedItem = selectedCar.Condition.ToString();

            NewCarLabel.Text = "Edit Car Details";
            AddCarButton.Visible = false;
        }
        private void AddCarButton_Click(object sender, EventArgs e)
        {
            var selectedCar = CarEditor();
            if (selectedCar != null)
            {
                carToAdd = selectedCar;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SaveCarDetails_Click(object sender, EventArgs e)
        {
            var selectedCar = CarEditor();

            if (selectedCar != null)
            {
                carToAdd = selectedCar;
                DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private bool ValidateCarDetails()
        {
            string brand = BrandTextBox.Text.Trim();
            string model = ModelTextBox.Text.Trim();
            string originCountry = OriginCountryTextBox.Text.Trim();
            string condition = ConditionComboBox.SelectedItem as string ?? string.Empty;
            string engine = engineTextBox.Text.Trim();
            string fuelType = fuelTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(brand) ||
                string.IsNullOrWhiteSpace(model) ||
                string.IsNullOrWhiteSpace(originCountry) ||
                string.IsNullOrWhiteSpace(engine) ||
                string.IsNullOrWhiteSpace(fuelType))
            {
                MessageBox.Show("Please, fill all text fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(yearTextBox.Text.Trim(), out int yearInt) || yearInt < 1900 || yearInt > DateTime.Now.Year)
            {
                MessageBox.Show("Please, enter a valid year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(priceTextBox.Text.Trim(), out int priceInt) || priceInt <= 0)
            {
                MessageBox.Show("Please, enter a valid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(horsePowerTextBox.Text.Trim(), out int horsePowerInt) || horsePowerInt <= 0)
            {
                MessageBox.Show("Please, enter a valid horse power", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (condition != "New" && condition != "Used")
            {
                MessageBox.Show("Please, select a valid condition", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private Car? CarEditor()
        {
            if( !ValidateCarDetails())
            {
                return null;
            }

            string brand = BrandTextBox.Text.Trim();
            string model = ModelTextBox.Text.Trim();
            string originCountry = OriginCountryTextBox.Text.Trim();
            string engine = engineTextBox.Text.Trim();
            string fuelType = fuelTextBox.Text.Trim();

            int.TryParse(yearTextBox.Text.Trim(), out int yearInt);
            int.TryParse(priceTextBox.Text.Trim(), out int priceInt);
            int.TryParse(horsePowerTextBox.Text.Trim(), out int horsePowerInt);

            string condition = ConditionComboBox.SelectedItem as string ?? string.Empty;
            Car.CarCondition carCondition = condition == "New" ? Car.CarCondition.New : Car.CarCondition.Used;

            return new Car(brand, model, originCountry, yearInt, new Features(engine, horsePowerInt, fuelType), priceInt, carCondition);
        }
    }
}
