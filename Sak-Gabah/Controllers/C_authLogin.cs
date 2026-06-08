using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using Sak_Gabah.Models;
using Sak_Gabah.Helpers;

namespace Sak_Gabah.Controllers
{
    public class C_authLogin 
    {
        public M_user AuthLogin(string username, string password)
        {
            M_user userResult = null;
            string query = "SELECT id_user, nama_lengkap, username_user, password_user, role, status_akun FROM \"user\" WHERE username_user = @user AND password_user = @pass";

            using (var conn = dbHelpers.GetConnection())
            {   
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string statusDariDB = reader["status_akun"].ToString();

                            if (statusDariDB != "Aktif")
                            {
                                userResult = new M_user();
                                userResult.statusAkun = statusDariDB;
                            }
                            else
                            {
                                userResult = new M_user();
                                userResult.id = Convert.ToInt32(reader["id_user"]);
                                userResult.namaLengkap = reader["nama_lengkap"].ToString();
                                userResult.role = reader["role"].ToString();
                                userResult.statusAkun = "Aktif";
                            }
                        }
                    }
                }
            }
            return userResult;
        }

    }
}
