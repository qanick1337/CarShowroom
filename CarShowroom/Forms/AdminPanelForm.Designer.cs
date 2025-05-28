namespace CarShowroom
{
    partial class AdminPanelForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            adminTabControl = new TabControl();
            tabCars = new TabPage();
            dataGridViewCars = new DataGridView();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            originCountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            releaseYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            featuresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            conditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carBindingSource = new BindingSource(components);
            tabCustomers = new TabPage();
            dataGridViewCustomers = new DataGridView();
            contactInfoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minBudgetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxBudgetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DesiredBrandsDisplay = new DataGridViewTextBoxColumn();
            DesiredModelsDisplay = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            tabApplications = new TabPage();
            dataGridViewApplications = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CarsDisplay = new DataGridViewTextBoxColumn();
            carApplicationBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            carToolStripMenuItem = new ToolStripMenuItem();
            closeAdminPanelToolStripMenuItem = new ToolStripMenuItem();
            deleteCarToolStripMenuItem = new ToolStripMenuItem();
            deleteCustomerToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            adminTabControl.SuspendLayout();
            tabCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            tabApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApplications).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carApplicationBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // adminTabControl
            // 
            adminTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminTabControl.Controls.Add(tabCars);
            adminTabControl.Controls.Add(tabCustomers);
            adminTabControl.Controls.Add(tabApplications);
            adminTabControl.Location = new Point(12, 51);
            adminTabControl.Name = "adminTabControl";
            adminTabControl.SelectedIndex = 0;
            adminTabControl.Size = new Size(1339, 434);
            adminTabControl.TabIndex = 0;
            adminTabControl.SelectedIndexChanged += adminTabControl_SelectedIndexChanged;
            // 
            // tabCars
            // 
            tabCars.Controls.Add(dataGridViewCars);
            tabCars.Location = new Point(4, 34);
            tabCars.Name = "tabCars";
            tabCars.Padding = new Padding(3);
            tabCars.Size = new Size(1331, 396);
            tabCars.TabIndex = 0;
            tabCars.Text = "Cars ";
            tabCars.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.AllowUserToAddRows = false;
            dataGridViewCars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCars.AutoGenerateColumns = false;
            dataGridViewCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCars.BackgroundColor = Color.White;
            dataGridViewCars.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 166, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Columns.AddRange(new DataGridViewColumn[] { brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, originCountryDataGridViewTextBoxColumn, releaseYearDataGridViewTextBoxColumn, featuresDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, conditionDataGridViewTextBoxColumn });
            dataGridViewCars.DataSource = carBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(208, 226, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCars.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCars.EnableHeadersVisualStyles = false;
            dataGridViewCars.Location = new Point(6, 6);
            dataGridViewCars.MultiSelect = false;
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.RowHeadersWidth = 62;
            dataGridViewCars.Size = new Size(1319, 384);
            dataGridViewCars.TabIndex = 0;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.FillWeight = 20F;
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.MinimumWidth = 8;
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.FillWeight = 20F;
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.MinimumWidth = 8;
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // originCountryDataGridViewTextBoxColumn
            // 
            originCountryDataGridViewTextBoxColumn.DataPropertyName = "OriginCountry";
            originCountryDataGridViewTextBoxColumn.FillWeight = 20F;
            originCountryDataGridViewTextBoxColumn.HeaderText = "Country";
            originCountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            originCountryDataGridViewTextBoxColumn.Name = "originCountryDataGridViewTextBoxColumn";
            // 
            // releaseYearDataGridViewTextBoxColumn
            // 
            releaseYearDataGridViewTextBoxColumn.DataPropertyName = "ReleaseYear";
            releaseYearDataGridViewTextBoxColumn.FillWeight = 20F;
            releaseYearDataGridViewTextBoxColumn.HeaderText = "Year";
            releaseYearDataGridViewTextBoxColumn.MinimumWidth = 8;
            releaseYearDataGridViewTextBoxColumn.Name = "releaseYearDataGridViewTextBoxColumn";
            // 
            // featuresDataGridViewTextBoxColumn
            // 
            featuresDataGridViewTextBoxColumn.DataPropertyName = "Features";
            featuresDataGridViewTextBoxColumn.FillWeight = 40F;
            featuresDataGridViewTextBoxColumn.HeaderText = "Features";
            featuresDataGridViewTextBoxColumn.MinimumWidth = 8;
            featuresDataGridViewTextBoxColumn.Name = "featuresDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.FillWeight = 30F;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            conditionDataGridViewTextBoxColumn.FillWeight = 20F;
            conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            conditionDataGridViewTextBoxColumn.MinimumWidth = 8;
            conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Models.Car);
            // 
            // tabCustomers
            // 
            tabCustomers.Controls.Add(dataGridViewCustomers);
            tabCustomers.Location = new Point(4, 34);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Padding = new Padding(3);
            tabCustomers.Size = new Size(1331, 396);
            tabCustomers.TabIndex = 1;
            tabCustomers.Text = "Customers";
            tabCustomers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AllowUserToAddRows = false;
            dataGridViewCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCustomers.AutoGenerateColumns = false;
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomers.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { contactInfoDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, minBudgetDataGridViewTextBoxColumn, maxBudgetDataGridViewTextBoxColumn, DesiredBrandsDisplay, DesiredModelsDisplay });
            dataGridViewCustomers.DataSource = customerBindingSource;
            dataGridViewCustomers.EnableHeadersVisualStyles = false;
            dataGridViewCustomers.Location = new Point(6, 6);
            dataGridViewCustomers.MultiSelect = false;
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 62;
            dataGridViewCustomers.Size = new Size(1319, 267);
            dataGridViewCustomers.TabIndex = 1;
            // 
            // contactInfoDataGridViewTextBoxColumn
            // 
            contactInfoDataGridViewTextBoxColumn.DataPropertyName = "ContactInfo";
            contactInfoDataGridViewTextBoxColumn.HeaderText = "Contact Info";
            contactInfoDataGridViewTextBoxColumn.MinimumWidth = 8;
            contactInfoDataGridViewTextBoxColumn.Name = "contactInfoDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // minBudgetDataGridViewTextBoxColumn
            // 
            minBudgetDataGridViewTextBoxColumn.DataPropertyName = "MinBudget";
            minBudgetDataGridViewTextBoxColumn.HeaderText = "Min. Budget";
            minBudgetDataGridViewTextBoxColumn.MinimumWidth = 8;
            minBudgetDataGridViewTextBoxColumn.Name = "minBudgetDataGridViewTextBoxColumn";
            // 
            // maxBudgetDataGridViewTextBoxColumn
            // 
            maxBudgetDataGridViewTextBoxColumn.DataPropertyName = "MaxBudget";
            maxBudgetDataGridViewTextBoxColumn.HeaderText = "Max. Budget";
            maxBudgetDataGridViewTextBoxColumn.MinimumWidth = 8;
            maxBudgetDataGridViewTextBoxColumn.Name = "maxBudgetDataGridViewTextBoxColumn";
            // 
            // DesiredBrandsDisplay
            // 
            DesiredBrandsDisplay.DataPropertyName = "DesiredBrandsDisplay";
            DesiredBrandsDisplay.HeaderText = "Brands";
            DesiredBrandsDisplay.MinimumWidth = 8;
            DesiredBrandsDisplay.Name = "DesiredBrandsDisplay";
            DesiredBrandsDisplay.ReadOnly = true;
            // 
            // DesiredModelsDisplay
            // 
            DesiredModelsDisplay.DataPropertyName = "DesiredModelsDisplay";
            DesiredModelsDisplay.HeaderText = "Models";
            DesiredModelsDisplay.MinimumWidth = 8;
            DesiredModelsDisplay.Name = "DesiredModelsDisplay";
            DesiredModelsDisplay.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Customer);
            // 
            // tabApplications
            // 
            tabApplications.Controls.Add(dataGridViewApplications);
            tabApplications.Location = new Point(4, 34);
            tabApplications.Name = "tabApplications";
            tabApplications.Size = new Size(1331, 396);
            tabApplications.TabIndex = 2;
            tabApplications.Text = "Applications";
            tabApplications.UseVisualStyleBackColor = true;
            // 
            // dataGridViewApplications
            // 
            dataGridViewApplications.AllowUserToAddRows = false;
            dataGridViewApplications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewApplications.AutoGenerateColumns = false;
            dataGridViewApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewApplications.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 167, 38);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApplications.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, customerEmailDataGridViewTextBoxColumn, CarsDisplay });
            dataGridViewApplications.DataSource = carApplicationBindingSource;
            dataGridViewApplications.EnableHeadersVisualStyles = false;
            dataGridViewApplications.Location = new Point(3, 3);
            dataGridViewApplications.MultiSelect = false;
            dataGridViewApplications.Name = "dataGridViewApplications";
            dataGridViewApplications.RowHeadersWidth = 62;
            dataGridViewApplications.Size = new Size(1325, 267);
            dataGridViewApplications.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            customerEmailDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail";
            customerEmailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            customerEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            // 
            // CarsDisplay
            // 
            CarsDisplay.DataPropertyName = "CarsDisplay";
            CarsDisplay.FillWeight = 200F;
            CarsDisplay.HeaderText = "Cars";
            CarsDisplay.MinimumWidth = 8;
            CarsDisplay.Name = "CarsDisplay";
            CarsDisplay.ReadOnly = true;
            // 
            // carApplicationBindingSource
            // 
            carApplicationBindingSource.DataSource = typeof(Models.CarApplication);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, closeAdminPanelToolStripMenuItem, deleteCarToolStripMenuItem, deleteCustomerToolStripMenuItem, deleteApplicationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1363, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { carToolStripMenuItem });
            addToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(58, 29);
            addToolStripMenuItem.Text = "Add";
            // 
            // carToolStripMenuItem
            // 
            carToolStripMenuItem.Name = "carToolStripMenuItem";
            carToolStripMenuItem.Size = new Size(121, 28);
            carToolStripMenuItem.Text = "Car";
            carToolStripMenuItem.Click += carToolStripMenuItem_Click;
            // 
            // closeAdminPanelToolStripMenuItem
            // 
            closeAdminPanelToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            closeAdminPanelToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeAdminPanelToolStripMenuItem.ForeColor = Color.FromArgb(255, 167, 38);
            closeAdminPanelToolStripMenuItem.Name = "closeAdminPanelToolStripMenuItem";
            closeAdminPanelToolStripMenuItem.Size = new Size(173, 29);
            closeAdminPanelToolStripMenuItem.Text = "Close Admin Panel";
            closeAdminPanelToolStripMenuItem.Click += closeAdminPanelToolStripMenuItem_Click;
            // 
            // deleteCarToolStripMenuItem
            // 
            deleteCarToolStripMenuItem.BackColor = Color.FromArgb(255, 167, 38);
            deleteCarToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteCarToolStripMenuItem.ForeColor = Color.White;
            deleteCarToolStripMenuItem.Name = "deleteCarToolStripMenuItem";
            deleteCarToolStripMenuItem.Size = new Size(113, 29);
            deleteCarToolStripMenuItem.Text = "Delete Car";
            deleteCarToolStripMenuItem.Click += deleteCarToolStripMenuItem_Click;
            // 
            // deleteCustomerToolStripMenuItem
            // 
            deleteCustomerToolStripMenuItem.BackColor = Color.FromArgb(255, 167, 38);
            deleteCustomerToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteCustomerToolStripMenuItem.ForeColor = Color.White;
            deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            deleteCustomerToolStripMenuItem.Size = new Size(167, 29);
            deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            deleteCustomerToolStripMenuItem.Click += deleteCustomerToolStripMenuItem_Click;
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.BackColor = Color.FromArgb(255, 167, 38);
            deleteApplicationToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteApplicationToolStripMenuItem.ForeColor = Color.White;
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(181, 29);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 591);
            Controls.Add(adminTabControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminPanelForm";
            Text = "AdminPanelForm";
            FormClosing += AdminPanelForm_FormClosing;
            adminTabControl.ResumeLayout(false);
            tabCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            tabApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewApplications).EndInit();
            ((System.ComponentModel.ISupportInitialize)carApplicationBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl adminTabControl;
        private TabPage tabCars;
        private TabPage tabCustomers;
        private TabPage tabApplications;
        private DataGridView dataGridViewCars;
        private BindingSource carApplicationBindingSource;
        private BindingSource carBindingSource;
        private BindingSource customerBindingSource;
        private DataGridView dataGridViewCustomers;
        private DataGridView dataGridViewApplications;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem carToolStripMenuItem;
        private ToolStripMenuItem closeAdminPanelToolStripMenuItem;
        private DataGridViewTextBoxColumn contactInfoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minBudgetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxBudgetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DesiredBrandsDisplay;
        private DataGridViewTextBoxColumn DesiredModelsDisplay;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn originCountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn releaseYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn featuresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CarsDisplay;
        private ToolStripMenuItem deleteCarToolStripMenuItem;
        private ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
    }
}