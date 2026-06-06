using Npgsql;

namespace pbo_seharijadi
{
    public class Database
    {
        private readonly string connString;

        public Database(string connString)
        {
            this.connString = connString;
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }

    public static class Config
    {
        public static string ConnString =
            "Host=localhost;" +
            "Port=5432;" +
            "Database=db_pbo sehari jadi;" +
            "Username=postgres;" +
            "Password=@Dw170796";
    }
}