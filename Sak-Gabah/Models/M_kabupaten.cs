using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Models
{
    public class M_kabupaten
    {
        public int id_kabupaten { get; set; }
        public string kabupaten { get; set; }
        public int IdKecamatan { get; set; }
        public M_kecamatan kecamatan { get; set; } = new M_kecamatan();
    }
}
