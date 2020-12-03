using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace ScheduleProgram.Universal
{
    public class Universals
    {
        public static int CurrentCustIndex { get; set; }
        public static int CurrentApptIndex { get; set; }

        public static int CustomerID { get; set; }
        public static int AppointmentID { get; set; }
        public static string CurrentAppointment { get; set; }

        public static string CurrentUser = "test";

        public static int CurrentUserID = 1;

        public static int CityID { get; set; }

        public static int AddressID { get; set; }

        public DataTable GetData(string d, DataTable dt)
        {
            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(d, connect);
                connect.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                connect.Close();
                return dt;
            }
        }

        public void GetCurrentUserName()
        {
            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                connect.Open();
                string getUser = "SELECT userName FROM user;";
                MySqlCommand user = new MySqlCommand(getUser, connect);
                MySqlDataReader reader = user.ExecuteReader();
                DataTable userResult = new DataTable();
                userResult.Load(reader);
                if (userResult.Rows.Count > 0)
                {
                    CurrentUser = userResult.Rows[0][0].ToString();
                }
                connect.Close();
            }
        }

        public void GetCurrentUserID()
        {
            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                connect.Open();
                string getID = "SELECT userId FROM user;";
                MySqlCommand id = new MySqlCommand(getID, connect);
                MySqlDataReader reader = id.ExecuteReader();
                DataTable userID = new DataTable();
                userID.Load(reader);
                if (userID.Rows.Count > 0)
                {
                    CurrentUserID = Convert.ToInt32(userID.Rows[0][0]);
                }
                connect.Close();
            }
        }

        public void ExecuteNonQueryUpdater(string updater)
        {
            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(updater, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
            }
        }

        public DataTable TableReader(string s, DataTable dt)
        {
            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(s, connect);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                connect.Close();
                return dt;
            }
        }
        public bool IsNotNullOrEmpty(string s)
        {
            return !string.IsNullOrEmpty(s);
        }
        public bool ValidateField(RichTextBox field, bool isValid)
        {
            if (isValid)
            {
                field.BackColor = System.Drawing.Color.White;
                return true;
            }
            else
            {
                field.BackColor = System.Drawing.Color.Salmon;
                return false;
            }
        }
        public bool CheckPhoneFormat(string phone)
        {
            Regex checkPhoneFormat = new Regex(@"([0-9]{3}-[0-9]{4})");
            if (checkPhoneFormat.IsMatch(phone))
                {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckZipFormat(string zip)
        {
            Regex checkZipFormat = new Regex(@"([0-9]{5})");
            if (checkZipFormat.IsMatch(zip))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
