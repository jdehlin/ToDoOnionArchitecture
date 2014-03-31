using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using StackExchange.Profiling;
using StackExchange.Profiling.Data;

namespace ToDoApp.Data
{
    public enum Databases
    {
        Default   
    }

    /// <summary>
    /// Contains database access utility methods.
    /// </summary>
    public class DbUtilities
    {
        private static readonly string SolePortalConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        /// <summary>
        /// Gets the appropriate connection string based on the provided database name.
        /// </summary>
        /// <param name="dbName">The database for which to fetch connection string.</param>
        /// <returns></returns>
        public static string ConnectionString(Databases dbName = Databases.Default)
        {   
            return SolePortalConnectionString;
        }

        /// <summary>
        /// Generates a profiled database connection using the provided connection string.
        /// </summary>
        /// <param name="connectionString">Database connection string.</param>
        /// <returns></returns>
        public static DbConnection GetProfiledConnection(string connectionString)
        {
            var sqlConnection = new SqlConnection(connectionString);
            // Wrap the connection with a profiling connection that tracks timings.  
            return new ProfiledDbConnection(sqlConnection, MiniProfiler.Current);
        } 
    }
}