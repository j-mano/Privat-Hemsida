using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Backend_Processing.DataAcess
{
    internal static class SqlDataAcess
    {
        public static string GetConnectionString(string connectionName = "DataBaseJoachimMainWebbsite")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> asyncLoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                // Getting connectionString and trying to conect to server as an async task. Exeptions is expteted to be handled in high lvl function that have acess to user interface.

                List<T> returnList = new List<T>();
                Action<object> action = (object obj) =>
                {
                    try
                    {
                        returnList = cnn.Query<T>(sql).ToList();
                    }
                    catch
                    {
                        throw;
                    }
                    finally
                    {
                        System.Console.WriteLine("Error connecting to database. Closing connection. SqlDataAcess");
                    }
                };

                Task task = new Task(action, "alpha");

                task.Start();
                task.Wait();

                return returnList;
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            // Getting connectionString and trying to conect to server as an async task. Exeptions is expteted to be handled in high lvl function that have acess to user interface.
                using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
                {
                    int i = 0;

                    Action<object> action = (object obj) =>
                    {
                        try
                        {
                            i = cnn.Execute(sql, data);
                        }
                        catch
                        {
                            throw;
                        }
                        finally
                        {
                            System.Console.WriteLine("Error connecting to database. Closing connection. SqlDataAcess");
                        }
                    };

                    Task task = new Task(action, "alpha");
                    task.Start();
                    task.Wait();

                    return i;
                }
        }
    }
}
