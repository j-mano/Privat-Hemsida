using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Backend_Processing.DataAcess
{
    public static class SqlDataAcess
    {
        public static string GetConnectionString(string connectionName = "DataBaseJoachimMainWebbsite")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            // Trying to execute the sql command and return an emty list if not able to connect to server.
            try
            {
                using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
                {
                    return cnn.Query<T>(sql).ToList();
                }
            }
            catch
            {
                List<T> emtyList = new List<T>();

                return emtyList;
            }
            finally
            {
                System.Console.WriteLine("Error connecting to database. Closing connection. SqlDataAcess");
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            // Trying to execute the sql command and return 0/emty if not.
            try
            {
                using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
                {
                    return cnn.Execute(sql, data);
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
