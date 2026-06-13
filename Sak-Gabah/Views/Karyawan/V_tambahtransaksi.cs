using Sak_Gabah.Controllers;
using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sak_Gabah.Views.Admin
{
    public partial class V_tambahtransaksi : Form
    {
        public V_tambahtransaksi()
        {
            InitializeComponent();
        }

        C_komoditas kontrolKomoditas = new C_komoditas();

        private void V_tambahtransaksi_Load(object sender, EventArgs e)
        {

            C_penjualan kontrolPenjualan = new C_penjualan();
            customercomboBox.SelectedIndexChanged -= customercomboBox_SelectedIndexChanged;
            komoditascomboBox.SelectedIndexChanged -= komoditascomboBox_SelectedIndexChanged;

            List<M_customer> listCust = kontrolPenjualan.ambilCustomer();
            customercomboBox.DataSource = listCust;
            customercomboBox.DisplayMember = "namaLengkap";
            customercomboBox.ValueMember = "id";
            customercomboBox.SelectedIndex = -1;

            List<M_komoditas> listKom = kontrolKomoditas.ambilKomoditas();
            komoditascomboBox.DataSource = listKom;
            komoditascomboBox.DisplayMember = "nama_komoditas";
            komoditascomboBox.ValueMember = "id";
            komoditascomboBox.SelectedIndex = -1;

            merkcomboBox.DataSource = null;
            metodeBayarcomboBox.Items.AddRange(new string[] { "Tunai", "Transfer Bank", "QRIS" });
            metodeBayarcomboBox.SelectedIndex = 0;

            customercomboBox.SelectedIndexChanged += customercomboBox_SelectedIndexChanged;
            komoditascomboBox.SelectedIndexChanged += komoditascomboBox_SelectedIndexChanged;
        }

        private void customercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customercomboBox.SelectedItem != null && customercomboBox.SelectedIndex != -1)
            {
                M_customer customerTerpilih = (M_customer)customercomboBox.SelectedItem;

                namaCustomertextBox.Text = customerTerpilih.namalengkap;
                noTelpontextBox.Text = customerTerpilih.no_telpon;
                alamattextBox.Text = customerTerpilih.alamat.alamatLengkap;
            }
        }

        private void komoditascomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (komoditascomboBox.SelectedValue != null && komoditascomboBox.SelectedIndex != -1)
            {
                int idKomoditas = Convert.ToInt32(komoditascomboBox.SelectedValue);

                List<M_detailKomoditas> listMerk = kontrolKomoditas.ambilDetailKomoditas(idKomoditas);

                merkcomboBox.DataSource = listMerk;
                merkcomboBox.DisplayMember = "merk";
                merkcomboBox.ValueMember = "id";
            }
        }

        private void tambahbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namaCustomertextBox.Text) || string.IsNullOrWhiteSpace(alamattextBox.Text) || string.IsNullOrWhiteSpace(noTelpontextBox.Text) || merkcomboBox.SelectedValue == null || string.IsNullOrWhiteSpace(kuantitastextBox.Text))
            {
                MessageBox.Show("Mohon lengkapi data customer, pilihan barang, dan kuantitas!", "Validasi Gagal");
                return;
            }

            if (!Int32.TryParse(kuantitastextBox.Text, out int hasilAngka))
            {
                MessageBox.Show("Kuantitas harus angka!", "Validasi Gagal");
                return;
            }

            


            M_transaksi transaksi = new M_transaksi();

            if (string.IsNullOrWhiteSpace((Convert.ToString(customercomboBox.SelectedValue))))
            {
                C_kelolaAkun kontrollerCustomer = new C_kelolaAkun();
                transaksi.customer.id = kontrollerCustomer.tambahCustomer(namaCustomertextBox.Text, noTelpontextBox.Text, alamattextBox.Text);

            }
            else
            {
                transaksi.customer.id = Convert.ToInt32(customercomboBox.SelectedValue);
            }

            transaksi.customer.namalengkap = namaCustomertextBox.Text;
            transaksi.customer.no_telpon = noTelpontextBox.Text;
            transaksi.customer.alamat.alamatLengkap = alamattextBox.Text;
            
            transaksi.metode_pembayaran = metodeBayarcomboBox.Text;
            transaksi.user.id = Helpers.UserSession.userAktif.id;

            M_detailKomoditas merkTerpilih = (M_detailKomoditas)merkcomboBox.SelectedItem;
            decimal hargaBarang = merkTerpilih.harga;

            int kuantitasBeli = Convert.ToInt32(kuantitastextBox.Text);
            transaksi.total_harga = kuantitasBeli * merkTerpilih.harga;

            M_detailTransaksi detailTrans = new M_detailTransaksi();
            detailTrans.id_detail_komoditas = merkTerpilih.id;
            detailTrans.kuantitas = kuantitasBeli;
            detailTrans.transaksi.total_harga = transaksi.total_harga;
            detailTrans.id_detail_komoditas = Convert.ToInt32(merkcomboBox.SelectedValue);

            detailTrans.transaksi = transaksi;

            C_penjualan controller = new C_penjualan();

            bool berhasil = controller.simpanTransaksi(detailTrans, Convert.ToInt32(customercomboBox.SelectedValue));

            if (berhasil)
            {
                MessageBox.Show($"Transaksi Berhasil ditambahkan", "Sukses");
                this.Close();
            }

        }

        private void batalbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
