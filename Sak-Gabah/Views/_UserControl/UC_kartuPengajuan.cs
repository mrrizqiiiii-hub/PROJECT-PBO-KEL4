using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using Sak_Gabah.Views.Admin;
using Sak_Gabah.Views.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views._UserControl
{
    public partial class UC_kartuPengajuan : UserControl
    {
        public UC_kartuPengajuan()
        {
            InitializeComponent();
        }

        public V_pengajuanSupplier FormIndukPengajuan;

        M_pengajuanKomoditas dataPengajuan = new M_pengajuanKomoditas();

        public void isiDataKartu(M_pengajuanKomoditas dataBaru)
        {
            this.dataPengajuan = dataBaru;
            namaKomoditaslabel.Text = dataBaru.komoditas.nama_komoditas;
            merklabel.Text = dataBaru.merk;
            hargalabel.Text = dataBaru.harga.ToString("F0");
        }

        private void lihatDetailbutton_Click(object sender, EventArgs e)
        {
            V_editPengajuan editPengajuan = new V_editPengajuan(dataPengajuan);

            if (editPengajuan.ShowDialog() == DialogResult.OK) 
            {
                if (this.FormIndukPengajuan != null)
                {
                    this.FormIndukPengajuan.tampilkanKartuKomoditas();
                }
            }
        }
    }
}
