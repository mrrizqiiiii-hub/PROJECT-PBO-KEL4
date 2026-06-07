using System;

namespace Sak_Gabah.Models
{
    public class M_transaksi
    {
        public int id_transaksi { get; set; } 
        public DateTime tanggal_transaksi { get; set; }
        public decimal total_harga { get; set; }
        public string metode_pembayaran { get; set; }
        public string bukti_transfer { get; set; } 
        public int id_user { get; set; }
        public M_user user { get; set; } = new M_user();
        public int id_customer { get; set; }
        public M_customer customer { get; set; } = new M_customer();
       
    
    }
}