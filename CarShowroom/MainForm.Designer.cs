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
            toolStripSeparator = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            logInToolStripMenuItemU = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            SignOutToolStripMenuItem = new ToolStripMenuItem();
            LogInToolStripMenuItem = new ToolStripMenuItem();
            CreateAccountToolStripMenuItem = new ToolStripMenuItem();
            UserNameToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            originCountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            releaseYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            featuresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Condition = new DataGridViewTextBoxColumn();
            SubmitApplicationButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            MainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            Find_button.TabIndex = 0;
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
            AutoFindButton.TabIndex = 19;
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
            ConditionLabel.Size = new Size(99, 28);
            ConditionLabel.TabIndex = 18;
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
            ConditionComboBox.Size = new Size(153, 36);
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
            ModelLabel.Size = new Size(69, 28);
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
            ModelsComboBox.Size = new Size(153, 36);
            ModelsComboBox.TabIndex = 15;
            ModelsComboBox.TextChanged += ModelsComboBox_TextChanged;
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.BackColor = Color.White;
            BrandLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BrandLabel.Location = new Point(37, 76);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(63, 28);
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
            BrandsComboBox.Size = new Size(153, 36);
            BrandsComboBox.TabIndex = 13;
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
            minPriceTextBox.Size = new Size(153, 34);
            minPriceTextBox.TabIndex = 10;
            // 
            // FindAutoLabel
            // 
            FindAutoLabel.Anchor = AnchorStyles.Top;
            FindAutoLabel.AutoSize = true;
            FindAutoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FindAutoLabel.ForeColor = Color.FromArgb(128, 255, 255);
            FindAutoLabel.Location = new Point(156, 9);
            FindAutoLabel.Name = "FindAutoLabel";
            FindAutoLabel.Size = new Size(252, 48);
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
            maxPriceTextBox.Size = new Size(153, 34);
            maxPriceTextBox.TabIndex = 5;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.White;
            yearTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yearTextBox.Location = new Point(193, 72);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.PlaceholderText = "Year";
            yearTextBox.Size = new Size(153, 34);
            yearTextBox.TabIndex = 3;
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
            MainFormMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem, SignOutToolStripMenuItem, LogInToolStripMenuItem, CreateAccountToolStripMenuItem, UserNameToolStripMenuItem });
            MainFormMenuStrip.Location = new Point(0, 0);
            MainFormMenuStrip.Name = "MainFormMenuStrip";
            MainFormMenuStrip.Size = new Size(1408, 36);
            MainFormMenuStrip.TabIndex = 4;
            MainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(58, 32);
            fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(142, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(142, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(145, 36);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redoToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(65, 32);
            editToolStripMenuItem.Text = "&Cars";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(284, 36);
            redoToolStripMenuItem.Text = "&➕ &New car";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(281, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(284, 36);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, logInToolStripMenuItemU, optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(67, 32);
            toolsToolStripMenuItem.Text = "&User";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(307, 36);
            customizeToolStripMenuItem.Text = "&New user";
            customizeToolStripMenuItem.Click += customizeToolStripMenuItem_Click;
            // 
            // logInToolStripMenuItemU
            // 
            logInToolStripMenuItemU.Name = "logInToolStripMenuItemU";
            logInToolStripMenuItemU.Size = new Size(307, 36);
            logInToolStripMenuItemU.Text = "Log in";
            logInToolStripMenuItemU.Click += logInToolStripMenuItemU_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(307, 36);
            optionsToolStripMenuItem.Text = "&Automative car search";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(69, 32);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(263, 36);
            contentsToolStripMenuItem.Text = "ℹ️ &About...";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(260, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(263, 36);
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
            SignOutToolStripMenuItem.Size = new Size(99, 32);
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
            LogInToolStripMenuItem.Size = new Size(81, 32);
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
            CreateAccountToolStripMenuItem.Size = new Size(92, 32);
            CreateAccountToolStripMenuItem.Text = "Sign up";
            CreateAccountToolStripMenuItem.Click += CreateAccountToolStripMenuItem_Click;
            // 
            // UserNameToolStripMenuItem
            // 
            UserNameToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            UserNameToolStripMenuItem.Name = "UserNameToolStripMenuItem";
            UserNameToolStripMenuItem.Size = new Size(133, 32);
            UserNameToolStripMenuItem.Text = "User's name";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 166, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, originCountryDataGridViewTextBoxColumn, releaseYearDataGridViewTextBoxColumn, featuresDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, Condition });
            dataGridView1.DataSource = carBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(208, 226, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(18, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1372, 533);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
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
            SubmitApplicationButton.Location = new Point(622, 830);
            SubmitApplicationButton.Name = "SubmitApplicationButton";
            SubmitApplicationButton.Size = new Size(200, 38);
            SubmitApplicationButton.TabIndex = 19;
            SubmitApplicationButton.Text = "New application";
            SubmitApplicationButton.UseVisualStyleBackColor = false;
            SubmitApplicationButton.Click += SubmitApplicationButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(1408, 944);
            Controls.Add(SubmitApplicationButton);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(MainFormMenuStrip);
            MainMenuStrip = MainFormMenuStrip;
            MinimumSize = new Size(1430, 1000);
            Name = "MainForm";
            Text = "Auto_ShowRoom";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            MainFormMenuStrip.ResumeLayout(false);
            MainFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ToolStripSeparator toolStripSeparator;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox maxPriceTextBox;
        private BindingSource carBindingSource;
        private DataGridView dataGridView1;
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
    }
}
