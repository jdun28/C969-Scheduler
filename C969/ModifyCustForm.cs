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
    public partial class ModifyCustForm : Form
    {

        public int cID;
        public int aID;

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


        public ModifyCustForm()
        {
            string city = "SELECT city from city;";
            DataTable cityDt = new DataTable();
            InitializeComponent();
            Universals.GetData(city, cityDt);
            cityCB.DataSource = cityDt;
            cityCB.DisplayMember = "City";
            
        }
        private void cancelCustBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }

        private void saveCustBtn_Click(object sender, EventArgs e)
        {
        
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
    }
}
