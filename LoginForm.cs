using System;
using System.Linq;
using System.Windows.Forms;


namespace CIS_424_Final
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Program.GetJson(); // Load user profiles from JSON file
        }



        private void Enter_Click(object sender, EventArgs e)
        {
            string username = textName.Text;
            string password = textPassword.Text;


            // Find user profile in list of users
            UserProfile? user = Program.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // Login successful, display welcome message
                Program.UserControl.LogIn(user);
                mainPage page = new();
                page.Show();
                this.Hide();

                MessageBox.Show($"Welcome, {Program.UserControl.CurrentUserName()} from {Program.UserControl.CurrentUserRegion()}!");
            }
            else
            {
                // Login failed, display error message
                MessageBox.Show("Invalid username or password.");
            }
        }

        //Exit application
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Registration page
        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new();
            registrationForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textPassword.Clear();

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



