using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPPHATTHUOC
{
    public static class DBConnection
    {
        private static string connectionString =
            @"Server=DESKTOP-SU6URTU\SQLEXPRESS;Database=QLCAPPHATTHUOC;Integrated Security=True;";

        private static SqlConnection conn;

        public static SqlConnection GetConnection()
        {
            if (conn == null)
                conn = new SqlConnection(connectionString);

            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

            return conn;
        }
    }
}
