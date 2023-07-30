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
        private SqlConnection _connection;
        public DataUtility(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }
       
        public void ExecuteSql(string sql, Dictionary<string, object> values)
        {
            using SqlCommand cmd = CreateCommand(sql, values);
            cmd.ExecuteNonQuery();
        }

        public IList<Dictionary<string, object>> DataRead(string sql, Dictionary<string, object> values)
        {
            using SqlCommand cmd = CreateCommand(sql, values);
            using SqlDataReader reader = cmd.ExecuteReader();

            List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();
            while (reader.Read())
            {
                Dictionary<string, object> row = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader.GetName(i), reader[i]);
                }
                data.Add(row);
            }

            return data;
        }


        private SqlCommand CreateCommand(string sql,Dictionary<string,object> values)
        {
            SqlCommand cmd = new SqlCommand();

           if(values !=null && values.Count > 0)
            {
                foreach (var item in values)
                {
                    cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
            }

            cmd.Connection = _connection;
            cmd.CommandText = sql;
            if (_connection.State != System.Data.ConnectionState.Open) _connection.Open();
            return cmd;
        }
    }
}
