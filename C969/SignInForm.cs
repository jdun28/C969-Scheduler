using MySql.Data.MySqlClient;
using ScheduleProgram.Localization;
using ScheduleProgram.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleProgram
{
    public partial class SignInForm : Form
    {

           
        public SignInForm()
        {
            InitializeComponent();
            
        }

        private void signInButton_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From user where userName = '" + usernameTxt.Text + "' and password = '" + passwordTxt.Text + "'", connect);
                DataTable loginDt = new DataTable();
                adapter.Fill(loginDt);

                if (loginDt.Rows.Count > 0)
                {
                    this.Hide();
                    MainForm dash = new MainForm();
                    dash.Show();
                }
                else
                {
                    if (RegionInfo.CurrentRegion.DisplayName == "Mexico")
                    {
                        errorLbl.Text = "El nombre de usuario o la contraseña son incorrectos.";
                    }
                    else
                    {
                        errorLbl.Text = "The username or password are incorrect.";
                    }
                }
            }

            WriteLogin();
            CheckAppt();
            Universals.GetCurrentUserName();
            Universals.GetCurrentUserID();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            Spanish();
        }

        private void Spanish()
        {
            ResourceManager location = new ResourceManager("ScheduleProgram.Localization.Spanish", Assembly.GetExecutingAssembly());
            {
                if (RegionInfo.CurrentRegion.DisplayName == "Mexico")
                {
                    welcomeLbl.Text = location.GetString("welcomeLbl");
                    usernameLbl.Text = location.GetString("usernameLbl");
                    passwordLbl.Text = location.GetString("passwordLbl");
                    signInBtn.Text = location.GetString("signInBtn");
                    exitBtn.Text = location.GetString("exitBtn");
                }
            }
        }
        private void WriteLogin()
        {
            try
            {
                //Checking to see if loginRecord.txt exists
                //If it exists write to it
                if (File.Exists("loginRecord.txt"))
                {
                    using (StreamWriter e = File.AppendText("loginRecord.txt"))
                    {
                        e.WriteLine(usernameTxt.Text + " successfully logged in at " + DateTime.Now.ToString(), e);
                    }
                }
                //if it does not exist create new file and write
                else
                {
                    using (StreamWriter logUser = new StreamWriter("loginRecord.txt"))
                    {
                        logUser.WriteLine(usernameTxt.Text + " successfully logged in at " + DateTime.Now.ToString());
                    }
                }          
            }
            catch (Exception)
            {
                MessageBox.Show("The file could not be written to.");
            }
        }

        private void CheckAppt()
        {
            DateTime Current = Convert.ToDateTime(DateTime.UtcNow);
            DateTime Future = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(15);

            DataTable upcoming = new DataTable();

            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                connect.Open();
                MySqlCommand apptCheck = new MySqlCommand("SELECT * from appointment where start between '" +
                    Current.ToString("yyy-MM-dd HH:mm:ss") + "' AND '" +
                    Future.ToString("yyyy-MM-dd HH:mm:ss") + "'", connect);
                MySqlDataReader apptRead = apptCheck.ExecuteReader();
                upcoming.Load(apptRead);

                if (upcoming.Rows.Count > 0)
                {
                    MessageBox.Show(upcoming.ToString(), "Upcoming Appointments!");
                }
                connect.Close();
            }
        }

    }
}
