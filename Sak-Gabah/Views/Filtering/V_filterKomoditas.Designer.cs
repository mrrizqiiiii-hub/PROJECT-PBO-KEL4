namespace Sak_Gabah.Views.Admin
{
    partial class V_filterKomoditas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_filterKomoditas));
            batalbutton = new Button();
            namaKomoditastextBox = new TextBox();
            cariKomoditasbutton = new Button();
            SuspendLayout();
            // 
            // batalbutton
            // 
            batalbutton.BackColor = Color.Transparent;
            batalbutton.BackgroundImageLayout = ImageLayout.Center;
            batalbutton.FlatAppearance.BorderSize = 0;
            batalbutton.FlatStyle = FlatStyle.Flat;
            batalbutton.ForeColor = Color.Transparent;
            batalbutton.Location = new Point(44, 211);
            batalbutton.Name = "batalbutton";
            batalbutton.Size = new Size(153, 82);
            batalbutton.TabIndex = 1;
            batalbutton.UseVisualStyleBackColor = false;
            batalbutton.Click += batalbutton_Click;
            // 
            // namaKomoditastextBox
            // 
            namaKomoditastextBox.BackColor = SystemColors.Window;
            namaKomoditastextBox.BorderStyle = BorderStyle.None;
            namaKomoditastextBox.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namaKomoditastextBox.ForeColor = SystemColors.MenuText;
            namaKomoditastextBox.Location = new Point(98, 103);
            namaKomoditastextBox.Multiline = true;
            namaKomoditastextBox.Name = "namaKomoditastextBox";
            namaKomoditastextBox.Size = new Size(233, 58);
            namaKomoditastextBox.TabIndex = 2;
            namaKomoditastextBox.TextChanged += namaKomoditastextBox_TextChanged;
            // 
            // cariKomoditasbutton
            // 
            cariKomoditasbutton.BackColor = Color.Transparent;
            cariKomoditasbutton.BackgroundImageLayout = ImageLayout.Center;
            cariKomoditasbutton.FlatAppearance.BorderSize = 0;
            cariKomoditasbutton.FlatStyle = FlatStyle.Flat;
            cariKomoditasbutton.ForeColor = Color.Transparent;
            cariKomoditasbutton.Location = new Point(232, 211);
            cariKomoditasbutton.Name = "cariKomoditasbutton";
            cariKomoditasbutton.Size = new Size(153, 82);
            cariKomoditasbutton.TabIndex = 3;
            cariKomoditasbutton.UseVisualStyleBackColor = false;
            cariKomoditasbutton.Click += cariKomoditasbutton_Click;
            // 
            // V_filterKomoditas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(429, 337);
            Controls.Add(cariKomoditasbutton);
            Controls.Add(namaKomoditastextBox);
            Controls.Add(batalbutton);
            DoubleBuffered = true;
            Name = "V_filterKomoditas";
            Text = "CariKomoditas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button batalbutton;
        private TextBox namaKomoditastextBox;
        private Button cariKomoditasbutton;
    }
}