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
    public partial class V_pengajuanSupplier : Form
    {
        public V_pengajuanSupplier()
        {
            InitializeComponent();
        }

        private void V_pengajuanSupplier_Load(object sender, EventArgs e)
        {
            tampilkanKartuKomoditas();
        }
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            V_dashboardSupplier dashboardSupplier = new V_dashboardSupplier();
            dashboardSupplier.Show();
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

        private void tambahPengajuanbutton_Click(object sender, EventArgs e)
        {
            V_tambahPengajuan tambahPengajuan = new V_tambahPengajuan();
            tambahPengajuan.ShowDialog();
            
        }

        public void tampilkanKartuKomoditas()
        {
            pengajuanLayoutPanel.Controls.Clear();
            C_pengajuan controller = new C_pengajuan();
            List<M_pengajuanKomoditas> daftarData;

            daftarData = controller.AmbilData(Helpers.UserSession.userAktif.id);

            if (daftarData.Count == 0)
            {
                MessageBox.Show("Pengajuan Masih Kosong, Silahkan buat!.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            foreach (var data in daftarData)
            {
                UC_kartuPengajuan kartuBaru = new UC_kartuPengajuan();

                kartuBaru.isiDataKartu(data);
                kartuBaru.FormIndukPengajuan = this;

                pengajuanLayoutPanel.Controls.Add(kartuBaru);
            }
        }
    }
}
