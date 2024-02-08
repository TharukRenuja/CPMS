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
    public partial class VehicleReserveCUS : Form
    {
        private string DBString = "Data Source=DESKTOP-QM2QJB4\\SQLEXPRESS;Initial Catalog=CPMS;Integrated Security=True;Encrypt=False";

        public VehicleReserveCUS()
        {
            InitializeComponent();
            LoadAvailableParkingSpots();
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
            AdminLogin login = new AdminLogin();
            login.Show();
        }

        private void ReserveSpotBtn_Click(object sender, EventArgs e)
        {
            string contactNo = ContactNTxt.Text;
            ReserveParkingSpot(contactNo);
        }

        private string GetLastCustomerID()
        {
            string query = @"SELECT TOP 1 ID
                             FROM Customer
                             ORDER BY CAST(SUBSTRING(ID, 4, LEN(ID)) AS INT) DESC
                            ";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                return result == null ? "CUS0" : result.ToString();
            }
        }

        private string GetLastVehicleID()
        {
            string query = @"SELECT TOP 1 ID
                             FROM Vehicle
                             ORDER BY CAST(SUBSTRING(ID, 4, LEN(ID)) AS INT) DESC
                            ";

            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                return result == null ? "VNO0" : result.ToString();
            }
        }

        private string GenerateNextCustomerID()
        {
            string lastCustomerID = GetLastCustomerID();

            int lastIdNumber = int.Parse(lastCustomerID.Substring(3));
            int nextIdNumber = lastIdNumber + 1;
            return "CUS" + nextIdNumber.ToString();
        }

        private string GenerateNextVehicleID()
        {
            string lastVehicleID = GetLastVehicleID();

            int lastIdNumber = int.Parse(lastVehicleID.Substring(3));
            int nextIdNumber = lastIdNumber + 1;
            return "VNO" + nextIdNumber.ToString();
        }

        private void ReserveParkingSpot(string contactNo)
        {
            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                // Check if the contact number exists
                string checkContactQuery = "SELECT COUNT(*) FROM Customer WHERE Contact = @Contact";
                SqlCommand checkContactCommand = new SqlCommand(checkContactQuery, connection);
                checkContactCommand.Parameters.AddWithValue("@Contact", contactNo);

                int contactCount = (int)checkContactCommand.ExecuteScalar();

                if (contactCount > 0)
                {
                    // Returning customer
                    MessageBox.Show("Returning Customer - Picking a Spot");

                    string getCustomerDetailsQuery = "SELECT ID, VLicense FROM Customer WHERE Contact = @Contact";
                    SqlCommand getCustomerDetailsCommand = new SqlCommand(getCustomerDetailsQuery, connection);
                    getCustomerDetailsCommand.Parameters.AddWithValue("@Contact", contactNo);

                    SqlDataReader reader = getCustomerDetailsCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        string customerID = reader["ID"].ToString();
                        string vLicense = reader["VLicense"].ToString();

                        reader.Close();

                        string insertVehicleQuery = "INSERT INTO Vehicle (ID, VLicense, OwnerID, ContactNo, InTime) VALUES (@ID, @VLicense, @OwnerID, @ContactNo, @InTime)";
                        SqlCommand insertVehicleCommand = new SqlCommand(insertVehicleQuery, connection);
                        insertVehicleCommand.Parameters.AddWithValue("@ID", GenerateNextVehicleID());
                        insertVehicleCommand.Parameters.AddWithValue("@VLicense", vLicense);
                        insertVehicleCommand.Parameters.AddWithValue("@OwnerID", customerID);
                        insertVehicleCommand.Parameters.AddWithValue("@ContactNo", contactNo);

                        insertVehicleCommand.Parameters.AddWithValue("@InTime", PickTime.Value.ToString("HH:mm:ss"));

                        insertVehicleCommand.ExecuteNonQuery();

                        string getNewVehicleIDQuery = "SELECT ID FROM Vehicle WHERE OwnerID = @OwnerID AND ContactNo = @ContactNo";
                        SqlCommand getNewVehicleIDCommand = new SqlCommand(getNewVehicleIDQuery, connection);
                        getNewVehicleIDCommand.Parameters.AddWithValue("@OwnerID", customerID);
                        getNewVehicleIDCommand.Parameters.AddWithValue("@ContactNo", contactNo);

                        string vehicleID = getNewVehicleIDCommand.ExecuteScalar().ToString();

                        ReserveParkingSpotForCustomer(vehicleID);

                        MessageBox.Show("Parking spot reserved.");
                        this.Hide();
                        GStatus aStatus = new GStatus();
                        aStatus.Show();
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Error fetching customer details.");
                    }
                }
                else
                {
                    // New Customer
                    string customerID = GenerateNextCustomerID();
                    AddNewCustomer(customerID, contactNo, NameTxt.Text, LicenseTxt.Text);

                    string vehicleID = GenerateNextVehicleID();
                    AddNewVehicle(contactNo, vehicleID, customerID);

                    ReserveParkingSpotForCustomer(vehicleID);

                    MessageBox.Show("Customer details added & Parking spot reserved.");
                    this.Hide();
                    GStatus aStatus = new GStatus();
                    aStatus.Show();

                    LoadAvailableParkingSpots();
                }
            }
        }

        private void AddNewCustomer(string customerID, string contactNo, string customerName, string customerLicense)
        {
            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string insertCustomerQuery = "INSERT INTO Customer (ID, Name, Contact, VLicense) VALUES (@ID, @Name, @Contact, @VLicense)";
                SqlCommand insertCustomerCommand = new SqlCommand(insertCustomerQuery, connection);
                insertCustomerCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10).Value = customerID.ToString();
                insertCustomerCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = customerName;
                insertCustomerCommand.Parameters.Add("@Contact", SqlDbType.VarChar).Value = contactNo;
                insertCustomerCommand.Parameters.Add("@VLicense", SqlDbType.VarChar).Value = customerLicense;

                insertCustomerCommand.ExecuteNonQuery();
            }
        }

        private void AddNewVehicle(string contactNo, string vehicleID, string customerID)
        {
            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string insertVehicleQuery = "INSERT INTO Vehicle (ID, OwnerID, ContactNo, VLicense, InTime) VALUES (@ID, @OwnerID, @ContactNo, @VLicense, @InTime)";
                SqlCommand insertVehicleCommand = new SqlCommand(insertVehicleQuery, connection);
                insertVehicleCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10).Value = vehicleID;
                insertVehicleCommand.Parameters.Add("@OwnerID", SqlDbType.VarChar, 10).Value = customerID;
                insertVehicleCommand.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = contactNo;
                insertVehicleCommand.Parameters.AddWithValue("@VLicense", LicenseTxt.Text);
                insertVehicleCommand.Parameters.AddWithValue("@InTime", PickTime.Value.ToString("HH:mm:ss"));

                insertVehicleCommand.ExecuteNonQuery();
            }
        }

        private void LoadCustomers()
        {
            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string query = "SELECT Contact FROM Customer";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int contact = (int)reader["Contact"];
                        ContactNTxt.Items.Add(contact);
                    }
                }

                ContactNTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ContactNTxt.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void LoadAvailableParkingSpots()
        {
            using (SqlConnection connection = new SqlConnection(DBString))
            {
                connection.Open();

                string loadSpotsQuery = @"SELECT ID FROM Status WHERE Status = 0 AND ID LIKE 'C-SPOT%'
                                          ORDER BY CAST(SUBSTRING(ID, 7, LEN(ID)) AS INT) ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(loadSpotsQuery, connection);

                DataTable spotsTable = new DataTable();
                adapter.Fill(spotsTable);

                PickSpot.DisplayMember = "ID";
                PickSpot.ValueMember = "ID";
                PickSpot.DataSource = spotsTable;
            }
        }

        private void ReserveParkingSpotForCustomer(string vehicleID)
        {
            string selectedSpot = PickSpot.Text;

            if (!string.IsNullOrEmpty(selectedSpot))
            {
                using (SqlConnection connection = new SqlConnection(DBString))
                {
                    connection.Open();

                    object vehicleIDParameter = string.IsNullOrEmpty(vehicleID) ? DBNull.Value : (object)vehicleID;

                    // Check if same ID already exists in the Status
                    string checkStatusQuery = "SELECT COUNT(*) FROM Status WHERE ID = @ID";
                    SqlCommand checkStatusCommand = new SqlCommand(checkStatusQuery, connection);
                    checkStatusCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10).Value = selectedSpot;

                    int existingStatusCount = (int)checkStatusCommand.ExecuteScalar();

                    if (existingStatusCount > 0)
                    {
                        string updateStatusQuery = "UPDATE Status SET Status = 1, VehicleID = @VehicleID WHERE ID = @ID";
                        SqlCommand updateStatusCommand = new SqlCommand(updateStatusQuery, connection);
                        updateStatusCommand.Parameters.Add("@VehicleID", SqlDbType.VarChar, 10).Value = vehicleIDParameter;
                        updateStatusCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10).Value = selectedSpot;
                        updateStatusCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        string insertStatusQuery = "INSERT INTO Status (ID, Status, VehicleID) VALUES (@ID, 1, @VehicleID)";
                        SqlCommand insertStatusCommand = new SqlCommand(insertStatusQuery, connection);
                        insertStatusCommand.Parameters.Add("@VehicleID", SqlDbType.VarChar, 10).Value = vehicleIDParameter;
                        insertStatusCommand.Parameters.Add("@ID", SqlDbType.VarChar, 10).Value = selectedSpot;
                        insertStatusCommand.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: No parking spot selected or No Parking Spots Available.");
            }
        }

        private void B2ResBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReserveView reserve = new ReserveView();
            reserve.Show();
        }
    }
}
