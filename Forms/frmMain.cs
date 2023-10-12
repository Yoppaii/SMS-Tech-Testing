using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Tech_testing1
{
    public partial class frmMain : Form
    {
        private Form activeForm;
        public frmMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Dock = DockStyle.Fill;
            this.pnlParent.Controls.Add(childForm);
            this.pnlParent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text;
        }


        private void btnRemind_Click(object sender, EventArgs e)
        {
            frmSendReminder sr = new frmSendReminder();
            sr.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboard(), sender);

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAppointment(), sender);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboard(), sender);
        }
    }
}
