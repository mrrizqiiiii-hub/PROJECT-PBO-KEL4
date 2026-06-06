using System;

namespace Sak.Gabah
{
    public class DetailTransaksi
    {
        public int id_detail { get; set; }
        public int id_transaksi { get; set; }
        public int id_detail_komoditas { get; set; } 
        public int kuantitas { get; set; }
    }
}