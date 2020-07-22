using MySql.Data.MySqlClient;
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

namespace ScheduleProgram
{
    public partial class AddEditApptForm : Form
    {
        public AddEditApptForm()
        {
            string customerName= "SELECT customerName from customer;";
            string apptType = "SELECT type from appointment;";
            DataTable customers = new DataTable();
            DataTable type = new DataTable();
            InitializeComponent();          
            Universals.GetData(customerName, customers);
            custNameCB.DataSource = customers;
            custNameCB.DisplayMember = "customerName";
            Universals.GetData(apptType, type);
            typeCB.DataSource = type;
            typeCB.DisplayMember = "type";
        }
        private void cancelApptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }

        private void custNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
