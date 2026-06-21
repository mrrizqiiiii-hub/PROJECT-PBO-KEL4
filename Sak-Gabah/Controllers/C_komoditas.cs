using Npgsql;
using Sak_Gabah.Helpers;
using Sak_Gabah.Models;
using Sak_Gabah.Repository;
using Sak_Gabah.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sak_Gabah.Controllers
{
    public class C_komoditas 
    {
        private R_komoditas kontroler = new R_komoditas();
        public List<M_detailKomoditas> AmbilData()
        {
            return kontroler.AmbilData();
        }

        public bool TambahData(M_komoditas dataBaru)
        {
            if (kontroler.cekDuplikat(dataBaru.nama_komoditas))
            {
                return false;
            }

            return kontroler.TambahData(dataBaru);
        }

        public bool cekDuplikatDetail(string merk)
        {
            return kontroler.cekDuplikat(merk);
        }

        public List<M_detailKomoditas> AmbilData(string kataKunci)
        {
            return kontroler.AmbilData(kataKunci);
        }

        public List<M_detailKomoditas> AmbilData(int idTerpilih)
        {
            return kontroler.AmbilData(idTerpilih);
        }

        public List<M_detailKomoditas> ambilDetailKomoditasTransaksi(int idTerpilih)
        {
            return kontroler.ambilDetailKomoditasTransaksi(idTerpilih);
        }

        public List<M_komoditas> ambilKomoditas()
        {
            return kontroler.ambilKomoditas();
        }

        public List<M_detailKomoditas> ambilSemuaMerk()
        {
            return kontroler.ambilSemuaMerk();
        }


        public List<M_detailKomoditas> ambilSemuaMerk(int id)
        {
            return kontroler.ambilSemuaMerk(id);
        }

        public bool nonAktifkanKomoditas(int idTerpilih, string status)
        {
            return kontroler.nonAktifkanKomoditas(idTerpilih, status);
        }

    }
}
