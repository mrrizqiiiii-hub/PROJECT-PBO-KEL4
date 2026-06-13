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
    public partial class UC_kartuTransaksi : UserControl
    {
        public UC_kartuTransaksi()
        {
            InitializeComponent();
        }

        private void UC_kartuTransaksi_Load(object sender, EventArgs e)
        {

        }

        M_detailTransaksi detailTrans = new M_detailTransaksi();

        public void isiDataKartu(M_detailTransaksi dataBaru)
        {
            this.detailTrans = dataBaru;

            komoditaslabel.Text = detailTrans.detailKomoditas.komoditas.nama_komoditas;
            merklabel.Text = detailTrans.detailKomoditas.merk;
            kuantitaslabel.Text = Convert.ToString(detailTrans.kuantitas);
            totallabel.Text = Convert.ToString(detailTrans.transaksi.total_harga);
            customerlabel.Text = Convert.ToString(detailTrans.transaksi.customer.namalengkap);
            metodelabel.Text = Convert.ToString(detailTrans.transaksi.metode_pembayaran);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            C_penjualan controller = new C_penjualan();

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin MENYELESAIKAN transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            bool berhasil = controller.selesaikanTransaksi(detailTrans);

            if (berhasil)
            {
                MessageBox.Show("Transaksi selesai diproses! Tanggal dicatat dan stok gudang otomatis berkurang.", "Sukses");
                this.Dispose();
            }
        }

        private void tolakbutton_Click(object sender, EventArgs e)
        {
            C_penjualan kontroller = new C_penjualan();

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin MEMBATALKAN setoran ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool berhasil = kontroller.batalkanTransaksi(this.detailTrans);

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
