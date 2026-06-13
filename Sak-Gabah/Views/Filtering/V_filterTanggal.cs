using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views.Admin
{

    public partial class V_filterTanggal : Form
    {
        public DateOnly tanggalAwal;
        public DateOnly tanggalAkhir;
        public V_filterTanggal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void caributton_Click(object sender, EventArgs e)
        {
            tanggalAwal = DateOnly.FromDateTime(tanggalAwalPicker.Value);   
            tanggalAkhir = DateOnly.FromDateTime(tanggalAkhirPicker.Value);

            if (tanggalAwal > tanggalAkhir)
            {
                MessageBox.Show("Tanggal awal tidak boleh melebihi tanggal akhir!",
                                "Validasi Gagal",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
