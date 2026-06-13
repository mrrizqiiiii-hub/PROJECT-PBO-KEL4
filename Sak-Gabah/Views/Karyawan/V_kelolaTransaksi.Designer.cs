namespace Sak_Gabah.Views
{
    partial class V_kelolaTransaksi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_kelolaTransaksi));
            filterKomoditasbutton = new Button();
            kelolaSetoranbutton = new Button();
            dashboardbutton = new Button();
            tambahTransaksibutton = new Button();
            transaksiLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // filterKomoditasbutton
            // 
            filterKomoditasbutton.BackColor = Color.Transparent;
            filterKomoditasbutton.FlatAppearance.BorderSize = 0;
            filterKomoditasbutton.FlatStyle = FlatStyle.Flat;
            filterKomoditasbutton.Location = new Point(481, 623);
            filterKomoditasbutton.Name = "filterKomoditasbutton";
            filterKomoditasbutton.Size = new Size(204, 82);
            filterKomoditasbutton.TabIndex = 14;
            filterKomoditasbutton.UseVisualStyleBackColor = false;
            filterKomoditasbutton.Click += filterKomoditasbutton_Click;
            // 
            // kelolaSetoranbutton
            // 
            kelolaSetoranbutton.BackColor = Color.Transparent;
            kelolaSetoranbutton.FlatAppearance.BorderSize = 0;
            kelolaSetoranbutton.FlatStyle = FlatStyle.Flat;
            kelolaSetoranbutton.Location = new Point(22, 109);
            kelolaSetoranbutton.Name = "kelolaSetoranbutton";
            kelolaSetoranbutton.Size = new Size(130, 41);
            kelolaSetoranbutton.TabIndex = 16;
            kelolaSetoranbutton.UseVisualStyleBackColor = false;
            kelolaSetoranbutton.Click += kelolaSetoranbutton_Click;
            // 
            // dashboardbutton
            // 
            dashboardbutton.BackColor = Color.Transparent;
            dashboardbutton.FlatAppearance.BorderSize = 0;
            dashboardbutton.FlatStyle = FlatStyle.Flat;
            dashboardbutton.Location = new Point(22, 61);
            dashboardbutton.Name = "dashboardbutton";
            dashboardbutton.Size = new Size(130, 41);
            dashboardbutton.TabIndex = 17;
            dashboardbutton.UseVisualStyleBackColor = false;
            dashboardbutton.Click += dashboardbutton_Click;
            // 
            // tambahTransaksibutton
            // 
            tambahTransaksibutton.BackColor = Color.Transparent;
            tambahTransaksibutton.FlatAppearance.BorderSize = 0;
            tambahTransaksibutton.FlatStyle = FlatStyle.Flat;
            tambahTransaksibutton.Location = new Point(237, 623);
            tambahTransaksibutton.Name = "tambahTransaksibutton";
            tambahTransaksibutton.Size = new Size(204, 82);
            tambahTransaksibutton.TabIndex = 15;
            tambahTransaksibutton.UseVisualStyleBackColor = false;
            tambahTransaksibutton.Click += tambahTransaksibutton_Click;
            // 
            // transaksiLayoutPanel
            // 
            transaksiLayoutPanel.AutoScroll = true;
            transaksiLayoutPanel.BackColor = Color.Transparent;
            transaksiLayoutPanel.Location = new Point(237, 12);
            transaksiLayoutPanel.Name = "transaksiLayoutPanel";
            transaksiLayoutPanel.Size = new Size(1099, 605);
            transaksiLayoutPanel.TabIndex = 18;
            // 
            // V_kelolaTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(transaksiLayoutPanel);
            Controls.Add(filterKomoditasbutton);
            Controls.Add(tambahTransaksibutton);
            Controls.Add(kelolaSetoranbutton);
            Controls.Add(dashboardbutton);
            DoubleBuffered = true;
            Name = "V_kelolaTransaksi";
            Text = "KelolaKomoditasKeluar";
            Load += V_kelolaTransaksi_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button filterKomoditasbutton;
        private Button kelolaSetoranbutton;
        private Button dashboardbutton;
        private Button tambahTransaksibutton;
        private FlowLayoutPanel transaksiLayoutPanel;
    }
}