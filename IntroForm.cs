using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_424_Final
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // send user to the login form
            MessageBox.Show("Login Redirect Detected");
            // previous method of redirection
            // unsure why LoginForm doesn't count as a form
            /*
            LoginForm loginRedirect = new LoginForm();
            loginRedirect.Show();
            this.Hide();
             */
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // send user to the register form
            MessageBox.Show("Register Redirect Detected");
            // previous method of redirection
            // waiting on RegisterForm to be created
            /*
            RegisterForm registerRedirect = new RegisterForm();
            registerRedirect.Show();
            this.Hide();
            */
        }
    }
}
