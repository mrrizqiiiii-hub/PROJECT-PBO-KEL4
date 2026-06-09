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
    public partial class UC_kartuDetailKomoditas : UserControl
    {
        private int idDipilih;
        public UC_kartuDetailKomoditas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void isiDataKartu(string merkKomoditas, double totalStok, double hargaKomoditas, string usernamePemilik, string deskripsiKomoditas)
        {
            merkKomoditaslabel.Text = merkKomoditas.ToString();
            totalStoklabel.Text = totalStok.ToString();
            hargalabel.Text = hargaKomoditas.ToString();
            usernamePemiliklabel.Text = usernamePemilik.ToString();
            deskripsitextBox.Text = deskripsiKomoditas.ToString();

        }

        private void totalStoklabel_Click(object sender, EventArgs e)
        {

        }

        private void UC_kartuDetailKomoditas_Load(object sender, EventArgs e)
        {

        }
    }
}
