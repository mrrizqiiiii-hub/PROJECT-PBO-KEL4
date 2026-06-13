using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views._UserControl
{
    public partial class UC_kartuSetoran : UserControl
    {
        public UC_kartuSetoran()
        {
            InitializeComponent();
        }

        public V_kelolaSupply FormInduk;

        M_setorSupply setorSupply = new M_setorSupply();

        public void isiDataKartu(M_setorSupply dataBaru)
        {
            this.setorSupply = dataBaru;

            komoditaslabel.Text = setorSupply.detailKomoditas.komoditas.nama_komoditas;
            merkKomoditaslabel.Text = setorSupply.detailKomoditas.merk;
            tanggalPengajuanlabel.Text = Convert.ToString(setorSupply.tanggal);
            jumlahSetoranlabel.Text = Convert.ToString(setorSupply.jumlah_setoran);

        }

        private void terimabutton_Click(object sender, EventArgs e)
        {
            C_setoran controller = new C_setoran();

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin MENYELESAIKAN setoran ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            bool berhasil = controller.terimaPengajuan(setorSupply);

            if (berhasil)
            {
                MessageBox.Show("Setoran selesai diproses! Tanggal dicatat dan stok gudang otomatis bertambah.", "Sukses");
                this.Dispose();
            }
        }

        private void tolakbutton_Click(object sender, EventArgs e)
        {
            C_setoran kontroller = new C_setoran();

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin MEMBATALKAN setoran ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool berhasil = kontroller.tolakPengajuan(this.setorSupply);

                    if (berhasil)
                    {
                        MessageBox.Show("Setoran berhasil dibatalkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
