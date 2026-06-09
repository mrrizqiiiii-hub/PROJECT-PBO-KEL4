namespace Sak_Gabah.Views.Admin
{
    partial class V_tambahKomoditas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_tambahKomoditas));
            maksimalStoktextBox = new TextBox();
            namaKomoditastextBox = new TextBox();
            maksimalSuppliertextBox = new TextBox();
            tambahbutton = new Button();
            batalbutton = new Button();
            SuspendLayout();
            // 
            // maksimalStoktextBox
            // 
            maksimalStoktextBox.BorderStyle = BorderStyle.None;
            maksimalStoktextBox.Location = new Point(87, 170);
            maksimalStoktextBox.Multiline = true;
            maksimalStoktextBox.Name = "maksimalStoktextBox";
            maksimalStoktextBox.Size = new Size(232, 33);
            maksimalStoktextBox.TabIndex = 0;
            // 
            // namaKomoditastextBox
            // 
            namaKomoditastextBox.BorderStyle = BorderStyle.None;
            namaKomoditastextBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namaKomoditastextBox.Location = new Point(87, 70);
            namaKomoditastextBox.Multiline = true;
            namaKomoditastextBox.Name = "namaKomoditastextBox";
            namaKomoditastextBox.Size = new Size(232, 33);
            namaKomoditastextBox.TabIndex = 1;
            // 
            // maksimalSuppliertextBox
            // 
            maksimalSuppliertextBox.BorderStyle = BorderStyle.None;
            maksimalSuppliertextBox.Location = new Point(87, 274);
            maksimalSuppliertextBox.Multiline = true;
            maksimalSuppliertextBox.Name = "maksimalSuppliertextBox";
            maksimalSuppliertextBox.Size = new Size(232, 33);
            maksimalSuppliertextBox.TabIndex = 2;
            // 
            // tambahbutton
            // 
            tambahbutton.BackColor = Color.Transparent;
            tambahbutton.FlatAppearance.BorderSize = 0;
            tambahbutton.FlatStyle = FlatStyle.Flat;
            tambahbutton.ForeColor = Color.Transparent;
            tambahbutton.Location = new Point(212, 361);
            tambahbutton.Name = "tambahbutton";
            tambahbutton.Size = new Size(153, 63);
            tambahbutton.TabIndex = 4;
            tambahbutton.UseVisualStyleBackColor = false;
            tambahbutton.Click += tambahbutton_Click;
            // 
            // batalbutton
            // 
            batalbutton.BackColor = Color.Transparent;
            batalbutton.FlatAppearance.BorderSize = 0;
            batalbutton.FlatStyle = FlatStyle.Flat;
            batalbutton.ForeColor = Color.Transparent;
            batalbutton.Location = new Point(38, 361);
            batalbutton.Name = "batalbutton";
            batalbutton.Size = new Size(153, 63);
            batalbutton.TabIndex = 4;
            batalbutton.UseVisualStyleBackColor = false;
            batalbutton.Click += batalbutton_Click;
            // 
            // V_tambahKomoditas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(403, 445);
            Controls.Add(batalbutton);
            Controls.Add(tambahbutton);
            Controls.Add(maksimalSuppliertextBox);
            Controls.Add(namaKomoditastextBox);
            Controls.Add(maksimalStoktextBox);
            Name = "V_tambahKomoditas";
            Text = "TambahKomoditas";
            Load += TambahKomoditas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox maksimalStoktextBox;
        private TextBox namaKomoditastextBox;
        private TextBox maksimalSuppliertextBox;
        private Button tambahbutton;
        private Button batalbutton;
    }
}