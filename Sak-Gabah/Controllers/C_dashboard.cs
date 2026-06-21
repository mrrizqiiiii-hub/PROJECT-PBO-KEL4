using Npgsql;
using Sak_Gabah.Helpers;
using Sak_Gabah.Models;
using Sak_Gabah.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Controllers
{
    public class C_dashboard 
    {
        R_dashboard kontroller = new R_dashboard();

        public double ambilTotalStokGudang()
        {
            return kontroller.ambilTotalStokGudang();
        }

        public double ambilTotalPenjualan()
        {
            return kontroller.ambilTotalPenjualan();
        }

        public double ambilTotalVerifikasi()
        {
            return kontroller.ambilTotalVerifikasi();
        }

        public double ambilKelolaSupply()
        {
            return kontroller.ambilKelolaSupply();
        }

        public double ambilVerifikasiTransaksi()
        {
            return kontroller.ambilVerifikasiTransaksi();
        }

        public double ambilTotalStokGudang(int id)
        {
            return kontroller.ambilTotalStokGudang(id);
        }

        public double ambilDataPengajuan(int id)
        {
            return kontroller.ambilDataPengajuan(id);
        }

        public double ambilSetoranVerifikasi(int id)
        {
            return kontroller.ambilSetoranVerifikasi(id);
        }

    }
}
