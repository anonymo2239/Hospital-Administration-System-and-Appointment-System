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
    public partial class FrmDoctorEditInfo : Form
    {
        public FrmDoctorEditInfo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        sqlConnection bgl = new sqlConnection();
        public string TCNO;
        private void FrmDoctorEditInfo_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCNO;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Doctors WHERE DoctorTC = @p1", bgl.connection());
            cmd.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                cmbBranch.Text = dr[3].ToString();
                txtPassword.Text = dr[5].ToString();
            }
            bgl.connection().Close();

            SqlCommand cmd4 = new SqlCommand("SELECT BranchName FROM Table_Branches", bgl.connection());
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                cmbBranch.Items.Add(dr4[0]);
            }
            bgl.connection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            mskTC.Text = "";
            cmbBranch.Text = "";
            txtPassword.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("UPDATE Table_Doctors SET DoctorName = @g1, " +
                "DoctorSurname = @g2, DoctorBranch = @g3, DoctorPassword = @g5 WHERE DoctorTC = @g4", bgl.connection());
            cmd3.Parameters.AddWithValue("@g1", txtName.Text);
            cmd3.Parameters.AddWithValue("@g2", txtSurname.Text);
            cmd3.Parameters.AddWithValue("@g3", cmbBranch.Text);
            cmd3.Parameters.AddWithValue("@g4", mskTC.Text);
            cmd3.Parameters.AddWithValue("@g5", txtPassword.Text);
            cmd3.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("The physician has been updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
