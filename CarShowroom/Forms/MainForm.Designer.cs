namespace CarShowroom
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Find_button = new Button();
            panel1 = new Panel();
            AutoFindButton = new Button();
            ConditionLabel = new Label();
            ConditionComboBox = new ComboBox();
            ModelLabel = new Label();
            ModelsComboBox = new ComboBox();
            BrandLabel = new Label();
            BrandsComboBox = new ComboBox();
            minPriceTextBox = new TextBox();
            FindAutoLabel = new Label();
            maxPriceTextBox = new TextBox();
            yearTextBox = new TextBox();
            carBindingSource = new BindingSource(components);
            MainFormMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            findACarToolStripMenuItem = new ToolStripMenuItem();
            autoFindToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            logInToolStripMenuItemU = new ToolStripMenuItem();
            signOutToolStripMenuItemAdd = new ToolStripMenuItem();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            newApplicationToolStripMenuItem = new ToolStripMenuItem();
            myApplicationsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            SignOutToolStripMenuItem = new ToolStripMenuItem();
            LogInToolStripMenuItem = new ToolStripMenuItem();
            CreateAccountToolStripMenuItem = new ToolStripMenuItem();
            UserNameToolStripMenuItem = new ToolStripMenuItem();
            CarsDataGridView = new DataGridView();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            originCountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            releaseYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            featuresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Condition = new DataGridViewTextBoxColumn();
            SubmitApplicationButton = new Button();
            CartButton = new Button();
            CartPanel = new Panel();
            CartTextBox = new TextBox();
            CloseCartButton = new Button();
            CartLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            MainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CarsDataGridView).BeginInit();
            CartPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Find_button
            // 
            Find_button.BackColor = Color.FromArgb(0, 123, 255);
            Find_button.FlatStyle = FlatStyle.Popup;
            Find_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Find_button.ForeColor = Color.White;
            Find_button.Location = new Point(159, 167);
            Find_button.Name = "Find_button";
            Find_button.Size = new Size(111, 38);
            Find_button.TabIndex = 8;
            Find_button.Text = "🔍Find";
            Find_button.UseVisualStyleBackColor = false;
            Find_button.Click += Find_button_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(AutoFindButton);
            panel1.Controls.Add(ConditionLabel);
            panel1.Controls.Add(ConditionComboBox);
            panel1.Controls.Add(ModelLabel);
            panel1.Controls.Add(ModelsComboBox);
            panel1.Controls.Add(BrandLabel);
            panel1.Controls.Add(BrandsComboBox);
            panel1.Controls.Add(minPriceTextBox);
            panel1.Controls.Add(FindAutoLabel);
            panel1.Controls.Add(maxPriceTextBox);
            panel1.Controls.Add(yearTextBox);
            panel1.Controls.Add(Find_button);
            panel1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel1.Location = new Point(429, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 217);
            panel1.TabIndex = 1;
            // 
            // AutoFindButton
            // 
            AutoFindButton.BackColor = Color.White;
            AutoFindButton.FlatStyle = FlatStyle.Popup;
            AutoFindButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AutoFindButton.ForeColor = Color.FromArgb(0, 123, 255);
            AutoFindButton.Location = new Point(315, 167);
            AutoFindButton.Name = "AutoFindButton";
            AutoFindButton.Size = new Size(131, 38);
            AutoFindButton.TabIndex = 9;
            AutoFindButton.Text = "⚡Auto Find";
            AutoFindButton.UseVisualStyleBackColor = false;
            AutoFindButton.Click += AutoFindButton_Click;
            // 
            // ConditionLabel
            // 
            ConditionLabel.AutoSize = true;
            ConditionLabel.BackColor = Color.White;
            ConditionLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConditionLabel.Location = new Point(196, 119);
            ConditionLabel.Name = "ConditionLabel";
            ConditionLabel.Size = new Size(85, 23);
            ConditionLabel.TabIndex = 5;
            ConditionLabel.Text = "Condition";
            // 
            // ConditionComboBox
            // 
            ConditionComboBox.BackColor = Color.White;
            ConditionComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConditionComboBox.ForeColor = Color.FromArgb(33, 37, 41);
            ConditionComboBox.Items.AddRange(new object[] { "All", "New", "Used" });
            ConditionComboBox.Location = new Point(193, 116);
            ConditionComboBox.Name = "ConditionComboBox";
            ConditionComboBox.Size = new Size(153, 31);
            ConditionComboBox.TabIndex = 17;
            ConditionComboBox.SelectedIndexChanged += ConditionComboBox_SelectedIndexChanged;
            ConditionComboBox.TextChanged += ConditionComboBox_TextChanged;
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.BackColor = Color.White;
            ModelLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ModelLabel.Location = new Point(37, 119);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(58, 23);
            ModelLabel.TabIndex = 16;
            ModelLabel.Text = "Model";
            // 
            // ModelsComboBox
            // 
            ModelsComboBox.BackColor = Color.White;
            ModelsComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ModelsComboBox.ForeColor = Color.FromArgb(33, 37, 41);
            ModelsComboBox.Location = new Point(34, 116);
            ModelsComboBox.Name = "ModelsComboBox";
            ModelsComboBox.Size = new Size(153, 31);
            ModelsComboBox.TabIndex = 3;
            ModelsComboBox.TextChanged += ModelsComboBox_TextChanged;
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.BackColor = Color.White;
            BrandLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BrandLabel.Location = new Point(37, 76);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(55, 23);
            BrandLabel.TabIndex = 14;
            BrandLabel.Text = "Brand";
            // 
            // BrandsComboBox
            // 
            BrandsComboBox.BackColor = Color.White;
            BrandsComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BrandsComboBox.ForeColor = Color.FromArgb(33, 37, 41);
            BrandsComboBox.Items.AddRange(new object[] { "All" });
            BrandsComboBox.Location = new Point(34, 73);
            BrandsComboBox.Name = "BrandsComboBox";
            BrandsComboBox.Size = new Size(153, 31);
            BrandsComboBox.TabIndex = 2;
            BrandsComboBox.SelectedIndexChanged += BrandsComboBox_SelectedIndexChanged;
            BrandsComboBox.TextChanged += BrandsComboBox_TextChanged;
            // 
            // minPriceTextBox
            // 
            minPriceTextBox.BackColor = Color.White;
            minPriceTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minPriceTextBox.Location = new Point(352, 72);
            minPriceTextBox.Name = "minPriceTextBox";
            minPriceTextBox.PlaceholderText = "Minimum Price";
            minPriceTextBox.Size = new Size(153, 30);
            minPriceTextBox.TabIndex = 6;
            // 
            // FindAutoLabel
            // 
            FindAutoLabel.Anchor = AnchorStyles.Top;
            FindAutoLabel.AutoSize = true;
            FindAutoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FindAutoLabel.ForeColor = Color.FromArgb(0, 123, 255);
            FindAutoLabel.Location = new Point(156, 9);
            FindAutoLabel.Name = "FindAutoLabel";
            FindAutoLabel.Size = new Size(212, 41);
            FindAutoLabel.TabIndex = 2;
            FindAutoLabel.Text = "Auto Matcher";
            // 
            // maxPriceTextBox
            // 
            maxPriceTextBox.BackColor = Color.White;
            maxPriceTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maxPriceTextBox.Location = new Point(352, 116);
            maxPriceTextBox.Name = "maxPriceTextBox";
            maxPriceTextBox.PlaceholderText = "Maximum Price";
            maxPriceTextBox.Size = new Size(153, 30);
            maxPriceTextBox.TabIndex = 7;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.White;
            yearTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yearTextBox.Location = new Point(193, 72);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.PlaceholderText = "Year";
            yearTextBox.Size = new Size(153, 30);
            yearTextBox.TabIndex = 4;
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Models.Car);
            // 
            // MainFormMenuStrip
            // 
            MainFormMenuStrip.BackColor = SystemColors.ButtonFace;
            MainFormMenuStrip.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainFormMenuStrip.ImageScalingSize = new Size(24, 24);
            MainFormMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, applicationsToolStripMenuItem, helpToolStripMenuItem, SignOutToolStripMenuItem, LogInToolStripMenuItem, CreateAccountToolStripMenuItem, UserNameToolStripMenuItem });
            MainFormMenuStrip.Location = new Point(0, 0);
            MainFormMenuStrip.Name = "MainFormMenuStrip";
            MainFormMenuStrip.Size = new Size(1412, 31);
            MainFormMenuStrip.TabIndex = 1;
            MainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(49, 27);
            fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(118, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(121, 28);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator4, findACarToolStripMenuItem, autoFindToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(57, 27);
            editToolStripMenuItem.Text = "&Cars";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(167, 6);
            // 
            // findACarToolStripMenuItem
            // 
            findACarToolStripMenuItem.Name = "findACarToolStripMenuItem";
            findACarToolStripMenuItem.Size = new Size(170, 28);
            findACarToolStripMenuItem.Text = "Find a car";
            findACarToolStripMenuItem.Click += findACarToolStripMenuItem_Click;
            // 
            // autoFindToolStripMenuItem
            // 
            autoFindToolStripMenuItem.Name = "autoFindToolStripMenuItem";
            autoFindToolStripMenuItem.Size = new Size(170, 28);
            autoFindToolStripMenuItem.Text = "Auto find ";
            autoFindToolStripMenuItem.Click += autoFindToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, logInToolStripMenuItemU, signOutToolStripMenuItemAdd });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 27);
            toolsToolStripMenuItem.Text = "&User";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(165, 28);
            customizeToolStripMenuItem.Text = "&New user";
            customizeToolStripMenuItem.Click += customizeToolStripMenuItem_Click;
            // 
            // logInToolStripMenuItemU
            // 
            logInToolStripMenuItemU.Name = "logInToolStripMenuItemU";
            logInToolStripMenuItemU.Size = new Size(165, 28);
            logInToolStripMenuItemU.Text = "Log in";
            logInToolStripMenuItemU.Click += logInToolStripMenuItemU_Click;
            // 
            // signOutToolStripMenuItemAdd
            // 
            signOutToolStripMenuItemAdd.Name = "signOutToolStripMenuItemAdd";
            signOutToolStripMenuItemAdd.Size = new Size(165, 28);
            signOutToolStripMenuItemAdd.Text = "Sign Out";
            signOutToolStripMenuItemAdd.Click += signOutToolStripMenuItemAdd_Click;
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newApplicationToolStripMenuItem, myApplicationsToolStripMenuItem });
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(117, 27);
            applicationsToolStripMenuItem.Text = "&Applications";
            // 
            // newApplicationToolStripMenuItem
            // 
            newApplicationToolStripMenuItem.Name = "newApplicationToolStripMenuItem";
            newApplicationToolStripMenuItem.Size = new Size(217, 28);
            newApplicationToolStripMenuItem.Text = "New application";
            newApplicationToolStripMenuItem.Click += newApplicationToolStripMenuItem_Click;
            // 
            // myApplicationsToolStripMenuItem
            // 
            myApplicationsToolStripMenuItem.Name = "myApplicationsToolStripMenuItem";
            myApplicationsToolStripMenuItem.Size = new Size(217, 28);
            myApplicationsToolStripMenuItem.Text = "My applications";
            myApplicationsToolStripMenuItem.Click += myApplicationsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(59, 27);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(229, 28);
            contentsToolStripMenuItem.Text = "ℹ️ &About...";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(226, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(229, 28);
            aboutToolStripMenuItem.Text = "📘 &User's manual";
            // 
            // SignOutToolStripMenuItem
            // 
            SignOutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            SignOutToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            SignOutToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SignOutToolStripMenuItem.ForeColor = Color.FromArgb(0, 123, 255);
            SignOutToolStripMenuItem.Margin = new Padding(0, 0, 20, 0);
            SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem";
            SignOutToolStripMenuItem.Size = new Size(81, 27);
            SignOutToolStripMenuItem.Text = "Sign out";
            SignOutToolStripMenuItem.Click += SignOutToolStripMenuItem_Click;
            // 
            // LogInToolStripMenuItem
            // 
            LogInToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            LogInToolStripMenuItem.BackColor = Color.FromArgb(0, 123, 255);
            LogInToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LogInToolStripMenuItem.ForeColor = Color.White;
            LogInToolStripMenuItem.Margin = new Padding(0, 0, 20, 0);
            LogInToolStripMenuItem.Name = "LogInToolStripMenuItem";
            LogInToolStripMenuItem.Size = new Size(67, 27);
            LogInToolStripMenuItem.Text = "Log In";
            LogInToolStripMenuItem.Click += LogInToolStripMenuItem_Click;
            // 
            // CreateAccountToolStripMenuItem
            // 
            CreateAccountToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            CreateAccountToolStripMenuItem.BackColor = Color.FromArgb(255, 167, 38);
            CreateAccountToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateAccountToolStripMenuItem.ForeColor = Color.Black;
            CreateAccountToolStripMenuItem.Margin = new Padding(0, 0, 20, 0);
            CreateAccountToolStripMenuItem.Name = "CreateAccountToolStripMenuItem";
            CreateAccountToolStripMenuItem.Size = new Size(75, 27);
            CreateAccountToolStripMenuItem.Text = "Sign up";
            CreateAccountToolStripMenuItem.Click += CreateAccountToolStripMenuItem_Click;
            // 
            // UserNameToolStripMenuItem
            // 
            UserNameToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            UserNameToolStripMenuItem.Name = "UserNameToolStripMenuItem";
            UserNameToolStripMenuItem.Size = new Size(117, 27);
            UserNameToolStripMenuItem.Text = "User's name";
            // 
            // CarsDataGridView
            // 
            CarsDataGridView.AllowUserToAddRows = false;
            CarsDataGridView.AllowUserToDeleteRows = false;
            CarsDataGridView.AllowUserToResizeRows = false;
            CarsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CarsDataGridView.AutoGenerateColumns = false;
            CarsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CarsDataGridView.BackgroundColor = Color.White;
            CarsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 166, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CarsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CarsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarsDataGridView.Columns.AddRange(new DataGridViewColumn[] { brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, originCountryDataGridViewTextBoxColumn, releaseYearDataGridViewTextBoxColumn, featuresDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, Condition });
            CarsDataGridView.DataSource = carBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(208, 226, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CarsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            CarsDataGridView.EnableHeadersVisualStyles = false;
            CarsDataGridView.Location = new Point(18, 277);
            CarsDataGridView.Name = "CarsDataGridView";
            CarsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CarsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CarsDataGridView.RowHeadersWidth = 62;
            CarsDataGridView.ScrollBars = ScrollBars.Vertical;
            CarsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarsDataGridView.Size = new Size(1372, 533);
            CarsDataGridView.TabIndex = 6;
            CarsDataGridView.DataError += CarsDataGridView_DataError;
            CarsDataGridView.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.FillWeight = 20F;
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.MinimumWidth = 8;
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.FillWeight = 20F;
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.MinimumWidth = 8;
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originCountryDataGridViewTextBoxColumn
            // 
            originCountryDataGridViewTextBoxColumn.DataPropertyName = "OriginCountry";
            originCountryDataGridViewTextBoxColumn.FillWeight = 20F;
            originCountryDataGridViewTextBoxColumn.HeaderText = "Country";
            originCountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            originCountryDataGridViewTextBoxColumn.Name = "originCountryDataGridViewTextBoxColumn";
            originCountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseYearDataGridViewTextBoxColumn
            // 
            releaseYearDataGridViewTextBoxColumn.DataPropertyName = "ReleaseYear";
            releaseYearDataGridViewTextBoxColumn.FillWeight = 20F;
            releaseYearDataGridViewTextBoxColumn.HeaderText = "Year";
            releaseYearDataGridViewTextBoxColumn.MinimumWidth = 8;
            releaseYearDataGridViewTextBoxColumn.Name = "releaseYearDataGridViewTextBoxColumn";
            releaseYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // featuresDataGridViewTextBoxColumn
            // 
            featuresDataGridViewTextBoxColumn.DataPropertyName = "Features";
            featuresDataGridViewTextBoxColumn.FillWeight = 50F;
            featuresDataGridViewTextBoxColumn.HeaderText = "Features";
            featuresDataGridViewTextBoxColumn.MinimumWidth = 8;
            featuresDataGridViewTextBoxColumn.Name = "featuresDataGridViewTextBoxColumn";
            featuresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.FillWeight = 30F;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Condition
            // 
            Condition.DataPropertyName = "Condition";
            Condition.FillWeight = 20F;
            Condition.HeaderText = "Condition";
            Condition.MinimumWidth = 8;
            Condition.Name = "Condition";
            Condition.ReadOnly = true;
            // 
            // SubmitApplicationButton
            // 
            SubmitApplicationButton.Anchor = AnchorStyles.Bottom;
            SubmitApplicationButton.BackColor = Color.White;
            SubmitApplicationButton.FlatStyle = FlatStyle.Popup;
            SubmitApplicationButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SubmitApplicationButton.ForeColor = Color.FromArgb(0, 123, 255);
            SubmitApplicationButton.Location = new Point(585, 823);
            SubmitApplicationButton.Name = "SubmitApplicationButton";
            SubmitApplicationButton.Size = new Size(200, 38);
            SubmitApplicationButton.TabIndex = 19;
            SubmitApplicationButton.Text = "➕New application";
            SubmitApplicationButton.UseVisualStyleBackColor = false;
            SubmitApplicationButton.Click += SubmitApplicationButton_Click;
            // 
            // CartButton
            // 
            CartButton.Anchor = AnchorStyles.Bottom;
            CartButton.BackColor = Color.FromArgb(0, 123, 255);
            CartButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CartButton.ForeColor = Color.White;
            CartButton.Location = new Point(1105, 823);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(201, 50);
            CartButton.TabIndex = 20;
            CartButton.Text = "\U0001f6d2 Your Applications";
            CartButton.UseVisualStyleBackColor = false;
            CartButton.Click += CartButton_Click;
            // 
            // CartPanel
            // 
            CartPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CartPanel.BackColor = Color.White;
            CartPanel.BorderStyle = BorderStyle.FixedSingle;
            CartPanel.Controls.Add(CartTextBox);
            CartPanel.Controls.Add(CloseCartButton);
            CartPanel.Controls.Add(CartLabel);
            CartPanel.Location = new Point(799, 260);
            CartPanel.Name = "CartPanel";
            CartPanel.Size = new Size(592, 548);
            CartPanel.TabIndex = 21;
            // 
            // CartTextBox
            // 
            CartTextBox.Location = new Point(3, 98);
            CartTextBox.Multiline = true;
            CartTextBox.Name = "CartTextBox";
            CartTextBox.ScrollBars = ScrollBars.Vertical;
            CartTextBox.Size = new Size(582, 422);
            CartTextBox.TabIndex = 21;
            // 
            // CloseCartButton
            // 
            CloseCartButton.BackColor = Color.FromArgb(224, 224, 224);
            CloseCartButton.Location = new Point(543, 3);
            CloseCartButton.Name = "CloseCartButton";
            CloseCartButton.Size = new Size(42, 41);
            CloseCartButton.TabIndex = 20;
            CloseCartButton.Text = "❌";
            CloseCartButton.UseVisualStyleBackColor = false;
            CloseCartButton.Click += CloseCartButton_Click;
            // 
            // CartLabel
            // 
            CartLabel.Anchor = AnchorStyles.Top;
            CartLabel.AutoSize = true;
            CartLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CartLabel.ForeColor = Color.FromArgb(0, 123, 255);
            CartLabel.Location = new Point(170, 18);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(261, 41);
            CartLabel.TabIndex = 18;
            CartLabel.Text = "Your applications";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(1412, 953);
            Controls.Add(CartPanel);
            Controls.Add(CartButton);
            Controls.Add(SubmitApplicationButton);
            Controls.Add(CarsDataGridView);
            Controls.Add(panel1);
            Controls.Add(MainFormMenuStrip);
            MainMenuStrip = MainFormMenuStrip;
            MinimumSize = new Size(1430, 1000);
            Name = "MainForm";
            Text = "Auto Matcher";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            MainFormMenuStrip.ResumeLayout(false);
            MainFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CarsDataGridView).EndInit();
            CartPanel.ResumeLayout(false);
            CartPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Find_button;
        private Panel panel1;
        private Label FindAutoLabel;
        private TextBox brandTextBox;
        private TextBox yearTextBox;
        private MenuStrip MainFormMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox maxPriceTextBox;
        private BindingSource carBindingSource;
        private DataGridView CarsDataGridView;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem CreateAccountToolStripMenuItem;
        private TextBox modelTextBox;
        private TextBox minPriceTextBox;
        private ToolStripMenuItem LogInToolStripMenuItem;
        private ComboBox BrandsComboBox;
        private Label BrandLabel;
        private ComboBox ModelsComboBox;
        private Label ModelLabel;
        private ComboBox ConditionComboBox;
        private Label ConditionLabel;
        private Button SubmitApplicationButton;
        private ToolStripMenuItem UserNameToolStripMenuItem;
        private ToolStripMenuItem SignOutToolStripMenuItem;
        private Button AutoFindButton;
        private ToolStripMenuItem logInToolStripMenuItemU;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn originCountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn releaseYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn featuresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Condition;
        private Button CartButton;
        private Panel CartPanel;
        private Label CartLabel;
        private Button CloseCartButton;
        private TextBox CartTextBox;
        private ToolStripMenuItem findACarToolStripMenuItem;
        private ToolStripMenuItem autoFindToolStripMenuItem;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem newApplicationToolStripMenuItem;
        private ToolStripMenuItem myApplicationsToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItemAdd;
    }
}
