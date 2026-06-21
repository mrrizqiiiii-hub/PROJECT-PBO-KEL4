using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using Sak_Gabah.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views
{
    public partial class V_laporanPenjualan : Form
    {
        internal DateOnly tanggalAwal;
        internal DateOnly tanggalAkhir;
        internal string namaKomoditas;
        public V_laporanPenjualan()
        {
            InitializeComponent();
        }
        private void V_laporanPenjualan_Load(object sender, EventArgs e)
        {
            tampilkanData();
        }

        private void Dashboardbutton_Click(object sender, EventArgs e)
        {
            V_dashboardAdmin dashboardAdmin = new V_dashboardAdmin();
            dashboardAdmin.Show();
            this.Close();
        }

        private void kelolaKomoditasbutton_Click(object sender, EventArgs e)
        {
            V_kelolaKomoditas kelolaKomoditas = new V_kelolaKomoditas();
            kelolaKomoditas.Show();
            this.Close();
        }

        private void laporanSupplybutton_Click(object sender, EventArgs e)
        {
            V_laporanSupply laporanSupply = new V_laporanSupply();
            laporanSupply.Show();
            this.Close();
        }

        private void verifikasiSupplierbutton_Click(object sender, EventArgs e)
        {
            V_verifikasiSupplier verifikasiSupplier = new V_verifikasiSupplier();
            verifikasiSupplier.Show();
            this.Close();
        }

        private void registerKaryawanbutton_Click(object sender, EventArgs e)
        {
            V_registerKaryawan registerKaryawan = new V_registerKaryawan();
            registerKaryawan.Show();
            this.Close();
        }


        private void tampilkanData()
        {
            C_penjualan kontroller = new C_penjualan();
            List<M_detailTransaksi> dataMentah = kontroller.AmbilData();

            if (this.tanggalAwal != default(DateOnly) && this.tanggalAkhir != default(DateOnly))
            {
                dataMentah = kontroller.AmbilData(this.tanggalAwal, this.tanggalAkhir);
            }

            else if (!string.IsNullOrWhiteSpace(this.namaKomoditas))
            {
                dataMentah = kontroller.AmbilData(this.namaKomoditas);
            }

            else
            {
                dataMentah = kontroller.AmbilData();
            }

            if (dataMentah.Count == 0)
            {
                MessageBox.Show("Penjualan masih kosong.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dataRata = dataMentah.Select(data => new
            {
                id_Detail = data.id,
                Tanggal_Transaksi = data.transaksi.tanggal.ToString("dd MMMM yyyy"),
                Nama_Barang = data.detailKomoditas.merk,
                Kuantitas = data.kuantitas,
                TotalHarga = data.transaksi.total_harga,
                Nama_Pelayan = data.transaksi.user.username,
                Nama_Customer = data.transaksi.customer.namalengkap,
            }).ToList();

            penjualanGridView.DataSource = dataRata;
        }

        private void filterTanggalbutton_Click(object sender, EventArgs e)
        {
            V_filterTanggal filterTanggal = new V_filterTanggal();

            if (filterTanggal.ShowDialog() == DialogResult.OK)
            {
                this.tanggalAwal = filterTanggal.tanggalAwal;
                this.tanggalAkhir = filterTanggal.tanggalAkhir;
                this.tampilkanData();
            }
        }
        private void filterKomoditasbutton_Click(object sender, EventArgs e)
        {
            V_filterKomoditas filterKomoditas = new V_filterKomoditas();
            if (filterKomoditas.ShowDialog() == DialogResult.OK)
            {
                this.namaKomoditas = filterKomoditas.keyWord;
                this.tampilkanData();
            }
        }

        private void kelolaAkunbutton_Click_1(object sender, EventArgs e)
        {
            V_kelolaAkun kelolaAkun = new V_kelolaAkun(this);
            kelolaAkun.ShowDialog();
        }
    }
}
