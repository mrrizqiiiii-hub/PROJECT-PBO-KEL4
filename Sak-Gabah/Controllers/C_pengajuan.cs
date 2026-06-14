using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using Npgsql;
using Sak_Gabah.Controllers.Interface;
using Sak_Gabah.Helpers;
using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Controllers
{
    internal class C_pengajuan : C_baseController, IControllerBaca<M_pengajuanKomoditas>, IControllerTambah<M_pengajuanKomoditas>, IControllerHapus
    {
        public List<M_pengajuanKomoditas> AmbilData()
        {
            List<M_pengajuanKomoditas> listPengajuan = new List<M_pengajuanKomoditas>();

            string query =
                "SELECT " +
                    "pk.id_pengajuan as idpengajuan, " +
                    "k.id_komoditas as idKomoditas,  " + 
                    "u.id_user as idUser, "+ 
                    "k.nama_komoditas as namaKomoditas, " +
                    "pk.merk as merk, " +
                    "pk.harga as harga, " +
                    "u.username_user as username, " +
                    "pk.status_pengajuan as statusPengajuan, " +
                    "pk.deskripsi as deskripsi " +
                "FROM pengajuan_komoditas pk " +
                "JOIN \"user\" u USING (id_user) " +
                "JOIN komoditas k USING (id_komoditas) " +
                "WHERE pk.status_pengajuan ILIKE 'Pending'";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_pengajuanKomoditas item = new M_pengajuanKomoditas();
                        item.id = Convert.ToInt32(reader["idpengajuan"]);
                        item.komoditas.id = Convert.ToInt32(reader["idKomoditas"]);
                        item.user.id = Convert.ToInt32(reader["idUser"]);
                        item.komoditas.nama_komoditas = reader["namaKomoditas"].ToString();
                        item.merk = reader["merk"].ToString();
                        item.harga = Convert.ToDecimal(reader["harga"]);
                        item.user.username = reader["username"].ToString();
                        item.status_pengajuan = reader["statusPengajuan"].ToString();
                        item.deskripsi = reader["deskripsi"].ToString();

                        listPengajuan.Add(item);
                    }
                }
            }
            return listPengajuan;
        }

        public List<M_pengajuanKomoditas> AmbilData(string keyword)
        {
            List<M_pengajuanKomoditas> listPengajuan = new List<M_pengajuanKomoditas>();

            string query =
                "SELECT " +
                    "pk.id_pengajuan as idpengajuan, " +
                    "k.id_komoditas as idKomoditas,  " +
                    "u.id_user as idUser, " +
                    "k.nama_komoditas as namaKomoditas, " +
                    "pk.merk as merk, " +
                    "pk.harga as harga, " +
                    "u.username_user as username, " +
                    "pk.status_pengajuan as statusPengajuan, " +
                    "pk.deskripsi as deskripsi " +
                "FROM pengajuan_komoditas pk " +
                "JOIN \"user\" u USING (id_user) " +
                "JOIN komoditas k USING (id_komoditas) " +
                "WHERE pk.status_pengajuan ILIKE 'Pending' AND (k.merk ILIKE @keyword OR u.username_user ILIKE @keyword)";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@keyword", keyword);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_pengajuanKomoditas item = new M_pengajuanKomoditas();
                        item.id = Convert.ToInt32(reader["idpengajuan"]);
                        item.komoditas.id = Convert.ToInt32(reader["idKomoditas"]);
                        item.user.id = Convert.ToInt32(reader["idUser"]);
                        item.komoditas.nama_komoditas = reader["namaKomoditas"].ToString();
                        item.merk = reader["merk"].ToString();
                        item.harga = Convert.ToDecimal(reader["harga"]);
                        item.user.username = reader["username"].ToString();
                        item.status_pengajuan = reader["statusPengajuan"].ToString();
                        item.deskripsi = reader["deskripsi"].ToString();

                        listPengajuan.Add(item);
                    }
                }
            }
            return listPengajuan;
        }

        public List<M_pengajuanKomoditas> AmbilData(int id)
        {
            List<M_pengajuanKomoditas> listPengajuan = new List<M_pengajuanKomoditas>();

            string query =
                "SELECT " +
                    "pk.id_pengajuan as idpengajuan, " +
                    "k.id_komoditas as idKomoditas,  " +
                    "u.id_user as idUser, " +
                    "k.nama_komoditas as namaKomoditas, " +
                    "pk.merk as merk, " +
                    "pk.harga as harga, " +
                    "u.username_user as username, " +
                    "pk.status_pengajuan as statusPengajuan, " +
                    "pk.deskripsi as deskripsi " +
                "FROM pengajuan_komoditas pk " +
                "JOIN \"user\" u USING (id_user) " +
                "JOIN komoditas k USING (id_komoditas) " +
                "WHERE pk.status_pengajuan ILIKE 'Pending' AND u.id_user = @id";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_pengajuanKomoditas item = new M_pengajuanKomoditas();
                        item.id = Convert.ToInt32(reader["idpengajuan"]);
                        item.komoditas.id = Convert.ToInt32(reader["idKomoditas"]);
                        item.user.id = Convert.ToInt32(reader["idUser"]);
                        item.komoditas.nama_komoditas = reader["namaKomoditas"].ToString();
                        item.merk = reader["merk"].ToString();
                        item.harga = Convert.ToDecimal(reader["harga"]);
                        item.user.username = reader["username"].ToString();
                        item.status_pengajuan = reader["statusPengajuan"].ToString();
                        item.deskripsi = reader["deskripsi"].ToString();

                        listPengajuan.Add(item);
                    }
                }
            }
            return listPengajuan;
        }

        public bool terimaPengajuan(M_pengajuanKomoditas dataPengajuan)
        {
            bool isSukses = false;
            
            string queryUpdate = @"
                UPDATE pengajuan_komoditas 
                SET status_pengajuan = 'DITERIMA ' 
                WHERE id_pengajuan = @idPengajuan ";

            string queryInsert = @"
                INSERT INTO detail_komoditas (id_user, id_komoditas, merk, harga, stok, status_aktif, deskripsi) 
                VALUES (@idUser, @idKomoditas, @merk, @harga, 0, '1', @deskripsi)";

            using (var conn = AmbilKoneksi())
            {
                using (var transaksi = conn.BeginTransaction())
                {

                        using (var cmdUpdate = new NpgsqlCommand(queryUpdate, conn))
                        {
                            cmdUpdate.Transaction = transaksi;
                            cmdUpdate.Parameters.AddWithValue("@idPengajuan", dataPengajuan.id);
                            cmdUpdate.ExecuteNonQuery();
                        }

                        using (var cmdInsert = new NpgsqlCommand(queryInsert, conn))
                        {
                            cmdInsert.Transaction = transaksi;
                            cmdInsert.Parameters.AddWithValue("@idUser", dataPengajuan.user.id);
                            cmdInsert.Parameters.AddWithValue("@idKomoditas", dataPengajuan.komoditas.id);
                            cmdInsert.Parameters.AddWithValue("@merk", dataPengajuan.merk);
                            cmdInsert.Parameters.AddWithValue("@harga", dataPengajuan.harga);
                            cmdInsert.Parameters.AddWithValue("@deskripsi", dataPengajuan.deskripsi);
                            cmdInsert.ExecuteNonQuery();
                        }

                        transaksi.Commit();
                        isSukses = true;

                }
            }

            return isSukses;
        }

        public bool tolakPengajuan(M_pengajuanKomoditas dataPengajuan)
        {
            bool isSukses = false;

            string query = @"
                UPDATE pengajuan_komoditas 
                SET status_pengajuan = 'DITOLAK ' 
                WHERE id_pengajuan = @idPengajuan ";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPengajuan", dataPengajuan.id);
                    int barisPengaruh = cmd.ExecuteNonQuery();

                    if (barisPengaruh > 0)
                    {
                        isSukses = true;
                    }

                }
            }

            return isSukses;
        }
    

        public bool TambahData(M_pengajuanKomoditas dataBaru)
        {
            bool isSukses = false;

            string query = @"
                INSERT INTO pengajuan_komoditas (merk, harga, deskripsi, status_pengajuan, id_komoditas, id_user)
                VALUES (@merk, @harga, @deskripsi, 'PENDING', @idKomoditas, @idUser)";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@merk", dataBaru.merk);
                    cmd.Parameters.AddWithValue("@harga", dataBaru.harga);
                    cmd.Parameters.AddWithValue("@deskripsi", dataBaru.deskripsi);
                    cmd.Parameters.AddWithValue("@idKomoditas", dataBaru.komoditas.id);
                    cmd.Parameters.AddWithValue("@idUser", dataBaru.user.id);

                    int barisTerganggu = cmd.ExecuteNonQuery();

                    if (barisTerganggu > 0) isSukses = true;
                }
            }
            return isSukses;
        }

        public bool updatePengajuan(M_pengajuanKomoditas dataBaru)
        {
            bool isSukses = false;

            string query = @"
                UPDATE pengajuan_komoditas 
                SET 
                    merk = @merk, 
                    harga = @harga, 
                    deskripsi = @deskripsi, 
                    id_komoditas = @idKomoditas
                WHERE id_pengajuan = @idPengajuan;";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@merk", dataBaru.merk.TrimStart().TrimEnd());
                    cmd.Parameters.AddWithValue("@harga", dataBaru.harga);
                    cmd.Parameters.AddWithValue("@deskripsi", dataBaru.deskripsi.TrimStart().TrimEnd());
                    cmd.Parameters.AddWithValue("@idKomoditas", dataBaru.komoditas.id);
                    cmd.Parameters.AddWithValue("@idPengajuan", dataBaru.id);

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
                DELETE FROM pengajuan_komoditas WHERE id_pengajuan = @id";

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
