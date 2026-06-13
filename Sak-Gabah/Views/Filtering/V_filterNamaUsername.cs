using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views.Admin
{
    public partial class V_filterNama : Form
    {
        public string keyWord;
        public V_filterNama()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.keyWord = namaUsernametextBox.Text.TrimStart().TrimEnd();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void batalbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
