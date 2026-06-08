using Sak_Gabah.Controllers;
using Sak_Gabah.Helpers;
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
    public partial class V_halamanLogin : Form
    {
        public V_halamanLogin()
        {
            InitializeComponent();
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void viewRegisterbutton_Click(object sender, EventArgs e)
        {
            V_register register = new V_register();
            this.Close();
            register.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usernameInput = usernameTxtBox.Text;
            string passwordInput = passwordTxtBox.Text;

            C_authLogin auth = new C_authLogin();

            M_user userResult = auth.AuthLogin(usernameInput, passwordInput);

            if (userResult != null)
            {
                if (userResult.statusAkun != "Aktif")
                {
                    MessageBox.Show("Login Gagal! Akun anda telah dinonaktifkan.", "Akun Dinonaktifkan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UserSession.userAktif = userResult;

                    MessageBox.Show($"Selamat Datang, {userResult.username}!", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    if (userResult.role == "Admin")
                    {
                        V_dashboardAdmin dashboardAdmin = new V_dashboardAdmin();
                        dashboardAdmin.Show();
                    }
                    else if (userResult.role == "Karyawan")
                    {
                        V_dashboardKaryawan dashboardSupplier = new V_dashboardKaryawan();
                        dashboardSupplier.Show();
                    }
                    else
                    {
                        V_dashboardSupplier dashboardSupplier = new V_dashboardSupplier();
                        dashboardSupplier.Show();
                    }

                }

            }
            else
            {
                MessageBox.Show("Username atau Password yang kamu masukkan salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);


                passwordTxtBox.Clear();
                usernameTxtBox.Clear();
            }
        }

        private void visiblebutton_Click(object sender, EventArgs e)
        {
            if (passwordTxtBox.PasswordChar == '*')
            {
                passwordTxtBox.PasswordChar = '\0';
                visiblebutton.BackgroundImage = Properties.Resources.EyeOpen;
            }
            else
            {
                passwordTxtBox.PasswordChar = '*';
                visiblebutton.BackgroundImage = Properties.Resources.EyeClosed;
            }

        }

        private void V_halamanLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
