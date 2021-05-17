using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataProvider
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;

        string connectStr =
            "Data Source=SALTER\\SALTER;Initial Catalog=QLKTX;Integrated Security=True";

        public DataProvider()
        {
            conn = new SqlConnection(connectStr);
            cmd = conn.CreateCommand();
        }

        // Select query
        //Kieu query tra DataTable
        public DataTable ExecuteQueryDataTable(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }

        // Kieu query tra ve mot doi tuong/mot gia tri
        public object ExecuteScalar(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            object data = null;

            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            //data = cmd.ExecuteScalar();
            try
            {
                data = cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                
            }
            finally
            {
                conn.Close();
            }

            return data;
        }

        public string ExecuteQueryXML(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            return ds.GetXml();
        }

        // Action query
        // Kieu query khong lay gia tri tra ve
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error,
            params SqlParameter[] param)
        {
            bool f = false;
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return f;
        }
    }
}
