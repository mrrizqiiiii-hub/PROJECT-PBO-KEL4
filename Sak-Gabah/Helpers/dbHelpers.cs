using Npgsql;

namespace Sak_Gabah.Helpers
{

    public static class H_Config
    {
        public static string ConnString =
            "Host=localhost;" +
            "Port=5432;" +
            "Database=Sak_Gabah;" +
            "Username=postgres;" +
            "Password=SKUTSKUT123_321";
    }
    public class dbHelpers
    {
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(H_Config.ConnString);
        }
    }
}