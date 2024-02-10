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
    public partial class FrmPatientEditInfo : Form
    {
        public FrmPatientEditInfo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        void Clean()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            msktc.Text = "";
            mskTel.Text = "";
            txtNewPassword.Text = "";
            txtNewPasswordAgn.Text = "";
            txtPassword.Text = "";
        }

        sqlConnection sqlconnection4 = new sqlConnection();

        public string TCno;
        public string name;
        public string surname;
        private void label7_Click(object sender, EventArgs e)
        {
            FrmPatientDetail forPatientDetail = new FrmPatientDetail();
            forPatientDetail.Show();
            this.Hide();
        }

        private void FrmPatientEditInfo_Load(object sender, EventArgs e)
        {
            msktc.Text = TCno;
            txtName.Text = name;
            txtSurname.Text = surname;
            SqlCommand cmd4 =
                new SqlCommand("SELECT PatientPhone, PatientGender, PatientPassword FROM Table_Patients where PatientTC = @b1",
                    sqlconnection4.connection());
            cmd4.Parameters.AddWithValue("@b1", TCno);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            if (reader4.Read())
            {
                mskTel.Text = reader4[0].ToString();
                label11.Text = reader4[1].ToString();
                label7.Text = reader4[2].ToString();
            }

            if (label11.Text == "True")
            {
                radioButton1.Checked = true;
            }
            else if (label11.Text == "False")
            {
                radioButton2.Checked = true;
            }
            sqlconnection4.connection().Close();

        }
        int num = 0;
        private void lblShowPassword_Click(object sender, EventArgs e)
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

        private void lnkClearAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clean();
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            SqlCommand cmd5 =
                new SqlCommand(
                    "UPDATE Table_Patients set PatientName = @p1, PatientSurname = @p2," +
                    " PatientPhone = @p3, PatientPassword = @p4, PatientGender = @p5 WHERE PatientTC = @p6",
                    sqlconnection4.connection());
            cmd5.Parameters.AddWithValue("@p1", txtName.Text);
            cmd5.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd5.Parameters.AddWithValue("@p3", mskTel.Text);
            cmd5.Parameters.AddWithValue("@p4", txtNewPassword.Text);
            cmd5.Parameters.AddWithValue("@p5", label11.Text);
            cmd5.Parameters.AddWithValue("@p6", msktc.Text);
            if (txtNewPassword.Text == txtNewPasswordAgn.Text && txtPassword.Text == label7.Text)
            {
                cmd5.ExecuteNonQuery();
                sqlconnection4.connection().Close();
                MessageBox.Show("Your informations has been updated. Your Password: " + txtNewPassword.Text, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtNewPassword.Text != txtNewPasswordAgn.Text && txtPassword.Text == label7.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNewPassword.Text == txtNewPasswordAgn.Text && txtPassword.Text != label7.Text)
            {
                MessageBox.Show("Old Password that were entered is wrong. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
