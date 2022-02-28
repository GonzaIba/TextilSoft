using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Tools
{
    public class SqlHelperSL
    {
        static string connString;
        private readonly static SqlHelperSL _instance = new SqlHelperSL();

        public static SqlHelperSL Current
        {
            get
            {
                return _instance;
            }
        }
        private SqlHelperSL()
        {
            connString = ConfigurationManager.ConnectionStrings["upfDB"].ConnectionString;
        }
        public static SqlDataReader ExecuteReader(String commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connString);

            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
        }
        public static Int32 ExecuteNonQuery(String commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    // There're three command types: StoredProcedure, Text, TableDirect. The TableDirect 
                    // type is only for OLE DB.  
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static bool ExecuteNonQueryReturn(String commandText, CommandType commandType, string parametro, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    var resultado = new SqlParameter(parametro, false);
                    resultado.Direction = ParameterDirection.InputOutput;
                    cmd.Parameters.Add(resultado);
                    cmd.ExecuteNonQuery();
                    return (bool)resultado.Value;
                }
            }
        }


        public static Object ExecuteScalar(String commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
