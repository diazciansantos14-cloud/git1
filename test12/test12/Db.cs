using System.Configuration;

namespace test12
{
    public static class Db
    {
        public static string ConnString =
            ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;
    }
}
