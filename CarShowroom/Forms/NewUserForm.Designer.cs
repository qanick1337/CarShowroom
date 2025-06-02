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
            NewUserFormPanel = new Panel();
            CancelButton = new Button();
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
            NewUserFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NewUserFormPanel
            // 
            NewUserFormPanel.Anchor = AnchorStyles.Top;
            NewUserFormPanel.BackColor = Color.FromArgb(249, 250, 251);
            NewUserFormPanel.Controls.Add(CancelButton);
            NewUserFormPanel.Controls.Add(FavoriteModelsLabel);
            NewUserFormPanel.Controls.Add(FavoriteModelsListBox);
            NewUserFormPanel.Controls.Add(PricingLabel);
            NewUserFormPanel.Controls.Add(AddModelTextBox);
            NewUserFormPanel.Controls.Add(UserModelsTextBox);
            NewUserFormPanel.Controls.Add(PrefferedCarsLabel);
            NewUserFormPanel.Controls.Add(PersonalInfoLabel);
            NewUserFormPanel.Controls.Add(UserPasswordTextBox);
            NewUserFormPanel.Controls.Add(FavoriteBrandsLabel);
            NewUserFormPanel.Controls.Add(FavoriteBrandsListBox);
            NewUserFormPanel.Controls.Add(AddBrandButton);
            NewUserFormPanel.Controls.Add(UserBrandsTextBox);
            NewUserFormPanel.Controls.Add(minPriceTextBox);
            NewUserFormPanel.Controls.Add(WelcomeLabel);
            NewUserFormPanel.Controls.Add(maxPriceTextBox);
            NewUserFormPanel.Controls.Add(UserMailTextBox);
            NewUserFormPanel.Controls.Add(CreateButton);
            NewUserFormPanel.Location = new Point(12, 12);
            NewUserFormPanel.Name = "NewUserFormPanel";
            NewUserFormPanel.Size = new Size(792, 652);
            NewUserFormPanel.TabIndex = 6;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.White;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.FromArgb(255, 167, 38);
            CancelButton.Location = new Point(440, 523);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(111, 45);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // FavoriteModelsLabel
            // 
            FavoriteModelsLabel.AutoSize = true;
            FavoriteModelsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            FavoriteModelsLabel.Location = new Point(498, 279);
            FavoriteModelsLabel.Name = "FavoriteModelsLabel";
            FavoriteModelsLabel.Size = new Size(161, 28);
            FavoriteModelsLabel.TabIndex = 22;
            FavoriteModelsLabel.Text = "Favorite Models";
            // 
            // FavoriteModelsListBox
            // 
            FavoriteModelsListBox.BackColor = Color.White;
            FavoriteModelsListBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FavoriteModelsListBox.FormattingEnabled = true;
            FavoriteModelsListBox.ItemHeight = 23;
            FavoriteModelsListBox.Location = new Point(499, 314);
            FavoriteModelsListBox.Name = "FavoriteModelsListBox";
            FavoriteModelsListBox.Size = new Size(231, 96);
            FavoriteModelsListBox.TabIndex = 99;
            FavoriteModelsListBox.TabStop = false;
            // 
            // PricingLabel
            // 
            PricingLabel.AutoSize = true;
            PricingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PricingLabel.Location = new Point(36, 334);
            PricingLabel.Name = "PricingLabel";
            PricingLabel.Size = new Size(155, 28);
            PricingLabel.TabIndex = 20;
            PricingLabel.Text = "💰Your budget";
            // 
            // AddModelTextBox
            // 
            AddModelTextBox.BackColor = Color.FromArgb(0, 123, 255);
            AddModelTextBox.FlatStyle = FlatStyle.Popup;
            AddModelTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddModelTextBox.ForeColor = Color.White;
            AddModelTextBox.Location = new Point(250, 277);
            AddModelTextBox.Name = "AddModelTextBox";
            AddModelTextBox.Size = new Size(64, 34);
            AddModelTextBox.TabIndex = 6;
            AddModelTextBox.Text = "Add";
            AddModelTextBox.UseVisualStyleBackColor = false;
            AddModelTextBox.Click += AddModelTextBox_Click;
            // 
            // UserModelsTextBox
            // 
            UserModelsTextBox.BackColor = Color.White;
            UserModelsTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserModelsTextBox.Location = new Point(36, 277);
            UserModelsTextBox.Name = "UserModelsTextBox";
            UserModelsTextBox.PlaceholderText = "Models you want to buy";
            UserModelsTextBox.Size = new Size(208, 30);
            UserModelsTextBox.TabIndex = 5;
            // 
            // PrefferedCarsLabel
            // 
            PrefferedCarsLabel.AutoSize = true;
            PrefferedCarsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PrefferedCarsLabel.Location = new Point(36, 202);
            PrefferedCarsLabel.Name = "PrefferedCarsLabel";
            PrefferedCarsLabel.Size = new Size(314, 28);
            PrefferedCarsLabel.TabIndex = 17;
            PrefferedCarsLabel.Text = "🚘Preferred brands and models";
            // 
            // PersonalInfoLabel
            // 
            PersonalInfoLabel.AutoSize = true;
            PersonalInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PersonalInfoLabel.Location = new Point(36, 71);
            PersonalInfoLabel.Name = "PersonalInfoLabel";
            PersonalInfoLabel.Size = new Size(239, 28);
            PersonalInfoLabel.TabIndex = 16;
            PersonalInfoLabel.Text = "📋Personal information";
            // 
            // UserPasswordTextBox
            // 
            UserPasswordTextBox.BackColor = Color.White;
            UserPasswordTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserPasswordTextBox.Location = new Point(36, 146);
            UserPasswordTextBox.Name = "UserPasswordTextBox";
            UserPasswordTextBox.PlaceholderText = "Enter password*";
            UserPasswordTextBox.Size = new Size(278, 30);
            UserPasswordTextBox.TabIndex = 2;
            // 
            // FavoriteBrandsLabel
            // 
            FavoriteBrandsLabel.AutoSize = true;
            FavoriteBrandsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            FavoriteBrandsLabel.Location = new Point(499, 71);
            FavoriteBrandsLabel.Name = "FavoriteBrandsLabel";
            FavoriteBrandsLabel.Size = new Size(161, 28);
            FavoriteBrandsLabel.TabIndex = 14;
            FavoriteBrandsLabel.Text = "Favorite Brands";
            // 
            // FavoriteBrandsListBox
            // 
            FavoriteBrandsListBox.BackColor = Color.White;
            FavoriteBrandsListBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FavoriteBrandsListBox.FormattingEnabled = true;
            FavoriteBrandsListBox.ItemHeight = 23;
            FavoriteBrandsListBox.Location = new Point(499, 106);
            FavoriteBrandsListBox.Name = "FavoriteBrandsListBox";
            FavoriteBrandsListBox.Size = new Size(231, 96);
            FavoriteBrandsListBox.TabIndex = 99;
            FavoriteBrandsListBox.TabStop = false;
            // 
            // AddBrandButton
            // 
            AddBrandButton.BackColor = Color.FromArgb(0, 123, 255);
            AddBrandButton.FlatStyle = FlatStyle.Popup;
            AddBrandButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddBrandButton.ForeColor = Color.White;
            AddBrandButton.Location = new Point(250, 237);
            AddBrandButton.Name = "AddBrandButton";
            AddBrandButton.Size = new Size(64, 34);
            AddBrandButton.TabIndex = 4;
            AddBrandButton.Text = "Add";
            AddBrandButton.UseVisualStyleBackColor = false;
            AddBrandButton.Click += AddBrandButton_Click;
            // 
            // UserBrandsTextBox
            // 
            UserBrandsTextBox.BackColor = Color.White;
            UserBrandsTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserBrandsTextBox.Location = new Point(36, 237);
            UserBrandsTextBox.Name = "UserBrandsTextBox";
            UserBrandsTextBox.PlaceholderText = "Brands you want to buy";
            UserBrandsTextBox.Size = new Size(208, 30);
            UserBrandsTextBox.TabIndex = 3;
            // 
            // minPriceTextBox
            // 
            minPriceTextBox.BackColor = Color.White;
            minPriceTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minPriceTextBox.Location = new Point(36, 381);
            minPriceTextBox.Name = "minPriceTextBox";
            minPriceTextBox.PlaceholderText = "Minimum Price*";
            minPriceTextBox.Size = new Size(278, 30);
            minPriceTextBox.TabIndex = 7;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Anchor = AnchorStyles.Top;
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            WelcomeLabel.ForeColor = Color.FromArgb(0, 123, 255);
            WelcomeLabel.Location = new Point(112, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(472, 45);
            WelcomeLabel.TabIndex = 2;
            WelcomeLabel.Text = "Welcome to the Auto Matcher";
            // 
            // maxPriceTextBox
            // 
            maxPriceTextBox.BackColor = Color.White;
            maxPriceTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maxPriceTextBox.Location = new Point(36, 421);
            maxPriceTextBox.Name = "maxPriceTextBox";
            maxPriceTextBox.PlaceholderText = "Maximum Price*";
            maxPriceTextBox.Size = new Size(278, 30);
            maxPriceTextBox.TabIndex = 8;
            // 
            // UserMailTextBox
            // 
            UserMailTextBox.BackColor = Color.White;
            UserMailTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserMailTextBox.Location = new Point(36, 106);
            UserMailTextBox.Name = "UserMailTextBox";
            UserMailTextBox.PlaceholderText = "Your e-mail*";
            UserMailTextBox.Size = new Size(278, 30);
            UserMailTextBox.TabIndex = 1;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.White;
            CreateButton.FlatStyle = FlatStyle.Popup;
            CreateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateButton.ForeColor = Color.FromArgb(0, 123, 255);
            CreateButton.Location = new Point(269, 523);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(111, 45);
            CreateButton.TabIndex = 9;
            CreateButton.Text = "Sign Up";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(820, 685);
            Controls.Add(NewUserFormPanel);
            MinimumSize = new Size(838, 732);
            Name = "NewUserForm";
            Text = "NewUserForm";
            NewUserFormPanel.ResumeLayout(false);
            NewUserFormPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripMenuItem logInToolStripMenuItem;
        private Panel NewUserFormPanel;
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
        private Button CancelButton;
    }
}