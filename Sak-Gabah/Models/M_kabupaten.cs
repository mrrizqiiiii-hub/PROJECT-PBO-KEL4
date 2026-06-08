using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Models
{
    public class M_kabupaten : M_baseModel
    {
        public string kabupaten { get; set; }
        public int IdKecamatan { get; set; }
        public M_kecamatan kecamatan { get; set; } = new M_kecamatan();
    }
}
