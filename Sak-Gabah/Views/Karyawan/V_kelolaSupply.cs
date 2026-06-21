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
    public partial class V_kelolaSupply : Form
    {
        public V_kelolaSupply()
        {
            InitializeComponent();
        }

        internal DateOnly tanggalAwal;
        internal DateOnly tanggalAkhir;
        internal string namaKomoditas;

        private void V_kelolaSupply_Load(object sender, EventArgs e)
        {
            tampilkanKartuKomoditas();
        }

        public void tampilkanKartuKomoditas()
        {
            setoranLayoutPanel.Controls.Clear();
            C_setoran controller = new C_setoran();
            List<M_setorSupply> daftarData;

            if (this.tanggalAwal != default(DateOnly) && this.tanggalAkhir != default(DateOnly))
            {
                daftarData = controller.ambilDataVerifikasi(this.tanggalAwal, this.tanggalAkhir);
            }

            else if (!string.IsNullOrWhiteSpace(this.namaKomoditas))
            {
                daftarData = controller.ambilDataVerifikasi(this.namaKomoditas);
            }

            else
            {
                daftarData = controller.ambilDataVerifikasi();
            }

            if (daftarData.Count == 0)
            {
                MessageBox.Show("Setoran masih kosong.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var data in daftarData)
            {
                UC_kartuSetoran kartuBaru = new UC_kartuSetoran();

                kartuBaru.isiDataKartu(data);

                setoranLayoutPanel.Controls.Add(kartuBaru);
            }
        }

        private void dashboardbutton_Click(object sender, EventArgs e)
        {
            V_dashboardKaryawan dashboardKaryawan = new V_dashboardKaryawan();
            dashboardKaryawan.Show();
            this.Close();
        }

        private void kelolaTransaksibutton_Click(object sender, EventArgs e)
        {
            V_kelolaTransaksi kelolaTransaksi = new V_kelolaTransaksi();
            kelolaTransaksi.Show();
            this.Close();
        }

        private void filterTanggalbutton_Click(object sender, EventArgs e)
        {
            V_filterTanggal filterTanggal = new V_filterTanggal();

            if (filterTanggal.ShowDialog() == DialogResult.OK)
            {
                this.tanggalAwal = filterTanggal.tanggalAwal;
                this.tanggalAkhir = filterTanggal.tanggalAkhir;
                this.tampilkanKartuKomoditas();
            }
        }

        private void filterKomoditasbutton_Click(object sender, EventArgs e)
        {
            V_filterKomoditas filterKomoditas = new V_filterKomoditas();
            if (filterKomoditas.ShowDialog() == DialogResult.OK)
            {
                this.namaKomoditas = filterKomoditas.keyWord;
                this.tampilkanKartuKomoditas();
            }
        }

        private void kelolaAkunbutton_Click(object sender, EventArgs e)
        {
            V_kelolaAkun kelolaAkun = new V_kelolaAkun(this);
            kelolaAkun.ShowDialog();
        }
    }
}
