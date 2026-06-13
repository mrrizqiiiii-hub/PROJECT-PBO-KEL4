namespace Sak_Gabah.Views
{
    partial class V_kelolaSupply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_kelolaSupply));
            dashboardbutton = new Button();
            kelolaTransaksibutton = new Button();
            filterTanggalbutton = new Button();
            filterKomoditasbutton = new Button();
            setoranLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // dashboardbutton
            // 
            dashboardbutton.BackColor = Color.Transparent;
            dashboardbutton.FlatAppearance.BorderSize = 0;
            dashboardbutton.FlatStyle = FlatStyle.Flat;
            dashboardbutton.Location = new Point(25, 62);
            dashboardbutton.Name = "dashboardbutton";
            dashboardbutton.Size = new Size(130, 41);
            dashboardbutton.TabIndex = 13;
            dashboardbutton.UseVisualStyleBackColor = false;
            dashboardbutton.Click += dashboardbutton_Click;
            // 
            // kelolaTransaksibutton
            // 
            kelolaTransaksibutton.BackColor = Color.Transparent;
            kelolaTransaksibutton.FlatAppearance.BorderSize = 0;
            kelolaTransaksibutton.FlatStyle = FlatStyle.Flat;
            kelolaTransaksibutton.Location = new Point(25, 157);
            kelolaTransaksibutton.Name = "kelolaTransaksibutton";
            kelolaTransaksibutton.Size = new Size(130, 41);
            kelolaTransaksibutton.TabIndex = 13;
            kelolaTransaksibutton.UseVisualStyleBackColor = false;
            kelolaTransaksibutton.Click += kelolaTransaksibutton_Click;
            // 
            // filterTanggalbutton
            // 
            filterTanggalbutton.BackColor = Color.Transparent;
            filterTanggalbutton.FlatAppearance.BorderSize = 0;
            filterTanggalbutton.FlatStyle = FlatStyle.Flat;
            filterTanggalbutton.Location = new Point(239, 622);
            filterTanggalbutton.Name = "filterTanggalbutton";
            filterTanggalbutton.Size = new Size(204, 82);
            filterTanggalbutton.TabIndex = 13;
            filterTanggalbutton.UseVisualStyleBackColor = false;
            filterTanggalbutton.Click += filterTanggalbutton_Click;
            // 
            // filterKomoditasbutton
            // 
            filterKomoditasbutton.BackColor = Color.Transparent;
            filterKomoditasbutton.FlatAppearance.BorderSize = 0;
            filterKomoditasbutton.FlatStyle = FlatStyle.Flat;
            filterKomoditasbutton.Location = new Point(479, 622);
            filterKomoditasbutton.Name = "filterKomoditasbutton";
            filterKomoditasbutton.Size = new Size(204, 82);
            filterKomoditasbutton.TabIndex = 13;
            filterKomoditasbutton.UseVisualStyleBackColor = false;
            filterKomoditasbutton.Click += filterKomoditasbutton_Click;
            // 
            // setoranLayoutPanel
            // 
            setoranLayoutPanel.AutoScroll = true;
            setoranLayoutPanel.BackColor = Color.Transparent;
            setoranLayoutPanel.Location = new Point(239, 12);
            setoranLayoutPanel.Name = "setoranLayoutPanel";
            setoranLayoutPanel.Size = new Size(1099, 604);
            setoranLayoutPanel.TabIndex = 14;
            // 
            // V_kelolaSupply
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(setoranLayoutPanel);
            Controls.Add(filterKomoditasbutton);
            Controls.Add(filterTanggalbutton);
            Controls.Add(kelolaTransaksibutton);
            Controls.Add(dashboardbutton);
            DoubleBuffered = true;
            Name = "V_kelolaSupply";
            Text = "KelolaSupply";
            Load += V_kelolaSupply_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button dashboardbutton;
        private Button kelolaTransaksibutton;
        private Button filterTanggalbutton;
        private Button filterKomoditasbutton;
        private FlowLayoutPanel setoranLayoutPanel;
    }
}