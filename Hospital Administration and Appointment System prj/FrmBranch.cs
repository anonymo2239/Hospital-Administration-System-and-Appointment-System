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
    public partial class FrmBranch : Form
    {
        public FrmBranch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        sqlConnection sqlConnectionim = new sqlConnection();
        private void FrmBranch_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Table_Branches", sqlConnectionim.connection());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_Branches (BranchName) VALUES (@p1)", sqlConnectionim.connection());
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.ExecuteNonQuery();
            sqlConnectionim.connection().Close();
            MessageBox.Show(txtName.Text + " branch has been added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Table_Branches", sqlConnectionim.connection());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            txtID.Text = "";
            txtName.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("DELETE FROM Table_Branches WHERE BranchName = @p1", sqlConnectionim.connection());
            cmd2.Parameters.AddWithValue("@p1", txtName.Text);
            cmd2.ExecuteNonQuery();
            sqlConnectionim.connection().Close();
            MessageBox.Show(txtName.Text + " branch has been deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("UPDATE Table_Branches SET BranchName = @p1 WHERE BranchID = @p2", sqlConnectionim.connection());
            cmd3.Parameters.AddWithValue("@p1", txtName.Text);
            cmd3.Parameters.AddWithValue("@p2", txtID.Text);
            cmd3.ExecuteNonQuery();
            sqlConnectionim.connection().Close();
            MessageBox.Show(txtName.Text + " branch has been updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
