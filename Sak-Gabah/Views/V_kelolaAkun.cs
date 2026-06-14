using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using Sak_Gabah.Views.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views.Admin
{
    public partial class V_kelolaAkun : Form
    {
        public V_kelolaAkun(Form formPengirim)
        {
            InitializeComponent();

            this._formUtama = formPengirim;
        }

        private Form _formUtama;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        C_kelolaAkun kelolaAkun = new C_kelolaAkun();
        C_authLogin authController = new C_authLogin();
        private void V_kelolaAkun_Load(object sender, EventArgs e)
        {
            

            M_user dataProfil = kelolaAkun.AmbilData(Helpers.UserSession.userAktif.id);

            usernametextBox.Text = dataProfil.username;
            namaLengkaptextBox.Text = dataProfil.namalengkap;
            emailtextBox.Text = dataProfil.email;
            noTelpontextBox.Text = dataProfil.no_telpon;
            alamattextBox.Text = dataProfil.alamat.alamatLengkap;

        }

        private void simpanPerubahabutton_Click(object sender, EventArgs e)
        {
            bool berhasil = kelolaAkun.updateAkun(emailtextBox.Text, usernametextBox.Text, namaLengkaptextBox.Text, noTelpontextBox.Text, alamattextBox.Text, Helpers.UserSession.userAktif.id);

            if (string.IsNullOrWhiteSpace(usernametextBox.Text) || string.IsNullOrWhiteSpace(namaLengkaptextBox.Text) || string.IsNullOrWhiteSpace(emailtextBox.Text) || string.IsNullOrWhiteSpace(alamattextBox.Text) || string.IsNullOrWhiteSpace(noTelpontextBox.Text))
            {
                MessageBox.Show("Mohon lengkapi data akun!", "Validasi Gagal");
                return;
            }

            if (authController.cekUsername(usernametextBox.Text))
            {
                MessageBox.Show($"Username '{usernametextBox.Text}' sudah digunakan oleh orang lain. Silakan cari nama unik yang berbeda!", "Username Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (authController.cekEmail(emailtextBox.Text))
            {
                MessageBox.Show($"Email '{emailtextBox.Text}' sudah pernah didaftarkan pada akun lain. Silakan gunakan email yang berbeda!",
                                "Email Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (berhasil)
            {
                MessageBox.Show($"Akun berhasil dirubah", "Sukses");
                this.Close();
            }
        }

        private void gantiPasswordbutton_Click(object sender, EventArgs e)
        {
            V_gantiPassword gantiPassword = new V_gantiPassword();
            gantiPassword.ShowDialog();
        }

        private void kembalibutton_Click(object sender, EventArgs e)
        {
            V_halamanLogin halamanLogin = new V_halamanLogin();

            if (this._formUtama != null)
            {
                this._formUtama.Close();
            }

            halamanLogin.Show();
        }
    }
}
