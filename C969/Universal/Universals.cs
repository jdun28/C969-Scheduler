using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleProgram.Universal
{
    class Universals
    {
        public static int CurrentCustIndex { get; set; }
        public static int CurrentApptIndex { get; set; }

        public static int CustomerID { get; set; }
        public static string CurrentAppointment { get; set; }

        public static string CurrentUser = "test";

        public static int CurrentUserID = 1;

        public static int CityID { get; set; }

        public static int AddressID { get; set; }

        //public static void GetCurrentUserName()
        //{
        //    using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
        //    {
        //        string getUser = "SELECT userName FROM user;";
        //        MySqlCommand user = new MySqlCommand(getUser, connect);
        //        var userResult = user.ExecuteScalar();
        //        if (userResult != null)
        //        {
        //            string thisUser = userResult.ToString();
        //            CurrentUser = thisUser;
        //        }
        //    }
        //}

        //public static void GetCurrentUserID()
        //{
        //    using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
        //    {
        //        string getID = "SELECT userId FROM user;";
        //        MySqlCommand id = new MySqlCommand(getID, connect);
        //        var userID = id.ExecuteScalar();
        //        if (userID != null)
        //        {
        //            int thisUserID = Convert.ToInt32(userID);
        //            CurrentUserID = thisUserID;
        //        }
        //    }
        //}

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

        public static bool IsInt(string text)
        {
            int number;
            return IsNotNullOrEmpty(text) &&
                Int32.TryParse(text, out number);
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
    }
}
