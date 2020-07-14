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
            InitializeComponent();
        }

        private void cancelApptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }
    }
}
