using ScheduleProgram.Database;
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
        public string cityCountry = "SELECT city.city, country.country "
       + " from city "
       + "INNER JOIN country on city.countryId = country.countryId;";

        public AddEditCustForm()
        {
            DataTable custDt = new DataTable();
            InitializeComponent();
            Customer.populateCustData(cityCountry, custDt);
            cityCB.DataSource = custDt;
            cityCB.DisplayMember = "City";
            countryCB.DataSource = custDt;
            countryCB.DisplayMember = "Country";
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
