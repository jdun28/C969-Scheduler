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

namespace ScheduleProgram
{
    public partial class AddEditCustForm : Form
    {
        //string to get only city and country
        public string city = "SELECT city from city;";
        public string country = "SELECT country from country;";

        public AddEditCustForm()
        {
            DataTable cityDt = new DataTable();
            DataTable countryDt = new DataTable();
            InitializeComponent();
            getConstData(city, cityDt);
            cityCB.DataSource = cityDt;
            cityCB.DisplayMember = "City";
            Customer.populateCustData(country, countryDt);
        }

        public void getConstData(string d, DataTable dt)
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

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelCustBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }

        private void cityCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
