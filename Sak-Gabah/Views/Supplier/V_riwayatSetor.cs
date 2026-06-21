using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
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
    public partial class V_riwayatSetor : Form
    {
        public V_riwayatSetor()
        {
            InitializeComponent();
        }

        internal DateOnly tanggalAwal;
        internal DateOnly tanggalAkhir;
        internal string namaKomoditas;
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

        private void setorSupplySetorbutton_Click(object sender, EventArgs e)
        {
            V_setorSupply setorSupply = new V_setorSupply();
            setorSupply.Show();
            this.Close();
        }

        private void filterTanggalbutton_Click(object sender, EventArgs e)
        {
            V_filterTanggal filterTanggal = new V_filterTanggal();

            if (filterTanggal.ShowDialog() == DialogResult.OK)
            {
                this.tanggalAwal = filterTanggal.tanggalAwal;
                this.tanggalAkhir = filterTanggal.tanggalAkhir;
                this.namaKomoditas = null;
                this.tampilkanData();
            }
        }

        private void filterKomoditasbutton_Click(object sender, EventArgs e)
        {
            V_filterKomoditas filterKomoditas = new V_filterKomoditas();
            if (filterKomoditas.ShowDialog() == DialogResult.OK)
            {
                this.namaKomoditas = filterKomoditas.keyWord;

                this.tampilkanData();
            }
        }

        private void V_riwayatSetor_Load(object sender, EventArgs e)
        {
            tampilkanData();
        }

        private void tampilkanData()
        {
            C_setoran kontroller = new C_setoran();
            List<M_setorSupply> dataMentah = kontroller.AmbilData();

            if (this.tanggalAwal != default(DateOnly) && this.tanggalAkhir != default(DateOnly))
            {
                dataMentah = kontroller.ambilDataHistoriPerUser(Helpers.UserSession.userAktif.id, this.tanggalAwal, this.tanggalAkhir);
            }

            else if (!string.IsNullOrWhiteSpace(this.namaKomoditas))
            {
                dataMentah = kontroller.ambilDataHistoriPerUser(Helpers.UserSession.userAktif.id, this.namaKomoditas);
            }

            else
            {
                dataMentah = kontroller.ambilDataHistoriPerUser(Helpers.UserSession.userAktif.id);
            }

            if (dataMentah.Count == 0)
            {
                MessageBox.Show("Setoran masih kosong, silahkan buat setoran", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dataRata = dataMentah.Select(data => new
            {
                iD = data.id,
                NamaKomoditas = data.detailKomoditas.komoditas.nama_komoditas,
                Merk = data.detailKomoditas.merk,
                tanggalSetor = data.tanggal,
                tanggalSelesai = data.tanggalTambahan,
                jumlahSetor = data.jumlah_setoran,
                statusSetoran = data.status_setoran,
            }).ToList();

            setorandataGridView.DataSource = dataRata;
        }

        private void kelolaAkunbutton_Click(object sender, EventArgs e)
        {
            V_kelolaAkun kelolaAkun = new V_kelolaAkun(this);
            kelolaAkun.ShowDialog();
        }
    }
}
