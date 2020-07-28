using ScheduleProgram.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ScheduleProgram
{
    public partial class ApptByCust : Form
    {
        string customers = "SELECT customerName from customer;";
        int CustomerID;
        
        public ApptByCust()
        {
            InitializeComponent();
            DataTable customerList = new DataTable();
            Universals.GetData(customers, customerList);
            custCB.DataSource = customerList;
            custCB.DisplayMember = "customerName";
            //populateAppointments();
                       
        }

        private void custCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void populateAppointments()
        {
            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                connect.Open();
                string customerName = custCB.GetItemText(custCB.Text);
                string sql = "SELECT customerId from customer where customerName = '" + customerName + "';";
                

                DataTable customerId = new DataTable();
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader customerReader = cmd.ExecuteReader();
                customerId.Load(customerReader);

                if (customerId.Rows.Count == 1)
                {
                    int custId = (int)customerId.Rows[0][0];
                    CustomerID = custId;
                }

                string getAppointments = "SELECT appointmentId, type, start, end FROM appointment WHERE customerId = '" + CustomerID + "';";

                DataTable appointments = new DataTable();
                MySqlCommand appointmentCommand = new MySqlCommand(getAppointments, connect);
                MySqlDataReader appointmentReader = appointmentCommand.ExecuteReader();
                appointments.Load(appointmentReader);

                apptByCustDgv.DataSource = appointments;

                connect.Close();

            }
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            populateAppointments();
        }

        private void returnMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }

        private void ApptByCust_Load(object sender, EventArgs e)
        {
            populateAppointments();
        }
    }
}
