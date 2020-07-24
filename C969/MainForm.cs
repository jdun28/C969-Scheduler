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

        

        public MainForm()
        {  
            InitializeComponent();
            todayDate = DateTime.Now;
            myCal.AddBoldedDate(todayDate);
            Universals.CurrentCustIndex = -1;
            Customer.populateCustData(Customer.findAllCustQuery, custDt);
            custDgv.DataSource = custDt;
            custDgv.Columns["customerID"].Visible = false;
            Universals.CurrentApptIndex = -1;
            Appointment.populateApptData(Appointment.apptQuery, apptDt);
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

     
    }
}
