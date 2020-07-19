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
            if (username == usernameTxt.Text && password == passwordTxt.Text)       
            {
                this.Hide();
                MainForm dash = new MainForm();
                dash.Show();
            }
            else
            {
                errorLbl.Text = "The username or password are incorrect.";
            }
            
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void SignInForm_Load(object sender, EventArgs e)
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
                    errorLbl.Text = location.GetString("errorLbl");

                }
            }
        }
        private void WriteLogin(string user)
        {
            try
            {
                using (StreamWriter logUser = new StreamWriter("loginRecord.txt"))
                {
                    logUser.WriteLine(Universals.Username + "successfully logged in at " + DateTime.Now.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The file could not be written to.");
            }
        }

        string username = "SELECT userName FROM user;";
        string password = "SELEECT password FROM user;";

    }
}
