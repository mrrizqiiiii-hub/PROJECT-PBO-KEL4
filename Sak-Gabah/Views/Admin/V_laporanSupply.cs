using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using Sak_Gabah.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views
{
    public partial class V_laporanSupply : Form
    {
        internal DateOnly tanggalAwal;
        internal DateOnly tanggalAkhir;
        internal string namaKomoditas;
        public V_laporanSupply()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void V_laporanSupply_Load(object sender, EventArgs e)
        {
            tampilkanData();
        }

        private void tampilkanData()
        {
            C_setoran kontroller = new C_setoran();
            List<M_setorSupply> dataMentah = kontroller.AmbilData();

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
                MessageBox.Show("Laporan setoran masih kosong.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dataRata = dataMentah.Select(data => new
            {
                iD = data.id,
                NamaKomoditas = data.detailKomoditas.merk,
                tanggalSetor = data.tanggal,
                jumlahSetor = data.jumlah_setoran,
                statusSetoran = data.status_setoran,
            }).ToList();

            setorandataGridView.DataSource = dataRata;
        }

        private void dashboardbutton_Click(object sender, EventArgs e)
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

        private void laporanPenjualanbutton_Click(object sender, EventArgs e)
        {
            V_laporanPenjualan laporanPenjualan = new V_laporanPenjualan();
            laporanPenjualan.Show();
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
