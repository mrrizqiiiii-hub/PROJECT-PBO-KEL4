using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views
{
    public partial class V_register : Form
    {
        public V_register()
        {
            InitializeComponent();

        }

        private C_authLogin authController = new C_authLogin();

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void signUpbutton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordtextBox.Text) ||
                string.IsNullOrWhiteSpace(emailtextBox.Text))
            {
                MessageBox.Show("Semua kolom pendaftaran wajib diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passwordInput = passwordtextBox.Text;
            if (passwordInput.Length < 8)
            {
                MessageBox.Show("Keamanan lemah! Password harus memiliki panjang minimal 8 karakter.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usernameInput = usernametextBox.Text.Trim();
            if (usernameInput.Contains(" "))
            {
                MessageBox.Show("Username tidak boleh mengandung spasi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string emailInput = emailtextBox.Text.TrimEnd().TrimStart();

            try
            {
                if (authController.cekUsername(usernameInput))
                {
                    MessageBox.Show($"Username '{usernameInput}' sudah digunakan oleh orang lain. Silakan cari nama unik yang berbeda!", "Username Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (authController.cekEmail(emailInput))
                {
                    MessageBox.Show($"Email '{emailInput}' sudah pernah didaftarkan pada akun lain. Silakan gunakan email yang berbeda!",
                                    "Email Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                M_user userBaru = new M_user();
                userBaru.username = usernameInput;
                userBaru.password = passwordInput;
                userBaru.email = emailtextBox.Text;

                bool berhasilSimpan = authController.RegistrasiUserBaru(userBaru);

                if (berhasilSimpan)
                {
                    MessageBox.Show("Akun baru berhasil didaftarkan ke sistem Sak-Gabah!", "Registrasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    V_halamanLogin halamanLogin = new V_halamanLogin();
                    halamanLogin.Show();
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kegagalan sistem saat registrasi: " + ex.Message, "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void signInbutton_Click(object sender, EventArgs e)
        {
            V_halamanLogin halamanLogin = new V_halamanLogin();
            halamanLogin.Show();
            this.Close();
        }

        private void visiblebutton_Click(object sender, EventArgs e)
        {
            if (passwordtextBox.PasswordChar == '*')
            {
                passwordtextBox.PasswordChar = '\0';
                visiblebutton.BackgroundImage = Properties.Resources.EyeOpen;
            }
            else
            {
                passwordtextBox.PasswordChar = '*';
                visiblebutton.BackgroundImage = Properties.Resources.EyeClosed;
            }

        }
    }
}
