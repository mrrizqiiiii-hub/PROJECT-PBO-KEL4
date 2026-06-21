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
    public partial class V_kelolaTransaksi : Form
    {
        public V_kelolaTransaksi()
        {
            InitializeComponent();
        }

        internal string namaKomoditas;

        private void V_kelolaTransaksi_Load(object sender, EventArgs e)
        {
            tampilkanKartu();

        }

        private void dashboardbutton_Click(object sender, EventArgs e)
        {
            V_dashboardKaryawan dashboardKaryawan = new V_dashboardKaryawan();
            dashboardKaryawan.Show();
            this.Close();
        }

        private void kelolaSetoranbutton_Click(object sender, EventArgs e)
        {
            V_kelolaSupply kelolaSupply = new V_kelolaSupply();
            kelolaSupply.Show();
            this.Close();
        }

        private void tambahTransaksibutton_Click(object sender, EventArgs e)
        {
            V_tambahtransaksi tambahTransaksi = new V_tambahtransaksi();
            tambahTransaksi.ShowDialog();


        }

        private void filterKomoditasbutton_Click(object sender, EventArgs e)
        {
            V_filterKomoditas filterKomoditas = new V_filterKomoditas();

            if (filterKomoditas.ShowDialog() == DialogResult.OK)
            {
                this.namaKomoditas = filterKomoditas.keyWord;
                this.tampilkanKartu();
            }


        }

        private void tampilkanKartu()
        {
            transaksiLayoutPanel.Controls.Clear();
            C_penjualan controller = new C_penjualan();
            List<M_detailTransaksi> daftarData;

            if (!string.IsNullOrWhiteSpace(this.namaKomoditas))
            {
                daftarData = controller.AmbilData(this.namaKomoditas);
            }

            else
            {
                daftarData = controller.AmbilData();
            }

            if (daftarData.Count == 0)
            {
                MessageBox.Show("Belum ada transaksi dibuat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            daftarData = controller.ambilDataVerifikasiJual();

            foreach (var data in daftarData)
            {
                UC_kartuTransaksi kartuBaru = new UC_kartuTransaksi();

                kartuBaru.isiDataKartu(data);

                transaksiLayoutPanel.Controls.Add(kartuBaru);
            }
        }

        private void kelolaAkunbutton_Click(object sender, EventArgs e)
        {
            V_kelolaAkun kelolaAkun = new V_kelolaAkun(this);
            kelolaAkun.ShowDialog();
        }
    }
}
