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
    public partial class EditEmployee : Form
    {
        private string DBString = "Data Source=DESKTOP-QM2QJB4\\SQLEXPRESS;Initial Catalog=CPMS;Integrated Security=True;Encrypt=False";

        public EditEmployee()
        {
            InitializeComponent();
            LoadCustomers();
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
            Employees employees = new Employees();
            employees.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void SaveChanges()
        {
            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string query = "UPDATE Employee SET Name = @Name, Email = @Email, Contact = @Contact, VLicense = @VLicense WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Name", NameTxt.Text);
                    command.Parameters.AddWithValue("@Email", EmailTxt.Text);
                    command.Parameters.AddWithValue("@Contact", ContactNTxt.Text);
                    command.Parameters.AddWithValue("@VLicense", LicenseTxt.Text);
                    command.Parameters.AddWithValue("@ID", PickCus.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Changes saved successfully!");
                        this.Hide();
                        Employees employees = new Employees();
                        employees.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save changes!");
                    }
                }
            }
        }

        private void LoadCustomers()
        {
            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string query = "SELECT ID FROM Employee";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string empID = reader.GetString(0);
                        PickCus.Items.Add(empID);
                    }
                }
            }
        }

        private void EditEmpBtn_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}
