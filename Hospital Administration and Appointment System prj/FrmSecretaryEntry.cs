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
    public partial class FrmSecretaryEntry : Form
    {
        public FrmSecretaryEntry()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        sqlConnection sqlConnection5 = new sqlConnection();
        private int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd7 =
                new SqlCommand("SELECT * FROM Table_Secretaries WHERE SecretaryTC = @p1 and SecretaryPassword = @p2",
                    sqlConnection5.connection());
            cmd7.Parameters.AddWithValue("@p1", mskSecTC.Text);
            cmd7.Parameters.AddWithValue("@p2", txtSecPw.Text);
            SqlDataReader reader = cmd7.ExecuteReader();
            if (reader.Read())
            {
                
                FrmSecretaryDetail detail = new FrmSecretaryDetail();
                detail.TCno = mskSecTC.Text;
                detail.Show();
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
            sqlConnection5.connection().Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            FrmEntries frEntries = new FrmEntries();
            frEntries.Show();
            this.Close();
        }
    }
}
