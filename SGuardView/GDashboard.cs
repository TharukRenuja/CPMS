using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPMS
{
    public partial class GDashboard : Form
    {
        private string DBString = "Data Source=DESKTOP-QM2QJB4\\SQLEXPRESS;Initial Catalog=CPMS;Integrated Security=True;Encrypt=False";

        public GDashboard()
        {
            InitializeComponent();
            GetStatus();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
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

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void GetStatus()
        {
            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string queryCApot = "SELECT COUNT(*) FROM Status WHERE Status = 0 AND ID LIKE 'C-SPOT%'";
                string queryEApot = "SELECT COUNT(*) FROM Status WHERE Status = 0 AND ID LIKE 'E-SPOT%'";
                string queryCRpot = "SELECT COUNT(*) FROM Status WHERE Status = 1 AND ID LIKE 'C-SPOT%'";
                string queryERpot = "SELECT COUNT(*) FROM Status WHERE Status = 1 AND ID LIKE 'E-SPOT%'";
                string queryCusTo = "SELECT COUNT(*) FROM Customer WHERE ID = ID";
                string queryRevTo = "SELECT SUM(Amount) FROM Invoice";
                DateTime tdyDate = DateTime.Now.Date;
                string queryRevTD = $"SELECT SUM(Amount) FROM Invoice WHERE DATE = '{tdyDate}'";

                using (SqlCommand commandCApot = new SqlCommand(queryCApot, connection))
                using (SqlCommand commandEApot = new SqlCommand(queryEApot, connection))
                using (SqlCommand commandCRpot = new SqlCommand(queryCRpot, connection))
                using (SqlCommand commandERpot = new SqlCommand(queryERpot, connection))
                using (SqlCommand commandCusTo = new SqlCommand(queryCusTo, connection))
                using (SqlCommand commandRevTo = new SqlCommand(queryRevTo, connection))
                using (SqlCommand commandRevTD = new SqlCommand(queryRevTD, connection))
                {
                    int cAVSpotCount = (int)commandCApot.ExecuteScalar();
                    int eAVSpotCount = (int)commandEApot.ExecuteScalar();
                    int cRVSpotCount = (int)commandCRpot.ExecuteScalar();
                    int eRVSpotCount = (int)commandERpot.ExecuteScalar();
                    int TotCusCount = (int)commandCusTo.ExecuteScalar();
                    decimal TotRevCount = (decimal)commandRevTo.ExecuteScalar();
                    decimal? TdyRevCount = commandRevTD.ExecuteScalar() as decimal?;

                    cSpotAV.Text = $"{cAVSpotCount}";
                    cSpotRV.Text = $"{cRVSpotCount}";
                    eSpotAV.Text = $"{eAVSpotCount}";
                    eSpotRV.Text = $"{eRVSpotCount}";
                    CusTotal.Text = $"{TotCusCount}";

                    CultureInfo lkRupees = new CultureInfo("en-LK");
                    RevTot.Text = TotRevCount.ToString("C", lkRupees);
                    RevTdy.Text = TdyRevCount?.ToString("C", lkRupees) ?? "LKR0.00";
                }
            }
        }

        private void GetInvoiceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetInvoice getInvoice = new GetInvoice();
            getInvoice.Show();
        }

        private void ResCUSBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleReserveCUS cusReserve = new VehicleReserveCUS();
            cusReserve.Show();
        }

        private void ResEMPBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleReserveEMP empReserve = new VehicleReserveEMP();
            empReserve.Show();
        }

        private void AddOutBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string vLicense = LeaveTXT.Text;

                string getVehicleInfoQuery = "SELECT ID FROM Vehicle WHERE VLicense = @VLicense";
                SqlCommand getVehicleInfoCommand = new SqlCommand(getVehicleInfoQuery, connection);
                getVehicleInfoCommand.Parameters.AddWithValue("@VLicense", vLicense);

                SqlDataReader reader = getVehicleInfoCommand.ExecuteReader();

                if (reader.Read())
                {
                    string vehicleID = reader.GetString(0);
                    reader.Close();

                    string updateStatusQuery = "UPDATE Status SET Status = 0, VehicleID = NULL WHERE VehicleID = @VehicleID";
                    SqlCommand updateStatusCommand = new SqlCommand(updateStatusQuery, connection);
                    updateStatusCommand.Parameters.AddWithValue("@VehicleID", vehicleID);
                    updateStatusCommand.ExecuteNonQuery();

                    string removeVehicleQuery = "DELETE FROM Vehicle WHERE ID = @VehicleID";
                    SqlCommand removeVehicleCommand = new SqlCommand(removeVehicleQuery, connection);
                    removeVehicleCommand.Parameters.AddWithValue("@VehicleID", vehicleID);
                    removeVehicleCommand.ExecuteNonQuery();
                    this.Hide();
                    GDashboard dashboard = new GDashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Vehicle not found!");
                }
            }
        }
    }
}
