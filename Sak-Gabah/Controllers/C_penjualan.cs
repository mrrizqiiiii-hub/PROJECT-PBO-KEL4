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
    internal class C_penjualan 
    {

        private R_penjualan repo = new R_penjualan();

        public List<M_detailTransaksi> AmbilData()
        {
            return repo.AmbilData();
        }

        public List<M_detailTransaksi> AmbilData(DateOnly tanggalAwal, DateOnly tanggalAkhir)
        {
            return repo.AmbilData(tanggalAwal, tanggalAkhir);
        }

        public List<M_detailTransaksi> AmbilData(string namaKomoditas)
        {
            return repo.AmbilData(namaKomoditas);
        }



        public List<M_customer> ambilCustomer()
        {
            return repo.ambilCustomer();
        }


        public bool simpanTransaksi(M_detailTransaksi detailTransaksi, int id)
        {
            return repo.simpanTransaksi(detailTransaksi, id);
        }

        public List<M_detailTransaksi> ambilDataVerifikasiJual()
        {
            return repo.ambilDataVerifikasiJual();
        }

        public List<M_detailTransaksi> ambilDataVerifikasiJual(string keyword)
        {
            return repo.ambilDataVerifikasiJual(keyword);
        }

        public bool selesaikanTransaksi(M_detailTransaksi dataTransaksi)
        {
            return repo.selesaikanTransaksi(dataTransaksi);
        }

        public bool batalkanTransaksi(M_detailTransaksi dataSetor)
        {
            return repo.batalkanTransaksi(dataSetor);
        }
    }
}
