namespace CIS_424_Final
{
    partial class RegistrationForm
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
            RegistrationLabel = new Label();
            RegionLabel = new Label();
            NameLabel = new Label();
            PasswordLabel = new Label();
            RegionText = new TextBox();
            NameText = new TextBox();
            PasswordText = new TextBox();
            UsernameLabel = new Label();
            UsernameText = new TextBox();
            RegisterButton = new Button();
            CancelButton = new Button();
            LoginLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // RegistrationLabel
            // 
            RegistrationLabel.AutoSize = true;
            RegistrationLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            RegistrationLabel.Location = new Point(159, 9);
            RegistrationLabel.Name = "RegistrationLabel";
            RegistrationLabel.Size = new Size(281, 65);
            RegistrationLabel.TabIndex = 11;
            RegistrationLabel.Text = "Registration";
            // 
            // RegionLabel
            // 
            RegionLabel.AutoSize = true;
            RegionLabel.Location = new Point(136, 270);
            RegionLabel.Name = "RegionLabel";
            RegionLabel.Size = new Size(44, 15);
            RegionLabel.TabIndex = 19;
            RegionLabel.Text = "Region";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(141, 220);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 18;
            NameLabel.Text = "Name";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(123, 165);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 17;
            PasswordLabel.Text = "Password";
            // 
            // RegionText
            // 
            RegionText.Location = new Point(186, 262);
            RegionText.Name = "RegionText";
            RegionText.Size = new Size(278, 23);
            RegionText.TabIndex = 16;
            // 
            // NameText
            // 
            NameText.Location = new Point(186, 212);
            NameText.Name = "NameText";
            NameText.Size = new Size(278, 23);
            NameText.TabIndex = 15;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(186, 162);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(278, 23);
            PasswordText.TabIndex = 14;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(120, 115);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(60, 15);
            UsernameLabel.TabIndex = 13;
            UsernameLabel.Text = "Username";
            // 
            // UsernameText
            // 
            UsernameText.Location = new Point(186, 112);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(278, 23);
            UsernameText.TabIndex = 12;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = SystemColors.ActiveCaption;
            RegisterButton.Location = new Point(389, 314);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 46);
            RegisterButton.TabIndex = 20;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ActiveCaption;
            CancelButton.Location = new Point(186, 314);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 46);
            CancelButton.TabIndex = 21;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // LoginLinkLabel
            // 
            LoginLinkLabel.ActiveLinkColor = Color.Blue;
            LoginLinkLabel.AutoSize = true;
            LoginLinkLabel.Location = new Point(386, 377);
            LoginLinkLabel.Name = "LoginLinkLabel";
            LoginLinkLabel.Size = new Size(78, 15);
            LoginLinkLabel.TabIndex = 22;
            LoginLinkLabel.TabStop = true;
            LoginLinkLabel.Text = "Login Instead";
            LoginLinkLabel.LinkClicked += LoginLinkLabel_LinkClicked;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 411);
            Controls.Add(LoginLinkLabel);
            Controls.Add(CancelButton);
            Controls.Add(RegisterButton);
            Controls.Add(RegionLabel);
            Controls.Add(NameLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(RegionText);
            Controls.Add(NameText);
            Controls.Add(PasswordText);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameText);
            Controls.Add(RegistrationLabel);
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RegistrationLabel;
        private Label RegionLabel;
        private Label NameLabel;
        private Label PasswordLabel;
        private TextBox RegionText;
        private TextBox NameText;
        private TextBox PasswordText;
        private Label UsernameLabel;
        private TextBox UsernameText;
        private Button RegisterButton;
        private Button CancelButton;
        private LinkLabel LoginLinkLabel;
    }
}