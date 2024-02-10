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
using System.Security.Cryptography.X509Certificates;

namespace Hospital_Administration_and_Appointment_System_prj
{
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string tc;
        sqlConnection sqlConnection3 = new sqlConnection();
        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            //ad soyad cekme islemi
            lblID.Text = tc;
            SqlCommand cmd = new SqlCommand("SELECT PatientName, PatientSurname FROM Table_Patients WHERE PatientTC = @a1", sqlConnection3.connection());
            cmd.Parameters.AddWithValue("@a1", lblID.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblName.Text = reader[0].ToString();
                lblSurname.Text = Convert.ToString(reader[1]);
            }
            sqlConnection3.connection().Close();

            //appointment history
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Table_Appointments WHERE PatientTCID = " + tc, sqlConnection3.connection());
            da2.Fill(dt);
            dataGridView1.DataSource = dt;


            //bransları cekme
            SqlCommand cmd2 = new SqlCommand("SELECT BranchName FROM Table_Branches", sqlConnection3.connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranch.Items.Add(dr2[0]);
            }
            sqlConnection3.connection().Close();
        }
        //doktorlari cekme
        private void cmbbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("SELECT DoctorName, DoctorSurname FROM Table_Doctors WHERE DoctorBranch = @p1", sqlConnection3.connection());
            cmd3.Parameters.AddWithValue("@p1", cmbbranch.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            sqlConnection3.connection().Close();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table_Appointments WHERE AppBranch = '" + cmbbranch.Text + "' AND AppDoctor = '" + cmbDoctor.Text + "' AND AppSituation = 0",sqlConnection3.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkeditinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientEditInfo forEditInfo = new FrmPatientEditInfo();
            forEditInfo.TCno = lblID.Text;
            forEditInfo.name = lblName.Text;
            forEditInfo.surname = lblSurname.Text;
            forEditInfo.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FrmEntries frmEntries = new FrmEntries();
            frmEntries.Show();
            this.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Table_Appointments SET AppSituation = 1, PatientTCID = @p1, PatientComplaint" +
                " = @p2 WHERE AppID = @p3", sqlConnection3.connection());
            cmd.Parameters.AddWithValue("@p1", lblID.Text);
            cmd.Parameters.AddWithValue("@p2", rchComplain.Text);
            cmd.Parameters.AddWithValue("@p3", txtID.Text);
            cmd.ExecuteNonQuery();
            sqlConnection3.connection().Close();
            MessageBox.Show("Appointment has been made", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
