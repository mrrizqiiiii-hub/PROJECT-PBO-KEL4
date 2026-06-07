using System;
namespace Sak_Gabah.Models
{
    public class M_pengajuanKomoditas
    {
        public int id_pengajuan { get; set; } 
        public string merk { get; set; }
        public string alamat { get; set; }
        public decimal harga { get; set; }
        public string deskripsi { get; set; }
        public string status_pengajuan { get; set; }
        public int id_user { get; set; }
        public M_user user { get; set; } = new M_user();
        public int id_komoditas { get; set; }
        public M_komoditas komoditas { get; set; } = new M_komoditas();

    }
}