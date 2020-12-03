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
        private static Universals universals = new Universals();

        public ApptByMonth()
        {
            InitializeComponent();
            monthCB.Items.Add("July 2020");
            monthCB.Items.Add("Aug 2020");
            monthCB.Items.Add("Sep 2020");
            monthCB.Items.Add("Oct 2020");
            monthCB.Items.Add("Nov 2020");
            monthCB.Items.Add("Dec 2020");
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
            else if(monthCB.GetItemText(monthCB.Text) == "Dec 2020")
            {
                date = "2020-12%";
            }
            else
            {
                MessageBox.Show("Please select a month.");
            }

            string selectAllAppointmentsMonth = "SELECT  appointmentId, customerId, type FROM appointment WHERE start LIKE '" + date + "';";
            DataTable allAppointmentsDt = new DataTable();
            universals.TableReader(selectAllAppointmentsMonth, allAppointmentsDt);
            apptByMonDgv.DataSource = allAppointmentsDt;

            string selectDemoAppoinmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Demo';";
            DataTable demo = new DataTable();
            universals.TableReader(selectDemoAppoinmentMonth, demo);
            if (demo.Rows.Count > 0)
            {
                demoCount.Text = demo.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No demo appointments this month.");
            }
            string selectContractReviewAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Contract Review';";
            DataTable contract = new DataTable();
            universals.TableReader(selectContractReviewAppointmentMonth, contract);
            if (contract.Rows.Count > 0)
            {
                contractReviewCount.Text = contract.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No contract review appointments this month");
            }
            string selectPresentationAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Presentation';";
            DataTable presentation = new DataTable();
            universals.TableReader(selectPresentationAppointmentMonth, presentation);
            if (presentation.Rows.Count > 0)
            {
                presentationCount.Text = presentation.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No presentation appointments this month.");
            }
            string selectScrumAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Scrum';";
            DataTable scrum = new DataTable();
            universals.TableReader(selectScrumAppointmentMonth, scrum);
            if (scrum.Rows.Count > 0)
            {
                scrumCount.Text = scrum.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No scrum appointments this month.");
            }

            string selectAppointmentCountMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "';";
            DataTable all = new DataTable();
            universals.TableReader(selectAllAppointmentsMonth, all);
            if (all.Rows.Count > 0)
            {
                totalCount.Text = all.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No Appointments scheduled this Month.");
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
