using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPPHATTHUOC
{
    public static class Database
    {
        public static DataTable Query(string sql, params SqlParameter[] p)
        {
            SqlCommand cmd = new SqlCommand(sql, DBConnection.GetConnection());
            if (p != null) cmd.Parameters.AddRange(p);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int Execute(string sql, params SqlParameter[] p)
        {
            SqlCommand cmd = new SqlCommand(sql, DBConnection.GetConnection());
            if (p != null) cmd.Parameters.AddRange(p);

            return cmd.ExecuteNonQuery();
        }
    }
}
