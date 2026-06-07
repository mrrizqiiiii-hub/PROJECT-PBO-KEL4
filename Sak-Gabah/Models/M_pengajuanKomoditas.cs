using System;

namespace Sak.Gabah
{
    public class PengajuanKomoditas
    {
        public int id_pengajuan { get; set; } 
        public int id_komoditas { get; set; } 
        public int id_user { get; set; } 
        public string merk { get; set; }
        public string alamat { get; set; }
        public decimal harga { get; set; }
        public string deskripsi { get; set; }
        public string status_pengajuan { get; set; } 
    }
}