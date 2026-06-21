using Npgsql;
using Sak_Gabah.Models;
using Sak_Gabah.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Repository
{
    internal class R_setoran : R_baseRepo, IRepositoryBaca<M_setorSupply>, IRepositoryTambah<M_setorSupply>, IRepositoryHapus
    {
        public List<M_setorSupply> AmbilData()
        {
            List<M_setorSupply> listData = new List<M_setorSupply>();

            string query =
                "SELECT s.id_setoran as idSetoran, dk.merk as merk, s.tanggal_pengajuan as tanggalSetoran, s.jumlah_setoran as jumlahSetoran, s.status_setoran as statusSetoran " +
                "FROM setoran s " +
                "JOIN detail_komoditas dk USING (id_detail_komoditas) " +
                "WHERE s.status_setoran = 'Selesai' ";


            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_setorSupply item = new M_setorSupply();
                        item.id = Convert.ToInt32(reader["idSetoran"]);
                        item.detailKomoditas.merk = reader["merk"].ToString();
                        item.tanggal = (DateOnly)reader["tanggalSetoran"];
                        item.jumlah_setoran = Convert.ToInt32(reader["jumlahSetoran"]);
                        item.status_setoran = Convert.ToString(reader["statusSetoran"]);

                        listData.Add(item);
                    }
                }
            }
            return listData;
        }

        public List<M_setorSupply> AmbilData(string namaKomoditas)
        {
            List<M_setorSupply> listHasil = new List<M_setorSupply>();

            string query = @"
                SELECT s.id_setoran as idSetoran, dk.merk as merk, s.tanggal_pengajuan as tanggalSetoran, s.jumlah_setoran as jumlahSetoran, s.status_setoran as statusSetoran 
                FROM setoran s 
                JOIN detail_komoditas dk USING (id_detail_komoditas)
                WHERE LOWER(dk.merk) LIKE LOWER(@keyword) ";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + namaKomoditas + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            M_setorSupply item = new M_setorSupply();
                            item.id = Convert.ToInt32(reader["idSEtoran"]);
                            item.detailKomoditas.merk = reader["merk"].ToString();
                            item.tanggal = (DateOnly)reader["tanggalSetoran"];
                            item.jumlah_setoran = Convert.ToInt32(reader["jumlahSetoran"]);
                            item.status_setoran = Convert.ToString(reader["statusSetoran"]);

                            listHasil.Add(item);
                        }
                    }
                }
            }
            return listHasil;
        }

        public List<M_setorSupply> AmbilData(DateOnly tanggalAwal, DateOnly tanggalAkhir)
        {
            List<M_setorSupply> listHasil = new List<M_setorSupply>();

            string query = @"
                SELECT s.id_setoran as idSetoran, dk.merk as merk, s.tanggal_pengajuan as tanggalSetoran, s.jumlah_setoran as jumlahSetoran, s.status_setoran as statusSetoran 
                FROM setoran s 
                JOIN detail_komoditas dk USING (id_detail_komoditas) 
                WHERE s.tanggal_pengajuan BETWEEN @tanggalAwal AND @tanggalAkhir ";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tanggalAwal", tanggalAwal);
                    cmd.Parameters.AddWithValue("@tanggalAkhir", tanggalAkhir);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            M_setorSupply item = new M_setorSupply();
                            item.id = Convert.ToInt32(reader["idSetoran"]);
                            item.jumlah_setoran = Convert.ToInt32(reader["jumlahSetoran"]);
                            item.tanggal = (DateOnly)reader["tanggalSetoran"];
                            item.detailKomoditas.merk = reader["merk"].ToString();
                            item.status_setoran = reader["statusSetoran"].ToString();

                            listHasil.Add(item);
                        }
                    }
                }
            }
            return listHasil;
        }

        public List<M_setorSupply> ambilDataVerifikasi()
        {
            List<M_setorSupply> listData = new List<M_setorSupply>();

            string query =
                "SELECT " +
                "s.id_setoran as idSetoran, " +
                "dk.id_detail_komoditas as idDetailKomoditas, " +
                "d.nama_komoditas as namaKomoditas, " +
                "dk.merk as merk, " +
                "s.tanggal_pengajuan as tanggalSetoran, " +
                "s.jumlah_setoran as jumlahSetoran, " +
                "s.status_setoran as statusSetoran " +
                "FROM setoran s " +
                "JOIN detail_komoditas dk USING (id_detail_komoditas) " +
                "JOIN komoditas d USING (id_komoditas) " +
                "WHERE s.status_setoran = 'Proses' ";


            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_setorSupply item = new M_setorSupply();
                        item.id = Convert.ToInt32(reader["idSetoran"]);
                        item.detailKomoditas.id = Convert.ToInt32(reader["idDetailKomoditas"]);
                        item.detailKomoditas.komoditas.nama_komoditas = reader["namaKomoditas"].ToString();
                        item.detailKomoditas.merk = reader["merk"].ToString();
                        item.tanggal = (DateOnly)reader["tanggalSetoran"];
                        item.jumlah_setoran = Convert.ToInt32(reader["jumlahSetoran"]);
                        item.status_setoran = Convert.ToString(reader["statusSetoran"]);

                        listData.Add(item);
                    }
                }
            }
            return listData;
        }

        public List<M_setorSupply> AmbilData(int idUserAktif)
        {
            List<M_setorSupply> listData = new List<M_setorSupply>();

            string query = @"
                SELECT 
                	s.status_setoran as status,
                	s.id_setoran AS idSetoran, 
                	s.jumlah_setoran AS jumlahSetoran,
                	dk.id_detail_komoditas AS idDetailKomoditas, 
                	dk.merk AS merk
                FROM setoran s
                JOIN detail_komoditas dk USING (id_detail_komoditas)
                WHERE s.status_setoran = 'Proses' AND dk.id_user = @id";

            using (var conn = AmbilKoneksi())
            {
                try
                {

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idUserAktif);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                M_setorSupply item = new M_setorSupply();

                                item.id = Convert.ToInt32(reader["idSetoran"]);
                                item.detailKomoditas.id = Convert.ToInt32(reader["idDetailKomoditas"]);
                                item.detailKomoditas.merk = reader["merk"].ToString();
                                item.jumlah_setoran = Convert.ToInt32(reader["jumlahSetoran"]);
                                item.status_setoran = reader["status"].ToString();


                                listData.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal memuat data verifikasi: " + ex.Message);
                }
            }
            return listData;
        }

        public List<M_setorSupply> ambilDataHistoriPerUser(int idUserAktif)
        {
            List<M_setorSupply> listData = new List<M_setorSupply>();

            string query = @"
                SELECT 
                	s.status_setoran as status,
                	s.id_setoran AS idSetoran, 
                	s.jumlah_setoran AS jumlahSetoran,
                	dk.id_detail_komoditas AS idDetailKomoditas, 
                	dk.merk AS merk,
                	s.tanggal_pengajuan AS tanggalPengajuan,
                	s.tanggal_selesai as tanggalSelesai,
                	k.nama_komoditas as namaKomoditas
                FROM setoran s
                JOIN detail_komoditas dk USING (id_detail_komoditas)
                JOIN komoditas k USING (id_komoditas)
                WHERE s.status_setoran = 'Selesai' AND dk.id_user = @id";

            using (var conn = AmbilKoneksi())
            {
                try
                {

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idUserAktif);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                M_setorSupply item = new M_setorSupply();

                                item.id = Convert.ToInt32(reader["idSetoran"]);
                                item.detailKomoditas.id = Convert.ToInt32(reader["idDetailKomoditas"]);
                                item.detailKomoditas.merk = reader["merk"].ToString();
                                item.jumlah_setoran = Convert.ToInt32(reader["jumlahSetoran"]);
                                item.status_setoran = reader["status"].ToString();
                                item.tanggalTambahan = (DateOnly)reader["tanggalSelesai"];
                                item.tanggal = (DateOnly)reader["tanggalPengajuan"];
                                item.detailKomoditas.komoditas.nama_komoditas = reader["namaKomoditas"].ToString();


                                listData.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal memuat data verifikasi: " + ex.Message);
                }
            }
            return listData;
        }

        public List<M_setorSupply> ambilDataHistoriPerUser(int idUserAktif, string namaKomoditas)
        {
            List<M_setorSupply> listData = new List<M_setorSupply>();

            string query = @"
                SELECT 
                	s.status_setoran as status,
                	s.id_setoran AS idSetoran, 
                	s.jumlah_setoran AS jumlahSetoran,
                	dk.id_detail_komoditas AS idDetailKomoditas, 
                	dk.merk AS merk,
                	s.tanggal_pengajuan AS tanggalPengajuan,
                	s.tanggal_selesai as tanggalSelesai,
                	k.nama_komoditas as namaKomoditas
                FROM setoran s
                JOIN detail_komoditas dk USING (id_detail_komoditas)
                JOIN komoditas k USING (id_komoditas)
                WHERE s.status_setoran = 'Selesai' AND dk.id_user = @id AND LOWER(k.nama_komoditas) LIKE LOWER(@namaKomoditas)";

            using (var conn = AmbilKoneksi())
            {
                try
                {
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idUserAktif);
                        cmd.Parameters.AddWithValue("@namaKomoditas", namaKomoditas);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                M_setorSupply item = new M_setorSupply();

                                item.id = Convert.ToInt32(reader["idSetoran"]);
                                item.detailKomoditas.id = Convert.ToInt32(reader["idDetailKomoditas"]);
                                item.detailKomoditas.merk = reader["merk"].ToString();
                                item.jumlah_setoran = Convert.ToInt32(reader["jumlahSetoran"]);
                                item.status_setoran = reader["status"].ToString();
                                item.tanggalTambahan = (DateOnly)reader["tanggalSelesai"];
                                item.tanggal = (DateOnly)reader["tanggalPengajuan"];
                                item.detailKomoditas.komoditas.nama_komoditas = reader["namaKomoditas"].ToString();


                                listData.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal memuat data verifikasi: " + ex.Message);
                }
            }
            return listData;
        }

        public List<M_setorSupply> ambilDataHistoriPerUser(int idUserAktif, DateOnly tanggalAwal, DateOnly tanggalAkhir)
        {
            List<M_setorSupply> listData = new List<M_setorSupply>();

            string query = @"
                SELECT 
                	s.status_setoran as status,
                	s.id_setoran AS idSetoran, 
                	s.jumlah_setoran AS jumlahSetoran,
                	dk.id_detail_komoditas AS idDetailKomoditas, 
                	dk.merk AS merk,
                	s.tanggal_pengajuan AS tanggalPengajuan,
                	s.tanggal_selesai as tanggalSelesai,
                	k.nama_komoditas as namaKomoditas
                FROM setoran s
                JOIN detail_komoditas dk USING (id_detail_komoditas)
                JOIN komoditas k USING (id_komoditas)
                WHERE s.status_setoran = 'Selesai' AND dk.id_user = @id AND s.tanggal_pengajuan BETWEEN @tanggalAwal AND @tanggalAkhir";

            using (var conn = AmbilKoneksi())
            {
                try
                {

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idUserAktif);
                        cmd.Parameters.AddWithValue("@tanggalAwal", tanggalAwal);
                        cmd.Parameters.AddWithValue("@tanggalAkhir", tanggalAkhir);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                M_setorSupply item = new M_setorSupply();

                                item.id = Convert.ToInt32(reader["idSetoran"]);
                                item.detailKomoditas.id = Convert.ToInt32(reader["idDetailKomoditas"]);
                                item.detailKomoditas.merk = reader["merk"].ToString();
                                item.jumlah_setoran = Convert.ToInt32(reader["jumlahSetoran"]);
                                item.status_setoran = reader["status"].ToString();
                                item.tanggalTambahan = (DateOnly)reader["tanggalSelesai"];
                                item.tanggal = (DateOnly)reader["tanggalPengajuan"];
                                item.detailKomoditas.komoditas.nama_komoditas = reader["namaKomoditas"].ToString();


                                listData.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal memuat data verifikasi: " + ex.Message);
                }
            }
            return listData;
        }



        public List<M_setorSupply> ambilDataVerifikasi(DateOnly tanggalAwal, DateOnly tanggalAkhir)
        {
            List<M_setorSupply> listData = new List<M_setorSupply>();

            string query =
                "SELECT s.id_setoran as idSetoran, dk.id_detail_komoditas as idDetailKomoditas, d.nama_komoditas as namaKomoditas, dk.merk as merk, s.tanggal_pengajuan as tanggalSetoran, s.jumlah_setoran as jumlahSetoran, s.status_setoran as statusSetoran " +
                "FROM setoran s " +
                "JOIN detail_komoditas dk USING (id_detail_komoditas) " +
                "JOIN komoditas d USING (id_komoditas) " +
                "WHERE s.status_setoran = 'Proses' AND s.tanggal_pengajuan BETWEEN @tanggalAwal AND @tanggalAkhir ";


            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@tanggalAwal", tanggalAwal);
                    cmd.Parameters.AddWithValue("@tanggalAkhir", tanggalAkhir);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_setorSupply item = new M_setorSupply();
                        item.id = Convert.ToInt32(reader["idSetoran"]);
                        item.detailKomoditas.id = Convert.ToInt32(reader["idDetailKomoditas"]);
                        item.detailKomoditas.komoditas.nama_komoditas = reader["namaKomoditas"].ToString();
                        item.detailKomoditas.merk = reader["merk"].ToString();
                        item.tanggal = (DateOnly)reader["tanggalSetoran"];
                        item.jumlah_setoran = Convert.ToInt32(reader["jumlahSetoran"]);
                        item.status_setoran = Convert.ToString(reader["statusSetoran"]);

                        listData.Add(item);
                    }
                }
            }
            return listData;
        }

        public List<M_setorSupply> ambilDataVerifikasi(string namaKomoditas)
        {
            List<M_setorSupply> listData = new List<M_setorSupply>();

            string query =
                "SELECT s.id_setoran as idSetoran, dk.id_detail_komoditas as idDetailKomoditas, d.nama_komoditas as namaKomoditas, dk.merk as merk, s.tanggal_pengajuan as tanggalSetoran, s.jumlah_setoran as jumlahSetoran, s.status_setoran as statusSetoran " +
                "FROM setoran s " +
                "JOIN detail_komoditas dk USING (id_detail_komoditas) " +
                "JOIN komoditas d USING (id_komoditas) " +
                "WHERE s.status_setoran = 'Proses' AND d.nama_komoditas ILIKE @keyword ";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@keyword", "%" + namaKomoditas + "%");

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_setorSupply item = new M_setorSupply();
                        item.id = Convert.ToInt32(reader["idSetoran"]);
                        item.detailKomoditas.id = Convert.ToInt32(reader["idDetailKomoditas"]);
                        item.detailKomoditas.komoditas.nama_komoditas = reader["namaKomoditas"].ToString();
                        item.detailKomoditas.merk = reader["merk"].ToString();
                        item.tanggal = (DateOnly)reader["tanggalSetoran"];
                        item.jumlah_setoran = Convert.ToInt32(reader["jumlahSetoran"]);
                        item.status_setoran = Convert.ToString(reader["statusSetoran"]);

                        listData.Add(item);
                    }
                }
            }
            return listData;
        }

        public bool terimaPengajuan(M_setorSupply dataSetor)
        {
            bool isSukses = false;

            string queryStatus = @"
                UPDATE setoran
                SET status_setoran = 'Selesai', tanggal_selesai = CURRENT_DATE
                WHERE id_setoran = @idPengajuan ";

            string queryUpdateStok = @"
                UPDATE detail_komoditas 
                SET stok = stok + @stokBaru 
                WHERE id_detail_komoditas = @idDetailKomoditas;";

            using (var conn = AmbilKoneksi())
            {

                using (var transaksi = conn.BeginTransaction())
                {
                    try
                    {
                        using (var cmdStatus = new NpgsqlCommand(queryStatus, conn))
                        {
                            cmdStatus.Transaction = transaksi;
                            cmdStatus.Parameters.AddWithValue("@idPengajuan", dataSetor.id);
                            cmdStatus.ExecuteNonQuery();
                        }

                        using (var cmdStok = new NpgsqlCommand(queryUpdateStok, conn))
                        {
                            cmdStok.Transaction = transaksi;
                            cmdStok.Parameters.AddWithValue("@idDetailKomoditas", dataSetor.detailKomoditas.id);
                            cmdStok.Parameters.AddWithValue("@stokBaru", dataSetor.jumlah_setoran);
                            cmdStok.ExecuteNonQuery();
                        }

                        transaksi.Commit();
                        isSukses = true;
                    }
                    catch (Exception ex)
                    {
                        transaksi.Rollback();
                        throw new Exception("Gagal memproses penyelesaian setoran: " + ex.Message);
                    }
                }
            }

            return isSukses;
        }


        public bool tolakPengajuan(M_setorSupply dataSetor)
        {
            bool isSukses = false;

            string query = @"
                UPDATE setoran 
                SET status_setoran = 'Dibatalkan' 
                WHERE id_setoran = @idPengajuan ";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPengajuan", dataSetor.id);
                    int barisPengaruh = cmd.ExecuteNonQuery();

                    if (barisPengaruh > 0)
                    {
                        isSukses = true;
                    }

                }
            }
            return isSukses;
        }

        public bool TambahData(M_setorSupply dataBaru)
        {
            bool isSukses = false;

            string query = @"
                INSERT INTO setoran (id_detail_komoditas, jumlah_setoran, tanggal_pengajuan, status_setoran) 
                VALUES (@idDetailKomoditas, @jumlahSetoran, CURRENT_DATE, 'Proses');";

            using (var conn = AmbilKoneksi())
            {
                try
                {
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idDetailKomoditas", dataBaru.detailKomoditas.id);
                        cmd.Parameters.AddWithValue("@jumlahSetoran", dataBaru.jumlah_setoran);

                        int barisTerpengaruh = cmd.ExecuteNonQuery();
                        if (barisTerpengaruh > 0)
                        {
                            isSukses = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal menyimpan pengajuan setoran: " + ex.Message);
                }
            }

            return isSukses;
        }

        public bool updateSetoran(M_setorSupply dataBaru)
        {
            bool isSukses = false;

            string query = @"
                UPDATE setoran 
                SET 
                    id_detail_komoditas = @idDetail,
                    jumlah_setoran = @jumlahSetor
                WHERE id_setoran = @idSetoran;";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@idSetoran", dataBaru.id);
                    cmd.Parameters.AddWithValue("@idDetail", dataBaru.detailKomoditas.id);
                    cmd.Parameters.AddWithValue("@jumlahSetor", dataBaru.jumlah_setoran);


                    int barisTerpengaruh = cmd.ExecuteNonQuery();
                    if (barisTerpengaruh > 0)
                    {
                        isSukses = true;
                    }
                }
            }

            return isSukses;
        }


        public bool HapusData(int id)
        {
            bool isSukses = false;

            string query = @"
                DELETE FROM setoran WHERE id_setoran = @id";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@id", id);

                    int barisTerpengaruh = cmd.ExecuteNonQuery();
                    if (barisTerpengaruh > 0)
                    {
                        isSukses = true;
                    }
                }
            }

            return isSukses;
        }
    }
}
