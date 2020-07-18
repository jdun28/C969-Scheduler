using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ScheduleProgram.Database
{
    public class Appointment
    {
        

        //query to create appointment view for apptDgv
        public static string apptQuery =
            "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end "
            + " FROM appointment "
            + " INNER JOIN customer ON appointment.customerId = customer.customerId;";

        public static void populateApptData(string a, DataTable dt)
        {
            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(a, connect);
                connect.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                connect.Close();
            }
        }


        public static void ScheduledAppointments()
        {
            DateTime Curr = Convert.ToDateTime(DateTime.UtcNow);
            DateTime Next15 = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(15);

            DataTable upcoming = new DataTable();

            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                MySqlCommand cmd = new
            }
        }
    }
}
