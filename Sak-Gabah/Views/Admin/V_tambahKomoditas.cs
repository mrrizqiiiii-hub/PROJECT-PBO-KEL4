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
    public partial class V_tambahKomoditas : Form
    {
        public V_tambahKomoditas()
        {
            InitializeComponent();
        }

        private void TambahKomoditas_Load(object sender, EventArgs e)
        {

        }

        private void tambahbutton_Click(object sender, EventArgs e)
        {
            M_komoditas dataKomoditas = new M_komoditas();

            dataKomoditas.nama_komoditas = namaKomoditastextBox.Text.TrimStart().TrimEnd();
            dataKomoditas.maksimal_stok = Convert.ToInt32(maksimalStoktextBox.Text);
            dataKomoditas.maksimal_supplier = Convert.ToInt32(maksimalSuppliertextBox.Text);

            C_komoditas kontrolKomoditas = new C_komoditas();

            if (kontrolKomoditas.cekDuplikat(namaKomoditastextBox.Text))
            {
                MessageBox.Show
                    ($"Komoditas dengan nama '{namaKomoditastextBox.Text}' sudah ada di sistem! Silakan gunakan nama lain.",
                      "Data Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool sukses = kontrolKomoditas.TambahData(dataKomoditas);

            if (sukses)
            {
                MessageBox.Show("Data komoditas baru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan data ke database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void batalbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
