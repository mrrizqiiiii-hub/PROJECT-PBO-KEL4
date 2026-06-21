using Npgsql;
using Sak_Gabah.Models;
using Sak_Gabah.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Repository
{
    internal class R_komoditas : R_baseRepo, IRepositoryBaca<M_detailKomoditas>, IRepositoryTambah<M_komoditas>
    {
        public List<M_detailKomoditas> AmbilData()
        {
            List<M_detailKomoditas> listKomoditas = new List<M_detailKomoditas>();

            string query =
                "SELECT k.id_komoditas, k.nama_komoditas, count(CASE WHEN dk.status_aktif = '1' THEN id_detail_komoditas END) as jumlahSupplier, COALESCE(sum(dk.stok), 0) as totalStok " +
                "FROM komoditas k " +
                "LEFT OUTER JOIN detail_komoditas dk using (id_komoditas) " +
                "GROUP BY k.id_komoditas, k.nama_komoditas";

            using (var conn = AmbilKoneksi())
            {
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

        public bool TambahData(M_komoditas dataBaru)
        {
            bool sukses = false;
            string query = "INSERT INTO komoditas (maksimal_stok, maksimal_supplier, nama_komoditas) VALUES (@maksimalStok, @maksimalSupplier, @namaKomoditas)";

            using (var conn = AmbilKoneksi())
            {

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maksimalStok", dataBaru.maksimal_stok);
                    cmd.Parameters.AddWithValue("@maksimalSupplier", dataBaru.maksimal_supplier);
                    cmd.Parameters.AddWithValue("@namaKomoditas", dataBaru.nama_komoditas);

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

            using (var conn = AmbilKoneksi())
            {

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

            using (var conn = AmbilKoneksi())
            {

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@merk", merk);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0) adaDuplikat = true;
                }
            }
            return adaDuplikat;
        }

        public List<M_detailKomoditas> AmbilData(string kataKunci)
        {
            List<M_detailKomoditas> listKomoditas = new List<M_detailKomoditas>();

            string query =
                "SELECT k.id_komoditas, k.nama_komoditas, count(CASE WHEN dk.status_aktif = '1' THEN id_detail_komoditas END) as jumlahSupplier, COALESCE(sum(dk.stok), 0) as totalStok " +
                "FROM komoditas k " +
                "LEFT OUTER JOIN detail_komoditas dk using (id_komoditas) " +
                "WHERE k.nama_komoditas ILIKE @kataKunci " +
                "GROUP BY k.id_komoditas, k.nama_komoditas ";

            using (var conn = AmbilKoneksi())
            {
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

        public List<M_detailKomoditas> AmbilData(int idTerpilih)
        {
            List<M_detailKomoditas> listKomoditas = new List<M_detailKomoditas>();
            string query =
                "SELECT k.id_komoditas as idKomoditas, dk.id_detail_komoditas as idDetailKomoditas, u.username_user as usernameUser, dk.merk as merk, dk.stok as stok, dk.harga as harga, dk.deskripsi as deskripsi " +
                "FROM komoditas k " +
                "JOIN detail_komoditas dk USING (id_komoditas) " +
                "JOIN \"user\" u USING (id_user) " +
                "WHERE k.id_komoditas = @idTerpilih;";

            using (var conn = AmbilKoneksi())
            {
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

        public List<M_detailKomoditas> ambilDetailKomoditasTransaksi(int idTerpilih)
        {
            List<M_detailKomoditas> listKomoditas = new List<M_detailKomoditas>();
            string query =
                "SELECT k.id_komoditas as idKomoditas, dk.id_detail_komoditas as idDetailKomoditas, u.username_user as usernameUser, dk.merk as merk, dk.stok as stok, dk.harga as harga, dk.deskripsi as deskripsi " +
                "FROM komoditas k " +
                "JOIN detail_komoditas dk USING (id_komoditas) " +
                "JOIN \"user\" u USING (id_user) " +
                "WHERE k.id_komoditas = @idTerpilih AND stok > 0 AND dk.status_aktif = '1'";

            using (var conn = AmbilKoneksi())
            {
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

            using (var conn = AmbilKoneksi())
            {
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

            using (var conn = AmbilKoneksi())
            {
                try
                {
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

            using (var conn = AmbilKoneksi())
            {
                try
                {
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

        public bool nonAktifkanKomoditas(int idTerpilih, string status)
        {
            bool sukses = false;
            string query = @"
                UPDATE komoditas
                SET status_aktif = @status
                WHERE id_komoditas = @id";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idTerpilih);
                    cmd.Parameters.AddWithValue("@status", status);


                    int barisTerganggu = cmd.ExecuteNonQuery();
                    if (barisTerganggu > 0) sukses = true;
                }
            }
            return sukses;
        }

    }
}

