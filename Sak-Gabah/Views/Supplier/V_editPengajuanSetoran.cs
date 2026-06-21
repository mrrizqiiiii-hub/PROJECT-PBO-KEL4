using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using Sak_Gabah.Views._UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views.Supplier
{
    public partial class V_editPengajuanSetoran : Form
    {
        public V_editPengajuanSetoran(M_setorSupply dataSetor)
        {
            InitializeComponent();

            jumlahStoktextBox.Text = (dataSetor.jumlah_setoran).ToString();

            this._dataSetor = dataSetor;
        }

        M_setorSupply _dataSetor = new M_setorSupply();
        C_komoditas kontrolkomoditas = new C_komoditas();
        C_setoran kontrolPengajuan = new C_setoran();

        private void merkcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void V_editPengajuanSetoran_Load(object sender, EventArgs e)
        {
            List<M_detailKomoditas> daftarMerk = kontrolkomoditas.ambilSemuaMerk(Helpers.UserSession.userAktif.id);

            merkeditcomboBox.DataSource = daftarMerk;
            merkeditcomboBox.DisplayMember = "merk";
            merkeditcomboBox.ValueMember = "id";
            merkeditcomboBox.SelectedValue = _dataSetor.detailKomoditas.id;
        }

        private void tambahbutton_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(jumlahStoktextBox.Text, out int hasilAngka))
            {
                MessageBox.Show("Kolom ini wajib diisi dengan ANGKA saja, tidak boleh mengandung huruf atau simbol!",
                                "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            M_setorSupply dataBaru = new M_setorSupply();
            dataBaru.id = _dataSetor.id;
            dataBaru.detailKomoditas.id = Convert.ToInt32(merkeditcomboBox.SelectedValue);
            dataBaru.jumlah_setoran = Convert.ToInt32(jumlahStoktextBox.Text);

            bool berhasil = kontrolPengajuan.updateSetoran(dataBaru);
            if (berhasil)
            {
                MessageBox.Show("Data pengajuan berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data, ID tidak ditemukan.", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void batalbutton_Click(object sender, EventArgs e)
        {

            bool berhasil = kontrolPengajuan.HapusData(_dataSetor.id);
            if (berhasil)
            {
                MessageBox.Show("Data pengajuan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal menghapus data, ID tidak ditemukan.", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
