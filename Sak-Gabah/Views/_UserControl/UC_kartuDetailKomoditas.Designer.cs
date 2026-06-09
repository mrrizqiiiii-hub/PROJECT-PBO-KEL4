namespace Sak_Gabah.Views._UserControl
{
    partial class UC_kartuDetailKomoditas
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
            totalStoklabel = new Label();
            stokTampilanlabel = new Label();
            merkKomoditaslabel = new Label();
            hargaTampilanLabel = new Label();
            hargalabel = new Label();
            deskripsitextBox = new TextBox();
            namaPemiliklabel = new Label();
            usernamePemiliklabel = new Label();
            SuspendLayout();
            // 
            // totalStoklabel
            // 
            totalStoklabel.BackColor = Color.Transparent;
            totalStoklabel.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            totalStoklabel.ForeColor = Color.DarkGreen;
            totalStoklabel.Location = new Point(385, 17);
            totalStoklabel.Name = "totalStoklabel";
            totalStoklabel.Size = new Size(252, 48);
            totalStoklabel.TabIndex = 7;
            totalStoklabel.Text = "100";
            totalStoklabel.TextAlign = ContentAlignment.MiddleLeft;
            totalStoklabel.Click += totalStoklabel_Click;
            // 
            // stokTampilanlabel
            // 
            stokTampilanlabel.BackColor = Color.Transparent;
            stokTampilanlabel.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold);
            stokTampilanlabel.ForeColor = Color.DarkGreen;
            stokTampilanlabel.Location = new Point(300, 14);
            stokTampilanlabel.Name = "stokTampilanlabel";
            stokTampilanlabel.Size = new Size(197, 51);
            stokTampilanlabel.TabIndex = 9;
            stokTampilanlabel.Text = "Stok :";
            stokTampilanlabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // merkKomoditaslabel
            // 
            merkKomoditaslabel.BackColor = Color.ForestGreen;
            merkKomoditaslabel.BorderStyle = BorderStyle.Fixed3D;
            merkKomoditaslabel.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            merkKomoditaslabel.ForeColor = Color.PaleGreen;
            merkKomoditaslabel.Location = new Point(18, 14);
            merkKomoditaslabel.Name = "merkKomoditaslabel";
            merkKomoditaslabel.Size = new Size(271, 171);
            merkKomoditaslabel.TabIndex = 10;
            merkKomoditaslabel.Text = "Komoditas";
            merkKomoditaslabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hargaTampilanLabel
            // 
            hargaTampilanLabel.BackColor = Color.Transparent;
            hargaTampilanLabel.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold);
            hargaTampilanLabel.ForeColor = Color.DarkGreen;
            hargaTampilanLabel.Location = new Point(300, 65);
            hargaTampilanLabel.Name = "hargaTampilanLabel";
            hargaTampilanLabel.Size = new Size(197, 51);
            hargaTampilanLabel.TabIndex = 11;
            hargaTampilanLabel.Text = "Harga :";
            hargaTampilanLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hargalabel
            // 
            hargalabel.BackColor = Color.Transparent;
            hargalabel.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            hargalabel.ForeColor = Color.DarkGreen;
            hargalabel.Location = new Point(412, 68);
            hargalabel.Name = "hargalabel";
            hargalabel.Size = new Size(225, 48);
            hargalabel.TabIndex = 12;
            hargalabel.Text = "100";
            hargalabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // deskripsitextBox
            // 
            deskripsitextBox.BackColor = Color.ForestGreen;
            deskripsitextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deskripsitextBox.ForeColor = Color.PaleGreen;
            deskripsitextBox.Location = new Point(643, 14);
            deskripsitextBox.Multiline = true;
            deskripsitextBox.Name = "deskripsitextBox";
            deskripsitextBox.ReadOnly = true;
            deskripsitextBox.ScrollBars = ScrollBars.Vertical;
            deskripsitextBox.Size = new Size(662, 171);
            deskripsitextBox.TabIndex = 13;
            deskripsitextBox.Text = "DESKRIPSI DESKRIPSI DESKRIPSI DESKRIPSI DESKRIPSI DESKRIPSI ";
            // 
            // namaPemiliklabel
            // 
            namaPemiliklabel.BackColor = Color.Transparent;
            namaPemiliklabel.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold);
            namaPemiliklabel.ForeColor = Color.DarkGreen;
            namaPemiliklabel.Location = new Point(300, 116);
            namaPemiliklabel.Name = "namaPemiliklabel";
            namaPemiliklabel.Size = new Size(165, 51);
            namaPemiliklabel.TabIndex = 14;
            namaPemiliklabel.Text = "Pemilik :";
            namaPemiliklabel.TextAlign = ContentAlignment.MiddleLeft;
            namaPemiliklabel.Click += label1_Click;
            // 
            // usernamePemiliklabel
            // 
            usernamePemiliklabel.BackColor = Color.Transparent;
            usernamePemiliklabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernamePemiliklabel.ForeColor = Color.DarkGreen;
            usernamePemiliklabel.Location = new Point(427, 119);
            usernamePemiliklabel.Name = "usernamePemiliklabel";
            usernamePemiliklabel.Size = new Size(210, 48);
            usernamePemiliklabel.TabIndex = 15;
            usernamePemiliklabel.Text = "Abing";
            usernamePemiliklabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_kartuDetailKomoditas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            Controls.Add(usernamePemiliklabel);
            Controls.Add(namaPemiliklabel);
            Controls.Add(deskripsitextBox);
            Controls.Add(hargalabel);
            Controls.Add(hargaTampilanLabel);
            Controls.Add(totalStoklabel);
            Controls.Add(stokTampilanlabel);
            Controls.Add(merkKomoditaslabel);
            Name = "UC_kartuDetailKomoditas";
            Size = new Size(1326, 197);
            Load += UC_kartuDetailKomoditas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalStoklabel;
        private Label stokTampilanlabel;
        private Label merkKomoditaslabel;
        private Label hargaTampilanLabel;
        private Label hargalabel;
        private TextBox deskripsitextBox;
        private Label namaPemiliklabel;
        private Label usernamePemiliklabel;
    }
}
