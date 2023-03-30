using System;
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
            dynamic RegisterObject = new ExpandoObject();

            RegisterObject.Username = UsernameText.Text;
            RegisterObject.Password = PasswordText.Text;
            RegisterObject.Name = NameText.Text;
            RegisterObject.Region = RegionText.Text;

            File.WriteAllText(@"UserProfiles.json", JsonConvert.SerializeObject(RegisterObject, Formatting.Indented));
        }

        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
