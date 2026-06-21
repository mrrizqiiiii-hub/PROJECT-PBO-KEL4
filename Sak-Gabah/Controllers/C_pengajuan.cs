using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using Npgsql;
using Sak_Gabah.Helpers;
using Sak_Gabah.Models;
using Sak_Gabah.Repository;
using Sak_Gabah.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Controllers
{
    internal class C_pengajuan 
    {

        private R_pengajuan repo = new R_pengajuan();

        public List<M_pengajuanKomoditas> AmbilData()
        {
            return repo.AmbilData();
        }

        public List<M_pengajuanKomoditas> AmbilData(string keyword)
        {
            return repo.AmbilData(keyword);
        }

        public List<M_pengajuanKomoditas> AmbilData(int id)
        {
            return repo.AmbilData(id);
        }

        public bool terimaPengajuan(M_pengajuanKomoditas dataPengajuan)
        {
            return repo.terimaPengajuan(dataPengajuan);
        }

        public bool tolakPengajuan(M_pengajuanKomoditas dataPengajuan)
        {
            return repo.tolakPengajuan(dataPengajuan);
        }
    

        public bool TambahData(M_pengajuanKomoditas dataBaru)
        {
            return repo.TambahData(dataBaru);
        }

        public bool updatePengajuan(M_pengajuanKomoditas dataBaru)
        {
            return repo.updatePengajuan(dataBaru);
        }

        public bool HapusData(int id)
        {
            return repo.HapusData(id);
        }
        
    }
}
