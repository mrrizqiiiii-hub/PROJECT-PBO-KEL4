using System;

namespace Sak.Gabah
{
    public class Transaksi
    {
        public int id_transaksi { get; set; } 
        public int id_user { get; set; } 
        public int id_customer { get; set; } 
        public DateTime tanggal_transaksi { get; set; }
        public decimal total_harga { get; set; }
        public string metode_pembayaran { get; set; }
        public string bukti_transfer { get; set; } 

        public List<DetailTransaksi> Detail { get; set; } 
    }
}