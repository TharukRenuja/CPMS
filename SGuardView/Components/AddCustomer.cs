using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace CPMS
{
    public partial class AddCustomer : Form
    {
        private string DBString = "Data Source=DESKTOP-QM2QJB4\\SQLEXPRESS;Initial Catalog=CPMS;Integrated Security=True;Encrypt=False";

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GDashboard dashboard = new GDashboard();
            dashboard.Show();
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

        private void VehiclesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicles vehicles = new Vehicles();
            vehicles.Show();
        }

        private void B2CUSBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GCustomers customers = new GCustomers();
            customers.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void AddCusBtn_Click(object sender, EventArgs e)
        {
            string lastEMPID = GetlastCusID();
            string nextEMPID = GenNextCusID(lastEMPID);

            InsertCustomer(nextEMPID, NameTxt.Text, ContactNTxt.Text, LicenseTxt.Text);

            MessageBox.Show("New Customer added successfully!");
            this.Hide();
            Employees employees = new Employees();
            employees.Show();
        }

        private string GetlastCusID()
        {
            string query = "SELECT TOP 1 ID FROM Customer ORDER BY ID DESC";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                return result == null ? "CUS0" : result.ToString();
            }
        }

        private string GenNextCusID(string lastEMPID)
        {
            int lastIdNumber = int.Parse(lastEMPID.Substring(3));
            int nextIdNumber = lastIdNumber + 1;
            return "CUS" + nextIdNumber.ToString();
        }

        private void InsertCustomer(string empId, string name, string contactNo, string licenseNo)
        {
            string query = "INSERT INTO Customer (ID, Name, Contact, VLicense) VALUES (@ID, @Name, @Contact, @VLicense)";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ID", empId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Contact", contactNo);
                command.Parameters.AddWithValue("@VLicense", licenseNo);

                command.ExecuteNonQuery();
            }
        }
    }
}
