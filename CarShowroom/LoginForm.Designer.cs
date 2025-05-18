namespace CarShowroom
{
    partial class LoginForm
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
            button1 = new Button();
            PasswordlLabel = new Label();
            MailLabel = new Label();
            UserPasswordTextBox = new TextBox();
            WelcomeBackLabel = new Label();
            UserMailTextBox = new TextBox();
            LoginButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PasswordlLabel);
            panel1.Controls.Add(MailLabel);
            panel1.Controls.Add(UserPasswordTextBox);
            panel1.Controls.Add(WelcomeBackLabel);
            panel1.Controls.Add(UserMailTextBox);
            panel1.Controls.Add(LoginButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 430);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(369, 298);
            button1.Name = "button1";
            button1.Size = new Size(113, 44);
            button1.TabIndex = 18;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // PasswordlLabel
            // 
            PasswordlLabel.AutoSize = true;
            PasswordlLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordlLabel.Location = new Point(208, 187);
            PasswordlLabel.Name = "PasswordlLabel";
            PasswordlLabel.Size = new Size(196, 38);
            PasswordlLabel.TabIndex = 17;
            PasswordlLabel.Text = "Your password";
            // 
            // MailLabel
            // 
            MailLabel.AutoSize = true;
            MailLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MailLabel.Location = new Point(208, 96);
            MailLabel.Name = "MailLabel";
            MailLabel.Size = new Size(158, 38);
            MailLabel.TabIndex = 16;
            MailLabel.Text = "Your e-mail";
            // 
            // UserPasswordTextBox
            // 
            UserPasswordTextBox.BackColor = Color.FromArgb(192, 255, 192);
            UserPasswordTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserPasswordTextBox.Location = new Point(208, 228);
            UserPasswordTextBox.Name = "UserPasswordTextBox";
            UserPasswordTextBox.Size = new Size(278, 45);
            UserPasswordTextBox.TabIndex = 15;
            // 
            // WelcomeBackLabel
            // 
            WelcomeBackLabel.Anchor = AnchorStyles.Top;
            WelcomeBackLabel.AutoSize = true;
            WelcomeBackLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WelcomeBackLabel.ForeColor = Color.FromArgb(128, 255, 128);
            WelcomeBackLabel.Location = new Point(50, 17);
            WelcomeBackLabel.Name = "WelcomeBackLabel";
            WelcomeBackLabel.Size = new Size(616, 48);
            WelcomeBackLabel.TabIndex = 2;
            WelcomeBackLabel.Text = "Welcome back to the Auto Matcher";
            // 
            // UserMailTextBox
            // 
            UserMailTextBox.BackColor = Color.FromArgb(192, 255, 192);
            UserMailTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserMailTextBox.Location = new Point(208, 137);
            UserMailTextBox.Name = "UserMailTextBox";
            UserMailTextBox.Size = new Size(278, 45);
            UserMailTextBox.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(128, 255, 128);
            LoginButton.FlatStyle = FlatStyle.Popup;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginButton.Location = new Point(213, 298);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(113, 44);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 454);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CancelButton;
        private Label FavoriteModelsLabel;
        private ListBox FavoriteModelsListBox;
        private Label PricingLabel;
        private Button AddModelTextBox;
        private TextBox UserModelsTextBox;
        private Label PrefferedCarsLabel;
        private Label MailLabel;
        private TextBox UserPasswordTextBox;
        private Label FavoriteBrandsLabel;
        private ListBox FavoriteBrandsListBox;
        private Button AddBrandButton;
        private TextBox UserBrandsTextBox;
        private TextBox minPriceTextBox;
        private Label WelcomeBackLabel;
        private TextBox maxPriceTextBox;
        private TextBox UserMailTextBox;
        private Button LoginButton;
        private Label PasswordlLabel;
        private Button button1;
    }
}