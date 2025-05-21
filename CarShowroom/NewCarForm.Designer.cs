namespace CarShowroom
{
    partial class NewCarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BrandTextBox = new TextBox();
            NewCarLabel = new Label();
            ModelTextBox = new TextBox();
            OriginCountryTextBox = new TextBox();
            CarInfoLabel = new Label();
            yearTextBox = new TextBox();
            carCharacteristicslabel = new Label();
            engineTextBox = new TextBox();
            horsePowerTextBox = new TextBox();
            fuelTextBox = new TextBox();
            ConditionComboBox = new ComboBox();
            label1 = new Label();
            AddCarButton = new Button();
            priceTextBox = new TextBox();
            SuspendLayout();
            // 
            // BrandTextBox
            // 
            BrandTextBox.BackColor = Color.White;
            BrandTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BrandTextBox.Location = new Point(51, 135);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.PlaceholderText = "Brand";
            BrandTextBox.Size = new Size(278, 34);
            BrandTextBox.TabIndex = 1;
            // 
            // NewCarLabel
            // 
            NewCarLabel.Anchor = AnchorStyles.Top;
            NewCarLabel.AutoSize = true;
            NewCarLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NewCarLabel.ForeColor = Color.FromArgb(0, 123, 255);
            NewCarLabel.Location = new Point(318, 9);
            NewCarLabel.Name = "NewCarLabel";
            NewCarLabel.Size = new Size(166, 51);
            NewCarLabel.TabIndex = 3;
            NewCarLabel.Text = "New car";
            // 
            // ModelTextBox
            // 
            ModelTextBox.BackColor = Color.White;
            ModelTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ModelTextBox.Location = new Point(51, 175);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.PlaceholderText = "Model";
            ModelTextBox.Size = new Size(278, 34);
            ModelTextBox.TabIndex = 2;
            // 
            // OriginCountryTextBox
            // 
            OriginCountryTextBox.BackColor = Color.White;
            OriginCountryTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OriginCountryTextBox.Location = new Point(51, 215);
            OriginCountryTextBox.Name = "OriginCountryTextBox";
            OriginCountryTextBox.PlaceholderText = "Country";
            OriginCountryTextBox.Size = new Size(278, 34);
            OriginCountryTextBox.TabIndex = 3;
            // 
            // CarInfoLabel
            // 
            CarInfoLabel.AutoSize = true;
            CarInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CarInfoLabel.Location = new Point(51, 100);
            CarInfoLabel.Name = "CarInfoLabel";
            CarInfoLabel.Size = new Size(225, 32);
            CarInfoLabel.TabIndex = 17;
            CarInfoLabel.Text = "📋Car information";
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.White;
            yearTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yearTextBox.Location = new Point(51, 255);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.PlaceholderText = "Year";
            yearTextBox.Size = new Size(278, 34);
            yearTextBox.TabIndex = 4;
            // 
            // carCharacteristicslabel
            // 
            carCharacteristicslabel.AutoSize = true;
            carCharacteristicslabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            carCharacteristicslabel.Location = new Point(477, 100);
            carCharacteristicslabel.Name = "carCharacteristicslabel";
            carCharacteristicslabel.Size = new Size(256, 32);
            carCharacteristicslabel.TabIndex = 19;
            carCharacteristicslabel.Text = "⚙️Car characteristics";
            // 
            // engineTextBox
            // 
            engineTextBox.BackColor = Color.White;
            engineTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            engineTextBox.Location = new Point(477, 135);
            engineTextBox.Name = "engineTextBox";
            engineTextBox.PlaceholderText = "Engine";
            engineTextBox.Size = new Size(278, 34);
            engineTextBox.TabIndex = 6;
            // 
            // horsePowerTextBox
            // 
            horsePowerTextBox.BackColor = Color.White;
            horsePowerTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            horsePowerTextBox.Location = new Point(477, 175);
            horsePowerTextBox.Name = "horsePowerTextBox";
            horsePowerTextBox.PlaceholderText = "Horse powers ";
            horsePowerTextBox.Size = new Size(278, 34);
            horsePowerTextBox.TabIndex = 7;
            // 
            // fuelTextBox
            // 
            fuelTextBox.BackColor = Color.White;
            fuelTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fuelTextBox.Location = new Point(477, 215);
            fuelTextBox.Name = "fuelTextBox";
            fuelTextBox.PlaceholderText = "Fuel type";
            fuelTextBox.Size = new Size(278, 34);
            fuelTextBox.TabIndex = 8;
            // 
            // ConditionComboBox
            // 
            ConditionComboBox.BackColor = Color.White;
            ConditionComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConditionComboBox.ForeColor = Color.FromArgb(33, 37, 41);
            ConditionComboBox.Items.AddRange(new object[] { "New", "Used" });
            ConditionComboBox.Location = new Point(610, 253);
            ConditionComboBox.Name = "ConditionComboBox";
            ConditionComboBox.Size = new Size(145, 36);
            ConditionComboBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(477, 255);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 24;
            label1.Text = "Condition";
            // 
            // AddCarButton
            // 
            AddCarButton.BackColor = Color.FromArgb(0, 123, 255);
            AddCarButton.FlatStyle = FlatStyle.Popup;
            AddCarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddCarButton.ForeColor = Color.White;
            AddCarButton.Location = new Point(350, 349);
            AddCarButton.Name = "AddCarButton";
            AddCarButton.Size = new Size(113, 44);
            AddCarButton.TabIndex = 25;
            AddCarButton.Text = "Add car";
            AddCarButton.UseVisualStyleBackColor = false;
            AddCarButton.Click += AddCarButton_Click;
            // 
            // priceTextBox
            // 
            priceTextBox.BackColor = Color.White;
            priceTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            priceTextBox.Location = new Point(51, 295);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.PlaceholderText = "Price";
            priceTextBox.Size = new Size(278, 34);
            priceTextBox.TabIndex = 5;
            // 
            // NewCarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 450);
            Controls.Add(priceTextBox);
            Controls.Add(AddCarButton);
            Controls.Add(label1);
            Controls.Add(ConditionComboBox);
            Controls.Add(fuelTextBox);
            Controls.Add(horsePowerTextBox);
            Controls.Add(engineTextBox);
            Controls.Add(carCharacteristicslabel);
            Controls.Add(yearTextBox);
            Controls.Add(CarInfoLabel);
            Controls.Add(OriginCountryTextBox);
            Controls.Add(ModelTextBox);
            Controls.Add(NewCarLabel);
            Controls.Add(BrandTextBox);
            MinimumSize = new Size(810, 506);
            Name = "NewCarForm";
            Text = "NewCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BrandTextBox;
        private Label NewCarLabel;
        private TextBox ModelTextBox;
        private TextBox OriginCountryTextBox;
        private Label CarInfoLabel;
        private TextBox yearTextBox;
        private Label carCharacteristicslabel;
        private TextBox engineTextBox;
        private TextBox horsePowerTextBox;
        private TextBox fuelTextBox;
        private ComboBox ConditionComboBox;
        private Label label1;
        private Button AddCarButton;
        private TextBox priceTextBox;
    }
}