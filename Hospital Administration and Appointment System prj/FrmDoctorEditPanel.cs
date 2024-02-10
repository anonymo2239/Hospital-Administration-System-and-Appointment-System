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
    public partial class FrmDoctorEditPanel : Form
    {
        public FrmDoctorEditPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        sqlConnection busqlconnectionileosqlconnectionaynidegil = new sqlConnection();
        private void FrmDoctorEditPanel_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Table_Doctors", busqlconnectionileosqlconnectionaynidegil.connection());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            SqlCommand cmd4 = new SqlCommand("SELECT BranchName FROM Table_Branches", busqlconnectionileosqlconnectionaynidegil.connection());
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                cmbBranch.Items.Add(dr4[0]);
            }
            busqlconnectionileosqlconnectionaynidegil.connection().Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_Doctors (DoctorName, DoctorSurname, " +
                "DoctorBranch, DoctorTC, DoctorPassword) " +
                "VALUES (@p1, @p2, @p3, @p4, @p5)", busqlconnectionileosqlconnectionaynidegil.connection());
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4", mskTC.Text);
            cmd.Parameters.AddWithValue("@p5", txtPassword.Text);
            cmd.ExecuteNonQuery();
            busqlconnectionileosqlconnectionaynidegil.connection().Close();
            MessageBox.Show("The physician has been added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            cmbBranch.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("DELETE FROM Table_Doctors WHERE DoctorTC = @p1",
                busqlconnectionileosqlconnectionaynidegil.connection());
            cmd2.Parameters.AddWithValue("@p1", mskTC.Text);
            cmd2.ExecuteNonQuery();
            busqlconnectionileosqlconnectionaynidegil.connection() .Close();
            MessageBox.Show("The physician has been deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Table_Doctors", busqlconnectionileosqlconnectionaynidegil.connection());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtPassword.Text = "";
            mskTC.Text = "";
            cmbBranch.Items.Clear();
            SqlCommand cmd4 = new SqlCommand("SELECT BranchName FROM Table_Branches", busqlconnectionileosqlconnectionaynidegil.connection());
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                cmbBranch.Items.Add(dr4[0]);
            }
            busqlconnectionileosqlconnectionaynidegil.connection().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("UPDATE Table_Doctors SET DoctorName = @g1, " +
                "DoctorSurname = @g2, DoctorBranch = @g3, DoctorPassword = @g5 WHERE DoctorTC = @g4", busqlconnectionileosqlconnectionaynidegil.connection()); 
            cmd3.Parameters.AddWithValue("@g1", txtName.Text);
            cmd3.Parameters.AddWithValue("@g2", txtSurname.Text);
            cmd3.Parameters.AddWithValue("@g3", cmbBranch.Text);
            cmd3.Parameters.AddWithValue("@g4", mskTC.Text);
            cmd3.Parameters.AddWithValue("@g5", txtPassword.Text);
            cmd3.ExecuteNonQuery();
            busqlconnectionileosqlconnectionaynidegil.connection().Close();
            MessageBox.Show("The physician has been updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
