using System;

namespace Sak_Gabah.Models
{
    public class M_detailTransaksi
    {
        public int id_detail { get; set; }
        public int kuantitas { get; set; }
        public int id_transaksi { get; set; }
        public M_transaksi transaksi { get; set; } = new M_transaksi();
        public int id_detail_komoditas { get; set; }
        public M_detailKomoditas detailKomoditas { get; set; } = new M_detailKomoditas();

    }
}