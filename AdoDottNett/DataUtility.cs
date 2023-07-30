using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDottNett
{
    public class DataUtility
    {
        public void InsertData()
        {
            string connectionString = "Server=MAAQ-HP;Database=CsharpDB;User Id=sa;Password=M@@q_786;TrustServerCertificate=true";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"Insert Into Student(ID,[Name],Class) values (2,'Mamun',9)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = sql;
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
