using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Create_items
{
    public class DBManager
    {
        public static string OraConnString()
        {

            return String.Format("Server=.; Database=firstTestProject;User ID=sa;Password=123;Pooling=False;Trusted_Connection=False;");

        }
        public static DataTable ExecuteQuery(string ConnectionString, string query, string tableName)
        {
            using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter myAdapter = new SqlDataAdapter(query, myConnection))
                {
                    DataSet ds = new DataSet();
                    myAdapter.Fill(ds, tableName);
                    ds.Tables[0].TableName = tableName;
                    return ds.Tables[0];
                }
            }
        }
    }
}