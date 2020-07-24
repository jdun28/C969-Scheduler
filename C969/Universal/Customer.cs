using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ScheduleProgram.Universal
{
    public class Customer
    {
        //query to create selection for custDgv
        public static string findAllCustQuery =
            "SELECT customerId, customerName, address.address, city.city, address.postalCode, country.country, address.phone "
            + "FROM customer "
            + "INNER JOIN address ON customer.addressId = address.addressId "
            + "INNER JOIN city ON address.cityId = city.cityId "
            + "INNER JOIN country on city.countryId = country.countryId;";

        public static void populateCustData(string c, DataTable dt)
        {
            using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(c, connect);
                connect.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                connect.Close();
            }
        }
    }
}
