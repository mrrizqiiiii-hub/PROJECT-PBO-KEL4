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
        public V_kelolaAkun()
        {
            InitializeComponent();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        C_kelolaAkun kelolaAkun = new C_kelolaAkun();
        private void V_kelolaAkun_Load(object sender, EventArgs e)
        {
            

            M_user dataProfil = kelolaAkun.ambilUser(Helpers.UserSession.userAktif.id);

            usernametextBox.Text = dataProfil.username;
            namaLengkaptextBox.Text = dataProfil.namalengkap;
            emailtextBox.Text = dataProfil.email;
            noTelpontextBox.Text = dataProfil.no_telpon;
            alamattextBox.Text = dataProfil.alamat.alamatLengkap;

        }

        private void simpanPerubahabutton_Click(object sender, EventArgs e)
        {
            bool berhasil = kelolaAkun.updateAkun(emailtextBox.Text, usernametextBox.Text, namaLengkaptextBox.Text, noTelpontextBox.Text, alamattextBox.Text, Helpers.UserSession.userAktif.id);

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
            this.Close();
        }
    }
}
