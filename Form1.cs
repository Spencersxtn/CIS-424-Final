using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace CIS_424_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
            Program.GetJson();
            UserProfile userProfile = new UserProfile("test", "deleteme", "remove", "US");
            userProfile.AddUser(Program.JsonPath);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}