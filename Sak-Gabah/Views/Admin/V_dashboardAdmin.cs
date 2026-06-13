using Sak_Gabah.Controllers;
using Sak_Gabah.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sak_Gabah.Views
{
    public partial class V_dashboardAdmin : Form
    {
        public V_dashboardAdmin()
        {
            InitializeComponent();
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
        private void stokTotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void V_dashboardAdmin_Load(object sender, EventArgs e)
        {
            string namaPengguna = Sak_Gabah.Helpers.UserSession.userAktif.namalengkap;
            string usernamePengguna = Sak_Gabah.Helpers.UserSession.userAktif.username;
            string rolePengguna = Sak_Gabah.Helpers.UserSession.userAktif.role;

            C_dashboard dashboardController = new C_dashboard();
            selamatDatanglabel.Text = $"Selamat Datang, {namaPengguna}";
            stokTotalLabel.Text = $"{dashboardController.ambilTotalStokGudang()}";
            penjualanLabel.Text = $"{dashboardController.ambilTotalPenjualan()}";
            menungguVerifikasiLabel.Text = $"{dashboardController.ambilTotalVerifikasi()}";
            usernameTampilanlabel.Text = $"{usernamePengguna}";
            roleTampilanlabel.Text = $"{rolePengguna}";
        }

        private void V_dashboardAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void kelolaAkunbutton_Click(object sender, EventArgs e)
        {
            V_kelolaAkun kelolaAkun = new V_kelolaAkun();
            kelolaAkun.ShowDialog();
        }
    }
}
