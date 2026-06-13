using Sak_Gabah.Controllers;
using Sak_Gabah.Helpers;
using Sak_Gabah.Views.Admin;

namespace Sak_Gabah.Views
{
    partial class V_dashboardAdmin
    {
        C_dashboard dashboardController = new C_dashboard();
        
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_dashboardAdmin));
            kelolaKomoditasbutton = new Button();
            laporanSupplybutton = new Button();
            laporanPenjualanbutton = new Button();
            verifikasiSupplierbutton = new Button();
            registerKaryawanbutton = new Button();
            stokTotalLabel = new Label();
            penjualanLabel = new Label();
            menungguVerifikasiLabel = new Label();
            selamatDatanglabel = new Label();
            usernameTampilanlabel = new Label();
            roleTampilanlabel = new Label();
            kelolaAkunbutton = new Button();
            SuspendLayout();
            // 
            // kelolaKomoditasbutton
            // 
            kelolaKomoditasbutton.BackColor = Color.Transparent;
            kelolaKomoditasbutton.FlatAppearance.BorderSize = 0;
            kelolaKomoditasbutton.FlatStyle = FlatStyle.Flat;
            kelolaKomoditasbutton.Location = new Point(29, 108);
            kelolaKomoditasbutton.Name = "kelolaKomoditasbutton";
            kelolaKomoditasbutton.Size = new Size(130, 41);
            kelolaKomoditasbutton.TabIndex = 0;
            kelolaKomoditasbutton.UseVisualStyleBackColor = false;
            kelolaKomoditasbutton.Click += kelolaKomoditasbutton_Click;
            // 
            // laporanSupplybutton
            // 
            laporanSupplybutton.BackColor = Color.Transparent;
            laporanSupplybutton.FlatAppearance.BorderSize = 0;
            laporanSupplybutton.FlatStyle = FlatStyle.Flat;
            laporanSupplybutton.Location = new Point(28, 155);
            laporanSupplybutton.Name = "laporanSupplybutton";
            laporanSupplybutton.Size = new Size(130, 41);
            laporanSupplybutton.TabIndex = 0;
            laporanSupplybutton.UseVisualStyleBackColor = false;
            laporanSupplybutton.Click += laporanSupplybutton_Click;
            // 
            // laporanPenjualanbutton
            // 
            laporanPenjualanbutton.BackColor = Color.Transparent;
            laporanPenjualanbutton.FlatAppearance.BorderSize = 0;
            laporanPenjualanbutton.FlatStyle = FlatStyle.Flat;
            laporanPenjualanbutton.Location = new Point(28, 202);
            laporanPenjualanbutton.Name = "laporanPenjualanbutton";
            laporanPenjualanbutton.Size = new Size(130, 41);
            laporanPenjualanbutton.TabIndex = 0;
            laporanPenjualanbutton.UseVisualStyleBackColor = false;
            laporanPenjualanbutton.Click += laporanPenjualanbutton_Click;
            // 
            // verifikasiSupplierbutton
            // 
            verifikasiSupplierbutton.BackColor = Color.Transparent;
            verifikasiSupplierbutton.FlatAppearance.BorderSize = 0;
            verifikasiSupplierbutton.FlatStyle = FlatStyle.Flat;
            verifikasiSupplierbutton.Location = new Point(28, 249);
            verifikasiSupplierbutton.Name = "verifikasiSupplierbutton";
            verifikasiSupplierbutton.Size = new Size(130, 41);
            verifikasiSupplierbutton.TabIndex = 0;
            verifikasiSupplierbutton.UseVisualStyleBackColor = false;
            verifikasiSupplierbutton.Click += verifikasiSupplierbutton_Click;
            // 
            // registerKaryawanbutton
            // 
            registerKaryawanbutton.BackColor = Color.Transparent;
            registerKaryawanbutton.FlatAppearance.BorderSize = 0;
            registerKaryawanbutton.FlatStyle = FlatStyle.Flat;
            registerKaryawanbutton.Location = new Point(28, 296);
            registerKaryawanbutton.Name = "registerKaryawanbutton";
            registerKaryawanbutton.Size = new Size(130, 41);
            registerKaryawanbutton.TabIndex = 0;
            registerKaryawanbutton.UseVisualStyleBackColor = false;
            registerKaryawanbutton.Click += registerKaryawanbutton_Click;
            // 
            // stokTotalLabel
            // 
            stokTotalLabel.BackColor = Color.Transparent;
            stokTotalLabel.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stokTotalLabel.ForeColor = Color.Green;
            stokTotalLabel.Location = new Point(330, 406);
            stokTotalLabel.Name = "stokTotalLabel";
            stokTotalLabel.Size = new Size(148, 116);
            stokTotalLabel.TabIndex = 2;
            stokTotalLabel.Text = "50";
            stokTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            stokTotalLabel.Click += stokTotalLabel_Click;
            // 
            // penjualanLabel
            // 
            penjualanLabel.BackColor = Color.Transparent;
            penjualanLabel.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            penjualanLabel.ForeColor = Color.Green;
            penjualanLabel.Location = new Point(700, 406);
            penjualanLabel.Name = "penjualanLabel";
            penjualanLabel.Size = new Size(148, 116);
            penjualanLabel.TabIndex = 2;
            penjualanLabel.Text = "52";
            penjualanLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menungguVerifikasiLabel
            // 
            menungguVerifikasiLabel.BackColor = Color.Transparent;
            menungguVerifikasiLabel.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menungguVerifikasiLabel.ForeColor = Color.Green;
            menungguVerifikasiLabel.Location = new Point(1080, 406);
            menungguVerifikasiLabel.Name = "menungguVerifikasiLabel";
            menungguVerifikasiLabel.Size = new Size(148, 116);
            menungguVerifikasiLabel.TabIndex = 2;
            menungguVerifikasiLabel.Text = "5";
            menungguVerifikasiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selamatDatanglabel
            // 
            selamatDatanglabel.BackColor = Color.Transparent;
            selamatDatanglabel.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selamatDatanglabel.ForeColor = Color.PaleGreen;
            selamatDatanglabel.Location = new Point(253, 37);
            selamatDatanglabel.Name = "selamatDatanglabel";
            selamatDatanglabel.Size = new Size(788, 64);
            selamatDatanglabel.TabIndex = 3;
            selamatDatanglabel.Text = "Selamat Datang, Admin";
            selamatDatanglabel.TextAlign = ContentAlignment.MiddleLeft;
            selamatDatanglabel.Click += label1_Click;
            // 
            // usernameTampilanlabel
            // 
            usernameTampilanlabel.BackColor = Color.Transparent;
            usernameTampilanlabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTampilanlabel.ForeColor = Color.DarkGreen;
            usernameTampilanlabel.Location = new Point(60, 672);
            usernameTampilanlabel.Name = "usernameTampilanlabel";
            usernameTampilanlabel.Size = new Size(133, 28);
            usernameTampilanlabel.TabIndex = 4;
            usernameTampilanlabel.Text = "Abing";
            usernameTampilanlabel.TextAlign = ContentAlignment.MiddleLeft;
            usernameTampilanlabel.Click += label1_Click_1;
            // 
            // roleTampilanlabel
            // 
            roleTampilanlabel.BackColor = Color.Transparent;
            roleTampilanlabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roleTampilanlabel.ForeColor = Color.DarkGreen;
            roleTampilanlabel.Location = new Point(63, 700);
            roleTampilanlabel.Name = "roleTampilanlabel";
            roleTampilanlabel.Size = new Size(130, 20);
            roleTampilanlabel.TabIndex = 5;
            roleTampilanlabel.Text = "Admin";
            roleTampilanlabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kelolaAkunbutton
            // 
            kelolaAkunbutton.BackColor = Color.Transparent;
            kelolaAkunbutton.FlatAppearance.BorderSize = 0;
            kelolaAkunbutton.FlatStyle = FlatStyle.Flat;
            kelolaAkunbutton.Location = new Point(12, 672);
            kelolaAkunbutton.Name = "kelolaAkunbutton";
            kelolaAkunbutton.Size = new Size(45, 46);
            kelolaAkunbutton.TabIndex = 6;
            kelolaAkunbutton.UseVisualStyleBackColor = false;
            kelolaAkunbutton.Click += kelolaAkunbutton_Click;
            // 
            // V_dashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(kelolaAkunbutton);
            Controls.Add(roleTampilanlabel);
            Controls.Add(usernameTampilanlabel);
            Controls.Add(selamatDatanglabel);
            Controls.Add(menungguVerifikasiLabel);
            Controls.Add(penjualanLabel);
            Controls.Add(stokTotalLabel);
            Controls.Add(registerKaryawanbutton);
            Controls.Add(verifikasiSupplierbutton);
            Controls.Add(laporanPenjualanbutton);
            Controls.Add(laporanSupplybutton);
            Controls.Add(kelolaKomoditasbutton);
            DoubleBuffered = true;
            Name = "V_dashboardAdmin";
            Text = "Form1";
            FormClosed += V_dashboardAdmin_FormClosed;
            Load += V_dashboardAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button kelolaKomoditasbutton;
        private Button laporanSupplybutton;
        private Button laporanPenjualanbutton;
        private Button verifikasiSupplierbutton;
        private Button registerKaryawanbutton;
        private Label stokTotalLabel;
        private Label penjualanLabel;
        private Label menungguVerifikasiLabel;
        private Label selamatDatanglabel;
        private Label usernameTampilanlabel;
        private Label roleTampilanlabel;
        private Button kelolaAkunbutton;
    }
}