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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
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

        private void AdminLoginVBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        private void SGuardLoginVBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SGuardLogin sGuardLogin = new SGuardLogin();
            sGuardLogin.Show();
        }
    }
}
