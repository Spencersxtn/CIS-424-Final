using Newtonsoft.Json;
using System.Configuration;
using System.Runtime.InteropServices;

namespace CIS_424_Final
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.UserControl.LogOut();
            MessageBox.Show("You have successfully logged out.");
            LoginForm loginForm = new();
            loginForm.Show();
            this.Hide();
        }
    }
}