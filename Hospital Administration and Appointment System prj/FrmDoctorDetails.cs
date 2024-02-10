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
    public partial class FrmDoctorDetails : Form
    {
        public FrmDoctorDetails()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        sqlConnection sqlConnectionlast = new sqlConnection();
        public string TC;
        private void FrmDoctorDetails_Load(object sender, EventArgs e)
        {
            FrmDoctorEntry frmDoctorEntry = new FrmDoctorEntry();
            lblTC.Text = TC;
            SqlCommand sqlCommand = new SqlCommand("SELECT DoctorName, DoctorSurname " +
                "FROM Table_Doctors WHERE DoctorTC = " + TC , sqlConnectionlast.connection());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                lblName.Text = sqlDataReader[0].ToString();
                lblSurname.Text = sqlDataReader[1].ToString();
            }
            sqlConnectionlast.connection().Close();

            SqlCommand sqlCommand2 = new SqlCommand("SELECT Notice FROM Table_Announcements WHERE NoticeID = @NoticeID", sqlConnectionlast.connection());
            sqlCommand2.Parameters.AddWithValue("@NoticeID", 5);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            while (sqlDataReader2.Read())
            {
                label5.Text = sqlDataReader2[0].ToString();
            }
            sqlConnectionlast.connection().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table_Appointments WHERE" +
                " AppDoctor = '" + lblName.Text + " " + lblSurname.Text + "'", sqlConnectionlast.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNotices frmNotices = new FrmNotices();
            frmNotices.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoctorEditInfo frmDoctorEditInfo = new FrmDoctorEditInfo();
            frmDoctorEditInfo.TCNO = lblTC.Text;
            frmDoctorEditInfo.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            RchComplain.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }
    }
}
