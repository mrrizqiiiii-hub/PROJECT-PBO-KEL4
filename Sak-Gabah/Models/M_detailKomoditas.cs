using System;

namespace Sak.Gabah
{
    public class DetailKomoditas
    {
        public int id_detail_komoditas { get; set; } 
        public int id_user { get; set; } 
        public int id_komoditas { get; set; } 
        public int stok { get; set; }
        public decimal harga { get; set; } 
        public bool status_aktif { get; set; } 

    }
}