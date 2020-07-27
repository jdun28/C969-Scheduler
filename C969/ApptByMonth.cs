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
    public partial class ApptByMonth : Form
    {
        public ApptByMonth()
        {
            InitializeComponent();
            //monthCB.Text = "July 2020";
            //monthCB.Text = "Aug 2020";
            //monthCB.Text = "Sep 2020";
            //monthCB.Text = "Oct 2020";
            //monthCB.Text = "Nov 2020";
            monthCB.Items.Add("July 2020");
            monthCB.Items.Add("Aug 2020");
            monthCB.Items.Add("Sep 2020");
            monthCB.Items.Add("Oct 2020");
            monthCB.Items.Add("Nov 2020");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
