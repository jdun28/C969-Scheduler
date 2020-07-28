using ScheduleProgram.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ScheduleProgram
{
    public partial class ApptByMonth : Form
    {
        string date;

        public ApptByMonth()
        {
            InitializeComponent();
            monthCB.Items.Add("July 2020");
            monthCB.Items.Add("Aug 2020");
            monthCB.Items.Add("Sep 2020");
            monthCB.Items.Add("Oct 2020");
            monthCB.Items.Add("Nov 2020");
        }
        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            if (monthCB.GetItemText(monthCB.Text) == "July 2020")
            {
                date = "2020-07%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "Aug 2020")
            {
                date = "2020-08%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "Sep 2020")
            {
                date = "2020-09%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "Oct 2020")
            {
                date = "2020-10%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "Nov 2020")
            {
                date = "2020-11%";
            }
            else
            {
                MessageBox.Show("Please select a month.");
            }

            string selectAllAppointmentsMonth = "SELECT  appointmentId, customerId, type FROM appointment WHERE start LIKE '" + date + "';";

            string selectDemoAppoinmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Demo';";

            string selectContractReviewAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Contract Review';";

            string selectPresentationAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Presentation';";

            string selectScrumAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Scrum';";

            string selectAppointmentCountMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "';";
                
            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                connect.Open();
                MySqlCommand allAppointments = new MySqlCommand(selectAllAppointmentsMonth, connect);
                MySqlCommand demoAppointments = new MySqlCommand(selectDemoAppoinmentMonth, connect);
                MySqlCommand contractAppointments = new MySqlCommand(selectContractReviewAppointmentMonth, connect);
                MySqlCommand scrumAppointments = new MySqlCommand(selectScrumAppointmentMonth, connect);
                MySqlCommand presAppointments = new MySqlCommand(selectPresentationAppointmentMonth, connect);
                MySqlCommand allCount = new MySqlCommand(selectAppointmentCountMonth, connect);

                DataTable allAppointmentsDt = new DataTable();
                MySqlDataReader reader = allAppointments.ExecuteReader();
                allAppointmentsDt.Load(reader);
                apptByMonDgv.DataSource = allAppointmentsDt;

                DataTable contract = new DataTable();
                MySqlDataReader contractReader = contractAppointments.ExecuteReader();
                contract.Load(contractReader);
                contractReviewCount.Text = contract.Rows[0][0].ToString();

                DataTable demo = new DataTable();
                MySqlDataReader demoReader = demoAppointments.ExecuteReader();
                demo.Load(demoReader);
                demoCount.Text = demo.Rows[0][0].ToString();

                DataTable scrum = new DataTable();
                MySqlDataReader scrumReader = scrumAppointments.ExecuteReader();
                scrum.Load(scrumReader);
                scrumCount.Text = scrum.Rows[0][0].ToString();

                DataTable presentation = new DataTable();
                MySqlDataReader presReader = presAppointments.ExecuteReader();
                presentation.Load(presReader);
                presentationCount.Text = presentation.Rows[0][0].ToString();

                DataTable all = new DataTable();
                MySqlDataReader allTypeCount = allCount.ExecuteReader();
                all.Load(allTypeCount);
                totalCount.Text = all.Rows[0][0].ToString();

                connect.Close();
            }
        }

        private void mainScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }
    }
}
