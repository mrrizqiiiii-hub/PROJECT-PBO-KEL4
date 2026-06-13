namespace Sak_Gabah.Views._UserControl
{
    partial class UC_kartuPengajuanSetor
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
            lihatDetailbutton = new Button();
            stoklabel = new Label();
            merkLabel = new Label();
            statuslabel = new Label();
            SuspendLayout();
            // 
            // lihatDetailbutton
            // 
            lihatDetailbutton.BackColor = Color.Green;
            lihatDetailbutton.FlatStyle = FlatStyle.Flat;
            lihatDetailbutton.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lihatDetailbutton.ForeColor = Color.LightGreen;
            lihatDetailbutton.Location = new Point(24, 206);
            lihatDetailbutton.Name = "lihatDetailbutton";
            lihatDetailbutton.Size = new Size(199, 51);
            lihatDetailbutton.TabIndex = 18;
            lihatDetailbutton.Text = "LIHAT";
            lihatDetailbutton.UseVisualStyleBackColor = false;
            lihatDetailbutton.Click += lihatDetailbutton_Click;
            // 
            // stoklabel
            // 
            stoklabel.BackColor = Color.ForestGreen;
            stoklabel.BorderStyle = BorderStyle.Fixed3D;
            stoklabel.Font = new Font("Century Gothic", 18F);
            stoklabel.ForeColor = Color.PaleGreen;
            stoklabel.Location = new Point(24, 77);
            stoklabel.Name = "stoklabel";
            stoklabel.Size = new Size(199, 52);
            stoklabel.TabIndex = 17;
            stoklabel.Text = "STOK";
            stoklabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // merkLabel
            // 
            merkLabel.BackColor = Color.ForestGreen;
            merkLabel.BorderStyle = BorderStyle.Fixed3D;
            merkLabel.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            merkLabel.ForeColor = Color.PaleGreen;
            merkLabel.Location = new Point(20, 17);
            merkLabel.Name = "merkLabel";
            merkLabel.Size = new Size(208, 51);
            merkLabel.TabIndex = 15;
            merkLabel.Text = "Merk";
            merkLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statuslabel
            // 
            statuslabel.BackColor = Color.ForestGreen;
            statuslabel.BorderStyle = BorderStyle.Fixed3D;
            statuslabel.Font = new Font("Century Gothic", 18F);
            statuslabel.ForeColor = Color.PaleGreen;
            statuslabel.Location = new Point(24, 134);
            statuslabel.Name = "statuslabel";
            statuslabel.Size = new Size(199, 52);
            statuslabel.TabIndex = 17;
            statuslabel.Text = "STATUS";
            statuslabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_kartuPengajuanSetor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            Controls.Add(lihatDetailbutton);
            Controls.Add(statuslabel);
            Controls.Add(stoklabel);
            Controls.Add(merkLabel);
            Name = "UC_kartuPengajuanSetor";
            Size = new Size(248, 280);
            ResumeLayout(false);
        }

        #endregion

        private Button lihatDetailbutton;
        private Label stoklabel;
        private Label merklabel;
        private Label merkLabel;
        private Label statuslabel;
    }
}
