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
            Customer.populateCustData(Customer.custQuery, custDt);
            custDgv.DataSource = custDt;
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
            this.Close();
        }

        private void addApptBtn_Click(object sender, EventArgs e)
        {
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
            this.Hide();
            AddEditCustForm editCust = new AddEditCustForm();
            editCust.Show();
        }

        private void udpateApptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEditApptForm editAppt = new AddEditApptForm();
            editAppt.Show();
        }
    }
}
