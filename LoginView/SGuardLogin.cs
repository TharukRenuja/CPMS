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
    public partial class SGuardLogin : Form
    {
        public SGuardLogin()
        {
            InitializeComponent();
        }

        private void SGuardLogin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
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

            if (uname == "sguard" && pwd == "SGuard@CPMS")
            {
                this.Hide();
                GDashboard gDash = new GDashboard();
                gDash.Show();
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
    }
}
