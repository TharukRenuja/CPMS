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
using System.Xml.Linq;

namespace CPMS
{
    public partial class Vehicles : Form
    {
        private string DBString = "Data Source=DESKTOP-QM2QJB4\\SQLEXPRESS;Initial Catalog=CPMS;Integrated Security=True;Encrypt=False";

        public Vehicles()
        {
            InitializeComponent();
            LoadVehicleData();
            ConfigureDataGridView();
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

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void SearchVDBtn_Click(object sender, EventArgs e)
        {
            string VDNoToSearch = SearchTxt.Text;
            SearchVDNo(VDNoToSearch);
        }

        private void SearchVDNo(string vehicleNo)
        {
            string query = "SELECT ID, VLicense, OwnerID, InTime, ContactNo FROM Vehicle WHERE VLicense = @VLicense";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@VLicense", vehicleNo);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string vehicleId = reader["ID"].ToString();
                    string license = reader["VLicense"].ToString();
                    string owner = reader["OwnerID"].ToString();
                    string inTime = FormatInTime(reader["InTime"]);
                    string contact = reader["ContactNo"].ToString();

                    bool isEmployee = owner.StartsWith("EMP");
                    bool isCustomer = owner.StartsWith("CUS");
                    string ownerName = GetOwnerName(owner, isEmployee);

                    string title = "Searched Vehicle Info";

                    MessageBox.Show($"Owner: {ownerName}\nIs it an EMP Vehicle: {isEmployee}\nContact No: {contact}\nLicense No: {license}\nIn Time: {inTime}", title);
                }
                else
                {
                    MessageBox.Show("Vehicle not found.");
                }

                reader.Close();
            }
        }

        private string FormatInTime(object inTimeObject)
        {
            if (inTimeObject != DBNull.Value)
            {
                TimeSpan inTime = (TimeSpan)inTimeObject;
                DateTime dummyDate = DateTime.Today;
                DateTime combinedDateTime = dummyDate.Add(inTime);
                return combinedDateTime.ToString("hh:mm tt");
            }

            return string.Empty;
        }


        private string GetOwnerName(string ownerId, bool isEmployee)
        {
            string tableName = isEmployee ? "Employee" : "Customer";
            string idColumnName = isEmployee ? "ID" : "ID";
            string nameColumnName = isEmployee ? "Name" : "Name";

            string query = $"SELECT {nameColumnName} FROM {tableName} WHERE {idColumnName} = @ID";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ownerId);

                object result = command.ExecuteScalar();

                return result != null ? result.ToString() : "Unknown";
            }
        }

        private void ConfigureDataGridView()
        {
            // DataGridView controls
            VehicleDView.AutoGenerateColumns = false;
            VehicleDView.ReadOnly = true;
            VehicleDView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VehicleDView.MultiSelect = false;
            VehicleDView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            VehicleDView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            VehicleDView.RowHeadersVisible = false;
            VehicleDView.EnableHeadersVisualStyles = false;

            int totalWidth = VehicleDView.Width;

            VehicleDView.Columns["ID"].Width = (int)(totalWidth * 0.1);
            VehicleDView.Columns["Owner"].Width = (int)(totalWidth * 0.3);
            VehicleDView.Columns["LicenseNo"].Width = (int)(totalWidth * 0.2);
            VehicleDView.Columns["ContactNo"].Width = (int)(totalWidth * 0.2);
            VehicleDView.Columns["InTime"].Width = (int)(totalWidth * 0.2);

            VehicleDView.DefaultCellStyle.BackColor = Color.FromArgb(222, 208, 182);
            VehicleDView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(250, 238, 209);
            VehicleDView.DefaultCellStyle.SelectionForeColor = Color.Black;
            VehicleDView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(187, 171, 140);
            VehicleDView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(222, 208, 182);
        }

        private void LoadVehicleData()
        {
            GetVehicleData();
        }

        private void GetVehicleData()
        {
            string query = @"
                                SELECT Vehicle.ID, Vehicle.VLicense, Vehicle.OwnerID, Vehicle.InTime, Vehicle.ContactNo, 
                                        CASE 
                                            WHEN Vehicle.OwnerID LIKE 'EMP%' THEN Employee.Name 
                                            WHEN Vehicle.OwnerID LIKE 'CUS%' THEN Customer.Name 
                                            ELSE 'Unknown' 
                                        END AS OwnerName 
                                FROM Vehicle 
                                LEFT JOIN Employee ON Vehicle.OwnerID = Employee.ID 
                                LEFT JOIN Customer ON Vehicle.OwnerID = Customer.ID;
                            ";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID", typeof(string));
                dataTable.Columns.Add("Owner", typeof(string));
                dataTable.Columns.Add("LicenseNo", typeof(string));
                dataTable.Columns.Add("ContactNo", typeof(string));
                dataTable.Columns.Add("InTime", typeof(string));

                while (reader.Read())
                {
                    string vehicleID = reader["ID"].ToString();
                    string license = reader["VLicense"].ToString();
                    string ownerName = reader["OwnerName"].ToString();
                    string inTime = FormatInTime(reader["InTime"]);
                    string contact = reader["ContactNo"].ToString();

                    dataTable.Rows.Add(vehicleID, ownerName, license, contact, inTime);
                }

                reader.Close();

                VehicleDView.DataSource = dataTable;
            }
        }

        private void ReserveVBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReserveView reserve = new ReserveView();
            reserve.Show();
        }

        private void GetInvoiceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetInvoice getInvoice = new GetInvoice();
            getInvoice.Show();
        }
    }
}
