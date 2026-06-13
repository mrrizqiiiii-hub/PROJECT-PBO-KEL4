using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Models
{
    public abstract class M_baseTanggal : M_baseModel
    {
        public DateOnly tanggal { get; set; }

        public DateOnly tanggalTambahan { get; set; }
    }
}
