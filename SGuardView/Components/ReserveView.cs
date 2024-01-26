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
    public partial class ReserveView : Form
    {
        public ReserveView()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void ReserveEMPVBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleReserveEMP empReserve = new VehicleReserveEMP();
            empReserve.Show();
        }

        private void ReserveCUSVBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleReserveCUS cusReserve = new VehicleReserveCUS();
            cusReserve.Show();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GDashboard dashboard = new GDashboard();
            dashboard.Show();
        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicles employees = new Vehicles();
            employees.Show();
        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GCustomers customers = new GCustomers();
            customers.Show();
        }

        private void InvoicesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GInvoices invoices = new GInvoices();
            invoices.Show();
        }

        private void StatusBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GStatus aStatus = new GStatus();
            aStatus.Show();
        }

        private void B2ResBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicles vehicles = new Vehicles();
            vehicles.Show();
        }
    }
}
