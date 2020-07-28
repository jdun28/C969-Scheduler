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
        DateTime selectedDate = new DateTime();


        public MainForm()
        {
            InitializeComponent();

            selectedDate = DateTime.Now;
            myCal.AddBoldedDate(selectedDate);

            Universals.CurrentCustIndex = -1;
            Customer.populateCustData(Customer.findAllCustQuery, custDt);
            custDgv.RowHeadersVisible = false;
            custDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            custDgv.DefaultCellStyle.SelectionForeColor = custDgv.DefaultCellStyle.ForeColor;
            custDgv.DataSource = custDt;
            custDgv.Columns["country"].Visible = false;
            custDgv.Columns["customerId"].Visible = false;

            Universals.CurrentApptIndex = -1;
            Appointment.populateApptData(Appointment.apptQuery, apptDt);
            apptDgv.RowHeadersVisible = false;
            apptDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            apptDgv.DefaultCellStyle.SelectionForeColor = apptDgv.DefaultCellStyle.ForeColor;          
            apptDgv.DataSource = apptDt;
            apptDgv.Columns["customerId"].Visible = false;

        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            Universals.CustomerID = 0;
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
            HandleDay();
        }

        private void weekRb_CheckedChanged(object sender, EventArgs e)
        {
            HandleWeek();
        }

        private void monthRb_CheckedChanged(object sender, EventArgs e)
        {
            HandleMonth();
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
            if (Universals.CurrentApptIndex >= 0)
            {
                using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
                {
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * from appointment;", connect);
                    MySqlDataReader appointmentid = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(appointmentid);
                    if (dt.Rows.Count > 0)
                    {
                        int appointId = (int)dt.Rows[Universals.CurrentApptIndex]["appointmentId"];
                        Universals.AppointmentID = appointId;
                    }
                    connect.Close();
                }
                this.Hide();
                AddEditApptForm editAppt = new AddEditApptForm();
                editAppt.Show();
            }
            else
            {
                MessageBox.Show("Please select an appointment to update.");
            }
        }
        private void custDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Universals.CurrentCustIndex = e.RowIndex;
            custDgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
        }
        private void apptDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Universals.CurrentApptIndex = e.RowIndex;
            apptDgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
        }
    
        private void deleteCustBtn_Click(object sender, EventArgs e)
        {
            if (Universals.CurrentCustIndex >= 0)
            {
                using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
                {
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand(Customer.findAllCustQuery, connect);
                    MySqlDataReader custReader = cmd.ExecuteReader();
                    DataTable deleteCust = new DataTable();
                    deleteCust.Load(custReader);

                    Universals.CustomerID = (int)deleteCust.Rows[Universals.CurrentCustIndex]["customerId"];

                    MySqlCommand acmd = new MySqlCommand("SELECT addressId from customer WHERE customerId = '" + Universals.CustomerID + "';", connect);
                    MySqlDataReader addReader = acmd.ExecuteReader();
                    DataTable deleteAddress = new DataTable();
                    deleteAddress.Load(addReader);

                    Universals.AddressID = (int)deleteAddress.Rows[0][0];

                    if (Universals.CustomerID != 0)
                    {
                        string deleteCustomerAndAddress = "DELETE customer FROM customer WHERE customerId = '" + Universals.CustomerID + "';" +
                            "DELETE address FROM address WHERE addressId = '" + Universals.AddressID + "';";

                        MySqlCommand completeDelete = new MySqlCommand(deleteCustomerAndAddress, connect);
                        DialogResult dialogResult = MessageBox.Show("This will delete the customer and all appointments for this customer. Continue?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                {
                                    completeDelete.ExecuteNonQuery();
                                    this.Hide();
                                    MainForm dash = new MainForm();
                                    dash.Show();
                                }
                            }
                            catch
                            {

                                MessageBox.Show("Unable to delete customer. Recommend checking for currently scheduled appointments for selected customer.");
                            }
                        }
                        connect.Close();
                    }
                }
            }
            else
            {
            MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void deleteApptBtn_Click(object sender, EventArgs e)
        {
            if (Universals.CurrentApptIndex > 0)
            {
                using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
                {
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand(Appointment.apptQuery, connect);
                    MySqlDataReader apptReader = cmd.ExecuteReader();
                    DataTable deleteAppointment = new DataTable();
                    deleteAppointment.Load(apptReader);

                    Universals.AppointmentID = (int)deleteAppointment.Rows[Universals.CurrentApptIndex]["appointmentId"];

                    if (Universals.AppointmentID !=0)
                    {
                        string deleteSelectedAppointment = "DELETE appointment FROM appointment WHERE appointmentId = '" + Universals.AppointmentID + "';";

                        MySqlCommand delete = new MySqlCommand(deleteSelectedAppointment, connect);
                        DialogResult dialog = MessageBox.Show("Are you sure you want to delete this appointment?", "", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            delete.ExecuteNonQuery();
                            this.Hide();
                            MainForm dash = new MainForm();
                            dash.Show();
                        }
                    }
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }
        }

        private void HandleDay()
        {
            myCal.MaxSelectionCount = 1;
            DateTime dayStart = new DateTime();
            DateTime dayEnd = new DateTime();

            dayStart = selectedDate;
            dayEnd = selectedDate;

            myCal.SetSelectionRange(dayStart, dayEnd);

            string todayAppt = "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end  FROM " +
                "appointment INNER JOIN customer ON appointment.customerId = customer.customerId WHERE appointment.start BETWEEN  '" +
                TimeZoneInfo.ConvertTimeToUtc(dayStart).ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + TimeZoneInfo.ConvertTimeToUtc(dayEnd).ToString("yyyy-MM-dd HH:mm:ss") + "' ;";

            DataTable handleDay = new DataTable();

            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(todayAppt, connect);
                MySqlDataReader dayReader = cmd.ExecuteReader();
                handleDay.Load(dayReader);

                if (handleDay.Rows.Count > 0)
                {
                    for (int i = 0; i < handleDay.Rows.Count; i++)
                    {
                        apptDgv.DataSource = handleDay;
                        handleDay.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleDay.Rows[i]["start"], 
                            TimeZoneInfo.Local).ToString();
                        handleDay.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleDay.Rows[i]["end"],
                            TimeZoneInfo.Local).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No appointments found for this date.");
                }
                connect.Close();
            }
        }

        private void HandleWeek()
        {
            myCal.MaxSelectionCount = 7;
            DateTime weekStart = new DateTime();
            DateTime weekEnd = new DateTime();

            weekStart = selectedDate;
            weekEnd = selectedDate.AddDays(7);
            myCal.SetSelectionRange(weekStart, weekEnd);

            string weekAppts = "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end  FROM " + 
                "appointment INNER JOIN customer ON appointment.customerId = customer.customerId WHERE appointment.start BETWEEN '" + 
                TimeZoneInfo.ConvertTimeToUtc(weekStart).ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + TimeZoneInfo.ConvertTimeToUtc(weekEnd).ToString("yyyy-MM-dd HH:mm:ss") + "' ;";
            
            DataTable handleWeek = new DataTable();

            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(weekAppts, connect);
                MySqlDataReader weekReader = cmd.ExecuteReader();
                handleWeek.Load(weekReader);

                if (handleWeek.Rows.Count > 0)
                {
                    for (int i = 0; i < handleWeek.Rows.Count; i++)
                    {
                        apptDgv.DataSource = handleWeek;
                        handleWeek.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleWeek.Rows[i]["start"], 
                            TimeZoneInfo.Local).ToString();
                        handleWeek.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleWeek.Rows[i]["end"],
                            TimeZoneInfo.Local).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No appointments found for this date range.");
                }
                connect.Close();
            }
        }

        private void HandleMonth()
        {
            myCal.MaxSelectionCount = 31;
            DateTime monthStart = new DateTime();
            DateTime monthEnd = new DateTime();
            monthStart = selectedDate;
            monthEnd = selectedDate.AddDays(31);
            myCal.SetSelectionRange(monthStart, monthEnd);

            string monthAppts = "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end FROM " +
                "appointment INNER JOIN customer ON appointment.customerId = customer.customerId WHERE appointment.start BETWEEN '" +
                    TimeZoneInfo.ConvertTimeToUtc(monthStart).ToString("yyyy-MM-dd HH:mm:ss") +"' AND '" + TimeZoneInfo.ConvertTimeToUtc(monthEnd).ToString("yyyy-MM-dd HH:mm:ss") + "' ;";

            DataTable handleMon = new DataTable();
            //Universals.GetData(monthAppts, handleMon);
            //apptDgv.DataSource = handleMon;
            //apptDgv.Refresh();
            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                connect.Open();

                MySqlCommand populateDt = new MySqlCommand(monthAppts, connect);
                MySqlDataReader readMonthAppts = populateDt.ExecuteReader();
                handleMon.Load(readMonthAppts);
                if (handleMon.Rows.Count > 0)
                {
                    //convert start and end times from UTC
                    for (int i = 0; i < handleMon.Rows.Count; i++)
                    {
                        apptDgv.DataSource = handleMon;
                        handleMon.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleMon.Rows[i]["start"],
                            TimeZoneInfo.Local).ToString();
                        handleMon.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleMon.Rows[i]["end"],
                            TimeZoneInfo.Local).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No appointments found for this date range.");
                }
                connect.Close();
            }
        }
        private void myCal_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start;
            if (monthRb.Checked)
            {
                HandleMonth();
            }
            else
            {
                if (weekRb.Checked)
                {
                    HandleWeek();
                }
                else
                {
                    HandleDay();
                }
            }
        }

        private void apptByMonBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApptByMonth monReport = new ApptByMonth();
            monReport.Show();
        }

        private void apptByCustBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApptByCust custReport = new ApptByCust();
            custReport.Show();
        }

        private void userSchedBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSchedule userSched = new UserSchedule();
            userSched.Show();
        }
    }
}
