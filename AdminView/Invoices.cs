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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CPMS
{
    public partial class Invoices : Form
    {
        private string DBString = "Data Source=DESKTOP-QM2QJB4\\SQLEXPRESS;Initial Catalog=CPMS;Integrated Security=True;Encrypt=False";

        public Invoices()
        {
            InitializeComponent();
            LoadInvoices();
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

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customers = new Customers();
            customers.Show();
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

        private void SearchINVBtn_Click(object sender, EventArgs e)
        {
            string INVToSearch = SearchTxt.Text;
            SearchINVNo(INVToSearch);
        }

        private void SearchINVNo(string invNo)
        {
            string query = "SELECT CusID, VLicense, DATE, OutTime, Duration, Amount FROM Invoice WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", invNo);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string cusId = reader["CusID"].ToString();
                    string license = reader["VLicense"].ToString();
                    string date = reader.GetDateTime(2).ToString("yyyy-MM-dd");
                    string outTime = reader.GetTimeSpan(3).ToString("HH:mm:ss");
                    string duration = reader.GetTimeSpan(4).ToString("HH:mm:ss");
                    string amount = reader.GetDecimal(5).ToString();
                    string title = "Searched Invoice Info";

                    MessageBox.Show($"Customer ID: {cusId}\nVehicle No: {license}\nDate: {date}\nOut Time: {outTime}\nDuration: {duration}\nFare: {amount}", title);
                }
                else
                {
                    MessageBox.Show("Invoice not found.");
                }

                reader.Close();
            }
        }

        private void ConfigureDataGridView()
        {
            INVdataView.AutoGenerateColumns = false;
            INVdataView.ReadOnly = true;
            INVdataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            INVdataView.MultiSelect = false;
            INVdataView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            INVdataView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            INVdataView.RowHeadersVisible = false;
            INVdataView.EnableHeadersVisualStyles = false;

            int totalWidth = INVdataView.Width;

            INVdataView.Columns["ID"].Width = (int)(totalWidth * 0.1);
            INVdataView.Columns["CusID"].Width = (int)(totalWidth * 0.2);
            INVdataView.Columns["VLicense"].Width = (int)(totalWidth * 0.2);
            INVdataView.Columns["DATE"].Width = (int)(totalWidth * 0.1);
            INVdataView.Columns["OutTime"].Width = (int)(totalWidth * 0.1);
            INVdataView.Columns["Duration"].Width = (int)(totalWidth * 0.1);
            INVdataView.Columns["Amount"].Width = (int)(totalWidth * 0.2);

            INVdataView.DefaultCellStyle.BackColor = Color.FromArgb(222, 208, 182);
            INVdataView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(250, 238, 209);
            INVdataView.DefaultCellStyle.SelectionForeColor = Color.Black;
            INVdataView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(187, 171, 140);
            INVdataView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(222, 208, 182);
        }

        private void LoadInvoices()
        {
            INVdataView.DataSource = GetINVDataTable();
        }

        private DataTable GetINVDataTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string query = @"SELECT ID, CusID, VLicense, DATE, OutTime, Duration, Amount FROM Invoice
                                 ORDER BY CAST(SUBSTRING(ID, 4, LEN(ID)) AS INT) ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
