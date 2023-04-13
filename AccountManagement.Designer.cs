namespace CIS_424_Final
{
    partial class AccountManagement
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
            usernameLabel = new Label();
            passwordLabel = new Label();
            nameLabel = new Label();
            regionLabel = new Label();
            usernameTextLabel = new Label();
            passwordText = new TextBox();
            changePasswordButton = new Button();
            nameText = new TextBox();
            editNameButton = new Button();
            regionText = new TextBox();
            editRegionButton = new Button();
            closeButton = new Button();
            logoutButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(12, 30);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(66, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 70);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(63, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password: ";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 110);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(45, 15);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name: ";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new Point(12, 150);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new Size(50, 15);
            regionLabel.TabIndex = 3;
            regionLabel.Text = "Region: ";
            // 
            // usernameTextLabel
            // 
            usernameTextLabel.AutoSize = true;
            usernameTextLabel.Location = new Point(84, 30);
            usernameTextLabel.Name = "usernameTextLabel";
            usernameTextLabel.Size = new Size(27, 15);
            usernameTextLabel.TabIndex = 4;
            usernameTextLabel.Text = "text";
            // 
            // passwordText
            // 
            passwordText.Enabled = false;
            passwordText.Location = new Point(84, 67);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(192, 23);
            passwordText.TabIndex = 5;
            passwordText.Text = "dummypassword";
            passwordText.UseSystemPasswordChar = true;
            // 
            // changePasswordButton
            // 
            changePasswordButton.Location = new Point(297, 67);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(75, 23);
            changePasswordButton.TabIndex = 6;
            changePasswordButton.Text = "Change";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // nameText
            // 
            nameText.Enabled = false;
            nameText.Location = new Point(84, 107);
            nameText.Name = "nameText";
            nameText.Size = new Size(192, 23);
            nameText.TabIndex = 7;
            // 
            // editNameButton
            // 
            editNameButton.Location = new Point(297, 107);
            editNameButton.Name = "editNameButton";
            editNameButton.Size = new Size(75, 23);
            editNameButton.TabIndex = 8;
            editNameButton.Text = "Edit";
            editNameButton.UseVisualStyleBackColor = true;
            editNameButton.Click += editNameButton_Click;
            // 
            // regionText
            // 
            regionText.Enabled = false;
            regionText.Location = new Point(84, 147);
            regionText.Name = "regionText";
            regionText.Size = new Size(192, 23);
            regionText.TabIndex = 9;
            // 
            // editRegionButton
            // 
            editRegionButton.Location = new Point(297, 147);
            editRegionButton.Name = "editRegionButton";
            editRegionButton.Size = new Size(75, 23);
            editRegionButton.TabIndex = 10;
            editRegionButton.Text = "Edit";
            editRegionButton.UseVisualStyleBackColor = true;
            editRegionButton.Click += editRegionButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(12, 214);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 35);
            closeButton.TabIndex = 11;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(297, 214);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 35);
            logoutButton.TabIndex = 12;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(logoutButton);
            Controls.Add(closeButton);
            Controls.Add(editRegionButton);
            Controls.Add(regionText);
            Controls.Add(editNameButton);
            Controls.Add(nameText);
            Controls.Add(changePasswordButton);
            Controls.Add(passwordText);
            Controls.Add(usernameTextLabel);
            Controls.Add(regionLabel);
            Controls.Add(nameLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Margin = new Padding(2);
            Name = "AccountManagement";
            Text = "AccountManagement";
            Load += AccountManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private Label nameLabel;
        private Label regionLabel;
        private Label usernameTextLabel;
        private TextBox passwordText;
        private Button changePasswordButton;
        private TextBox nameText;
        private Button editNameButton;
        private TextBox regionText;
        private Button editRegionButton;
        private Button closeButton;
        private Button logoutButton;
    }
}