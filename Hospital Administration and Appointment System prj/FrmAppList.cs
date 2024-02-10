using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Administration_and_Appointment_System_prj
{
    public partial class FrmAppList : Form
    {
        public FrmAppList()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        sqlConnection sqlConnectionyeter = new sqlConnection();

        private void FrmAppList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Table_Appointments", sqlConnectionyeter.connection());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        public FrmSecretaryDetail frm;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            frm.txtid.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            frm.mskDate.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            frm.mskTime.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            frm.cmbBranch.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            frm.cmbDoctor.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            frm.mskID.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
        }
    }
}
