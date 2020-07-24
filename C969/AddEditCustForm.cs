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

        public static int cID;
        public static int aID;

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
        public AddEditCustForm()
        {
            string city = "SELECT city from city;";
            DataTable cityDt = new DataTable();
            InitializeComponent();
            Universals.GetData(city, cityDt);
            cityCB.DataSource = cityDt;
            cityCB.DisplayMember = "City";


        if (Universals.CustomerID > 0)
            {
                DataTable customerFill = new DataTable();
                string custInfo = Customer.findAllCustQuery;
                    
            
                using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
                {
                    connect.Open();
                    MySqlCommand ccmd = new MySqlCommand(custInfo, connect);
                    MySqlDataReader creader = ccmd.ExecuteReader();
                    customerFill.Load(creader);

                    nameTxt.Text = (string)customerFill.Rows[Universals.CurrentCustIndex]["customerName"];
                    addressTxt.Text = (string)customerFill.Rows[Universals.CurrentCustIndex]["address"];
                    zipTxt.Text = (string)customerFill.Rows[Universals.CurrentCustIndex]["postalCode"];
                    phoneTxt.Text = (string)customerFill.Rows[Universals.CurrentCustIndex]["phone"];
                    cityCB.Text = (string)customerFill.Rows[Universals.CurrentCustIndex]["city"];
                    connect.Close();
                }
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
            if (Universals.CustomerID == 0)
            {
                InsertCustomerData();
            }
            if (Universals.CustomerID > 0)
            {
                UpdateCustomerData();
            }
        }
        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            bool validName = Universals.IsNotNullOrEmpty(nameTxt.Text);
            Universals.ValidateField(nameTxt, validName);
            saveCustBtn.Enabled = SaveAllowed();
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            bool validAddress = Universals.IsNotNullOrEmpty(addressTxt.Text);
            Universals.ValidateField(addressTxt, validAddress);
            saveCustBtn.Enabled = SaveAllowed();
        }

        private void zipTxt_TextChanged(object sender, EventArgs e)
        {
            bool validZip = Universals.IsNotNullOrEmpty(zipTxt.Text);
            Universals.ValidateField(zipTxt, validZip);
            saveCustBtn.Enabled = SaveAllowed();
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            bool validPhone = Universals.IsNotNullOrEmpty(phoneTxt.Text);
            Universals.ValidateField(phoneTxt, validPhone);
            saveCustBtn.Enabled = SaveAllowed();
        }

        private void AddEditCustForm_Load(object sender, EventArgs e)
        {
            saveCustBtn.Enabled = SaveAllowed();
        }

        public void InsertCustomerData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(SqlDatabase.ConnectionString))
                {
                    con.Open();

                    //finding name of city from drop down
                    string getCity = cityCB.GetItemText(cityCB.SelectedIndex);

                    //selecting city id based off of city name
                    string sql = "SELECT cityId from city where city = '" + getCity + "';";

                    MySqlCommand city = new MySqlCommand(sql, con);
                    var cityResult = city.ExecuteScalar();
                    if (cityResult != null)
                    {
                        int cID = Convert.ToInt32(cityResult);
                    }

                    //query to enter address data in address table
                    string insertAddressData =
                        "INSERT INTO address (address, postalCode, phone, cityId, createDate, createdBy)" +
                        "VALUES ('" + addressTxt.Text + "', '" + zipTxt.Text + "', '" + cID + "', '" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "', '" + Universals.CurrentUser + "');";

                    //query to get address ID from address table
                    string getAddress = "SELECT addressId FROM address WHERE address = '" + addressTxt.Text + "';";

                    MySqlCommand addressInsert = new MySqlCommand(insertAddressData, con);
                    MySqlCommand address = new MySqlCommand(getAddress, con);
                    var addressResult = address.ExecuteScalar();
                    if (addressResult != null)
                    {
                        int aID = Convert.ToInt32(addressResult);
                    }
                    //query to insert customer data into customer table
                    string insertCustData =
                        "INSERT INTO customer (customerName, addressId, active, createDate, createdBy)" +
                        "VALUES ('" + nameTxt.Text + "' ,'" + aID + "'), 1 ,'" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "', '" + Universals.CurrentUser + "');";

                    MySqlCommand insertCustomer = new MySqlCommand(insertCustData, con);
                    var customerResult = insertCustomer.ExecuteScalar();
                    con.Close();
                }
            }
            catch (Exception)
            {
                errorLbl.Text = "An error has occurred. Please try again.";
            }

        }

        public void UpdateCustomerData()
        {
            try
            {
                using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
                {
                    //string to get city from dropdown
                    string updateCity = cityCB.GetItemText(cityCB.SelectedIndex);

                    string citySql = "SELECT cityId FROM city WHERE city ='" + updateCity + "';";
                    string customerID = "SELECT customerId FROM customer WHERE customerName = '" + nameTxt.Text + "';";
                    string addressID = "SELECT addressId FROM customer WHERE customerId = '" + customerID + "';";

                    string customerUpdate =
                        "UPDATE customer " +
                        " SET customerName = '" + nameTxt.Text + "', " + "lastUpdate = '" + 
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "',  '" +
                        "lastUpdateBy = '" + Universals.CurrentUser + "';" +
                        "WHERE customerId = '" + customerID + "';" +
                        "UPDATE address " +
                        "SET address = '" + addressTxt.Text + "', '" + zipTxt.Text + "', '" + phoneTxt.Text + "', '" + citySql + "'" +
                        "lastUpdate = '" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "',  '" +
                        "lastUpdateBy = '" + Universals.CurrentUser + "';" +
                        "WHERE addressId = '" + addressID + "';";
                    connect.Open();
                    MySqlCommand updateCustomer = new MySqlCommand(customerUpdate, connect);
                    var updatedCustomer = updateCustomer.ExecuteScalar();
                    connect.Close();
                }
            }
            catch
            {
                errorLbl.Text = "Unable to update customer. Please try again.";
            }
        }
    }
}
