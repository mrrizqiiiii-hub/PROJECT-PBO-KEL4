using Npgsql;
using Sak_Gabah.Helpers;
using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sak_Gabah.Controllers
{
    public class C_komoditas
    {
        public List<M_detailKomoditas> ambilDataKomoditas()
        {
            List<M_detailKomoditas> listKomoditas = new List<M_detailKomoditas>();

            string query =
                "SELECT k.id_komoditas, k.nama_komoditas, count(CASE WHEN dk.status_aktif = '1' THEN id_detail_komoditas END) as jumlahSupplier, COALESCE(sum(dk.stok), 0) as totalStok " +
                "FROM komoditas k " +
                "LEFT OUTER JOIN detail_komoditas dk using (id_komoditas) " +
                "GROUP BY k.id_komoditas, k.nama_komoditas";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_detailKomoditas item = new M_detailKomoditas();
                        item.id = Convert.ToInt32(reader["id_komoditas"]);
                        item.komoditas.nama_komoditas = reader["nama_komoditas"].ToString();
                        item.komoditas.totalStok = Convert.ToInt32(reader["totalStok"]);
                        item.komoditas.jumlahSupplier = Convert.ToInt32(reader["jumlahSupplier"]);

                        listKomoditas.Add(item);
                    }
                }
            }
            return listKomoditas;
        }

        public bool tambahDataKomoditas(double maksimalStok, double maksimalSupplier, string namaKomoditas)
        {
            bool sukses = false;
            string query = "INSERT INTO komoditas (maksimal_stok, maksimal_supplier, nama_komoditas) VALUES (@maksimalStok, @maksimalSupplier, @namaKomoditas)";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maksimalStok", maksimalStok);
                    cmd.Parameters.AddWithValue("@maksimalSupplier", maksimalSupplier);
                    cmd.Parameters.AddWithValue("@namaKomoditas", namaKomoditas);

                    int barisTerganggu = cmd.ExecuteNonQuery();
                    if (barisTerganggu > 0) sukses = true;
                }
            }
            return sukses;
        }

        public bool cekDuplikat(string namaKomoditas)
        {
            bool adaDuplikat = false;
            string query =
                "SELECT k.id_komoditas, k.nama_komoditas, count(CASE WHEN dk.status_aktif = '1' THEN id_detail_komoditas END) as jumlahSupplier, COALESCE(sum(dk.stok), 0) as totalStok " +
                "FROM komoditas k " +
                "LEFT OUTER JOIN detail_komoditas dk using (id_komoditas) " +
                "WHERE k.nama_komoditas = @namaKomoditas " +
                "GROUP BY k.id_komoditas, k.nama_komoditas ";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@namaKomoditas", namaKomoditas);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0) adaDuplikat = true;
                }
            }
            return adaDuplikat;
        }

        public bool cekDuplikatDetail(string merk)
        {
            bool adaDuplikat = false;
            string query = @"
                SELECT COUNT(*) 
                FROM detail_komoditas 
                WHERE merk ILIKE @merk";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@merk", merk);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0) adaDuplikat = true;
                }
            }
            return adaDuplikat;
        }

        public List<M_detailKomoditas> ambilDataKomoditas(string kataKunci)
        {
            List<M_detailKomoditas> listKomoditas = new List<M_detailKomoditas>();

            string query =
                "SELECT k.id_komoditas, k.nama_komoditas, count(CASE WHEN dk.status_aktif = '1' THEN id_detail_komoditas END) as jumlahSupplier, COALESCE(sum(dk.stok), 0) as totalStok " +
                "FROM komoditas k " +
                "LEFT OUTER JOIN detail_komoditas dk using (id_komoditas) " +
                "WHERE k.nama_komoditas ILIKE @kataKunci " +
                "GROUP BY k.id_komoditas, k.nama_komoditas ";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kataKunci", "%" + kataKunci + "%");

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_detailKomoditas item = new M_detailKomoditas();
                        item.id = Convert.ToInt32(reader["id_komoditas"]);
                        item.komoditas.nama_komoditas = reader["nama_komoditas"].ToString();
                        item.komoditas.totalStok = Convert.ToInt32(reader["totalStok"]);
                        item.komoditas.jumlahSupplier = Convert.ToInt32(reader["jumlahSupplier"]);

                        listKomoditas.Add(item);
                    }
                }
            }
            return listKomoditas;
        }

        public List<M_detailKomoditas> ambilDetailKomoditas(int idTerpilih)
        {
            List<M_detailKomoditas> listKomoditas = new List<M_detailKomoditas>();
            string query =
                "SELECT k.id_komoditas as idKomoditas, dk.id_detail_komoditas as idDetailKomoditas, u.username_user as usernameUser, dk.merk as merk, dk.stok as stok, dk.harga as harga, dk.deskripsi as deskripsi " +
                "FROM komoditas k " +
                "JOIN detail_komoditas dk USING (id_komoditas) " +
                "JOIN \"user\" u USING (id_user) " +
                "WHERE k.id_komoditas = @idTerpilih;";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idTerpilih", idTerpilih);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_detailKomoditas item = new M_detailKomoditas();
                        item.id = Convert.ToInt32(reader["idDetailKomoditas"]);
                        item.komoditas.id = Convert.ToInt32(reader["idKomoditas"]); 
                        item.user.username = reader["usernameUser"].ToString();
                        item.merk = reader["merk"].ToString();
                        item.stok = Convert.ToInt32(reader["stok"]);
                        item.harga = Convert.ToInt32(reader["harga"]);
                        item.deskripsi = reader["deskripsi"].ToString();

                        listKomoditas.Add(item);
                    }
                }
            }
            return listKomoditas;

        }

        public List<M_komoditas> ambilKomoditas()
        {
            List<M_komoditas> listKomoditas = new List<M_komoditas>();

            string query =
                "SELECT k.id_komoditas, k.nama_komoditas " +
                "FROM komoditas k " +
                "ORDER BY nama_komoditas ASC";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_komoditas item = new M_komoditas();
                        item.id = Convert.ToInt32(reader["id_komoditas"]);
                        item.nama_komoditas = reader["nama_komoditas"].ToString();

                        listKomoditas.Add(item);
                    }
                }
            }
            return listKomoditas;
        }

        public List<M_detailKomoditas> ambilSemuaMerk()
        {
            List<M_detailKomoditas> listMerk = new List<M_detailKomoditas>();

            string query = "SELECT id_detail_komoditas, merk FROM detail_komoditas ORDER BY merk ASC;";

            using (var conn = dbHelpers.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                M_detailKomoditas dk = new M_detailKomoditas();

                                dk.id = Convert.ToInt32(reader["id_detail_komoditas"]);
                                dk.merk = reader["merk"].ToString();

                                listMerk.Add(dk);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal mengambil data merk untuk setoran: " + ex.Message);
                }
            }

            return listMerk;
        }


        public List<M_detailKomoditas> ambilSemuaMerk(int id)
        {
            List<M_detailKomoditas> listMerk = new List<M_detailKomoditas>();

            string query = "SELECT id_detail_komoditas, merk FROM detail_komoditas WHERE id_user = @id ORDER BY merk ASC;";

            using (var conn = dbHelpers.GetConnection())
            {
                try
                {


                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@id", id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                M_detailKomoditas dk = new M_detailKomoditas();

                                dk.id = Convert.ToInt32(reader["id_detail_komoditas"]);
                                dk.merk = reader["merk"].ToString();

                                listMerk.Add(dk);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal mengambil data merk untuk setoran: " + ex.Message);
                }
            }

            return listMerk;
        }


    }
}
