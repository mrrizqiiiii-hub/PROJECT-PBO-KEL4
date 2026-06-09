using System;

namespace Sak_Gabah.Models
{
    public class M_komoditas : M_baseModel
    {
        public string nama_komoditas { get; set;  }
        public int maksimal_stok { get; set; }
        public int maksimal_supplier { get; set; }
        public int jumlahSupplier { get; set; }
        public int totalStok { get; set; }
    }
}