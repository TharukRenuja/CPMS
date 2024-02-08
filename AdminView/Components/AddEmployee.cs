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
    public partial class AddEmployee : Form
    {
        private string DBString = "Data Source=DESKTOP-QM2QJB4\\SQLEXPRESS;Initial Catalog=CPMS;Integrated Security=True;Encrypt=False";

        public AddEmployee()
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
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customers = new Customers();
            customers.Show();
        }

        private void InvoicesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoices invoices = new Invoices();
            invoices.Show();
        }

        private void StatusBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AStatus aStatus = new AStatus();
            aStatus.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void AddEMPBtn_Click(object sender, EventArgs e)
        {
            string lastEMPID = GetlastEMPID();
            string nextEMPID = GeneratenextEMPID(lastEMPID);

            InsertEmployee(nextEMPID, NameTxt.Text, EmailTxt.Text, ContactNTxt.Text, LicenseTxt.Text);

            MessageBox.Show("New Employee added successfully!");
            this.Hide();
            Employees employees = new Employees();
            employees.Show();
        }

        private string GetlastEMPID()
        {
            string query = @"SELECT TOP 1 ID
                             FROM Employee
                             ORDER BY CAST(SUBSTRING(ID, 4, LEN(ID)) AS INT) DESC
                            ";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                return result == null ? "EMP0" : result.ToString();
            }
        }

        private string GeneratenextEMPID(string lastEMPID)
        {
            int lastIdNumber = int.Parse(lastEMPID.Substring(3));
            int nextIdNumber = lastIdNumber + 1;
            return "EMP" + nextIdNumber.ToString();
        }

        private void InsertEmployee(string empId, string name, string email, string contactNo, string licenseNo)
        {
            string query = "INSERT INTO Employee (ID, Name, Email, Contact, VLicense) VALUES (@ID, @Name, @Email, @Contact, @VLicense)";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ID", empId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Contact", contactNo);
                command.Parameters.AddWithValue("@VLicense", licenseNo);

                command.ExecuteNonQuery();
            }
        }

        private void B2LogBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees employees = new Employees();
            employees.Show();
        }
    }
}
