using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using Sak_Gabah.Helpers;
using Sak_Gabah.Models;
using Sak_Gabah.Repository;
using Sak_Gabah.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Sak_Gabah.Controllers
{
    internal class C_setoran 
    {
        private R_setoran repo = new R_setoran();
        public List<M_setorSupply> AmbilData()
        {
            return repo.AmbilData();
        }

        public List<M_setorSupply> AmbilData(string namaKomoditas)
        {
            return repo.AmbilData(namaKomoditas);
        }

        public List<M_setorSupply> AmbilData(DateOnly tanggalAwal, DateOnly tanggalAkhir)
        {
            return repo.AmbilData(tanggalAwal, tanggalAkhir);
        }

        public List<M_setorSupply> ambilDataVerifikasi()
        {
            return repo.ambilDataVerifikasi();
        }

        public List<M_setorSupply> AmbilData(int idUserAktif)
        {
            return repo.AmbilData(idUserAktif);
        }

        public List<M_setorSupply> ambilDataHistoriPerUser(int idUserAktif)
        {
            return repo.ambilDataHistoriPerUser(idUserAktif);
        }

        public List<M_setorSupply> ambilDataHistoriPerUser(int idUserAktif, string namaKomoditas)
        {
            return repo.ambilDataHistoriPerUser(idUserAktif, namaKomoditas);
        }

        public List<M_setorSupply> ambilDataHistoriPerUser(int idUserAktif, DateOnly tanggalAwal, DateOnly tanggalAkhir)
        {
            return repo.ambilDataHistoriPerUser(idUserAktif, tanggalAwal, tanggalAkhir);
        }



        public List<M_setorSupply> ambilDataVerifikasi(DateOnly tanggalAwal, DateOnly tanggalAkhir)
        {
            return repo.ambilDataVerifikasi(tanggalAwal, tanggalAkhir);
        }

        public List<M_setorSupply> ambilDataVerifikasi(string namaKomoditas)
        {
            return repo.ambilDataVerifikasi(namaKomoditas);
        }

        public bool terimaPengajuan(M_setorSupply dataSetor)
        {
            return repo.terimaPengajuan(dataSetor);
        }


        public bool tolakPengajuan(M_setorSupply dataSetor)
        {
            return repo.tolakPengajuan(dataSetor);
        }

        public bool TambahData(M_setorSupply dataBaru)
        {
            return repo.TambahData(dataBaru);
        }

        public bool updateSetoran(M_setorSupply dataBaru)
        {
            return repo.updateSetoran(dataBaru);
        }


        public bool HapusData(int id)
        {
            return repo.HapusData(id);
        }
    }
}