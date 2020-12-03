using ScheduleProgram.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ScheduleProgram
{
    public partial class UserSchedule : Form
    {
        private static Universals universals = new Universals();
        string getUsers = "SELECT userName from user;";
        int userId;
        public UserSchedule()
        {
            InitializeComponent();
            DataTable users = new DataTable();
            universals.GetData(getUsers, users);
            userCB.DataSource = users;
            userCB.DisplayMember = "userName";
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            GetUserSchedules();
        }

        private void GetUserSchedules()
        {
            {
                string userName = userCB.GetItemText(userCB.Text);
                string getUserId = "SELECT userId FROM user WHERE userName = '" + userName + "';";
                DataTable userIds = new DataTable();
                universals.TableReader(getUserId, userIds);

                if (userIds.Rows.Count > 0)
                {
                    int id = Convert.ToInt32(userIds.Rows[0][0]);
                    userId = id;
                }

                string getSchedule = "SELECT appointmentId, customerId, type, start, end FROM appointment WHERE userId = '" + userId + "' ORDER BY start;";
                DataTable schedule = new DataTable();
                universals.TableReader(getSchedule, schedule);
                if (schedule.Rows.Count > 0)
                {
                    userDgv.DataSource = schedule;
                }
            }
        }

        private void UserSchedule_Load(object sender, EventArgs e)
        {
            GetUserSchedules();
        }

        private void returnMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }
    }
}
