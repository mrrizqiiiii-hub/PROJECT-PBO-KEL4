using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views.Admin
{
    public partial class V_tambahSetoran : Form
    {
        public V_tambahSetoran()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        C_komoditas kontrolKomoditas = new C_komoditas();

        private void V_tambahSetoran_Load(object sender, EventArgs e)
        {
            List<M_detailKomoditas> daftarMerk = kontrolKomoditas.ambilSemuaMerk(Helpers.UserSession.userAktif.id);
            
            merkcomboBox.DataSource = daftarMerk;
            merkcomboBox.DisplayMember = "merk";
            merkcomboBox.ValueMember = "id";

        }

        private void tambahbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(jumlahStoktextBox.Text) || string.IsNullOrWhiteSpace(merkcomboBox.Text))
            {
                MessageBox.Show("Mohon lengkapi data customer, pilihan barang, dan kuantitas!", "Validasi Gagal");
                return;
            }


            if (!Int32.TryParse(jumlahStoktextBox.Text, out int hasilAngka))
            {
                MessageBox.Show("Kolom ini wajib diisi dengan ANGKA saja, tidak boleh mengandung huruf atau simbol!",
                                "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            M_setorSupply dataBaru = new M_setorSupply();
            dataBaru.jumlah_setoran = Convert.ToInt32(jumlahStoktextBox.Text);
            dataBaru.detailKomoditas.id = Convert.ToInt32(merkcomboBox.SelectedValue);

            C_setoran kontrolSetoran = new C_setoran();
            bool berhasil = kontrolSetoran.tambahPengajuan(dataBaru);

            if (berhasil)
            {
                MessageBox.Show($"Setoran Berhasil ditambahkan, silahkan proses dan verifikasi oleh karyawan", "Sukses");
                this.Close();
            }
        }
    }
}
