using System;

namespace Sak_Gabah.Models
{
    public class M_setorSupply : M_baseTanggal
    {
        public int jumlah_setoran { get; set; }
        public string status_setoran { get; set; } 
        public int id_detail_komoditas { get; set; }
        public M_detailKomoditas detailKomoditas { get; set; } = new M_detailKomoditas();

    }
}
