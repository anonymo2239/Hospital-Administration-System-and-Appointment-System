using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Administration_and_Appointment_System_prj
{
    public partial class FrmPatientEntry : Form
    {
        public FrmPatientEntry()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        sqlConnection sqlConnection2 = new sqlConnection();

        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientSignin frmPatientSignin = new FrmPatientSignin();
            this.Close();
            frmPatientSignin.ShowDialog();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmEntries frmEntries = new FrmEntries();
            frmEntries.Show();
            this.Close();
        }
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Table_Patients where Patienttc = @p1 and PatientPassword = @p2", sqlConnection2.connection());
            cmd.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmPatientDetail frmPatientDetail = new FrmPatientDetail();
                frmPatientDetail.tc = maskedTextBox1.Text;
                frmPatientDetail.Show();
                this.Close();
            }
            else
            {
                i++;
                if (i == 5)
                {
                    MessageBox.Show("You made too many wrong attempts. The program is terminating...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
                MessageBox.Show("Wrong password or identity number. Please try again.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnection2.connection().Close();

        }
        int num = 0;
        private void label5_Click(object sender, EventArgs e)
        {
            num++;
            if (num % 2 == 1)
            {
                textBox1.UseSystemPasswordChar = false;
                txtHidePassword.Text = "Hide Password";
            }
            else if (num % 2 == 0)
            {
                textBox1.UseSystemPasswordChar = true;
                txtHidePassword.Text = "Show Password";
            }
        }
    }
}
