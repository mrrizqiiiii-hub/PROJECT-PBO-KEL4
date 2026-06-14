namespace Sak_Gabah.Views.Admin
{
    partial class V_tambahtransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_tambahtransaksi));
            customercomboBox = new ComboBox();
            komoditascomboBox = new ComboBox();
            merkcomboBox = new ComboBox();
            metodeBayarcomboBox = new ComboBox();
            namaCustomertextBox = new TextBox();
            kuantitastextBox = new TextBox();
            tambahbutton = new Button();
            batalbutton = new Button();
            noTelpontextBox = new TextBox();
            alamattextBox = new TextBox();
            SuspendLayout();
            // 
            // customercomboBox
            // 
            customercomboBox.FormattingEnabled = true;
            customercomboBox.Location = new Point(53, 102);
            customercomboBox.Name = "customercomboBox";
            customercomboBox.Size = new Size(158, 23);
            customercomboBox.TabIndex = 0;
            customercomboBox.SelectedIndexChanged += customercomboBox_SelectedIndexChanged;
            // 
            // komoditascomboBox
            // 
            komoditascomboBox.FormattingEnabled = true;
            komoditascomboBox.Location = new Point(277, 199);
            komoditascomboBox.Name = "komoditascomboBox";
            komoditascomboBox.Size = new Size(158, 23);
            komoditascomboBox.TabIndex = 1;
            komoditascomboBox.SelectedIndexChanged += komoditascomboBox_SelectedIndexChanged;
            // 
            // merkcomboBox
            // 
            merkcomboBox.FormattingEnabled = true;
            merkcomboBox.Location = new Point(277, 301);
            merkcomboBox.Name = "merkcomboBox";
            merkcomboBox.Size = new Size(158, 23);
            merkcomboBox.TabIndex = 2;
            // 
            // metodeBayarcomboBox
            // 
            metodeBayarcomboBox.FormattingEnabled = true;
            metodeBayarcomboBox.Location = new Point(277, 400);
            metodeBayarcomboBox.Name = "metodeBayarcomboBox";
            metodeBayarcomboBox.Size = new Size(158, 23);
            metodeBayarcomboBox.TabIndex = 3;
            // 
            // namaCustomertextBox
            // 
            namaCustomertextBox.BackColor = SystemColors.Window;
            namaCustomertextBox.BorderStyle = BorderStyle.None;
            namaCustomertextBox.Font = new Font("Century Gothic", 12F);
            namaCustomertextBox.ForeColor = SystemColors.MenuText;
            namaCustomertextBox.Location = new Point(48, 196);
            namaCustomertextBox.Multiline = true;
            namaCustomertextBox.Name = "namaCustomertextBox";
            namaCustomertextBox.Size = new Size(169, 33);
            namaCustomertextBox.TabIndex = 4;
            // 
            // kuantitastextBox
            // 
            kuantitastextBox.BackColor = SystemColors.Window;
            kuantitastextBox.BorderStyle = BorderStyle.None;
            kuantitastextBox.Font = new Font("Century Gothic", 12F);
            kuantitastextBox.ForeColor = SystemColors.MenuText;
            kuantitastextBox.Location = new Point(271, 95);
            kuantitastextBox.Multiline = true;
            kuantitastextBox.Name = "kuantitastextBox";
            kuantitastextBox.Size = new Size(169, 33);
            kuantitastextBox.TabIndex = 4;
            // 
            // tambahbutton
            // 
            tambahbutton.BackColor = Color.Transparent;
            tambahbutton.BackgroundImageLayout = ImageLayout.Center;
            tambahbutton.FlatAppearance.BorderSize = 0;
            tambahbutton.FlatStyle = FlatStyle.Flat;
            tambahbutton.ForeColor = Color.Transparent;
            tambahbutton.Location = new Point(272, 465);
            tambahbutton.Name = "tambahbutton";
            tambahbutton.Size = new Size(137, 54);
            tambahbutton.TabIndex = 5;
            tambahbutton.UseVisualStyleBackColor = false;
            tambahbutton.Click += tambahbutton_Click;
            // 
            // batalbutton
            // 
            batalbutton.BackColor = Color.Transparent;
            batalbutton.BackgroundImageLayout = ImageLayout.Center;
            batalbutton.FlatAppearance.BorderSize = 0;
            batalbutton.FlatStyle = FlatStyle.Flat;
            batalbutton.ForeColor = Color.Transparent;
            batalbutton.Location = new Point(63, 465);
            batalbutton.Name = "batalbutton";
            batalbutton.Size = new Size(137, 54);
            batalbutton.TabIndex = 5;
            batalbutton.UseVisualStyleBackColor = false;
            batalbutton.Click += batalbutton_Click;
            // 
            // noTelpontextBox
            // 
            noTelpontextBox.BackColor = SystemColors.Window;
            noTelpontextBox.BorderStyle = BorderStyle.None;
            noTelpontextBox.Font = new Font("Century Gothic", 12F);
            noTelpontextBox.ForeColor = SystemColors.MenuText;
            noTelpontextBox.Location = new Point(43, 296);
            noTelpontextBox.Multiline = true;
            noTelpontextBox.Name = "noTelpontextBox";
            noTelpontextBox.Size = new Size(169, 33);
            noTelpontextBox.TabIndex = 4;
            // 
            // alamattextBox
            // 
            alamattextBox.BackColor = SystemColors.Window;
            alamattextBox.BorderStyle = BorderStyle.None;
            alamattextBox.Font = new Font("Century Gothic", 12F);
            alamattextBox.ForeColor = SystemColors.MenuText;
            alamattextBox.Location = new Point(42, 395);
            alamattextBox.Multiline = true;
            alamattextBox.Name = "alamattextBox";
            alamattextBox.Size = new Size(169, 33);
            alamattextBox.TabIndex = 4;
            // 
            // V_tambahtransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(473, 554);
            Controls.Add(batalbutton);
            Controls.Add(tambahbutton);
            Controls.Add(kuantitastextBox);
            Controls.Add(alamattextBox);
            Controls.Add(noTelpontextBox);
            Controls.Add(namaCustomertextBox);
            Controls.Add(metodeBayarcomboBox);
            Controls.Add(merkcomboBox);
            Controls.Add(komoditascomboBox);
            Controls.Add(customercomboBox);
            Name = "V_tambahtransaksi";
            Text = "Tambahtransaksi";
            Load += V_tambahtransaksi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox customercomboBox;
        private ComboBox komoditascomboBox;
        private ComboBox merkcomboBox;
        private ComboBox metodeBayarcomboBox;
        private TextBox namaCustomertextBox;
        private TextBox kuantitastextBox;
        private Button tambahbutton;
        private Button batalbutton;
        private TextBox noTelpontextBox;
        private TextBox alamattextBox;
    }
}