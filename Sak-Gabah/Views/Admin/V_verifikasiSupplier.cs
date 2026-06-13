using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using Sak_Gabah.Views._UserControl;
using Sak_Gabah.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views
{
    public partial class V_verifikasiSupplier : Form
    {
        internal int idTerpilih;
        internal string keyword;


        public V_verifikasiSupplier()
        {
            InitializeComponent();
        }

        private void V_verifikasiSupplier_Load(object sender, EventArgs e)
        {
            tampilkanKartu();
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

        private void laporanSupplybutton_Click(object sender, EventArgs e)
        {
            V_laporanSupply laporanSupply = new V_laporanSupply();
            laporanSupply.Show();
            this.Close();
        }

        private void laporanPenjualanbutton_Click(object sender, EventArgs e)
        {
            V_laporanPenjualan laporanPenjualan = new V_laporanPenjualan();
            laporanPenjualan.Show();
            this.Close();
        }

        private void registerKaryawanbutton_Click(object sender, EventArgs e)
        {
            V_registerKaryawan registerKaryawan = new V_registerKaryawan();
            registerKaryawan.Show();
            this.Close();
        }

        private void filterSupplierbutton_Click(object sender, EventArgs e)
        {
            V_filterNama filterNamaKomoditas = new V_filterNama(); 
            if (filterNamaKomoditas.ShowDialog() == DialogResult.OK)
            {
                this.keyword = filterNamaKomoditas.keyWord;
                tampilkanKartu();
            }
        }

        private void filterKomoditasbutton_Click(object sender, EventArgs e)
        {
            V_filterKomoditas filterKomoditas = new V_filterKomoditas();
            if (filterKomoditas.ShowDialog() == DialogResult.OK)
            {
                this.keyword = filterKomoditas.keyWord;
                tampilkanKartu();
            }
        }

        private void tampilkanKartu()
        {

            verifikasiSupplierLayoutPanel.Controls.Clear();

            C_pengajuan controller = new C_pengajuan();
            List<M_pengajuanKomoditas> daftarData;

            if (!string.IsNullOrWhiteSpace(this.keyword))
            {
                daftarData = controller.ambilDataPengajuan(this.keyword);
            }
            else
            {
                daftarData = controller.ambilDataPengajuan();
            }

            if (daftarData.Count == 0)
            {
                MessageBox.Show("Setoran masih kosong.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            daftarData = controller.ambilDataPengajuan();

            foreach (var data in daftarData)
            {
                UC_kartuVerifikasiSupplier kartuBaru = new UC_kartuVerifikasiSupplier();

                kartuBaru.isiDataKartu(data);

                verifikasiSupplierLayoutPanel.Controls.Add(kartuBaru);
            }
        }
    }
}
