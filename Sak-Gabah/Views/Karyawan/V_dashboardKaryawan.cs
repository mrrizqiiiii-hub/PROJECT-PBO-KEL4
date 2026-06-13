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
    public partial class V_dashboardKaryawan : Form
    {
        public V_dashboardKaryawan()
        {
            InitializeComponent();
        }

        private void V_dashboarKaryawan_Load(object sender, EventArgs e)
        {
            string namaPengguna = Helpers.UserSession.userAktif.namalengkap;
            string usernamePengguna = Helpers.UserSession.userAktif.username;
            string rolePengguna = Helpers.UserSession.userAktif.role;

            C_dashboard kontroller = new C_dashboard();

            selamatDatanglabel.Text = $"Selamat Datang, {namaPengguna}";
            stokTotalLabel.Text = $"{kontroller.ambilTotalStokGudang()}";
            kelolaSupplyLabel.Text = $"{kontroller.ambilKelolaSupply()}";
            verifikasiTransaksiLabel.Text = $"{kontroller.ambilVerifikasiTransaksi()}";
            usernameTampilanlabel.Text = $"{usernamePengguna}";
            roleTampilanlabel.Text = $"{rolePengguna}";
        }

        private void kelolaSetoranbutton_Click(object sender, EventArgs e)
        {
            V_kelolaSupply kelolaSetoran = new V_kelolaSupply();
            kelolaSetoran.Show();
            this.Close();
        }

        private void kelolaTransaksibutton_Click(object sender, EventArgs e)
        {
            V_kelolaTransaksi kelolaTransaksi = new V_kelolaTransaksi();
            kelolaTransaksi.Show();
            this.Close();
        }
    }
}
