using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SMS_Tech_testing1.SMSTableAdapters;

namespace SMS_Tech_testing1
{
    public partial class frmAppointment : Form
    {
        public frmAppointment()
        {
            InitializeComponent();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            frmSchedule sc = new frmSchedule();
            sc.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmAppointment_Load(object sender, EventArgs e)
        {
            tblAppointmentTableAdapter adpAppointment = new tblAppointmentTableAdapter();
            SMS.tblAppointmentDataTable dtAppointment = new SMS.tblAppointmentDataTable(); 



        }

        private void btnRemind_Click(object sender, EventArgs e)
        {
            frmSendReminder sr = new frmSendReminder();
            sr.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
