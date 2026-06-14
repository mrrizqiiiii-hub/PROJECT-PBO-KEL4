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
    public partial class V_setorSupply : Form
    {
        public V_setorSupply()
        {
            InitializeComponent();
        }
        private void V_setorSupply_Load(object sender, EventArgs e)
        {
            tampilkanKartu();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            V_dashboardSupplier dashboardSupplier = new V_dashboardSupplier();
            dashboardSupplier.Show();
            this.Close();
        }

        private void pengajuanSupplierButton_Click(object sender, EventArgs e)
        {
            V_pengajuanSupplier pengajuanSupplier = new V_pengajuanSupplier();
            pengajuanSupplier.Show();
            this.Close();
        }

        private void riwayatSetorbutton_Click(object sender, EventArgs e)
        {
            V_riwayatSetor riwayatSetor = new V_riwayatSetor();
            riwayatSetor.Show();
            this.Close();
        }

        private void tambahSetoranbutton_Click(object sender, EventArgs e)
        {
            V_tambahSetoran tambahSetoran = new V_tambahSetoran();
            tambahSetoran.ShowDialog();
           

        }

        public void tampilkanKartu()
        {
            setoranLayoutPanel.Controls.Clear();

            C_setoran controller = new C_setoran();
            int idUser = Helpers.UserSession.userAktif.id;
            List<M_setorSupply> daftarData = controller.AmbilData(idUser);

            if (daftarData.Count == 0)
            {
                MessageBox.Show("Belum ada pengajuan setoran yang perlu diverifikasi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var data in daftarData)
            {
                UC_kartuPengajuanSetor kartuBaru = new UC_kartuPengajuanSetor();

                kartuBaru.FormIndukSetoran = this;

                setoranLayoutPanel.Controls.Add(kartuBaru);

                kartuBaru.isiDataKartu(data);
            }
        }
    }
}
