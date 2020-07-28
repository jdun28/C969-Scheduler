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

namespace ScheduleProgram.Universal
{
    class Universals
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

        public static void GetData(string d, DataTable dt)
        {
            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(d, connect);
                connect.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                connect.Close();
            }
        }

        public static void GetCurrentUserName()
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

        public static void GetCurrentUserID()
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
        public static bool IsNotNullOrEmpty(string text)
        {
            return !string.IsNullOrEmpty(text);
        }
        public static void ValidateField(RichTextBox field, bool isValid)
        {
            if (isValid)
            {
                field.BackColor = System.Drawing.Color.White;
            }
            else
            {
                field.BackColor = System.Drawing.Color.Salmon;
            }
        }
        public static bool CheckPhoneFormat(string phone)
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
        public static bool CheckZipFormat(string zip)
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
