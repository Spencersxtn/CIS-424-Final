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
    public partial class AccountManagement : Form
    {
        string username = Program.UserControl.CurrentUserUsername();
        string name = Program.UserControl.CurrentUserName();
        string region = Program.UserControl.CurrentUserRegion();

        public AccountManagement()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            usernameTextLabel.Text = username;
            nameText.Text = name;
            regionText.Text = region;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            passwordText.Text = "";
            if (changePasswordButton.Text == "Change")
            {
                changePasswordButton.Text = "Save";
                passwordText.Enabled = true;
            }
            else if (changePasswordButton.Text == "Save")
            {
                // run check for valid password input
                if (passwordText.Text != "")
                    Program.UserControl.UpdateUserPassword(passwordText.Text);
                changePasswordButton.Text = "Change";
                passwordText.Enabled = false;
                passwordText.Text = "dummypassword";
            }
        }

        private void editNameButton_Click(object sender, EventArgs e)
        {
            if (editNameButton.Text == "Edit")
            {
                editNameButton.Text = "Save";
                nameText.Enabled = true;
            }
            else if (editNameButton.Text == "Save")
            {
                // run check for valid input
                if (nameText.Text != "")
                    Program.UserControl.UpdateUserName(nameText.Text);
                editNameButton.Text = "Edit";
                nameText.Enabled = false;
            }
        }

        private void editRegionButton_Click(object sender, EventArgs e)
        {
            if (editRegionButton.Text == "Edit")
            {
                editRegionButton.Text = "Save";
                regionText.Enabled = true;
            }
            else if (editRegionButton.Text == "Save")
            {
                // run check for valid input
                if (regionText.Text != "")
                    Program.UserControl.UpdateUserRegion(regionText.Text);
                editRegionButton.Text = "Edit";
                regionText.Enabled = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            mainPage form = new mainPage();
            form.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Program.UserControl.LogOut();
            MessageBox.Show("You have successfully logged out.");
            LoginForm loginForm = new();
            loginForm.Show();
            this.Hide();
        }
    }
}
