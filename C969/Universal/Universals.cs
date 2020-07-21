using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

        public static Customer CurrentCustomer { get; set; }

        public static string CurrentUser()
        {
            using (MySqlConnection con = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                con.Open();
                MySqlCommand user = new MySqlCommand("SELECT userName FROM user;", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(user);
                con.Close();
                return user.ToString();               
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
