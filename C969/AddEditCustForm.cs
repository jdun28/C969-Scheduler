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

            if (Universals.CustomerID > 0)
            {
                UpdateCustomerData();
            }
            else
            {
                InsertCustomerData();
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
                    string getCity = cityCB.GetItemText(cityCB.Text);
                    
                    //selecting city id based off of city name
                    string sql = "SELECT cityId from city where city = '" + getCity + "';";

                    MySqlCommand city = new MySqlCommand(sql, con);
                    MySqlDataAdapter cityAdapter = new MySqlDataAdapter(city);
                    DataTable cityResult = new DataTable();
                    cityAdapter.Fill(cityResult);
                    //if (cityResult.Rows.Count > 0)
                    
                    int cID = Convert.ToInt32(cityResult.Rows[0][0]);
                    
                    //query to enter address data in address table
                    string insertAddressData =
                        "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy)" +
                        "VALUES ('" + addressTxt.Text + "', ' ', '" + cID + "', '" + zipTxt.Text + "', '"  + phoneTxt.Text + "', '"
                         + TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "', '" + Universals.CurrentUser + "', '" + Universals.CurrentUser + "');";

                    //query to get address ID from address table
                    string getAddress = "SELECT addressId FROM address WHERE address = '" + addressTxt.Text + "';";

                    MySqlCommand addressInsert = new MySqlCommand(insertAddressData, con);
                    addressInsert.ExecuteNonQuery();
                    MySqlCommand address = new MySqlCommand(getAddress, con);
                    MySqlDataAdapter addressAdapter = new MySqlDataAdapter(address);
                    DataTable addressResult = new DataTable();
                    addressAdapter.Fill(addressResult);
                    int aID = Convert.ToInt32(addressResult.Rows[0][0]);
                    
                    //query to insert customer data into customer table
                    string insertCustData =
                        "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdateBy)" +
                        "VALUES ('" + nameTxt.Text + "', '" + aID + "', 1 ,'" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "', '" + Universals.CurrentUser + "', '" + Universals.CurrentUser + "');";

                    MySqlCommand insertCustomer = new MySqlCommand(insertCustData, con);
                    insertCustomer.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                errorLbl.Text = "An error has occurred. Please try again.";
            }

            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();

        }

        public void UpdateCustomerData()
        {
            try
            {
                using (MySqlConnection connect = new MySqlConnection(SqlDatabase.ConnectionString))
                {
                    connect.Open();
                    //string to get city from dropdown
                    string updateCity = cityCB.GetItemText(cityCB.SelectedItem);
                    string citySql = "SELECT cityId FROM city WHERE city ='" + updateCity + "';";

                    MySqlCommand getCity = new MySqlCommand(citySql, connect);
                    MySqlDataAdapter city = new MySqlDataAdapter(getCity);
                    DataTable cityCombo = new DataTable();
                    city.Fill(cityCombo);
                    if (cityCombo.Rows.Count >0)
                    {
                        int id = (int)cityCombo.Rows[0][0];
                        Universals.CityID = id;
                    }

                    string addressID = "SELECT addressId FROM customer WHERE customerId = '" + Universals.CustomerID + "';";

                    MySqlCommand getAddress = new MySqlCommand(addressID, connect);
                    MySqlDataAdapter address = new MySqlDataAdapter(getAddress);
                    DataTable addressDt = new DataTable();
                    address.Fill(addressDt);
                    if (addressDt.Rows.Count > 0)
                    {
                        int addressid = (int)addressDt.Rows[0][0];
                        Universals.AddressID = addressid;
                    }


                    string addressUpdate =
                        "UPDATE address SET address = '" + addressTxt.Text + "', postalCode ='"  + zipTxt.Text + "', phone ='" + phoneTxt.Text + "', cityId ='" + Universals.CityID + "', " +
                        "lastUpdate = '" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "',  " +
                        "lastUpdateBy = '" + Universals.CurrentUser + "' " +
                        "WHERE addressId = '" + Universals.AddressID + "';";

                    string customerUpdate = "UPDATE customer SET customerName = '" + nameTxt.Text + "', " + "lastUpdate = '" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "',  " +
                        "lastUpdateBy = '" + Universals.CurrentUser + "' " +
                        "WHERE customerId = '" + Universals.CustomerID + "';";

                    MySqlCommand updateAddress = new MySqlCommand(addressUpdate, connect);
                    updateAddress.ExecuteNonQuery();

                    MySqlCommand updateCustomer = new MySqlCommand(customerUpdate, connect);
                    updateCustomer.ExecuteNonQuery();
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                errorLbl.Text = ex.ToString();
            }
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }

        private void cityCB_DropDownClosed(object sender, EventArgs e)
        {

        }
    }
}
