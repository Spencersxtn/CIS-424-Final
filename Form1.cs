using Newtonsoft.Json;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using System.Data;

namespace CIS_424_Final
{
    public partial class mainPage : Form
    {
        private DataGridView dataGridView = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();

        public mainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PlantControl.RetrievePlantTable(Program.PlantPath);
            dataGridView1.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.UserControl.LogOut();
            MessageBox.Show("You have successfully logged out.");
            LoginForm loginForm = new();
            loginForm.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.UserControl.LogOut();
            MessageBox.Show("You have successfully logged out.");
            LoginForm loginForm = new();
            loginForm.Show();
            this.Hide();
        }

        private void changeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroForm frm = new IntroForm();
            frm.Show();
            this.Hide();
        }

        private void registerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
            this.Hide();
        }
    }
}