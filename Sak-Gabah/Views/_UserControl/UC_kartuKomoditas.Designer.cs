namespace Sak_Gabah.Views._UserControl
{
    partial class UC_kartuKomoditas
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            namaKomoditaslabel = new Label();
            totalStoklabel = new Label();
            stokTampilanlabel = new Label();
            label1 = new Label();
            jumlahSupplierlabel = new Label();
            lihatDetailbutton = new Button();
            SuspendLayout();
            // 
            // namaKomoditaslabel
            // 
            namaKomoditaslabel.BackColor = Color.Transparent;
            namaKomoditaslabel.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namaKomoditaslabel.ForeColor = Color.DarkGreen;
            namaKomoditaslabel.Location = new Point(14, 15);
            namaKomoditaslabel.Name = "namaKomoditaslabel";
            namaKomoditaslabel.Size = new Size(226, 46);
            namaKomoditaslabel.TabIndex = 4;
            namaKomoditaslabel.Text = "Komoditas";
            namaKomoditaslabel.TextAlign = ContentAlignment.MiddleCenter;
            namaKomoditaslabel.Click += namaKomoditaslabel_Click;
            // 
            // totalStoklabel
            // 
            totalStoklabel.BackColor = Color.Transparent;
            totalStoklabel.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalStoklabel.ForeColor = Color.DarkGreen;
            totalStoklabel.Location = new Point(75, 106);
            totalStoklabel.Name = "totalStoklabel";
            totalStoklabel.Size = new Size(108, 39);
            totalStoklabel.TabIndex = 4;
            totalStoklabel.Text = "100";
            totalStoklabel.TextAlign = ContentAlignment.MiddleCenter;
            totalStoklabel.Click += totalStoklabel_Click;
            // 
            // stokTampilanlabel
            // 
            stokTampilanlabel.BackColor = Color.Transparent;
            stokTampilanlabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stokTampilanlabel.ForeColor = Color.DarkGreen;
            stokTampilanlabel.Location = new Point(56, 73);
            stokTampilanlabel.Name = "stokTampilanlabel";
            stokTampilanlabel.Size = new Size(150, 33);
            stokTampilanlabel.TabIndex = 4;
            stokTampilanlabel.Text = "Jumlah Stok :";
            stokTampilanlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(40, 145);
            label1.Name = "label1";
            label1.Size = new Size(184, 33);
            label1.TabIndex = 4;
            label1.Text = "Jumlah Supplier :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // jumlahSupplierlabel
            // 
            jumlahSupplierlabel.BackColor = Color.Transparent;
            jumlahSupplierlabel.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jumlahSupplierlabel.ForeColor = Color.DarkGreen;
            jumlahSupplierlabel.Location = new Point(75, 178);
            jumlahSupplierlabel.Name = "jumlahSupplierlabel";
            jumlahSupplierlabel.Size = new Size(108, 39);
            jumlahSupplierlabel.TabIndex = 4;
            jumlahSupplierlabel.Text = "100";
            jumlahSupplierlabel.TextAlign = ContentAlignment.MiddleCenter;
            jumlahSupplierlabel.Click += jumlahSupplierlabel_Click;
            // 
            // lihatDetailbutton
            // 
            lihatDetailbutton.BackColor = Color.Green;
            lihatDetailbutton.FlatStyle = FlatStyle.Flat;
            lihatDetailbutton.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            lihatDetailbutton.ForeColor = Color.LightGreen;
            lihatDetailbutton.Location = new Point(17, 231);
            lihatDetailbutton.Name = "lihatDetailbutton";
            lihatDetailbutton.Size = new Size(223, 60);
            lihatDetailbutton.TabIndex = 5;
            lihatDetailbutton.Text = "LIHAT";
            lihatDetailbutton.UseVisualStyleBackColor = false;
            lihatDetailbutton.Click += lihatDetailbutton_Click;
            // 
            // UC_kartuKomoditas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            Controls.Add(lihatDetailbutton);
            Controls.Add(jumlahSupplierlabel);
            Controls.Add(totalStoklabel);
            Controls.Add(label1);
            Controls.Add(stokTampilanlabel);
            Controls.Add(namaKomoditaslabel);
            Name = "UC_kartuKomoditas";
            Size = new Size(252, 304);
            Load += kartuKomoditas_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label namaKomoditaslabel;
        private Label totalStoklabel;
        private Label stokTampilanlabel;
        private Label label1;
        private Label jumlahSupplierlabel;
        private Button lihatDetailbutton;
    }
}
