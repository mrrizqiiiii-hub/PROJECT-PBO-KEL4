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
                                userResult.namalengkap = reader["nama_lengkap"].ToString();
                                userResult.username = reader["username_user"].ToString();
                                userResult.role = reader["role"].ToString();
                                userResult.statusAkun = "Aktif";
                            }
                        }
                    }
                }
            }
            return userResult;
        }

        public bool cekUsername(string username)
        {
            bool exist = false;
            string query = "SELECT COUNT(*) FROM \"user\" WHERE username_user = @username;";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username.TrimStart().TrimEnd());
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0) exist = true;
                }
            }
            return exist;
        }

        public bool RegistrasiUserBaru(M_user userBaru)
        {
            bool isSukses = false;
            string query = @"
                INSERT INTO ""user"" (email_user, username_user, password_user, role, status_akun) 
                VALUES (@email, @username, @password, 'Supplier', 'Aktif');";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", userBaru.email.TrimStart().TrimEnd());
                    cmd.Parameters.AddWithValue("@username", userBaru.username.Trim());
                    cmd.Parameters.AddWithValue("@password", userBaru.password.TrimStart().TrimEnd());

                    int barisTerpengaruh = cmd.ExecuteNonQuery();
                    if (barisTerpengaruh > 0) isSukses = true;
                }
            }
            return isSukses;
        }

        public bool cekEmail(string email)
        {
            bool exist = false;
            string query = "SELECT COUNT(*) FROM \"user\" WHERE email_user = @email;";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email.Trim().ToLower());
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0) exist = true;
                }
            }
            return exist;
        }

    }
}
