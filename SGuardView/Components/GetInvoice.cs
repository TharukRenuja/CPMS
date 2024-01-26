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
    public partial class GetInvoice : Form
    {
        private string DBString = "Data Source=DESKTOP-QM2QJB4\\SQLEXPRESS;Initial Catalog=CPMS;Integrated Security=True;Encrypt=False";

        public GetInvoice()
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

        private void GenInvoiceBtn_Click(object sender, EventArgs e)
        {
            string getVLTxt = GetVLTXT.Text;
            string outTime = datePicker.Value.ToString("HH:mm:ss");
            //DateTime outTime = datePicker.Value;
            GenerateInvoice(getVLTxt, outTime);
        }

        private string GetLastInvoiceID()
        {
            string query = "SELECT TOP 1 ID FROM Invoice ORDER BY ID DESC";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                return result == null ? "INV0" : result.ToString();
            }
        }

        private string GenerateNextInvoiceID()
        {
            string lastCustomerID = GetLastInvoiceID();

            int lastIdNumber = int.Parse(lastCustomerID.Substring(3));
            int nextIdNumber = lastIdNumber + 1;
            return "INV" + nextIdNumber.ToString();
        }

        private void GenerateInvoice(string vLicense, string outTime)
        {
            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string getVehicleInfoQuery = "SELECT ID, OwnerID, InTime FROM Vehicle WHERE VLicense = @VLicense";
                SqlCommand getVehicleInfoCommand = new SqlCommand(getVehicleInfoQuery, connection);
                getVehicleInfoCommand.Parameters.AddWithValue("@VLicense", vLicense);

                SqlDataReader reader = getVehicleInfoCommand.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Genrating Invoice...");

                    string vehicleID = reader.GetString(0);
                    string ownerID = reader.GetString(1);
                    string inTime = DateTime.Parse(reader["InTime"].ToString()).ToString("HH:mm:ss");
                    reader.Close();

                    //DateTime timeIn;
                    //DateTime.TryParse(InTime, out timeIn);
                    //DateTime timeOut;
                    //DateTime.TryParse(outTime, out timeOut);
                    DateTime dt1 = DateTime.ParseExact(outTime, "HH:mm:ss", new DateTimeFormatInfo());
                    DateTime dt2 = DateTime.ParseExact(inTime, "HH:mm:ss", new DateTimeFormatInfo());
                    TimeSpan duration = dt1.Subtract(dt2);

                    double ratePerHour = 100.00; // Rate per hour
                    double fare;

                    // Calculate the fare based on the duration and rate
                    fare = duration.TotalHours * ratePerHour;

                    // Ensure the fare is a decimal(10,2) value
                    decimal Ffare = (decimal)fare;

                    string invID = GenerateNextInvoiceID();

                    //decimal farePerHour = 100;
                    //decimal fare = (decimal)duration.TotalHours * farePerHour;

                    //int totalMinutes = (int)(timeOut - timeIn).TotalMinutes;

                    //int hours = totalMinutes / 60;
                    //int minutes = totalMinutes % 60;

                    //string formattedDuration = $"{hours:D2}:{minutes:D2}";

                    //decimal farePerHour = 100;
                    //decimal fare = (totalMinutes / 60) * farePerHour;

                    string updateStatusQuery = "UPDATE Status SET Status = 0, VehicleID = NULL WHERE VehicleID = @VehicleID";
                    SqlCommand updateStatusCommand = new SqlCommand(updateStatusQuery, connection);
                    updateStatusCommand.Parameters.AddWithValue("@VehicleID", vehicleID);
                    updateStatusCommand.ExecuteNonQuery();

                    string insertInvoiceQuery = "INSERT INTO Invoice (ID, CusID, VLicense, DATE, OutTime, Duration, Amount) VALUES (@ID, @CusID, @VLicense, @DATE, @OutTime, @Duration, @Amount)";
                    SqlCommand insertInvoiceCMD = new SqlCommand(insertInvoiceQuery, connection);
                    insertInvoiceCMD.Parameters.AddWithValue("@ID", invID);
                    insertInvoiceCMD.Parameters.AddWithValue("@CusID", ownerID);
                    insertInvoiceCMD.Parameters.AddWithValue("@VLicense", vLicense);
                    insertInvoiceCMD.Parameters.AddWithValue("@DATE", DateTime.Now.Date);
                    insertInvoiceCMD.Parameters.AddWithValue("@OutTime", DateTime.Now.ToString("HH:mm:ss"));
                    insertInvoiceCMD.Parameters.AddWithValue("@Duration", duration);
                    insertInvoiceCMD.Parameters.AddWithValue("@Amount", Ffare);
                    insertInvoiceCMD.ExecuteNonQuery();

                    string removeVehicleQuery = "DELETE FROM Vehicle WHERE ID = @VehicleID";
                    SqlCommand removeVehicleCommand = new SqlCommand(removeVehicleQuery, connection);
                    removeVehicleCommand.Parameters.AddWithValue("@VehicleID", vehicleID);
                    removeVehicleCommand.ExecuteNonQuery();

                    DisplaySummary(outTime, inTime, vLicense, duration, Ffare, invID);
                    GetVLTXT.Clear();
                }
                else
                {
                    MessageBox.Show("Vehicle not found!");
                }
            }
        }

        private void DisplaySummary(string outTime, string inTime, string vLicense, TimeSpan duration, decimal fare, string invID)
        {
            SDateTXT.Text = DateTime.Now.ToString("yyyy / MM / dd");
            PDate.Text = DateTime.Now.ToString("yyyy / MM / dd");

            SFrmTXT.Text = inTime;
            PFrom.Text = inTime;

            SToTXT.Text = outTime;
            PTo.Text = outTime;

            SVLTXT.Text = vLicense;
            PVLNo.Text = vLicense;

            SduTXT.Text = duration.ToString();
            PDur.Text = duration.ToString();

            CultureInfo lkRupees = new CultureInfo("en-LK");

            fareTXT.Text = fare.ToString("C", lkRupees);
            PFare.Text = fare.ToString("C", lkRupees);

            PINV.Text = invID;
        }

        private void printPreview_Load(object sender, EventArgs e)
        {
            printPreview.Document = printDocument;
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            printPreview.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(printBox.Width, printBox.Height);
            printBox.DrawToBitmap(bmp, new Rectangle(0, 0, printBox.Width, printBox.Height));
            e.Graphics.DrawImage(bmp, new Point(100, 100));
        }
    }
}
