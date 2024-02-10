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
using System.Xml.Linq;

namespace Hospital_Administration_and_Appointment_System_prj
{
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string TCno;
        sqlConnection mySqlConnection5 = new sqlConnection();
        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            secTc.Text = TCno;

            //Ad soyad cekme islemi
            SqlCommand cmd =
                new SqlCommand("SELECT SecretaryNameSurname " +
                               "FROM Table_Secretaries WHERE SecretaryTC = @p1", mySqlConnection5.connection());
            cmd.Parameters.AddWithValue("@p1", secTc.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                secName.Text = reader[0].ToString();
            }
            mySqlConnection5.connection().Close();

            //Branslari Datagrid e aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da =
                new SqlDataAdapter("SELECT * FROM Table_Branches", mySqlConnection5.connection());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorlari listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT (DoctorName + ' ' + DoctorSurname) as 'Doctors', DoctorBranch " +
                                                    "FROM Table_Doctors", mySqlConnection5.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Bransı combobox'a aktarma
            
            SqlCommand cmd2 = new SqlCommand("SELECT BranchName FROM Table_Branches", mySqlConnection5.connection());
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while(reader2.Read())
            {
                cmbBranch.Items.Add(reader2[0].ToString());
            }
            mySqlConnection5.connection().Close();

            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FrmEntries frmEntries = new FrmEntries();
            frmEntries.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmdSave = new SqlCommand("INSERT INTO Table_Appointments (AppDate, AppTime, AppBranch, AppDoctor)" +
                                                " VALUES (@r1, @r2, @r3, @r4)", mySqlConnection5.connection());
            cmdSave.Parameters.AddWithValue("@r1", mskDate.Text);
            cmdSave.Parameters.AddWithValue("@r2", mskTime.Text);
            cmdSave.Parameters.AddWithValue("@r3", cmbBranch.Text);
            cmdSave.Parameters.AddWithValue("@r4", cmbDoctor.Text);
            cmdSave.ExecuteNonQuery();
            mySqlConnection5.connection();
            MessageBox.Show("Application has been created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktorlari combobox'a aktarma
            cmbDoctor.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("SELECT DoctorName, DoctorSurname FROM" +
                " Table_Doctors WHERE DoctorBranch = @p1", mySqlConnection5.connection());
            cmd3.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                cmbDoctor.Items.Add(reader3[0] + " " + reader3[1]);
            }
            mySqlConnection5.connection().Close();
        }

        private void btnCreateNotice_Click(object sender, EventArgs e)
        {
            SqlCommand cmdNotices = new SqlCommand("INSERT INTO Table_Announcements (Notice) VALUES (@l1)", mySqlConnection5.connection());
            cmdNotices.Parameters.AddWithValue("@l1", rchNotice.Text);
            cmdNotices.ExecuteNonQuery();
            mySqlConnection5.connection().Close();
            MessageBox.Show("The announcement has been saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDocPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorEditPanel frmDoctorEditPanel = new FrmDoctorEditPanel();
            frmDoctorEditPanel.Show();
        }

        private void btnBranchPanel_Click(object sender, EventArgs e)
        {
            FrmBranch frmBranch = new FrmBranch();
            frmBranch.Show();
        }

        private void btnAppList_Click(object sender, EventArgs e)
        {
            FrmAppList frmAppList = new FrmAppList();
            frmAppList.frm = this;
            frmAppList.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("DELETE FROM Table_Appointments WHERE AppDate = @p1 AND " +
                "AppTime = @p2 AND AppBranch = @p3 AND AppDoctor = @p4 AND PatientTCID = @p5", mySqlConnection5.connection());

            cmd2.Parameters.AddWithValue("@p1", mskDate.Text);
            cmd2.Parameters.AddWithValue("@p2", mskTime.Text);
            cmd2.Parameters.AddWithValue("@p3", cmbBranch.Text);
            cmd2.Parameters.AddWithValue("@p4", cmbDoctor.Text);
            cmd2.Parameters.AddWithValue("@p5", mskID.Text);

            cmd2.ExecuteNonQuery();
            mySqlConnection5.connection().Close();

            checkBox1.Checked = false;
            MessageBox.Show("Appointment has been deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNotices frmNotices = new FrmNotices();
            frmNotices.Show();
        }
    }
}
