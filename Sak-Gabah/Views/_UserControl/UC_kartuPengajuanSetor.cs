using Sak_Gabah.Models;
using Sak_Gabah.Views.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views._UserControl
{
    public partial class UC_kartuPengajuanSetor : UserControl
    {
        public UC_kartuPengajuanSetor()
        {
            InitializeComponent();
        }

        public V_setorSupply FormIndukSetoran;

        M_setorSupply _dataBaru = new M_setorSupply();
        public void isiDataKartu(M_setorSupply dataBaru)
        {
            
            this._dataBaru = dataBaru;

            merkLabel.Text = dataBaru.detailKomoditas.merk;
            stoklabel.Text = (dataBaru.jumlah_setoran).ToString();
            statuslabel.Text = dataBaru.status_setoran;
        }

        private void lihatDetailbutton_Click(object sender, EventArgs e)
        {
            V_editPengajuanSetoran editPengajuanSetor = new V_editPengajuanSetoran(_dataBaru);

            if (editPengajuanSetor.ShowDialog() == DialogResult.OK)
            {
                if (this.FormIndukSetoran != null)
                {
                    this.FormIndukSetoran.tampilkanKartu();
                }
            }
        }
    }
}
