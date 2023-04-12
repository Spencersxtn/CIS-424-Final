namespace CIS_424_Final
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
            Enter = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            userName = new Label();
            passWord = new Label();
            textName = new TextBox();
            textPassword = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Enter
            // 
            Enter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Enter.ForeColor = Color.Blue;
            Enter.Location = new Point(378, 508);
            Enter.Name = "Enter";
            Enter.Size = new Size(192, 60);
            Enter.TabIndex = 0;
            Enter.Text = "ENTER";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(187, 681);
            button1.Name = "button1";
            button1.Size = new Size(185, 58);
            button1.TabIndex = 1;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(185, 597);
            button2.Name = "button2";
            button2.Size = new Size(385, 58);
            button2.TabIndex = 2;
            button2.Text = "NEW USER REGISTER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(185, 508);
            button3.Name = "button3";
            button3.Size = new Size(187, 60);
            button3.TabIndex = 3;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userName.ForeColor = Color.Blue;
            userName.Location = new Point(41, 308);
            userName.Name = "userName";
            userName.Size = new Size(195, 45);
            userName.TabIndex = 4;
            userName.Text = "USERNAME";
            userName.Click += label1_Click;
            // 
            // passWord
            // 
            passWord.AutoSize = true;
            passWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passWord.ForeColor = Color.Blue;
            passWord.Location = new Point(41, 390);
            passWord.Name = "passWord";
            passWord.Size = new Size(198, 45);
            passWord.TabIndex = 5;
            passWord.Text = "PASSWORD";
            passWord.Click += label2_Click;
            // 
            // textName
            // 
            textName.Location = new Point(279, 308);
            textName.Name = "textName";
            textName.Size = new Size(277, 39);
            textName.TabIndex = 6;
            textName.TextChanged += textBox1_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(279, 397);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(277, 39);
            textPassword.TabIndex = 7;
            textPassword.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(328, 209);
            label1.Name = "label1";
            label1.Size = new Size(170, 59);
            label1.TabIndex = 8;
            label1.Text = "LOG IN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logiPic;
            pictureBox1.Location = new Point(328, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 765);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textPassword);
            Controls.Add(textName);
            Controls.Add(passWord);
            Controls.Add(userName);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Enter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Enter;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label userName;
        private Label passWord;
        private TextBox textName;
        private TextBox textPassword;
        private Label label1;
        private PictureBox pictureBox1;
    }
}