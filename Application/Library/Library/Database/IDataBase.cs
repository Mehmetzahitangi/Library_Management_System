using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Database
{
    class IDataBase
    {
       
        public static string connectionString = "Data Source=MEHMET\\SQLEXPRESS; Initial Catalog=LibraryMS ;Integrated Security=SSPI";
        public static DataTable DataToDataTable(string query, List<SqlParameter> parameters)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (SqlException ex)
            {
                throw ex;

            }
        }
        public static DataTable DataToDataTable(string query, SqlParameter parameter) {
            return DataToDataTable(query, new List<SqlParameter>() { parameter });
        }
        public static DataTable DataToDataTable(string query)
        {
            return DataToDataTable(query, new List<SqlParameter>() { });
        }
        public static void executeNonQuery(string query, List<SqlParameter> parameters)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw e;

            }
            finally
            {
                con.Close();
            }
        }
        public static void executeNonQuery(string query, SqlParameter parameters)
        {
            executeNonQuery( query, new List<SqlParameter>() { parameters });

        }
        public static object executeScalar(string query, List<SqlParameter> parameters)
        {
            object value = null;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
               value= cmd.ExecuteScalar();

            }
            catch (SqlException e)
            {
                throw e;

            }
            finally
            {
                con.Close();
            }
            return value;
        }



    }

}
