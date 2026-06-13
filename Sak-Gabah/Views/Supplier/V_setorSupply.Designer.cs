namespace Sak_Gabah.Views
{
    partial class V_setorSupply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_setorSupply));
            setoranLayoutPanel = new FlowLayoutPanel();
            tambahSetoranbutton = new Button();
            riwayatSetorbutton = new Button();
            pengajuanSupplierButton = new Button();
            dashboardButton = new Button();
            SuspendLayout();
            // 
            // setoranLayoutPanel
            // 
            setoranLayoutPanel.BackColor = Color.Transparent;
            setoranLayoutPanel.Location = new Point(238, 12);
            setoranLayoutPanel.Name = "setoranLayoutPanel";
            setoranLayoutPanel.Size = new Size(1099, 603);
            setoranLayoutPanel.TabIndex = 30;
            // 
            // tambahSetoranbutton
            // 
            tambahSetoranbutton.BackColor = Color.Transparent;
            tambahSetoranbutton.FlatAppearance.BorderSize = 0;
            tambahSetoranbutton.FlatStyle = FlatStyle.Flat;
            tambahSetoranbutton.Location = new Point(238, 624);
            tambahSetoranbutton.Name = "tambahSetoranbutton";
            tambahSetoranbutton.Size = new Size(203, 81);
            tambahSetoranbutton.TabIndex = 26;
            tambahSetoranbutton.UseVisualStyleBackColor = false;
            tambahSetoranbutton.Click += tambahSetoranbutton_Click;
            // 
            // riwayatSetorbutton
            // 
            riwayatSetorbutton.BackColor = Color.Transparent;
            riwayatSetorbutton.FlatAppearance.BorderSize = 0;
            riwayatSetorbutton.FlatStyle = FlatStyle.Flat;
            riwayatSetorbutton.Location = new Point(24, 205);
            riwayatSetorbutton.Name = "riwayatSetorbutton";
            riwayatSetorbutton.Size = new Size(130, 41);
            riwayatSetorbutton.TabIndex = 27;
            riwayatSetorbutton.UseVisualStyleBackColor = false;
            riwayatSetorbutton.Click += riwayatSetorbutton_Click;
            // 
            // pengajuanSupplierButton
            // 
            pengajuanSupplierButton.BackColor = Color.Transparent;
            pengajuanSupplierButton.FlatAppearance.BorderSize = 0;
            pengajuanSupplierButton.FlatStyle = FlatStyle.Flat;
            pengajuanSupplierButton.Location = new Point(20, 110);
            pengajuanSupplierButton.Name = "pengajuanSupplierButton";
            pengajuanSupplierButton.Size = new Size(130, 41);
            pengajuanSupplierButton.TabIndex = 28;
            pengajuanSupplierButton.UseVisualStyleBackColor = false;
            pengajuanSupplierButton.Click += pengajuanSupplierButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.Transparent;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Location = new Point(21, 63);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(130, 41);
            dashboardButton.TabIndex = 29;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // V_setorSupply
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(setoranLayoutPanel);
            Controls.Add(tambahSetoranbutton);
            Controls.Add(riwayatSetorbutton);
            Controls.Add(pengajuanSupplierButton);
            Controls.Add(dashboardButton);
            DoubleBuffered = true;
            Name = "V_setorSupply";
            Text = "Setor_Supplier";
            Load += V_setorSupply_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel setoranLayoutPanel;
        private Button tambahSetoranbutton;
        private Button riwayatSetorbutton;
        private Button pengajuanSupplierButton;
        private Button dashboardButton;
    }
}