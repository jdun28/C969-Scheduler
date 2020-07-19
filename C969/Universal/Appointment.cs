using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ScheduleProgram.Universal
{
    public class Appointment
    {
        public string aId { get; set; }
        public string cId { get; set; }
        public string uId { get; set; }
        public string type { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public DateTime createdDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public Appointment(string appointmentId, string customerId, string userId, string aType, DateTime startTime, 
            DateTime endTime, DateTime created, string whoCreate, DateTime lastUpdated, string whoLastUpdate)
        {
            aId = appointmentId;
            cId = customerId;
            uId = userId;
            type = aType;
            start = startTime;
            end = endTime;
            createdDate = created;
            createdBy = whoCreate;
            lastUpdate = lastUpdated;
            lastUpdateBy = whoLastUpdate;
        }

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


        //public static void ScheduledAppointments()
        //{
        //    DateTime Curr = Convert.ToDateTime(DateTime.UtcNow);
        //    DateTime Next15 = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(15);

        //    DataTable upcoming = new DataTable();

        //    using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
        //    {
        //        MySqlCommand cmd = new
        //    }
        //}
    }
}
