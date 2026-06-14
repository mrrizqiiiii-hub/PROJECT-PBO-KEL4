using Npgsql;
using Sak_Gabah.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Controllers
{
    public abstract class C_baseController
    {
        protected NpgsqlConnection AmbilKoneksi()
        {
            var conn = dbHelpers.GetConnection();
            conn.Open();
            return conn;
        }
    }
}
