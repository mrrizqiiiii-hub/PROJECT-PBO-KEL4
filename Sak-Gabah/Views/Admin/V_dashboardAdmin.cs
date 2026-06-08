using Sak_Gabah.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }

        private void stokTotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void V_dashboardAdmin_Load(object sender, EventArgs e)
        {
            string namaPengguna = Sak_Gabah.Helpers.UserSession.userAktif.namaLengkap;
            C_dashboard dashboardController = new C_dashboard();
            selamatDatanglabel.Text = $"Selamat Datang, {namaPengguna}";
            stokTotalLabel.Text = $"{dashboardController.ambilTotalStokGudang()}";
            penjualanLabel.Text = $"{dashboardController.ambilTotalPenjualan()}";
            menungguVerifikasiLabel.Text = $"{dashboardController.ambilTotalVerifikasi()}";
        }
    }
}
