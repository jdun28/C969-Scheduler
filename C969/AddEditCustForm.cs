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
    public partial class AddEditCustForm : Form
    {
        public AddEditCustForm()
        {
            InitializeComponent();
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
    }
}
