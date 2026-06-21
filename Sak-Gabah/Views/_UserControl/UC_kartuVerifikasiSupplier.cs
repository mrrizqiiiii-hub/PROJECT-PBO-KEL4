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
    public partial class UC_kartuVerifikasiSupplier : UserControl
    {

        public UC_kartuVerifikasiSupplier()
        {
            InitializeComponent();
        }

        M_pengajuanKomoditas pengajuanKomoditas = new M_pengajuanKomoditas();

        public void isiDataKartu(M_pengajuanKomoditas dataBaru)
        {
            this.pengajuanKomoditas = dataBaru;

            namaKomoditaslabel.Text = pengajuanKomoditas.komoditas.nama_komoditas;
            merkKomoditaslabel.Text = pengajuanKomoditas.merk;
            hargalabel.Text = Convert.ToString(pengajuanKomoditas.harga);
            supplierlabel.Text = pengajuanKomoditas.user.username;
            statusPengajuanlabel.Text = pengajuanKomoditas.status_pengajuan;
            deskripsitextBox.Text = pengajuanKomoditas.deskripsi;
        }

        private void terimabutton_Click(object sender, EventArgs e)
        {
            C_pengajuan kontroller = new C_pengajuan();

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin MENERIMA pengajuan ini?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool berhasil = kontroller.terimaPengajuan(this.pengajuanKomoditas);

                    if (berhasil)
                    {
                        MessageBox.Show("Pengajuan berhasil diterima!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tolakbutton_Click(object sender, EventArgs e)
        {
            C_pengajuan kontroller = new C_pengajuan();

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin MENOLAK pengajuan ini?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool berhasil = kontroller.tolakPengajuan(this.pengajuanKomoditas);

                    if (berhasil)
                    {
                        MessageBox.Show("Pengajuan ditolak diterima!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void namaKomoditaslabel_Click(object sender, EventArgs e)
        {

        }
    }
}
