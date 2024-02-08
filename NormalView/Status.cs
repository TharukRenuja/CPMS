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
    public partial class Status : Form
    {
        private string DBString = "Data Source=DESKTOP-QM2QJB4\\SQLEXPRESS;Initial Catalog=CPMS;Integrated Security=True;Encrypt=False";

        public Status()
        {
            InitializeComponent(); 
            LoadStatus();
            ConfigureDataGridView();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
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

        private void ConfigureDataGridView()
        {
            // DataGridView controls
            StatusDView.AutoGenerateColumns = false;
            StatusDView.ReadOnly = true;
            StatusDView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StatusDView.MultiSelect = false;
            StatusDView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StatusDView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StatusDView.RowHeadersVisible = false;
            StatusDView.EnableHeadersVisualStyles = false;

            int totalWidth = StatusDView.Width;

            StatusDView.Columns["ID"].Width = (int)(totalWidth * 0.2);
            StatusDView.Columns["VehicleID"].Width = (int)(totalWidth * 0.2);
            StatusDView.Columns["VLicense"].Width = (int)(totalWidth * 0.3);
            StatusDView.Columns["Status"].Width = (int)(totalWidth * 0.3);

            StatusDView.DefaultCellStyle.BackColor = Color.FromArgb(222, 208, 182);
            StatusDView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(250, 238, 209);
            StatusDView.DefaultCellStyle.SelectionForeColor = Color.Black;
            StatusDView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(187, 171, 140);
            StatusDView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(222, 208, 182);

            StatusDView.CellFormatting += StatDViewFormat;
        }

        private void StatDViewFormat(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == StatusDView.Columns["Status"].Index && e.Value != null)
            {
                int statusValue = (int)e.Value;
                bool status = (statusValue == 1);
                string statusText = status ? "Reserved" : "Available";

                e.Value = statusText;

                if (status)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }

        private void LoadStatus()
        {
            StatusDView.DataSource = GetStatData();
        }

        private DataTable GetStatData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string query = @"
                                    SELECT 
                                        Status.ID, 
                                        Status.VehicleID, 
                                        Vehicle.VLicense,
                                        Status.Status
                                    FROM 
                                        Status
                                        LEFT JOIN Vehicle ON Status.VehicleID = Vehicle.ID
                                    ORDER BY CAST(SUBSTRING(Status.ID, 7, LEN(Status.ID)) AS INT) ASC
                                ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
