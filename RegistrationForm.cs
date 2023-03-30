﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;
using Newtonsoft.Json;

namespace CIS_424_Final
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            UserProfile newUser = new(UsernameText.Text, PasswordText.Text, NameText.Text, RegionText.Text);
            Program.Users.Add(newUser);
            newUser.AddUser(Program.JsonPath);
            MessageBox.Show("Successfully Registered!");
            mainPage form = new();
            form.Show();
            this.Hide();
        }

        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new();
            loginForm.Show();
            this.Close();
        }
    }
}
