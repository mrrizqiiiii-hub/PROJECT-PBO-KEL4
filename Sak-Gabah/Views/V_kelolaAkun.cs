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
            

            M_user dataProfilAktif = kelolaAkun.AmbilData(Helpers.UserSession.userAktif.id);

            usernametextBox.Text = dataProfilAktif.username;
            usernametextBox.Tag = dataProfilAktif.username;

            namaLengkaptextBox.Text = dataProfilAktif.namalengkap;
            noTelpontextBox.Text = dataProfilAktif.no_telpon;
            alamattextBox.Text = dataProfilAktif.alamat.alamatLengkap;


        }

        private void simpanPerubahabutton_Click(object sender, EventArgs e)
        {

            string usernameAsli = usernametextBox.Tag?.ToString();
            string usernameSekarang = usernametextBox.Text;

            M_user _dataProfil = new M_user();
            _dataProfil.id = Helpers.UserSession.userAktif.id;
            _dataProfil.username = usernametextBox.Text;
            _dataProfil.namalengkap = namaLengkaptextBox.Text;
            _dataProfil.no_telpon = noTelpontextBox.Text;
            _dataProfil.alamat.alamatLengkap = alamattextBox.Text;
            

            if (string.IsNullOrWhiteSpace(usernametextBox.Text) || string.IsNullOrWhiteSpace(namaLengkaptextBox.Text) ||  string.IsNullOrWhiteSpace(alamattextBox.Text) || string.IsNullOrWhiteSpace(noTelpontextBox.Text))
            {
                MessageBox.Show("Mohon lengkapi data akun!", "Validasi Gagal");
                return;
            }

            if (usernameAsli != usernameSekarang)
            {
                bool berhasil = kelolaAkun.updateAkun(_dataProfil, usernameSekarang);

                if (berhasil)
                {
                    MessageBox.Show($"Akun berhasil dirubah", "Sukses");
                    this.Close();
                    Helpers.UserSession.userAktif.username = usernametextBox.Text;
                    Helpers.UserSession.userAktif.namalengkap = namaLengkaptextBox.Text;
                    Helpers.UserSession.userAktif.no_telpon = noTelpontextBox.Text;
                    Helpers.UserSession.userAktif.alamat.alamatLengkap = alamattextBox.Text;

                    MessageBox.Show($"Semua data berhasil diubah!", "Berhasil");
                    return;
                }
                else
                {
                    MessageBox.Show($"Username sudah digunakan!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Username tetap sama.", "Informasi");
                return;
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
