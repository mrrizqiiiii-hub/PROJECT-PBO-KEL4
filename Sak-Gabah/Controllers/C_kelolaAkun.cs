using Npgsql;
using Sak_Gabah.Helpers;
using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sak_Gabah.Controllers
{
    internal class C_kelolaAkun
    {
        public List<M_user> ambilUser()
        {
            List<M_user> listUser = new List<M_user>();

            string query = 
                "SELECT id_user as id, username_user as username, nama_lengkap as nama, status_akun as statusAkun " + 
                "FROM \"user\" " +
                "WHERE role = 'Karyawan'";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_user item = new M_user();

                        item.id = Convert.ToInt32(reader["id"]);
                        item.username = reader["username"].ToString();
                        item.namalengkap = reader["nama"].ToString();
                        item.statusAkun = reader["statusAkun"].ToString();

                        listUser.Add(item);
                    }
                }
            }

            return listUser;
        }

        public List<M_user> ambilUser(string keyWord)
        {
            List<M_user> listUser = new List<M_user>();

            string query =
                "SELECT id_user as id, username_user as username, nama_lengkap as nama, status_akun as statusAkun " +
                "FROM \"user\" " +
                "WHERE role = 'Karyawan' AND (WHERE username_user ILIKE @keyword OR nama_lengkap ILIKE @keyword)";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", keyWord);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_user item = new M_user();

                        item.id = Convert.ToInt32(reader["id"]);
                        item.username = reader["username"].ToString();
                        item.namalengkap = reader["nama"].ToString();
                        item.statusAkun = reader["statusAkun"].ToString();

                        listUser.Add(item);
                    }
                }
            }

            return listUser;
        }

        public M_user ambilUser(int id)
        {
            M_user user = null;

            string query = @"

                SELECT email_user, username_user, nama_lengkap, no_telpon, alamat
                FROM ""user""
                WHERE id_user = @id";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new M_user();
                            user.email = reader["email_user"].ToString();
                            user.username = reader["username_user"].ToString();
                            user.namalengkap = reader["nama_lengkap"].ToString();
                            user.no_telpon = reader["no_telpon"].ToString();
                            user.alamat.alamatLengkap = reader["alamat"].ToString();
                        }
                    }
                }
            }

            return user;
        }



        public bool editAkunKaryawan(M_user dataUser)
        {
            bool isSukses = false;

            string query = @"
                UPDATE ""user""
                SET status_akun = @statusAkun 
                WHERE id_user = @idPengajuan ";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPengajuan", dataUser.id);
                    cmd.Parameters.AddWithValue("@statusAkun", dataUser.statusAkun);

                    int barisPengaruh = cmd.ExecuteNonQuery();

                    if (barisPengaruh > 0)
                    {
                        isSukses = true;
                    }

                }
            }

            return isSukses;
        }

        public bool tambahAkun(M_user dataBaru)
        {
            bool sukses = false;
            string query = @"
                INSERT INTO ""user""(email_user, username_user, password_user, nama_lengkap, no_telpon, role, status_akun) 
                VALUES (@emailUser, @username, 'default123', @namaLengkap, @noTelpon, 'Karyawan', 'Aktif')";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@emailUser", dataBaru.email);
                    cmd.Parameters.AddWithValue("@username", dataBaru.username);
                    cmd.Parameters.AddWithValue("@namaLengkap", dataBaru.namalengkap);
                    cmd.Parameters.AddWithValue("@noTelpon", dataBaru.no_telpon);

                    int barisTerganggu = cmd.ExecuteNonQuery();

                    if (barisTerganggu > 0) sukses = true;
                }
            }
            return sukses;
        }

        public bool cekDuplikat(M_user dataBaru)
        {
            bool adaDuplikat = false;
            string query = @"
                SELECT count(id_user)
                FROM ""user""
                WHERE email_user ILIKE @emailUser OR username_user ILIKE @username";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@emailUser", dataBaru.email);
                    cmd.Parameters.AddWithValue("@username", dataBaru.username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0) adaDuplikat = true;
                }
            }
            return adaDuplikat;
        }


        public bool resetPassword(string username)
        {
            bool adaDuplikat = false;
            string query = @"
                UPDATE ""user""
                SET password_user = 'default123'
                WHERE username_user ILIKE @username";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0) adaDuplikat = true;
                }
            }
            return adaDuplikat;
        }

        public bool gantiPassword(string username, string password)
        {
            bool adaDuplikat = false;
            string query = @"
                UPDATE ""user""
                SET password_user = @password
                WHERE username_user ILIKE @username";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0) adaDuplikat = true;
                }
            }
            return adaDuplikat;
        }

        public int tambahCustomer(string nama, string noTelpon, string alamat)
        {
            int idCustomerBaru = 0;
            string query = @"
                INSERT INTO customer (nama_customer, no_telpon, alamat) 
                VALUES (@nama_customer, @noTelpon, @alamat) 
                RETURNING id_customer";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_customer", nama);
                    cmd.Parameters.AddWithValue("@noTelpon", noTelpon);
                    cmd.Parameters.AddWithValue("@alamat", alamat);

                    idCustomerBaru = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return idCustomerBaru;
        }

        public bool updateAkun(string email, string username, string nama, string notelpon, string alamat, int id)
        {
            bool isSukses = false;

            string query = @"
                UPDATE ""user""
                SET email_user = @email, username_user = @username, nama_lengkap = @nama, no_telpon = @nomorTelpon, alamat = @alamat 
                WHERE id_user = @id ";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@nomorTelpon", notelpon);
                    cmd.Parameters.AddWithValue("@alamat", alamat);

                    int barisPengaruh = cmd.ExecuteNonQuery();

                    if (barisPengaruh > 0)
                    {
                        isSukses = true;
                    }

                }
            }

            return isSukses;
        }


        public bool cekPassword(string username, string password)
        {
            bool cekPassword = false;
            string query = @"
                SELECT count(id_user)
                FROM ""user""
                WHERE username_user ILIKE @username AND password_user ILIKE @password";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0) cekPassword = true;
                }
            }
            return cekPassword;
        }
    }
}
