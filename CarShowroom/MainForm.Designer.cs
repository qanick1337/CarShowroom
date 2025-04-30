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
            Find_button = new Button();
            panel1 = new Panel();
            ConditionListBox = new ListBox();
            minPriceTextBox = new TextBox();
            FindAutoLabel = new Label();
            modelTextBox = new TextBox();
            maxPriceTextBox = new TextBox();
            yearTextBox = new TextBox();
            brandTextBox = new TextBox();
            ResultsListBox = new ListBox();
            carBindingSource = new BindingSource(components);
            MainFormMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            LogInToolStripMenuItem = new ToolStripMenuItem();
            CreateAccountToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            originCountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            releaseYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            featuresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            MainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Find_button
            // 
            Find_button.BackColor = Color.FromArgb(255, 192, 128);
            Find_button.FlatStyle = FlatStyle.Popup;
            Find_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Find_button.Location = new Point(258, 167);
            Find_button.Name = "Find_button";
            Find_button.Size = new Size(111, 38);
            Find_button.TabIndex = 0;
            Find_button.Text = "Find";
            Find_button.UseVisualStyleBackColor = false;
            Find_button.Click += Find_button_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ConditionListBox);
            panel1.Controls.Add(minPriceTextBox);
            panel1.Controls.Add(FindAutoLabel);
            panel1.Controls.Add(modelTextBox);
            panel1.Controls.Add(maxPriceTextBox);
            panel1.Controls.Add(yearTextBox);
            panel1.Controls.Add(brandTextBox);
            panel1.Controls.Add(Find_button);
            panel1.Location = new Point(229, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 263);
            panel1.TabIndex = 1;
            // 
            // ConditionListBox
            // 
            ConditionListBox.BackColor = Color.FromArgb(192, 255, 192);
            ConditionListBox.FormattingEnabled = true;
            ConditionListBox.ItemHeight = 25;
            ConditionListBox.Items.AddRange(new object[] { "New", "Used" });
            ConditionListBox.Location = new Point(193, 116);
            ConditionListBox.Name = "ConditionListBox";
            ConditionListBox.SelectionMode = SelectionMode.None;
            ConditionListBox.Size = new Size(153, 29);
            ConditionListBox.TabIndex = 11;
            // 
            // minPriceTextBox
            // 
            minPriceTextBox.BackColor = Color.FromArgb(192, 255, 192);
            minPriceTextBox.Location = new Point(352, 75);
            minPriceTextBox.Name = "minPriceTextBox";
            minPriceTextBox.PlaceholderText = "Minimum Price";
            minPriceTextBox.Size = new Size(153, 31);
            minPriceTextBox.TabIndex = 10;
            // 
            // FindAutoLabel
            // 
            FindAutoLabel.Anchor = AnchorStyles.Top;
            FindAutoLabel.AutoSize = true;
            FindAutoLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            FindAutoLabel.ForeColor = Color.FromArgb(255, 128, 0);
            FindAutoLabel.Location = new Point(183, 10);
            FindAutoLabel.Name = "FindAutoLabel";
            FindAutoLabel.Size = new Size(268, 51);
            FindAutoLabel.TabIndex = 2;
            FindAutoLabel.Text = "Auto Matcher";
            // 
            // modelTextBox
            // 
            modelTextBox.BackColor = Color.FromArgb(192, 255, 192);
            modelTextBox.Location = new Point(24, 116);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.PlaceholderText = "Model";
            modelTextBox.Size = new Size(153, 31);
            modelTextBox.TabIndex = 9;
            // 
            // maxPriceTextBox
            // 
            maxPriceTextBox.BackColor = Color.FromArgb(192, 255, 192);
            maxPriceTextBox.Location = new Point(352, 116);
            maxPriceTextBox.Name = "maxPriceTextBox";
            maxPriceTextBox.PlaceholderText = "Maximum Price";
            maxPriceTextBox.Size = new Size(153, 31);
            maxPriceTextBox.TabIndex = 5;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.FromArgb(192, 255, 192);
            yearTextBox.Location = new Point(193, 75);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.PlaceholderText = "Year";
            yearTextBox.Size = new Size(153, 31);
            yearTextBox.TabIndex = 3;
            // 
            // brandTextBox
            // 
            brandTextBox.BackColor = Color.FromArgb(192, 255, 192);
            brandTextBox.Location = new Point(24, 75);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.PlaceholderText = "Brand";
            brandTextBox.Size = new Size(153, 31);
            brandTextBox.TabIndex = 1;
            // 
            // ResultsListBox
            // 
            ResultsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ResultsListBox.DataSource = carBindingSource;
            ResultsListBox.DisplayMember = "Model";
            ResultsListBox.FormattingEnabled = true;
            ResultsListBox.ItemHeight = 25;
            ResultsListBox.Location = new Point(773, 501);
            ResultsListBox.Name = "ResultsListBox";
            ResultsListBox.Size = new Size(0, 4);
            ResultsListBox.TabIndex = 3;
            ResultsListBox.ValueMember = "Features";
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Models.Car);
            // 
            // MainFormMenuStrip
            // 
            MainFormMenuStrip.BackColor = SystemColors.ButtonFace;
            MainFormMenuStrip.ImageScalingSize = new Size(24, 24);
            MainFormMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem, LogInToolStripMenuItem, CreateAccountToolStripMenuItem });
            MainFormMenuStrip.Location = new Point(0, 0);
            MainFormMenuStrip.Name = "MainFormMenuStrip";
            MainFormMenuStrip.Size = new Size(1074, 33);
            MainFormMenuStrip.TabIndex = 4;
            MainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator, saveAsToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(282, 34);
            openToolStripMenuItem.Text = "&Open Car DB";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(279, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(282, 34);
            saveAsToolStripMenuItem.Text = "&Save Car DB As";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(279, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(282, 34);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(62, 29);
            editToolStripMenuItem.Text = "&Cars";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(268, 34);
            undoToolStripMenuItem.Text = "🔍 &Find a car";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(268, 34);
            redoToolStripMenuItem.Text = "&➕ &New car";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(265, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(268, 34);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(63, 29);
            toolsToolStripMenuItem.Text = "&User";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(289, 34);
            customizeToolStripMenuItem.Text = "&New user";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(289, 34);
            optionsToolStripMenuItem.Text = "&Automative car search";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(250, 34);
            contentsToolStripMenuItem.Text = "ℹ️ &About...";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(247, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(250, 34);
            aboutToolStripMenuItem.Text = "📘 &User's manual";
            // 
            // LogInToolStripMenuItem
            // 
            LogInToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            LogInToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            LogInToolStripMenuItem.ForeColor = Color.Black;
            LogInToolStripMenuItem.Margin = new Padding(0, 0, 20, 0);
            LogInToolStripMenuItem.Name = "LogInToolStripMenuItem";
            LogInToolStripMenuItem.Size = new Size(78, 29);
            LogInToolStripMenuItem.Text = "Log In";
            // 
            // CreateAccountToolStripMenuItem
            // 
            CreateAccountToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            CreateAccountToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 128);
            CreateAccountToolStripMenuItem.ForeColor = Color.Black;
            CreateAccountToolStripMenuItem.Margin = new Padding(0, 0, 20, 0);
            CreateAccountToolStripMenuItem.Name = "CreateAccountToolStripMenuItem";
            CreateAccountToolStripMenuItem.Size = new Size(145, 29);
            CreateAccountToolStripMenuItem.Text = "Create account";
            CreateAccountToolStripMenuItem.Click += logInToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, originCountryDataGridViewTextBoxColumn, releaseYearDataGridViewTextBoxColumn, featuresDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = carBindingSource;
            dataGridView1.Location = new Point(76, 380);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(956, 239);
            dataGridView1.TabIndex = 6;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.MinimumWidth = 8;
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            brandDataGridViewTextBoxColumn.ReadOnly = true;
            brandDataGridViewTextBoxColumn.Width = 150;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.MinimumWidth = 8;
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.ReadOnly = true;
            modelDataGridViewTextBoxColumn.Width = 150;
            // 
            // originCountryDataGridViewTextBoxColumn
            // 
            originCountryDataGridViewTextBoxColumn.DataPropertyName = "OriginCountry";
            originCountryDataGridViewTextBoxColumn.HeaderText = "OriginCountry";
            originCountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            originCountryDataGridViewTextBoxColumn.Name = "originCountryDataGridViewTextBoxColumn";
            originCountryDataGridViewTextBoxColumn.ReadOnly = true;
            originCountryDataGridViewTextBoxColumn.Width = 150;
            // 
            // releaseYearDataGridViewTextBoxColumn
            // 
            releaseYearDataGridViewTextBoxColumn.DataPropertyName = "ReleaseYear";
            releaseYearDataGridViewTextBoxColumn.HeaderText = "ReleaseYear";
            releaseYearDataGridViewTextBoxColumn.MinimumWidth = 8;
            releaseYearDataGridViewTextBoxColumn.Name = "releaseYearDataGridViewTextBoxColumn";
            releaseYearDataGridViewTextBoxColumn.ReadOnly = true;
            releaseYearDataGridViewTextBoxColumn.Width = 150;
            // 
            // featuresDataGridViewTextBoxColumn
            // 
            featuresDataGridViewTextBoxColumn.DataPropertyName = "Features";
            featuresDataGridViewTextBoxColumn.HeaderText = "Features";
            featuresDataGridViewTextBoxColumn.MinimumWidth = 8;
            featuresDataGridViewTextBoxColumn.Name = "featuresDataGridViewTextBoxColumn";
            featuresDataGridViewTextBoxColumn.ReadOnly = true;
            featuresDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1074, 640);
            Controls.Add(dataGridView1);
            Controls.Add(ResultsListBox);
            Controls.Add(panel1);
            Controls.Add(MainFormMenuStrip);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = MainFormMenuStrip;
            MinimumSize = new Size(1100, 700);
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
        private ListBox ResultsListBox;
        private MenuStrip MainFormMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
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
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn originCountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn releaseYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn featuresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem CreateAccountToolStripMenuItem;
        private TextBox modelTextBox;
        private ListBox ConditionListBox;
        private TextBox minPriceTextBox;
        private ToolStripMenuItem LogInToolStripMenuItem;
    }
}
