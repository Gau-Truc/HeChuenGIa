using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class connect
    {
        public static String ConnectString = "Data Source=LAPTOP-MAVHB4L2\\SQLEXPRESS;Initial Catalog=ChuanDoanBenhPhoi;user id=sa;password=29102001lun";

        public static DataTable ExecuteDataTable_SQL(string sql)
        {
            using (SqlConnection conn = new SqlConnection(ConnectString))
            {
                using (SqlDataAdapter dad = new SqlDataAdapter(sql, conn))
                {
                    using (DataSet dst = new DataSet())
                    {
                        dad.Fill(dst);
                        return dst.Tables[0];
                    }
                }
            }
        }

        public static void ExecuteNonData(string sql)
        {
            using (SqlConnection conn = new SqlConnection(ConnectString))
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
