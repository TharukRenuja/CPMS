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
    public partial class Customers : Form
    {
        private string DBString = "Data Source=DESKTOP-QM2QJB4\\SQLEXPRESS;Initial Catalog=CPMS;Integrated Security=True;Encrypt=False";

        public Customers()
        {
            InitializeComponent();
            LoadCustomers();
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

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees employees = new Employees();
            employees.Show();
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

        private void SearchCusBtn_Click(object sender, EventArgs e)
        {
            string cusNoToSearch = SearchTxt.Text;
            SearchcusNo(cusNoToSearch);
        }

        private void SearchcusNo(string cusNo)
        {
            string query = "SELECT ID, Name, Contact, VLicense FROM Customer WHERE Contact = @Contact";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Contact", cusNo);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string empId = reader["ID"].ToString();
                    string name = reader["Name"].ToString();
                    string contact = reader["Contact"].ToString();
                    string license = reader["VLicense"].ToString();
                    string title = "Searched Customer Info";

                    MessageBox.Show($"Name: {name}\nContact No: {contact}\nLicense No: {license}", title);
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }

                reader.Close();
            }
        }

        private void ConfigureDataGridView()
        {
            CusdataView.AutoGenerateColumns = false;
            CusdataView.ReadOnly = true;
            CusdataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CusdataView.MultiSelect = false;
            CusdataView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CusdataView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CusdataView.RowHeadersVisible = false;
            CusdataView.EnableHeadersVisualStyles = false;

            int totalWidth = CusdataView.Width;

            CusdataView.Columns["ID"].Width = (int)(totalWidth * 0.2);
            CusdataView.Columns["Name"].Width = (int)(totalWidth * 0.3);
            CusdataView.Columns["Contact"].Width = (int)(totalWidth * 0.3);
            CusdataView.Columns["VLicense"].Width = (int)(totalWidth * 0.2);

            CusdataView.DefaultCellStyle.BackColor = Color.FromArgb(222, 208, 182);
            CusdataView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(250, 238, 209);
            CusdataView.DefaultCellStyle.SelectionForeColor = Color.Black;
            CusdataView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(187, 171, 140);
            CusdataView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(222, 208, 182);
        }

        private void LoadCustomers()
        {
            CusdataView.DataSource = GetCusDataTable();
        }

        private DataTable GetCusDataTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string query = "SELECT ID, Name, Contact, VLicense FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
