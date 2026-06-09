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

namespace Sak_Gabah.Views._UserControl
{
    public partial class UC_kartuKomoditas : UserControl
    {
        private int idTerpilih;
        public UC_kartuKomoditas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lihatDetailbutton_Click(object sender, EventArgs e)
        {
            V_lihatDetailKomoditas detailKomoditas = new V_lihatDetailKomoditas(this.idTerpilih);

            C_komoditas kontroller = new C_komoditas();
            List<M_detailKomoditas> cekData = kontroller.ambilDetailKomoditas(idTerpilih);
            if (cekData.Count == 0)
            {
                MessageBox.Show("Tidak ada detail komoditas.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            detailKomoditas.ShowDialog();

            
        }

        private void totalStoklabel_Click(object sender, EventArgs e)
        {

        }

        private void kartuKomoditas_Load(object sender, EventArgs e)
        {

        }

        public void isiDataKartu(int id, string namaKomoditas, double totalStok, int jumlahSupplier)
        {
            this.idTerpilih = id;
            namaKomoditaslabel.Text = namaKomoditas;
            totalStoklabel.Text = totalStok.ToString();
            jumlahSupplierlabel.Text = jumlahSupplier.ToString();
        }

        private void jumlahSupplierlabel_Click(object sender, EventArgs e)
        {

        }

        private void namaKomoditaslabel_Click(object sender, EventArgs e)
        {

        }
    }
}
