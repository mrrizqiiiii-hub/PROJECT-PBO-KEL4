using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Models
{
    public abstract class M_basePerson : M_baseModel
    {
        public string namalengkap { get; set; }
        public string no_telpon { get; set; }
        public  int id_alamatLengkap { get; set; }
        public M_alamatLengkap alamat { get; set; } = new M_alamatLengkap();
    }
}
