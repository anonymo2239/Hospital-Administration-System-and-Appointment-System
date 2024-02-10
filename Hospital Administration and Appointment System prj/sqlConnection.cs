using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Administration_and_Appointment_System_prj
{
    internal class sqlConnection
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=LAPTOP-E82TE7I7\\SQLEXPRESS;Initial Catalog=\"Hospital Project\";Integrated Security=True");
            connect.Open();
            return connect;
        }
        
    }
}
