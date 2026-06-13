using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using Sak_Gabah.Views._UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views.Admin
{
    public partial class V_filterKomoditas : Form
    {
        public string keyWord;
        public V_filterKomoditas()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cariKomoditasbutton_Click(object sender, EventArgs e)
        {
            this.keyWord = namaKomoditastextBox.Text.TrimStart().TrimEnd();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void namaKomoditastextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void batalbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
