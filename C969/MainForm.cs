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

namespace ScheduleProgram
{
    public partial class MainForm : Form
    {
        DataTable custDt = new DataTable();
        DataTable apptDt = new DataTable();
        DateTime todayDate;

        //query to create selection for custDgv
        string custQuery =
            "SELECT customerName, address.address, city.city, address.postalCode, country.country, address.phone "
            + "FROM customer "
            + "INNER JOIN address ON customer.addressId = address.addressId "
            + "INNER JOIN city ON address.cityId = city.cityId "
            + "INNER JOIN country on city.countryId = country.countryId;";

        //query to create appointment view for apptDgv
        string apptQuery =
            "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end "
            + " FROM appointment "
            + " INNER JOIN customer ON appointment.customerId = customer.customerId;";

        private void populateCustData(string s)
        {
            using (MySqlConnection connect = new MySqlConnection(Database.SqlDatabase.ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(s, connect);
                connect.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(custDt);
                connect.Close();
            }
        }
        private void populateApptData(string z)
        {
            using (MySqlConnection connect = new MySqlConnection(Database.SqlDatabase.ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(z, connect);
                connect.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(apptDt);
                connect.Close();
            }
        }

        public MainForm()
        {
           
            
            InitializeComponent();
            todayDate = DateTime.Now;
            myCal.AddBoldedDate(todayDate);
            populateCustData(custQuery);
            custDgv.DataSource = custDt;
            populateApptData(apptQuery);
            apptDgv.DataSource = apptDt;


           

            
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEditCustForm newCust = new AddEditCustForm();
            newCust.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
