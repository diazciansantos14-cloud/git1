using System;
using System.Data;
using System.Data.SqlClient;

namespace RAC_System
{
    public static class DatabaseHelper
    {
        // Universal local SQL Server Express connection string
        // The '.' connects to whichever computer runs the program!
        public static string ConnectionString = @"Server=.\SQLEXPRESS;Database=RAC_DB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        // Test connection helper
        public static bool TestConnection(out string errorMessage)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    errorMessage = null;
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}
