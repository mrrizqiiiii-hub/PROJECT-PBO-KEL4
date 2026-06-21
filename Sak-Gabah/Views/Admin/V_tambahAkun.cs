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
    public partial class V_tambahAkun : Form
    {
        public V_tambahAkun()
        {
            InitializeComponent();
        }

        private void tambahbutton_Click(object sender, EventArgs e)
        {
            M_user dataBaru = new M_user();
            C_kelolaAkun kontroller = new C_kelolaAkun();

            dataBaru.username = usernametextBox.Text;
            dataBaru.namalengkap = namaKaryawantextBox.Text;
            dataBaru.no_telpon= nomorTelepontextBox.Text;
            dataBaru.email = emailtextBox.Text;

            if (string.IsNullOrWhiteSpace(usernametextBox.Text) || string.IsNullOrWhiteSpace(namaKaryawantextBox.Text) || string.IsNullOrWhiteSpace(nomorTelepontextBox.Text) || string.IsNullOrWhiteSpace(emailtextBox.Text))
            {
                MessageBox.Show("Mohon lengkapi data customer, pilihan barang, dan kuantitas!", "Validasi Gagal");
                return;
            }

            bool sukses = kontroller.TambahData(dataBaru);

            if (sukses)
            {
                MessageBox.Show("Akun karyawan baru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan akun ke database, username sudah digunakan!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void batalbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
