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
    public partial class V_kelolaKomoditas : Form
    {
        private string kataKunci;
        public V_kelolaKomoditas()
        {
            InitializeComponent();
        }

        private void tambahKomoditasbutton_Click(object sender, EventArgs e)
        {
            V_tambahKomoditas tambahKomoditas = new V_tambahKomoditas();
            tambahKomoditas.ShowDialog();
            this.tampilkanKartuKomoditas();
        }

        private void cariKomoditasbutton_Click(object sender, EventArgs e)
        {
            V_filterKomoditas filterKomoditas = new V_filterKomoditas();

            if (filterKomoditas.ShowDialog() == DialogResult.OK)
            {
                this.kataKunci = filterKomoditas.keyWord;
                this.tampilkanKartuKomoditas();
            }
        }

        private void dashboardbutton_Click(object sender, EventArgs e)
        {
            V_dashboardAdmin dashboardAdmin = new V_dashboardAdmin();
            dashboardAdmin.Show();
            this.Close();
        }

        private void V_kelolaKomoditas_Load(object sender, EventArgs e)
        {
            tampilkanKartuKomoditas();
        }

        public void tampilkanKartuKomoditas()
        {
            kartuLayoutPanel.Controls.Clear();
            C_komoditas controller = new C_komoditas();
            List<M_detailKomoditas> daftarData;

            if (string.IsNullOrWhiteSpace(this.kataKunci))
            {
                daftarData = controller.ambilDataKomoditas();
            }
            else
            {
                daftarData = controller.cariKomoditas(this.kataKunci);
            }

            if (daftarData.Count == 0)
            {
                MessageBox.Show("Komoditas tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kataKunci = "";
                tampilkanKartuKomoditas();
                return;
            }

            foreach (var data in daftarData)
            {
                UC_kartuKomoditas kartuBaru = new UC_kartuKomoditas();

                kartuBaru.isiDataKartu(
                    data.id,
                    data.komoditas.nama_komoditas,
                    data.komoditas.totalStok,
                    data.komoditas.jumlahSupplier
                );

                kartuLayoutPanel.Controls.Add(kartuBaru);
            }
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
    }
}
