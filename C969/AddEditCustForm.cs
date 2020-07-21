using ScheduleProgram.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Markup;

namespace ScheduleProgram
{
    public partial class AddEditCustForm : Form
    {
        
        
        public AddEditCustForm()
        {
            string city = "SELECT city from city;";
            DataTable cityDt = new DataTable();
            InitializeComponent();
            GetCities(city, cityDt);
            cityCB.DataSource = cityDt;
            cityCB.DisplayMember = "City";
            
        }
        public void GetCities(string d, DataTable dt)
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
        private void cancelCustBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }

        private void saveCustBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(SqlDatabase.ConnectionString))
                {
                    con.Open();
                    MySqlCommand getCity = new MySqlCommand("SELECT cityId from city where city = '" + cityCB.GetItemText(cityCB.SelectedIndex) + "';", con);

                    string insertAddressData =
                        "INSERT INTO address (address, postalCode, phone, cityId, createDate, createdBy)" +
                        "VALUES (" + addressTxt.Text + "," + zipTxt.Text + "," + getCity + "," +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + ", test;";

                    string insertCustData =
                        "INSERT INTO customer (customerName, addressId, active, createDate, createdBy)" +
                        "VALUES ('" + nameTxt.Text + "','" + "'(SELECT addressId from address WHERE address = '" + addressTxt.Text + "'), 1 ,'" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "', '" + Universals.CurrentUser() + "');";

                    MySqlCommand insertAddress = new MySqlCommand(insertAddressData, con);
                    MySqlCommand insertCust = new MySqlCommand(insertCustData, con);

                    con.Close();
                }
            }
            catch (Exception)
            {
                errorLbl.Text = "An error has occurred. Please try again.";
            }
        }
        private bool SaveAllowed()
        {
           if (!Universals.IsNotNullOrEmpty(nameTxt.Text))
            { return false; }
           if (!Universals.IsNotNullOrEmpty(addressTxt.Text))
            { return false; }
           if (!Universals.IsNotNullOrEmpty(zipTxt.Text))
            { return false; }
           if (!Universals.IsNotNullOrEmpty(phoneTxt.Text))
            { return false; }
            return true;
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            saveCustBtn.Enabled = SaveAllowed();
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            saveCustBtn.Enabled = SaveAllowed();
        }

        private void zipTxt_TextChanged(object sender, EventArgs e)
        {
            saveCustBtn.Enabled = SaveAllowed();
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            saveCustBtn.Enabled = SaveAllowed();
        }

        private void AddEditCustForm_Load(object sender, EventArgs e)
        {
            saveCustBtn.Enabled = SaveAllowed();
        }
    }
}
