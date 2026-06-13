namespace Sak_Gabah.Views._UserControl
{
    partial class UC_kartuPengajuan
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
            merklabel = new Label();
            hargalabel = new Label();
            lihatDetailbutton = new Button();
            SuspendLayout();
            // 
            // namaKomoditaslabel
            // 
            namaKomoditaslabel.BackColor = Color.ForestGreen;
            namaKomoditaslabel.BorderStyle = BorderStyle.Fixed3D;
            namaKomoditaslabel.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namaKomoditaslabel.ForeColor = Color.PaleGreen;
            namaKomoditaslabel.Location = new Point(20, 10);
            namaKomoditaslabel.Name = "namaKomoditaslabel";
            namaKomoditaslabel.Size = new Size(208, 66);
            namaKomoditaslabel.TabIndex = 11;
            namaKomoditaslabel.Text = "Komoditas";
            namaKomoditaslabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // merklabel
            // 
            merklabel.BackColor = Color.ForestGreen;
            merklabel.BorderStyle = BorderStyle.Fixed3D;
            merklabel.Font = new Font("Century Gothic", 18F);
            merklabel.ForeColor = Color.PaleGreen;
            merklabel.Location = new Point(24, 109);
            merklabel.Name = "merklabel";
            merklabel.Size = new Size(199, 49);
            merklabel.TabIndex = 12;
            merklabel.Text = "MERK";
            merklabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hargalabel
            // 
            hargalabel.BackColor = Color.ForestGreen;
            hargalabel.BorderStyle = BorderStyle.Fixed3D;
            hargalabel.Font = new Font("Century Gothic", 18F);
            hargalabel.ForeColor = Color.PaleGreen;
            hargalabel.Location = new Point(24, 167);
            hargalabel.Name = "hargalabel";
            hargalabel.Size = new Size(199, 49);
            hargalabel.TabIndex = 13;
            hargalabel.Text = "HARGA";
            hargalabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lihatDetailbutton
            // 
            lihatDetailbutton.BackColor = Color.Green;
            lihatDetailbutton.FlatStyle = FlatStyle.Flat;
            lihatDetailbutton.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lihatDetailbutton.ForeColor = Color.LightGreen;
            lihatDetailbutton.Location = new Point(24, 267);
            lihatDetailbutton.Name = "lihatDetailbutton";
            lihatDetailbutton.Size = new Size(199, 51);
            lihatDetailbutton.TabIndex = 14;
            lihatDetailbutton.Text = "LIHAT";
            lihatDetailbutton.UseVisualStyleBackColor = false;
            lihatDetailbutton.Click += lihatDetailbutton_Click;
            // 
            // UC_kartuPengajuan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            Controls.Add(lihatDetailbutton);
            Controls.Add(hargalabel);
            Controls.Add(merklabel);
            Controls.Add(namaKomoditaslabel);
            Name = "UC_kartuPengajuan";
            Size = new Size(248, 342);
            ResumeLayout(false);
        }

        #endregion

        private Label namaKomoditaslabel;
        private Label merklabel;
        private Label hargalabel;
        private Button lihatDetailbutton;
    }
}
