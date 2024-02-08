using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPMS
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            HidePWDBtn.Visible = false;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void StatusBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Status status = new Status();
            status.Show();
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact contact = new Contact();
            contact.Show();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            About about = new About();
            about.Show();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            string uname = UNameTxt.Text;
            string pwd = PWDTxt.Text;

            if (uname == "admin" && pwd == "Admin@CPMS")
            {
                this.Hide();
                Dashboard aDash = new Dashboard();
                aDash.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect.");
                PWDTxt.Clear();
            }
        }

        private void B2LogBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void ShowPWDBtn_Click(object sender, EventArgs e)
        {
            PWDTxt.UseSystemPasswordChar = false;
            ShowPWDBtn.Visible = false;
            HidePWDBtn.Visible = true;
        }

        private void HidePWDBtn_Click(object sender, EventArgs e)
        {
            PWDTxt.UseSystemPasswordChar = true;
            HidePWDBtn.Visible = false;
            ShowPWDBtn.Visible = true;
        }
    }
}
