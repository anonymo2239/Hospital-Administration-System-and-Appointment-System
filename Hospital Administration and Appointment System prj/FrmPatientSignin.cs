using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Administration_and_Appointment_System_prj
{
    public partial class FrmPatientSignin : Form
    {
        public FrmPatientSignin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        int num = 0;
        void ShowPassword()
        {
            num++;
            if (num % 2 == 1)
            {
                txtPassword.UseSystemPasswordChar = false;
                label9.Text = "Hide Password";
            }
            else if (num % 2 == 0)
            {
                txtPassword.UseSystemPasswordChar = true;
                label9.Text = "Show Password";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FrmPatientEntry frmPatientEntry = new FrmPatientEntry();
            frmPatientEntry.Show();
            this.Close();
        }

        sqlConnection sqlConnection = new sqlConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            bool gender = false;
            if (label8.Text == "True")
            { gender = true; }
            else if (label8.Text == "False")
            { gender = false; };
            SqlCommand command = new SqlCommand("insert into Table_Patients (PatientName, PatientSurname, PatientTC, PatientPhone, PatientPassword, PatientGender) values (@p1, @p2, @p3, @p4, @p5, @p6)", sqlConnection.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", mskTC.Text);
            command.Parameters.AddWithValue("@p4", mskPhone.Text);
            command.Parameters.AddWithValue("@p5", txtPassword.Text);
            command.Parameters.AddWithValue("@p6", gender);
            command.ExecuteNonQuery();
            sqlConnection.connection().Close();
            MessageBox.Show("Your registration has been completed. Your password: " + txtPassword.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";
        }

        
        private void label9_Click(object sender, EventArgs e)
        {
            ShowPassword();
        }
    }
}
