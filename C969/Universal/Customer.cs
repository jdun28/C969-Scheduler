using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ScheduleProgram.Universal
{
    public class Customer
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int AddressId { get; set; }
        public string Active { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string PhoneNum { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }

        public Customer (int cId, string cName, int aId, string status, string address, string postal, string phone, 
            DateTime created, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CustomerId = cId;
            CustomerName = cName;
            AddressId = aId;
            Active = status;
            Address = address;
            PostCode = postal;
            PhoneNum = phone;
            CreatedDate = created;
            CreatedBy = createdBy;
            LastUpdated = lastUpdate;
            LastUpdatedBy = lastUpdateBy;
        }


        //query to create selection for custDgv
        public static string custQuery =
            "SELECT customerName, address.address, city.city, address.postalCode, country.country, address.phone "
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
