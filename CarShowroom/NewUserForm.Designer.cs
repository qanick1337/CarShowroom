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
            FavoriteBrandsLabel = new Label();
            FavoriteBrandsListBox = new ListBox();
            AddBrandButton = new Button();
            UserBrandsTextBox = new TextBox();
            minPriceTextBox = new TextBox();
            WelcomeLabel = new Label();
            UserMailTextBox = new TextBox();
            maxPriceTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            Find_button = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(FavoriteBrandsLabel);
            panel1.Controls.Add(FavoriteBrandsListBox);
            panel1.Controls.Add(AddBrandButton);
            panel1.Controls.Add(UserBrandsTextBox);
            panel1.Controls.Add(minPriceTextBox);
            panel1.Controls.Add(WelcomeLabel);
            panel1.Controls.Add(UserMailTextBox);
            panel1.Controls.Add(maxPriceTextBox);
            panel1.Controls.Add(UserNameTextBox);
            panel1.Controls.Add(Find_button);
            panel1.Location = new Point(108, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 306);
            panel1.TabIndex = 6;
            // 
            // FavoriteBrandsLabel
            // 
            FavoriteBrandsLabel.AutoSize = true;
            FavoriteBrandsLabel.Location = new Point(339, 67);
            FavoriteBrandsLabel.Name = "FavoriteBrandsLabel";
            FavoriteBrandsLabel.Size = new Size(133, 25);
            FavoriteBrandsLabel.TabIndex = 14;
            FavoriteBrandsLabel.Text = "Favorite Brands";
            // 
            // FavoriteBrandsListBox
            // 
            FavoriteBrandsListBox.BackColor = Color.FromArgb(192, 255, 192);
            FavoriteBrandsListBox.FormattingEnabled = true;
            FavoriteBrandsListBox.ItemHeight = 25;
            FavoriteBrandsListBox.Location = new Point(339, 92);
            FavoriteBrandsListBox.Name = "FavoriteBrandsListBox";
            FavoriteBrandsListBox.Size = new Size(231, 129);
            FavoriteBrandsListBox.TabIndex = 13;
            // 
            // AddBrandButton
            // 
            AddBrandButton.BackColor = Color.FromArgb(255, 192, 128);
            AddBrandButton.FlatStyle = FlatStyle.Popup;
            AddBrandButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddBrandButton.Location = new Point(238, 151);
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
            UserBrandsTextBox.Location = new Point(24, 151);
            UserBrandsTextBox.Name = "UserBrandsTextBox";
            UserBrandsTextBox.PlaceholderText = "Brands you want to buy";
            UserBrandsTextBox.Size = new Size(208, 31);
            UserBrandsTextBox.TabIndex = 11;
            // 
            // minPriceTextBox
            // 
            minPriceTextBox.BackColor = Color.FromArgb(128, 255, 128);
            minPriceTextBox.Location = new Point(24, 190);
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
            // UserMailTextBox
            // 
            UserMailTextBox.BackColor = Color.FromArgb(192, 255, 192);
            UserMailTextBox.Location = new Point(24, 110);
            UserMailTextBox.Name = "UserMailTextBox";
            UserMailTextBox.PlaceholderText = "Your e-mail";
            UserMailTextBox.Size = new Size(278, 31);
            UserMailTextBox.TabIndex = 9;
            // 
            // maxPriceTextBox
            // 
            maxPriceTextBox.BackColor = Color.FromArgb(128, 255, 128);
            maxPriceTextBox.Location = new Point(163, 190);
            maxPriceTextBox.Name = "maxPriceTextBox";
            maxPriceTextBox.PlaceholderText = "Maximum Price";
            maxPriceTextBox.Size = new Size(139, 31);
            maxPriceTextBox.TabIndex = 5;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.BackColor = Color.FromArgb(192, 255, 192);
            UserNameTextBox.Location = new Point(24, 67);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.PlaceholderText = "Your name";
            UserNameTextBox.Size = new Size(278, 31);
            UserNameTextBox.TabIndex = 1;
            // 
            // Find_button
            // 
            Find_button.BackColor = Color.FromArgb(255, 192, 128);
            Find_button.FlatStyle = FlatStyle.Popup;
            Find_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Find_button.Location = new Point(254, 245);
            Find_button.Name = "Find_button";
            Find_button.Size = new Size(111, 38);
            Find_button.TabIndex = 0;
            Find_button.Text = "Create";
            Find_button.UseVisualStyleBackColor = false;
            Find_button.Click += Find_button_Click;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(833, 450);
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
        private TextBox UserMailTextBox;
        private TextBox maxPriceTextBox;
        private TextBox UserNameTextBox;
        private Button Find_button;
        private TextBox UserBrandsTextBox;
        private Button AddBrandButton;
        private ListBox FavoriteBrandsListBox;
        private Label FavoriteBrandsLabel;
    }
}