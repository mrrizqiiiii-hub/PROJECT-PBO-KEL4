using Sak_Gabah.Controllers;
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
    public partial class V_dashboardSupplier : Form
    {
        public V_dashboardSupplier()
        {
            InitializeComponent();
        }

        private void V_dashboardSupplier_Load(object sender, EventArgs e)
        {
            string namaPengguna = Helpers.UserSession.userAktif.namalengkap;
            string usernamePengguna = Helpers.UserSession.userAktif.username;
            string rolePengguna = Helpers.UserSession.userAktif.role;
            int idUser = Helpers.UserSession.userAktif.id;

            C_dashboard kontroller = new C_dashboard();

            selamatDatanglabel.Text = $"Selamat Datang, {namaPengguna}";
            stokTotalLabel.Text = $"{kontroller.ambilTotalStokGudang(idUser)}";
            pengajuanPendingLabel.Text = $"{kontroller.ambilDataPengajuan(idUser)}";
            setoranVerifikasiLabel.Text = $"{kontroller.ambilSetoranVerifikasi(idUser)}";
            usernameTampilanlabel.Text = $"{usernamePengguna}";
            roleTampilanlabel.Text = $"{rolePengguna}";
        }

        private void pengajuanSupplierButton_Click(object sender, EventArgs e)
        {
            V_pengajuanSupplier pengajuanSupplier = new V_pengajuanSupplier();
            pengajuanSupplier.Show();
            this.Close();
        }

        private void setorSupplyButton_Click(object sender, EventArgs e)
        {
            V_setorSupply setorSupply = new V_setorSupply();
            setorSupply.Show();
            this.Close();

        }

        private void riwayatSetorbutton_Click(object sender, EventArgs e)
        {
            V_riwayatSetor riwayatSetor = new V_riwayatSetor();
            riwayatSetor.Show();
            this.Close();


        }
    }
}
