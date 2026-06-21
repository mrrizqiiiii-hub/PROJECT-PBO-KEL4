using Sak_Gabah.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views.Supplier
{
    public partial class V_gantiPassword : Form
    {
        public V_gantiPassword()
        {
            InitializeComponent();
        }

        C_kelolaAkun kontrollerAkun = new C_kelolaAkun();

        private void ubahbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordlamatextBox.Text) || string.IsNullOrWhiteSpace(passwordbarutextBox.Text))
            {
                MessageBox.Show("Isi password lama dan baru!!", "Validasi Gagal");
                return;
            }

            bool gantiPassword = kontrollerAkun.gantiPassword(Helpers.UserSession.userAktif.username, passwordlamatextBox.Text, passwordbarutextBox.Text);

            if (gantiPassword)
            {
                MessageBox.Show($"Password Berhasil Diubah!", "Sukses");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Password lama salah!", "Gagal");
                this.Close();
            }

        }

        private void batalbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
