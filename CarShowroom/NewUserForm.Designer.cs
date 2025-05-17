namespace CarShowroom
{
    partial class NewUserForm
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
            panel1 = new Panel();
            FavoriteModelsLabel = new Label();
            FavoriteModelsListBox = new ListBox();
            PricingLabel = new Label();
            AddModelTextBox = new Button();
            UserModelsTextBox = new TextBox();
            PrefferedCarsLabel = new Label();
            PersonalInfoLabel = new Label();
            UserPasswordTextBox = new TextBox();
            FavoriteBrandsLabel = new Label();
            FavoriteBrandsListBox = new ListBox();
            AddBrandButton = new Button();
            UserBrandsTextBox = new TextBox();
            minPriceTextBox = new TextBox();
            WelcomeLabel = new Label();
            maxPriceTextBox = new TextBox();
            UserMailTextBox = new TextBox();
            CreateButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(FavoriteModelsLabel);
            panel1.Controls.Add(FavoriteModelsListBox);
            panel1.Controls.Add(PricingLabel);
            panel1.Controls.Add(AddModelTextBox);
            panel1.Controls.Add(UserModelsTextBox);
            panel1.Controls.Add(PrefferedCarsLabel);
            panel1.Controls.Add(PersonalInfoLabel);
            panel1.Controls.Add(UserPasswordTextBox);
            panel1.Controls.Add(FavoriteBrandsLabel);
            panel1.Controls.Add(FavoriteBrandsListBox);
            panel1.Controls.Add(AddBrandButton);
            panel1.Controls.Add(UserBrandsTextBox);
            panel1.Controls.Add(minPriceTextBox);
            panel1.Controls.Add(WelcomeLabel);
            panel1.Controls.Add(maxPriceTextBox);
            panel1.Controls.Add(UserMailTextBox);
            panel1.Controls.Add(CreateButton);
            panel1.Location = new Point(113, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 487);
            panel1.TabIndex = 6;
            // 
            // FavoriteModelsLabel
            // 
            FavoriteModelsLabel.AutoSize = true;
            FavoriteModelsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FavoriteModelsLabel.Location = new Point(335, 238);
            FavoriteModelsLabel.Name = "FavoriteModelsLabel";
            FavoriteModelsLabel.Size = new Size(152, 28);
            FavoriteModelsLabel.TabIndex = 22;
            FavoriteModelsLabel.Text = "Favorite Models";
            // 
            // FavoriteModelsListBox
            // 
            FavoriteModelsListBox.BackColor = Color.WhiteSmoke;
            FavoriteModelsListBox.FormattingEnabled = true;
            FavoriteModelsListBox.ItemHeight = 25;
            FavoriteModelsListBox.Location = new Point(335, 269);
            FavoriteModelsListBox.Name = "FavoriteModelsListBox";
            FavoriteModelsListBox.Size = new Size(231, 104);
            FavoriteModelsListBox.TabIndex = 21;
            // 
            // PricingLabel
            // 
            PricingLabel.AutoSize = true;
            PricingLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PricingLabel.Location = new Point(24, 309);
            PricingLabel.Name = "PricingLabel";
            PricingLabel.Size = new Size(120, 28);
            PricingLabel.TabIndex = 20;
            PricingLabel.Text = "Your budget";
            // 
            // AddModelTextBox
            // 
            AddModelTextBox.BackColor = Color.FromArgb(255, 192, 128);
            AddModelTextBox.FlatStyle = FlatStyle.Popup;
            AddModelTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddModelTextBox.Location = new Point(238, 259);
            AddModelTextBox.Name = "AddModelTextBox";
            AddModelTextBox.Size = new Size(64, 31);
            AddModelTextBox.TabIndex = 19;
            AddModelTextBox.Text = "Add";
            AddModelTextBox.UseVisualStyleBackColor = false;
            AddModelTextBox.Click += AddModelTextBox_Click;
            // 
            // UserModelsTextBox
            // 
            UserModelsTextBox.BackColor = Color.FromArgb(192, 255, 192);
            UserModelsTextBox.Location = new Point(24, 258);
            UserModelsTextBox.Name = "UserModelsTextBox";
            UserModelsTextBox.PlaceholderText = "Models you want to buy";
            UserModelsTextBox.Size = new Size(208, 31);
            UserModelsTextBox.TabIndex = 18;
            // 
            // PrefferedCarsLabel
            // 
            PrefferedCarsLabel.AutoSize = true;
            PrefferedCarsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PrefferedCarsLabel.Location = new Point(29, 188);
            PrefferedCarsLabel.Name = "PrefferedCarsLabel";
            PrefferedCarsLabel.Size = new Size(264, 28);
            PrefferedCarsLabel.TabIndex = 17;
            PrefferedCarsLabel.Text = "Preferred brands and models";
            // 
            // PersonalInfoLabel
            // 
            PersonalInfoLabel.AutoSize = true;
            PersonalInfoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PersonalInfoLabel.Location = new Point(29, 69);
            PersonalInfoLabel.Name = "PersonalInfoLabel";
            PersonalInfoLabel.Size = new Size(193, 28);
            PersonalInfoLabel.TabIndex = 16;
            PersonalInfoLabel.Text = "Personal information";
            // 
            // UserPasswordTextBox
            // 
            UserPasswordTextBox.BackColor = Color.FromArgb(192, 255, 192);
            UserPasswordTextBox.Location = new Point(24, 137);
            UserPasswordTextBox.Name = "UserPasswordTextBox";
            UserPasswordTextBox.PlaceholderText = "Enter password";
            UserPasswordTextBox.Size = new Size(278, 31);
            UserPasswordTextBox.TabIndex = 15;
            // 
            // FavoriteBrandsLabel
            // 
            FavoriteBrandsLabel.AutoSize = true;
            FavoriteBrandsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FavoriteBrandsLabel.Location = new Point(335, 69);
            FavoriteBrandsLabel.Name = "FavoriteBrandsLabel";
            FavoriteBrandsLabel.Size = new Size(146, 28);
            FavoriteBrandsLabel.TabIndex = 14;
            FavoriteBrandsLabel.Text = "Favorite Brands";
            // 
            // FavoriteBrandsListBox
            // 
            FavoriteBrandsListBox.BackColor = Color.WhiteSmoke;
            FavoriteBrandsListBox.FormattingEnabled = true;
            FavoriteBrandsListBox.ItemHeight = 25;
            FavoriteBrandsListBox.Location = new Point(335, 100);
            FavoriteBrandsListBox.Name = "FavoriteBrandsListBox";
            FavoriteBrandsListBox.Size = new Size(231, 104);
            FavoriteBrandsListBox.TabIndex = 13;
            // 
            // AddBrandButton
            // 
            AddBrandButton.BackColor = Color.FromArgb(255, 192, 128);
            AddBrandButton.FlatStyle = FlatStyle.Popup;
            AddBrandButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddBrandButton.Location = new Point(238, 222);
            AddBrandButton.Name = "AddBrandButton";
            AddBrandButton.Size = new Size(64, 31);
            AddBrandButton.TabIndex = 12;
            AddBrandButton.Text = "Add";
            AddBrandButton.UseVisualStyleBackColor = false;
            AddBrandButton.Click += AddBrandButton_Click;
            // 
            // UserBrandsTextBox
            // 
            UserBrandsTextBox.BackColor = Color.FromArgb(192, 255, 192);
            UserBrandsTextBox.Location = new Point(24, 221);
            UserBrandsTextBox.Name = "UserBrandsTextBox";
            UserBrandsTextBox.PlaceholderText = "Brands you want to buy";
            UserBrandsTextBox.Size = new Size(208, 31);
            UserBrandsTextBox.TabIndex = 11;
            // 
            // minPriceTextBox
            // 
            minPriceTextBox.BackColor = Color.FromArgb(192, 255, 192);
            minPriceTextBox.Location = new Point(24, 342);
            minPriceTextBox.Name = "minPriceTextBox";
            minPriceTextBox.PlaceholderText = "Minimum Price";
            minPriceTextBox.Size = new Size(133, 31);
            minPriceTextBox.TabIndex = 10;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Anchor = AnchorStyles.Top;
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            WelcomeLabel.ForeColor = Color.FromArgb(255, 128, 0);
            WelcomeLabel.Location = new Point(24, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(561, 51);
            WelcomeLabel.TabIndex = 2;
            WelcomeLabel.Text = "Welcome to the Auto Matcher";
            // 
            // maxPriceTextBox
            // 
            maxPriceTextBox.BackColor = Color.FromArgb(192, 255, 192);
            maxPriceTextBox.Location = new Point(163, 342);
            maxPriceTextBox.Name = "maxPriceTextBox";
            maxPriceTextBox.PlaceholderText = "Maximum Price";
            maxPriceTextBox.Size = new Size(139, 31);
            maxPriceTextBox.TabIndex = 5;
            // 
            // UserMailTextBox
            // 
            UserMailTextBox.BackColor = Color.FromArgb(192, 255, 192);
            UserMailTextBox.Location = new Point(24, 100);
            UserMailTextBox.Name = "UserMailTextBox";
            UserMailTextBox.PlaceholderText = "Your e-mail";
            UserMailTextBox.Size = new Size(278, 31);
            UserMailTextBox.TabIndex = 1;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.FromArgb(255, 192, 128);
            CreateButton.FlatStyle = FlatStyle.Popup;
            CreateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CreateButton.Location = new Point(257, 405);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(111, 38);
            CreateButton.TabIndex = 0;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += Find_button_Click;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(833, 547);
            Controls.Add(panel1);
            Name = "NewUserForm";
            Text = "NewUserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripMenuItem logInToolStripMenuItem;
        private Panel panel1;
        private ListBox ConditionListBox;
        private TextBox minPriceTextBox;
        private Label WelcomeLabel;
        private TextBox maxPriceTextBox;
        private TextBox UserMailTextBox;
        private Button CreateButton;
        private TextBox UserBrandsTextBox;
        private Button AddBrandButton;
        private ListBox FavoriteBrandsListBox;
        private Label FavoriteBrandsLabel;
        private TextBox UserPasswordTextBox;
        private Label PersonalInfoLabel;
        private Label PrefferedCarsLabel;
        private Button AddModelTextBox;
        private TextBox UserModelsTextBox;
        private Label FavoriteModelsLabel;
        private ListBox FavoriteModelsListBox;
        private Label PricingLabel;
    }
}