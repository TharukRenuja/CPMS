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

                string query = @"SELECT ID FROM Employee
                                 ORDER BY CAST(SUBSTRING(ID, 4, LEN(ID)) AS INT) ASC";
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

        private void FetchInfoBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT ID, Name, Email, Contact, VLicense FROM Employee WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", PickCus.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string email = reader["Email"].ToString();
                    string contact = reader["Contact"].ToString();
                    string license = reader["VLicense"].ToString();

                    NameTxt.Text = name; 
                    EmailTxt.Text = email;
                    ContactNTxt.Text = contact;
                    LicenseTxt.Text = license;
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }

                reader.Close();
            }
        }
    }
}
