using System;

namespace Sak.Gabah
{
    public class Setoran
    {
        public int id_log_setoran { get; set; } 
        public int id_detail_komoditas { get; set; }
        public DateTime tanggal_setoran { get; set; }
        public int jumlah_setoran { get; set; }
        public string status_setoran { get; set; } 
    }
}
