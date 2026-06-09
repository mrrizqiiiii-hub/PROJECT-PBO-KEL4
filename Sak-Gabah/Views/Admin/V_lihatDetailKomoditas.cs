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
    public partial class V_lihatDetailKomoditas : Form
    {
        private int idDetailTerpilih;
        public V_lihatDetailKomoditas(int idTerpilih)
        {
            InitializeComponent();
            this.idDetailTerpilih = idTerpilih;
            tampilkanKartuKomoditas();
        }

        public void tampilkanKartuKomoditas()
        {
            detailKomoditasLayoutPanel.Controls.Clear();

            C_komoditas controller = new C_komoditas();
            List<M_detailKomoditas> daftarData;

            daftarData = controller.ambilDetailKomoditas(idDetailTerpilih);

            foreach (var data in daftarData)
            {
                UC_kartuDetailKomoditas kartuBaru = new UC_kartuDetailKomoditas();

                kartuBaru.isiDataKartu(
                    data.merk,
                    data.stok,
                    data.harga,
                    data.user.username,
                    data.deskripsi
                );

                detailKomoditasLayoutPanel.Controls.Add(kartuBaru);
            }
        }
    }
}
