using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using ScheduleProgram.Universal;
using MySqlX.XDevAPI.Relational;
using System.Security.Cryptography.X509Certificates;

namespace ScheduleProgram
{
    public partial class MainForm : Form
    {
        DataTable custDt = new DataTable();
        DataTable apptDt = new DataTable();
        DateTime todayDate;
        int addressId;
        int customerId;

        

        public MainForm()
        {  
            InitializeComponent();
            todayDate = DateTime.Now;
            myCal.AddBoldedDate(todayDate);
            Universals.CurrentCustIndex = -1;
            Customer.populateCustData(Customer.findAllCustQuery, custDt);
            custDgv.DataSource = custDt;
            custDgv.RowHeadersVisible = false;
            custDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            custDgv.DefaultCellStyle.SelectionForeColor = custDgv.DefaultCellStyle.ForeColor;
            Universals.CurrentApptIndex = -1;
            Appointment.populateApptData(Appointment.apptQuery, apptDt);
            apptDgv.DataSource = apptDt;
            apptDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            apptDgv.DefaultCellStyle.SelectionForeColor = apptDgv.DefaultCellStyle.ForeColor;
            
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEditCustForm newCust = new AddEditCustForm();
            newCust.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void addApptBtn_Click(object sender, EventArgs e)
        {
            Universals.CustomerID = 0;
            this.Hide();
            AddEditApptForm newAppt = new AddEditApptForm();
            newAppt.Show();
        }

        private void dayRb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void weekRb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void monthRb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void updateCustBtn_Click(object sender, EventArgs e)
        {
            if (Universals.CurrentCustIndex >= 0)
            {
                using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
                {
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer;", connect);
                    MySqlDataReader customerid = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(customerid);
                    if (dt.Rows.Count > 0)
                    {
                        int custId = (int)dt.Rows[Universals.CurrentCustIndex]["customerId"];
                        Universals.CustomerID = custId;
                    }
                    connect.Close();
                }
                this.Hide();
                AddEditCustForm editCust = new AddEditCustForm();
                editCust.Show();
            }
            else
            {
                MessageBox.Show("Please select a customer to update.");
            }
        }
        private void udpateApptBtn_Click(object sender, EventArgs e)
        {      
            this.Hide();
            AddEditApptForm editAppt = new AddEditApptForm();
            editAppt.Show();
        }

        private void custDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Universals.CurrentCustIndex = e.RowIndex;
            

        }

        private void deleteCustBtn_Click(object sender, EventArgs e)
        {
            if (Universals.CurrentCustIndex >= 0)
            {
                using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
                {
                    string getCustID = "SELECT * FROM customer WHERE customerId = '" + customerId + "';";
                    string getAddressID = "SELECT addressId from customer where customerId = '" + customerId + "';";


                    connect.Open();
                    MySqlCommand getCID = new MySqlCommand(getCustID, connect);
                    var custIdResult = getCID.ExecuteScalar();
                    if (custIdResult != null)
                    {
                        customerId = Convert.ToInt32(custIdResult);
                        Universals.CustomerID = customerId;
                    }

                    MySqlCommand getAId = new MySqlCommand(getAddressID, connect);
                    var addressIdResult = getAId.ExecuteScalar();
                    if (addressIdResult != null)
                    {
                        addressId = Convert.ToInt32(addressIdResult);
                        Universals.AddressID = addressId;
                    }

                    string deleteCustomerAndAddress = "DELETE customer FROM customer WHERE customerId = '" + Universals.CustomerID + "';" +
                    "DELETE address FROM address WHERE addressId = '" + Universals.AddressID + "';";

                    MySqlCommand deleteCust = new MySqlCommand(deleteCustomerAndAddress, connect);
                    deleteCust.ExecuteScalar();
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void custDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Universals.CurrentCustIndex = e.RowIndex;
        }

        private void apptDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
