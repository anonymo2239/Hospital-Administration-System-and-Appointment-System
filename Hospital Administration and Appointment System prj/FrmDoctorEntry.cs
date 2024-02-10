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

namespace Hospital_Administration_and_Appointment_System_prj
{
    public partial class FrmDoctorEntry : Form
    {
        public FrmDoctorEntry()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        sqlConnection doctorEntry = new sqlConnection();

        private void lblBack_Click(object sender, EventArgs e)
        {
            FrmEntries frm = new FrmEntries();
            frm.Show();
            this.Close();
        }
        int i = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT DoctorTC, DoctorPassword FROM Table_Doctors WHERE " +
                "DoctorTC = @p1 AND DoctorPassword = @p2", doctorEntry.connection());
            cmd.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorDetails frmDoctorDetails = new FrmDoctorDetails();
                frmDoctorDetails.TC = maskedTextBox1.Text;
                frmDoctorDetails.Show();
                this.Hide();
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
            doctorEntry.connection().Close();
        }

        int num = 0;
        private void label4_Click(object sender, EventArgs e)
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
