namespace Sak_Gabah.Views
{
    partial class V_riwayatSetor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_riwayatSetor));
            setorSupplySetorbutton = new Button();
            pengajuanSupplierButton = new Button();
            dashboardButton = new Button();
            filterKomoditasbutton = new Button();
            filterTanggalbutton = new Button();
            setorandataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)setorandataGridView).BeginInit();
            SuspendLayout();
            // 
            // setorSupplySetorbutton
            // 
            setorSupplySetorbutton.BackColor = Color.Transparent;
            setorSupplySetorbutton.FlatAppearance.BorderSize = 0;
            setorSupplySetorbutton.FlatStyle = FlatStyle.Flat;
            setorSupplySetorbutton.Location = new Point(22, 157);
            setorSupplySetorbutton.Name = "setorSupplySetorbutton";
            setorSupplySetorbutton.Size = new Size(130, 41);
            setorSupplySetorbutton.TabIndex = 21;
            setorSupplySetorbutton.UseVisualStyleBackColor = false;
            setorSupplySetorbutton.Click += setorSupplySetorbutton_Click;
            // 
            // pengajuanSupplierButton
            // 
            pengajuanSupplierButton.BackColor = Color.Transparent;
            pengajuanSupplierButton.FlatAppearance.BorderSize = 0;
            pengajuanSupplierButton.FlatStyle = FlatStyle.Flat;
            pengajuanSupplierButton.Location = new Point(22, 110);
            pengajuanSupplierButton.Name = "pengajuanSupplierButton";
            pengajuanSupplierButton.Size = new Size(130, 41);
            pengajuanSupplierButton.TabIndex = 22;
            pengajuanSupplierButton.UseVisualStyleBackColor = false;
            pengajuanSupplierButton.Click += pengajuanSupplierButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.Transparent;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Location = new Point(22, 63);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(130, 41);
            dashboardButton.TabIndex = 23;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // filterKomoditasbutton
            // 
            filterKomoditasbutton.BackColor = Color.Transparent;
            filterKomoditasbutton.FlatAppearance.BorderSize = 0;
            filterKomoditasbutton.FlatStyle = FlatStyle.Flat;
            filterKomoditasbutton.Location = new Point(486, 620);
            filterKomoditasbutton.Name = "filterKomoditasbutton";
            filterKomoditasbutton.Size = new Size(210, 87);
            filterKomoditasbutton.TabIndex = 26;
            filterKomoditasbutton.UseVisualStyleBackColor = false;
            filterKomoditasbutton.Click += filterKomoditasbutton_Click;
            // 
            // filterTanggalbutton
            // 
            filterTanggalbutton.BackColor = Color.Transparent;
            filterTanggalbutton.FlatAppearance.BorderSize = 0;
            filterTanggalbutton.FlatStyle = FlatStyle.Flat;
            filterTanggalbutton.Location = new Point(235, 621);
            filterTanggalbutton.Name = "filterTanggalbutton";
            filterTanggalbutton.Size = new Size(210, 87);
            filterTanggalbutton.TabIndex = 25;
            filterTanggalbutton.UseVisualStyleBackColor = false;
            filterTanggalbutton.Click += filterTanggalbutton_Click;
            // 
            // setorandataGridView
            // 
            setorandataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            setorandataGridView.BackgroundColor = Color.Gainsboro;
            setorandataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            setorandataGridView.Location = new Point(235, 12);
            setorandataGridView.Name = "setorandataGridView";
            setorandataGridView.Size = new Size(1103, 602);
            setorandataGridView.TabIndex = 27;
            // 
            // V_riwayatSetor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(setorandataGridView);
            Controls.Add(filterKomoditasbutton);
            Controls.Add(filterTanggalbutton);
            Controls.Add(setorSupplySetorbutton);
            Controls.Add(pengajuanSupplierButton);
            Controls.Add(dashboardButton);
            DoubleBuffered = true;
            Name = "V_riwayatSetor";
            Text = "Riwayat_Stor";
            Load += V_riwayatSetor_Load;
            ((System.ComponentModel.ISupportInitialize)setorandataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button setorSupplySetorbutton;
        private Button pengajuanSupplierButton;
        private Button dashboardButton;
        private Button filterKomoditasbutton;
        private Button filterTanggalbutton;
        private DataGridView setorandataGridView;
    }
}