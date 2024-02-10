using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Administration_and_Appointment_System_prj
{
    public partial class FrmEntries : Form
    {
        public FrmEntries()
        {
            InitializeComponent();
            label1.ForeColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPatientEntry patientEntry = new FrmPatientEntry();
            patientEntry.Show();
            this.Hide();
        }

        private void btnPhysician_Click(object sender, EventArgs e)
        {
            FrmDoctorEntry frmDoctorEntry = new FrmDoctorEntry();
            frmDoctorEntry.Show();
            this.Hide();
        }

        private void btnSecretary_Click(object sender, EventArgs e)
        {
            FrmSecretaryEntry frm = new FrmSecretaryEntry();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else{}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This system was developed by Adem Alperen Arda in 2023. https://github.com/anonymo2239 for more.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
