using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ttcm
{
   
    public  class Class1
    {
        private static Class1 instace;
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLBanXe;Integrated Security=True";
        public static Class1 Instance
        {
            get
            {
                if (instace == null)
                    instace = new Class1();
                return Class1.instace;
            }
            private set
            {
                Class1.instace = value;
            }
        }
        public DataTable  excuteQuery (string query)
        {

            DataTable data = new DataTable();
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            conn.Close();
            return data;

        }

        }

          

        }

    



