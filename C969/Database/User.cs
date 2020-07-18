using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleProgram.Database
{
    class User
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public bool Active { get; set; }

        private void WriteLogin(User user)
        {

            try
            {
                using (StreamWriter logUser = new StreamWriter("loginRecord.txt"))
                {
                    logUser.WriteLine(Username + "successfully logged in at " + DateTime.Now.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The file could not be written to.");
            }
        }

    }
}
