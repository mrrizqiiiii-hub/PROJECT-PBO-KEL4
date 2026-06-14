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
    internal class C_penjualan : C_baseController, IControllerBaca<M_detailTransaksi>
    {
        public List<M_detailTransaksi> AmbilData()
        {
            List<M_detailTransaksi> listPenjualan = new List<M_detailTransaksi>();

            string query =
                "SELECT " +
                    "t.id_transaksi as idTransaksi, " +
                    "t.tanggal_transaksi as tanggalTransaksi, " +
                    "dk.merk as merk, " +
                    "dt.kuantitas as kuantitas, " +
                    "(dk.harga * dt.kuantitas) as totalHarga, " +
                    "u.username_user as Pelayan, " +
                    "c.nama_customer as Customer " +
                "FROM detail_transaksi dt " +
                "JOIN detail_komoditas dk USING (id_detail_komoditas) " +
                "JOIN transaksi t USING (id_transaksi) " +
                "JOIN customer c USING (id_customer) " +
                "JOIN \"user\" u ON t.id_user = u.id_user;";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_detailTransaksi item = new M_detailTransaksi();
                        item.id = Convert.ToInt32(reader["idTransaksi"]);
                        item.transaksi.tanggal = (DateOnly)reader["tanggalTransaksi"];
                        item.detailKomoditas.merk = Convert.ToString(reader["merk"]);
                        item.kuantitas = Convert.ToInt32(reader["kuantitas"]);
                        item.transaksi.total_harga = Convert.ToDecimal(reader["totalHarga"]);
                        item.transaksi.user.username = Convert.ToString(reader["Pelayan"]);
                        item.transaksi.customer.namalengkap = Convert.ToString(reader["Customer"]);

                        listPenjualan.Add(item);
                    }
                }
            }
            return listPenjualan;
        }

        public List<M_detailTransaksi> AmbilData(DateOnly tanggalAwal, DateOnly tanggalAkhir)
        {
            List<M_detailTransaksi> listPenjualan = new List<M_detailTransaksi>();

            string query =
                "SELECT " +
                    "t.id_transaksi as idTransaksi, " +
                    "t.tanggal_transaksi as tanggalTransaksi, " +
                    "dk.merk as merk, " +
                    "dt.kuantitas as kuantitas, " +
                    "(dk.harga * dt.kuantitas) as totalHarga, " +
                    "u.username_user as Pelayan, " +
                    "c.nama_customer as Customer " +
                "FROM detail_transaksi dt " +
                "JOIN detail_komoditas dk USING (id_detail_komoditas) " +
                "JOIN transaksi t USING (id_transaksi) " +
                "JOIN customer c USING (id_customer) " +
                "JOIN \"user\" u ON t.id_user = u.id_user " +
                "WHERE t.tanggal_transaksi BETWEEN @tanggalAwal AND @tanggalAkhir  ";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@tanggalAwal", tanggalAwal);
                    cmd.Parameters.AddWithValue("@tanggalAkhir", tanggalAkhir);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_detailTransaksi item = new M_detailTransaksi();
                        item.id = Convert.ToInt32(reader["idTransaksi"]);
                        item.transaksi.tanggal = (DateOnly)reader["tanggalTransaksi"];
                        item.detailKomoditas.merk = Convert.ToString(reader["merk"]);
                        item.kuantitas = Convert.ToInt32(reader["kuantitas"]);
                        item.transaksi.total_harga = Convert.ToDecimal(reader["totalHarga"]);
                        item.transaksi.user.username = Convert.ToString(reader["Pelayan"]);
                        item.transaksi.customer.namalengkap = Convert.ToString(reader["Customer"]);

                        listPenjualan.Add(item);
                    }
                }
            }
            return listPenjualan;

        }

        public List<M_detailTransaksi> AmbilData(string namaKomoditas)
        {
            List<M_detailTransaksi> listPenjualan = new List<M_detailTransaksi>();

            string query =
                "SELECT " +
                    "t.id_transaksi as idTransaksi, " +
                    "t.tanggal_transaksi as tanggalTransaksi, " +
                    "dk.merk as merk, " +
                    "dt.kuantitas as kuantitas, " +
                    "(dk.harga * dt.kuantitas) as totalHarga, " +
                    "u.username_user as Pelayan, " +
                    "c.nama_customer as Customer " +
                "FROM detail_transaksi dt " +
                "JOIN detail_komoditas dk USING (id_detail_komoditas) " +
                "JOIN transaksi t USING (id_transaksi) " +
                "JOIN customer c USING (id_customer) " +
                "JOIN \"user\" u ON t.id_user = u.id_user " +
                "WHERE LOWER(dk.merk) LIKE LOWER(@keyword) ";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@keyword", "%" + namaKomoditas + "%");

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_detailTransaksi item = new M_detailTransaksi();
                        item.id = Convert.ToInt32(reader["idTransaksi"]);
                        item.transaksi.tanggal = (DateOnly)reader["tanggalTransaksi"];
                        item.detailKomoditas.merk = Convert.ToString(reader["merk"]);
                        item.kuantitas = Convert.ToInt32(reader["kuantitas"]);
                        item.transaksi.total_harga = Convert.ToDecimal(reader["totalHarga"]);
                        item.transaksi.user.username = Convert.ToString(reader["Pelayan"]);
                        item.transaksi.customer.namalengkap = Convert.ToString(reader["Customer"]);

                        listPenjualan.Add(item);
                    }
                }
            }
            return listPenjualan;
        }



        public List<M_customer> ambilCustomer()
        {
            List<M_customer> list = new List<M_customer>();
            string query = "SELECT id_customer, nama_customer, no_telpon, alamat kabupaten FROM customer ORDER BY nama_customer ASC;";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        M_customer customer = new M_customer();
                        customer.id = Convert.ToInt32(reader["id_customer"]);
                        customer.namalengkap = reader["nama_customer"].ToString();
                        customer.no_telpon = reader["no_telpon"].ToString();
                        customer.alamat.alamatLengkap = reader["kabupaten"].ToString();

                        list.Add(customer);
                    }
                }
            }
            return list;
        }


        public bool simpanTransaksi(M_detailTransaksi detailTransaksi, int id)
        {
            bool isSukses = false;

            string queryInduk = @"
                INSERT INTO transaksi (tanggal_transaksi, metode_pembayaran, id_customer, id_user, status_transaksi, total_harga) 
                VALUES (CURRENT_DATE, @metodePembayaran, @idCustomer, @idUser, 'Pending', @totalHarga ) 
                RETURNING id_transaksi;";

            string queryAnak = @"
                INSERT INTO detail_transaksi (kuantitas, id_detail_komoditas, id_transaksi) 
                VALUES (@kuantitas, @idDetailKomoditas, @idTransaksi);";


            string queryCustomer = @"
                UPDATE customer
                SET nama_customer = @namaCustomer, no_telpon = @noTelpon, alamat = @alamat
                WHERE id_customer = @id;";

            using (var conn = AmbilKoneksi())
            {
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {

                        int idTransaksiBaru = 0;

                        using (var cmdInduk = new NpgsqlCommand(queryInduk, conn))
                        {
                            cmdInduk.Transaction = tran;
                            cmdInduk.Parameters.AddWithValue("@metodePembayaran", detailTransaksi.transaksi.metode_pembayaran);
                            cmdInduk.Parameters.AddWithValue("@idCustomer", detailTransaksi.transaksi.customer.id);
                            cmdInduk.Parameters.AddWithValue("@idUser", detailTransaksi.transaksi.user.id);
                            cmdInduk.Parameters.AddWithValue("@totalHarga", detailTransaksi.transaksi.total_harga);

                            idTransaksiBaru = Convert.ToInt32(cmdInduk.ExecuteScalar());
                        }


                        using (var cmdAnak = new NpgsqlCommand(queryAnak, conn))
                        {
                            cmdAnak.Transaction = tran;
                            cmdAnak.Parameters.AddWithValue("@kuantitas", detailTransaksi.kuantitas);
                            cmdAnak.Parameters.AddWithValue("@idDetailKomoditas", detailTransaksi.id_detail_komoditas);
                            cmdAnak.Parameters.AddWithValue("@idTransaksi", idTransaksiBaru);

                            cmdAnak.ExecuteNonQuery();
                        }

                        using (var cmdCustomer = new NpgsqlCommand(queryCustomer, conn))
                        {
                            cmdCustomer.Transaction = tran;
                            cmdCustomer.Parameters.AddWithValue("@namaCustomer", detailTransaksi.transaksi.customer.namalengkap);
                            cmdCustomer.Parameters.AddWithValue("@noTelpon", detailTransaksi.transaksi.customer.no_telpon);
                            cmdCustomer.Parameters.AddWithValue("@alamat", detailTransaksi.transaksi.customer.alamat.alamatLengkap);
                            cmdCustomer.Parameters.AddWithValue("@id", id);

                            cmdCustomer.ExecuteNonQuery();
                        }


                        tran.Commit();
                        isSukses = true;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw new Exception("Gagal mengunci transaksi instant: " + ex.Message);
                    }
                }
            }
            return isSukses;
        }

        public List<M_detailTransaksi> ambilDataVerifikasiJual()
        {
            List<M_detailTransaksi> listPenjualan = new List<M_detailTransaksi>();

            string query = @"
                SELECT 
                    k.nama_komoditas AS ""Komoditas"",
                    dk.merk AS ""Merk"",
                    dt.kuantitas AS ""Kuantitas"",
                    t.total_harga AS ""Total"",
                    c.nama_customer AS ""Customer"",
                    t.metode_pembayaran AS ""Metode"",
                    t.status_transaksi AS ""Status"",
                    t.id_transaksi AS ""idTransaksi"",
                    dk.id_detail_komoditas AS ""idDetailKomoditas""
                FROM detail_transaksi dt
                JOIN transaksi t USING (id_transaksi)
                JOIN customer c USING (id_customer)
                JOIN detail_komoditas dk USING (id_detail_komoditas)
                JOIN komoditas k USING (id_komoditas)
                WHERE t.status_transaksi ILIKE 'Pending'";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_detailTransaksi item = new M_detailTransaksi();
                        item.id = Convert.ToInt32(reader["idTransaksi"]);
                        item.detailKomoditas.id = Convert.ToInt32(reader["idDetailKomoditas"]);
                        item.detailKomoditas.komoditas.nama_komoditas = Convert.ToString(reader["Komoditas"]);
                        item.detailKomoditas.merk = Convert.ToString(reader["Merk"]);
                        item.transaksi.total_harga = Convert.ToDecimal(reader["Total"]);
                        item.kuantitas = Convert.ToInt32(reader["Kuantitas"]);
                        item.transaksi.customer.namalengkap = Convert.ToString(reader["Customer"]);
                        item.transaksi.metode_pembayaran = Convert.ToString(reader["Metode"]);
                        item.transaksi.status_transaksi = Convert.ToString(reader["Status"]);

                        listPenjualan.Add(item);
                    }
                }
            }
            return listPenjualan;
        }

        public List<M_detailTransaksi> ambilDataVerifikasiJual(string keyword)
        {
            List<M_detailTransaksi> listPenjualan = new List<M_detailTransaksi>();

            string query = @"
                SELECT 
                    k.nama_komoditas AS ""Komoditas"",
                    dk.merk AS ""Merk"",
                    dt.kuantitas AS ""Kuantitas"",
                    t.total_harga AS ""Total"",
                    c.nama_customer AS ""Customer"",
                    t.metode_pembayaran AS ""Metode"",
                    t.status_transaksi AS ""Status"",
                    t.id_transaksi AS ""idTransaksi"",
                    dk.id_detail_komoditas AS ""idDetailKomoditas""
                FROM detail_transaksi dt
                JOIN transaksi t USING (id_transaksi)
                JOIN customer c USING (id_customer)
                JOIN detail_komoditas dk USING (id_detail_komoditas)
                JOIN komoditas k USING (id_komoditas)
                WHERE t.status_transaksi ILIKE 'Pending' AND k.nama_komoditas ILIKE @keyword ";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        M_detailTransaksi item = new M_detailTransaksi();
                        item.id = Convert.ToInt32(reader["idTransaksi"]);
                        item.detailKomoditas.id = Convert.ToInt32(reader["idDetailKomoditas"]);
                        item.detailKomoditas.komoditas.nama_komoditas = Convert.ToString(reader["Komoditas"]);
                        item.detailKomoditas.merk = Convert.ToString(reader["Merk"]);
                        item.transaksi.total_harga = Convert.ToDecimal(reader["Total"]);
                        item.kuantitas = Convert.ToInt32(reader["Kuantitas"]);
                        item.transaksi.customer.namalengkap = Convert.ToString(reader["Customer"]);
                        item.transaksi.metode_pembayaran = Convert.ToString(reader["Metode"]);
                        item.transaksi.status_transaksi = Convert.ToString(reader["Status"]);

                        listPenjualan.Add(item);
                    }
                }
            }
            return listPenjualan;
        }

        public bool selesaikanTransaksi(M_detailTransaksi dataTransaksi)
        {
            bool isSukses = false;

            string queryStatus = @"
                UPDATE transaksi 
                SET status_transaksi = 'Selesai' 
                WHERE id_transaksi = @idTransaksi;";

            string queryUpdateStok = @"
                UPDATE detail_komoditas 
                SET stok = stok - @kuantitas 
                WHERE id_detail_komoditas = @idDetailKomoditas;";

            using (var conn = AmbilKoneksi())
            {
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        using (var cmdStatus = new NpgsqlCommand(queryStatus, conn))
                        {
                            cmdStatus.Transaction = tran;
                            cmdStatus.Parameters.AddWithValue("@idTransaksi", dataTransaksi.id);
                            cmdStatus.ExecuteNonQuery();
                        }

                        using (var cmdStok = new NpgsqlCommand(queryUpdateStok, conn))
                        {
                            cmdStok.Transaction = tran;
                            cmdStok.Parameters.AddWithValue("@kuantitas", dataTransaksi.kuantitas);
                            cmdStok.Parameters.AddWithValue("@idDetailKomoditas", dataTransaksi.detailKomoditas.id);
                            cmdStok.ExecuteNonQuery();
                        }

                        tran.Commit();
                        isSukses = true;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw new Exception("Gagal menyelesaikan verifikasi transaksi: " + ex.Message);
                    }
                }
            }
            return isSukses;
        }

        public bool batalkanTransaksi(M_detailTransaksi dataSetor)
        {
            bool isSukses = false;

            string query = @"
                UPDATE transaksi 
                SET status_transaksi = 'Dibatalkan' 
                WHERE id_transaksi = @idTransaksi ";

            using (var conn = AmbilKoneksi())
            {
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idTransaksi", dataSetor.id);
                    int barisPengaruh = cmd.ExecuteNonQuery();

                    if (barisPengaruh > 0)
                    {
                        isSukses = true;
                    }

                }
            }

            return isSukses;
        }
    }
}
