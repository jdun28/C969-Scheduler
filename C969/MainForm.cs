using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleProgram
{
    public partial class MainForm : Form
    {
        public string connectionString = $"SERVER=3.227.166.251, DATABASE=U06Etk, USERNAME = U06Etk, PASSWORD = 53688740958";


        //query to create selection for custDgv
        string custQuery =
            "SELECT customerName, address.address, city.city, address.postalCode, country.country, address.phone "
            + "FROM customer "
            + "INNER JOIN address ON customer.addressId = address.addressId "
            + "INNER JOIN city ON address.cityId = city.cityId "
            + "INNER JOIN country on city.countryId = country.countryId;";
       

        public MainForm()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand populateCust = new SqlCommand(custQuery, con);

                try
                {
                    con.Open();
                    SqlDataReader custRead = populateCust.ExecuteReader();
                    while (custRead.Read())
                    {

                    }
                }
                catch
                {

                }
            }
            InitializeComponent();

            custDgv.DataSource = populateCust;

            
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEditCustForm newCust = new AddEditCustForm();
            newCust.Show();
        }
    }
}
