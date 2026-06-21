namespace Sak_Gabah.Views
{
    partial class V_pengajuanSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_pengajuanSupplier));
            riwayatSetorbutton = new Button();
            setorSupplyButton = new Button();
            dashboardButton = new Button();
            tambahPengajuanbutton = new Button();
            pengajuanLayoutPanel = new FlowLayoutPanel();
            kelolaAkunbutton = new Button();
            SuspendLayout();
            // 
            // riwayatSetorbutton
            // 
            riwayatSetorbutton.BackColor = Color.Transparent;
            riwayatSetorbutton.FlatAppearance.BorderSize = 0;
            riwayatSetorbutton.FlatStyle = FlatStyle.Flat;
            riwayatSetorbutton.Location = new Point(22, 204);
            riwayatSetorbutton.Name = "riwayatSetorbutton";
            riwayatSetorbutton.Size = new Size(130, 41);
            riwayatSetorbutton.TabIndex = 21;
            riwayatSetorbutton.UseVisualStyleBackColor = false;
            riwayatSetorbutton.Click += riwayatSetorbutton_Click;
            // 
            // setorSupplyButton
            // 
            setorSupplyButton.BackColor = Color.Transparent;
            setorSupplyButton.FlatAppearance.BorderSize = 0;
            setorSupplyButton.FlatStyle = FlatStyle.Flat;
            setorSupplyButton.Location = new Point(22, 157);
            setorSupplyButton.Name = "setorSupplyButton";
            setorSupplyButton.Size = new Size(130, 41);
            setorSupplyButton.TabIndex = 22;
            setorSupplyButton.UseVisualStyleBackColor = false;
            setorSupplyButton.Click += setorSupplyButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.Transparent;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Location = new Point(22, 64);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(130, 41);
            dashboardButton.TabIndex = 23;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // tambahPengajuanbutton
            // 
            tambahPengajuanbutton.BackColor = Color.Transparent;
            tambahPengajuanbutton.FlatAppearance.BorderSize = 0;
            tambahPengajuanbutton.FlatStyle = FlatStyle.Flat;
            tambahPengajuanbutton.Location = new Point(239, 621);
            tambahPengajuanbutton.Name = "tambahPengajuanbutton";
            tambahPengajuanbutton.Size = new Size(203, 81);
            tambahPengajuanbutton.TabIndex = 21;
            tambahPengajuanbutton.UseVisualStyleBackColor = false;
            tambahPengajuanbutton.Click += tambahPengajuanbutton_Click;
            // 
            // pengajuanLayoutPanel
            // 
            pengajuanLayoutPanel.BackColor = Color.Transparent;
            pengajuanLayoutPanel.Location = new Point(239, 12);
            pengajuanLayoutPanel.Name = "pengajuanLayoutPanel";
            pengajuanLayoutPanel.Size = new Size(1099, 603);
            pengajuanLayoutPanel.TabIndex = 25;
            // 
            // kelolaAkunbutton
            // 
            kelolaAkunbutton.BackColor = Color.Transparent;
            kelolaAkunbutton.FlatAppearance.BorderSize = 0;
            kelolaAkunbutton.FlatStyle = FlatStyle.Flat;
            kelolaAkunbutton.Location = new Point(12, 672);
            kelolaAkunbutton.Name = "kelolaAkunbutton";
            kelolaAkunbutton.Size = new Size(45, 46);
            kelolaAkunbutton.TabIndex = 26;
            kelolaAkunbutton.UseVisualStyleBackColor = false;
            kelolaAkunbutton.Click += kelolaAkunbutton_Click;
            // 
            // V_pengajuanSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(kelolaAkunbutton);
            Controls.Add(pengajuanLayoutPanel);
            Controls.Add(tambahPengajuanbutton);
            Controls.Add(riwayatSetorbutton);
            Controls.Add(setorSupplyButton);
            Controls.Add(dashboardButton);
            DoubleBuffered = true;
            Name = "V_pengajuanSupplier";
            Text = "pengajuanSuplier";
            Load += V_pengajuanSupplier_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button riwayatSetorbutton;
        private Button setorSupplyButton;
        private Button dashboardButton;
        private Button tambahPengajuanbutton;
        private FlowLayoutPanel pengajuanLayoutPanel;
        private Button kelolaAkunbutton;
    }
}