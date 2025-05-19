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
            LoginCancelButton = new Button();
            PasswordlLabel = new Label();
            MailLabel = new Label();
            UserPasswordTextBox = new TextBox();
            WelcomeBackLabel = new Label();
            UserMailTextBox = new TextBox();
            LoginButton = new Button();
            RetryLabel = new Label();
            RetryButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(RetryButton);
            panel1.Controls.Add(RetryLabel);
            panel1.Controls.Add(LoginCancelButton);
            panel1.Controls.Add(PasswordlLabel);
            panel1.Controls.Add(MailLabel);
            panel1.Controls.Add(UserPasswordTextBox);
            panel1.Controls.Add(WelcomeBackLabel);
            panel1.Controls.Add(UserMailTextBox);
            panel1.Controls.Add(LoginButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 514);
            panel1.TabIndex = 7;
            // 
            // LoginCancelButton
            // 
            LoginCancelButton.BackColor = Color.FromArgb(255, 192, 128);
            LoginCancelButton.FlatStyle = FlatStyle.Popup;
            LoginCancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginCancelButton.Location = new Point(399, 305);
            LoginCancelButton.Name = "LoginCancelButton";
            LoginCancelButton.Size = new Size(113, 44);
            LoginCancelButton.TabIndex = 18;
            LoginCancelButton.Text = "Cancel";
            LoginCancelButton.UseVisualStyleBackColor = false;
            LoginCancelButton.Click += LoginCancelButton_Click;
            // 
            // PasswordlLabel
            // 
            PasswordlLabel.AutoSize = true;
            PasswordlLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PasswordlLabel.Location = new Point(234, 194);
            PasswordlLabel.Name = "PasswordlLabel";
            PasswordlLabel.Size = new Size(207, 38);
            PasswordlLabel.TabIndex = 17;
            PasswordlLabel.Text = "Your password";
            // 
            // MailLabel
            // 
            MailLabel.AutoSize = true;
            MailLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MailLabel.Location = new Point(234, 103);
            MailLabel.Name = "MailLabel";
            MailLabel.Size = new Size(167, 38);
            MailLabel.TabIndex = 16;
            MailLabel.Text = "Your e-mail";
            // 
            // UserPasswordTextBox
            // 
            UserPasswordTextBox.BackColor = Color.White;
            UserPasswordTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserPasswordTextBox.Location = new Point(234, 235);
            UserPasswordTextBox.Name = "UserPasswordTextBox";
            UserPasswordTextBox.Size = new Size(278, 45);
            UserPasswordTextBox.TabIndex = 15;
            // 
            // WelcomeBackLabel
            // 
            WelcomeBackLabel.Anchor = AnchorStyles.Top;
            WelcomeBackLabel.AutoSize = true;
            WelcomeBackLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WelcomeBackLabel.ForeColor = Color.FromArgb(0, 123, 255);
            WelcomeBackLabel.Location = new Point(71, 17);
            WelcomeBackLabel.Name = "WelcomeBackLabel";
            WelcomeBackLabel.Size = new Size(654, 51);
            WelcomeBackLabel.TabIndex = 2;
            WelcomeBackLabel.Text = "Welcome back to the Auto Matcher";
            // 
            // UserMailTextBox
            // 
            UserMailTextBox.BackColor = Color.White;
            UserMailTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserMailTextBox.Location = new Point(234, 144);
            UserMailTextBox.Name = "UserMailTextBox";
            UserMailTextBox.Size = new Size(278, 45);
            UserMailTextBox.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(0, 123, 255);
            LoginButton.FlatStyle = FlatStyle.Popup;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(234, 305);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(113, 44);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // RetryLabel
            // 
            RetryLabel.Anchor = AnchorStyles.Top;
            RetryLabel.AutoSize = true;
            RetryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RetryLabel.ForeColor = Color.Black;
            RetryLabel.Location = new Point(130, 414);
            RetryLabel.Name = "RetryLabel";
            RetryLabel.Size = new Size(280, 32);
            RetryLabel.TabIndex = 25;
            RetryLabel.Text = "Don't have an account?";
            // 
            // RetryButton
            // 
            RetryButton.BackColor = Color.FromArgb(249, 250, 251);
            RetryButton.DialogResult = DialogResult.Retry;
            RetryButton.FlatStyle = FlatStyle.Popup;
            RetryButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RetryButton.ForeColor = Color.FromArgb(0, 123, 255);
            RetryButton.Location = new Point(413, 408);
            RetryButton.Margin = new Padding(0);
            RetryButton.Name = "RetryButton";
            RetryButton.Size = new Size(205, 45);
            RetryButton.TabIndex = 26;
            RetryButton.Text = "Create account";
            RetryButton.UseVisualStyleBackColor = false;
            RetryButton.Click += RetryButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 538);
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
        private Button LoginCancelButton;
        private Label RetryLabel;
        private Button RetryButton;
    }
}