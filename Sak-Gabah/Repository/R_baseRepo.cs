using Npgsql;
using Sak_Gabah.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Repository
{
    public abstract class R_baseRepo
    {
        protected NpgsqlConnection AmbilKoneksi()
        {
            var conn = dbHelpers.GetConnection();
            conn.Open();
            return conn;
        }
    }
}
