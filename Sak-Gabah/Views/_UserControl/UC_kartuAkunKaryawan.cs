using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views._UserControl
{
    public partial class UC_kartuAkunKaryawan : UserControl
    {
        public V_registerKaryawan FormInduk;
        public UC_kartuAkunKaryawan()
        {
            InitializeComponent();
        }

        M_user dataUser = new M_user();
        C_kelolaAkun kontroller = new C_kelolaAkun();

        public void isiDataKartu(M_user dataBaru)
        {
            this.dataUser = dataBaru;

            usernamelabel.Text = dataBaru.username;
            namaLengkaplabel.Text = dataBaru.namalengkap;
            statusAkunlabel.Text = dataBaru.statusAkun;

            if (statusAkunlabel.Text == "Aktif")
            {
                gantiStatusbutton.BackColor = Color.Red;
                gantiStatusbutton.Text = "Nonaktifkan";
            }
            else
            {
                gantiStatusbutton.BackColor = Color.DarkGreen;
                gantiStatusbutton.Text = "Aktifkan";
            }
        }

        private void gantiStatusbutton_Click(object sender, EventArgs e)
        {

            if (this.dataUser.statusAkun == "Aktif")
            {
                this.dataUser.statusAkun = "Nonaktif"; 
            }
            else
            {
                this.dataUser.statusAkun = "Aktif";
            }

            bool berhasil = kontroller.editAkunKaryawan(this.dataUser);

            if (berhasil)
            {
                MessageBox.Show("Status berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.FormInduk != null)
                {
                    this.FormInduk.tampilkanKartu();
                }
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            bool berhasil = kontroller.resetPassword(dataUser.username);

            if (berhasil)
            {
                MessageBox.Show("Password berhasil di reset!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
