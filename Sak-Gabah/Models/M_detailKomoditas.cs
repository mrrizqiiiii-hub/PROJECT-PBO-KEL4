using System;

namespace Sak_Gabah.Models
{
    public class M_detailKomoditas
    {
        public int id_detail_komoditas { get; set; } 
        public int stok { get; set; }
        public decimal harga { get; set; } 
        public bool status_aktif { get; set; } 
        public int id_user { get; set; }
        public M_user user { get; set; } = new M_user();
        public int id_komoditas { get; set; }
        public M_komoditas komoditas { get; set; } = new M_komoditas();

    }
}