using Npgsql;
using Sak_Gabah.Helpers;
using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Controllers
{
    public class C_dashboard
    {
        public double ambilTotalStokGudang()
        {
            double totalStok = 0;
            string query = "SELECT SUM(stok) FROM detail_komoditas";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        totalStok = Convert.ToDouble(result);
                    }
                }
            }
            return totalStok;
        }

        public double ambilTotalPenjualan()
        {
            double totalPenjualan = 0;
            string query = "SELECT COUNT(Id_transaksi) FROM Transaksi";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        totalPenjualan = Convert.ToDouble(result);
                    }
                }
            }
            return totalPenjualan;
        }

        public double ambilTotalVerifikasi()
        {
            double totalVerifikasi = 0;
            string query = "SELECT count(id_pengajuan) FROM pengajuan_komoditas WHERE status_pengajuan = 'Pending'";

            using (var conn = dbHelpers.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        totalVerifikasi = Convert.ToDouble(result);
                    }
                }
            }
            return totalVerifikasi;
        }

    }
}
