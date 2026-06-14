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
    public partial class V_registerKaryawan : Form
    {
        internal string keyword;
        public V_registerKaryawan()
        {
            InitializeComponent();
        }
        private void V_registerKaryawan_Load(object sender, EventArgs e)
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

        private void verifikasiSupplierbutton_Click(object sender, EventArgs e)
        {
            V_verifikasiSupplier verifikasiSupplier = new V_verifikasiSupplier();
            verifikasiSupplier.Show();
            this.Close();
        }

        private void tambahAkunbutton_Click(object sender, EventArgs e)
        {
            V_tambahAkun tambahAkun = new V_tambahAkun();
            tambahAkun.ShowDialog();
            this.tampilkanKartu();
        }

        private void filterUsernamebutton_Click(object sender, EventArgs e)
        {
            V_filterNama filterNama = new V_filterNama();

            if (filterNama.ShowDialog() == DialogResult.OK)
            {
                this.keyword = filterNama.keyWord;
                tampilkanKartu();
            }
        }

        public void tampilkanKartu()
        {
            karyawanAkunLayoutPanel.Controls.Clear();

            C_kelolaAkun kontroller = new C_kelolaAkun();

            List<M_user> daftarData;



            if (!string.IsNullOrWhiteSpace(this.keyword))
            {
                daftarData = kontroller.AmbilData(this.keyword);
            }
            else
            {
                daftarData = kontroller.AmbilData();
            }

            if (daftarData.Count == 0)
            {
                MessageBox.Show("Akun Tidak Ditemukan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var data in daftarData)
            {
                UC_kartuAkunKaryawan kartuBaru = new UC_kartuAkunKaryawan();

                kartuBaru.isiDataKartu(data);

                kartuBaru.FormInduk = this;

                karyawanAkunLayoutPanel.Controls.Add(kartuBaru);
            }


        }
        private void kelolaAkunbutton_Click_1(object sender, EventArgs e)
        {
            V_kelolaAkun kelolaAkun = new V_kelolaAkun(this);
            kelolaAkun.ShowDialog();
        }
    }
}
