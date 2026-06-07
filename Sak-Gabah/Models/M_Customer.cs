using System;

namespace Sak_Gabah.Models
{
    public class M_customer
    {
        public int id_customer { get; set; }
        public string nama_customer { get; set; }
        public string no_telpon { get; set; }
        public string alamat { get; set; }
        public int id_kabupaten { get; set; }
        public M_kabupaten kabupaten { get; set; } = new M_kabupaten();
    }
}
