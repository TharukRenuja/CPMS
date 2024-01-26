using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPMS
{
    public partial class Employees : Form
    {
        private string DBString = "Data Source=DESKTOP-QM2QJB4\\SQLEXPRESS;Initial Catalog=CPMS;Integrated Security=True;Encrypt=False";

        public Employees()
        {
            InitializeComponent();
            LoadEmployees();
            ConfigureDataGridView();
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

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void SearchEmpBtn_Click(object sender, EventArgs e)
        {
            string employeeIdToSearch = SearchTxt.Text;
            SearchEMPId(employeeIdToSearch);
        }

        private void SearchEMPId(string employeeId)
        {
            string query = "SELECT ID, Name, Email, Contact, VLicense FROM Employee WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", employeeId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string empId = reader["ID"].ToString();
                    string name = reader["Name"].ToString();
                    string email = reader["Email"].ToString();
                    string contact = reader["Contact"].ToString();
                    string license = reader["VLicense"].ToString();
                    string title = "Searched Employee Info";

                    MessageBox.Show($"Name: {name}\nEmail: {email}\nContact No: {contact}\nLicense No: {license}", title);
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }

                reader.Close();
            }
        }

        private void ConfigureDataGridView()
        {
            EMPdataView.AutoGenerateColumns = false;
            EMPdataView.ReadOnly = true;
            EMPdataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EMPdataView.MultiSelect = false;
            EMPdataView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EMPdataView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EMPdataView.RowHeadersVisible = false;
            EMPdataView.EnableHeadersVisualStyles = false;

            int totalWidth = EMPdataView.Width;

            EMPdataView.Columns["ID"].Width = (int)(totalWidth * 0.1);
            EMPdataView.Columns["Name"].Width = (int)(totalWidth * 0.3);
            EMPdataView.Columns["Email"].Width = (int)(totalWidth * 0.4);
            EMPdataView.Columns["Contact"].Width = (int)(totalWidth * 0.1);
            EMPdataView.Columns["VLicense"].Width = (int)(totalWidth * 0.1);

            EMPdataView.DefaultCellStyle.BackColor = Color.FromArgb(222, 208, 182);
            EMPdataView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(250, 238, 209);
            EMPdataView.DefaultCellStyle.SelectionForeColor = Color.Black;
            EMPdataView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(187, 171, 140);
            EMPdataView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(222, 208, 182);
        }

        private void LoadEmployees()
        {
            EMPdataView.DataSource = GetEmployeesDataTable();
        }

        private DataTable GetEmployeesDataTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string query = "SELECT ID, Name, Email, Contact, VLicense FROM Employee";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void EditEmpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditEmployee editEmp = new EditEmployee();
            editEmp.Show();
        }

        private void DelEmpBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                string removeVehicleQuery = "DELETE FROM Employee WHERE ID = @ID";
                SqlCommand removeVehicleCommand = new SqlCommand(removeVehicleQuery, connection);
                removeVehicleCommand.Parameters.AddWithValue("@ID", DelEMPTxt.Text);
                removeVehicleCommand.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Succesfully!");
                LoadEmployees();
                ConfigureDataGridView();
            }
        }
    }
}
