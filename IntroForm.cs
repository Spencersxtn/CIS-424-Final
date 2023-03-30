using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroForm
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // send user to the login form
            LoginForm loginRedirect = new LoginForm();
            loginRedirect.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // send user to the register form
            // possibly fix names if the register form is different
            RegisterForm registerRedirect = new RegisterForm();
            registerRedirect.Show();
            this.Hide();
        }
    }
}
