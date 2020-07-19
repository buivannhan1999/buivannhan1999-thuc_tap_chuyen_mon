using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ttcmon
{
    public class Connectcs
    {
        private static Connectcs instace;
        private string strConn = @"Data Source=DESKTOP-I9DGU6F\SQLEXPRESS;Initial Catalog=QLCHDT;Integrated Security=True";

        public static Connectcs Instance
        {
            get
            {
                if (instace == null)
                    instace = new Connectcs();
                return Connectcs.instace;
            }
            private set
            {
                Connectcs.instace = value;
            }
        }
        public DataTable excuteQuery(string query)
        {
            DataTable data = new DataTable();
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            conn.Close();
            return data;

        }
    }
}
