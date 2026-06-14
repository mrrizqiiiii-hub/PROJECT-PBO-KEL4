using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views.Admin
{
    public partial class V_tambahPengajuan : Form
    {
        public V_tambahPengajuan()
        {
            InitializeComponent();
        }

        C_komoditas kontrolKomoditas = new C_komoditas();

        private void V_tambahPengajuan_Load(object sender, EventArgs e)
        {

            komoditascomboBox.SelectedIndexChanged -= komoditascomboBox_SelectedIndexChanged;

            List<M_komoditas> listKom = kontrolKomoditas.ambilKomoditas();
            komoditascomboBox.DataSource = listKom;
            komoditascomboBox.DisplayMember = "nama_komoditas";
            komoditascomboBox.ValueMember = "id";
            komoditascomboBox.SelectedIndex = -1;

            komoditascomboBox.SelectedIndexChanged += komoditascomboBox_SelectedIndexChanged;
        }

        private void komoditascomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tambahbutton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(merktextBox.Text) || string.IsNullOrWhiteSpace(hargatextBox.Text) || string.IsNullOrWhiteSpace(deskripsitextBox.Text) || komoditascomboBox.SelectedValue == null)
            {
                MessageBox.Show("Mohon lengkapi data", "Validasi Gagal");
                return;
            }


            if (!Int32.TryParse(hargatextBox.Text, out int hasilAngka))
            {
                MessageBox.Show("Kolom ini wajib diisi dengan ANGKA saja, tidak boleh mengandung huruf atau simbol!",
                                "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (kontrolKomoditas.cekDuplikatDetail(merktextBox.Text))
            {
                MessageBox.Show($"Merk '{merktextBox.Text}' sudah terdaftar di kategori komoditas ini. Silakan masukkan merk lain!",
                                "Data Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            M_pengajuanKomoditas dataBaru = new M_pengajuanKomoditas();
            dataBaru.merk = merktextBox.Text;
            dataBaru.harga = Convert.ToDecimal(hargatextBox.Text);
            dataBaru.deskripsi = deskripsitextBox.Text;
            dataBaru.komoditas.id = Convert.ToInt32(komoditascomboBox.SelectedValue);
            dataBaru.user.id = Helpers.UserSession.userAktif.id;

            C_pengajuan kontrolPengajuan = new C_pengajuan();
            bool berhasil = kontrolPengajuan.TambahData(dataBaru);

            if (berhasil)
            {
                MessageBox.Show($"Transaksi Berhasil ditambahkan", "Sukses");
                this.Close();
            }
        }

        private void batalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
