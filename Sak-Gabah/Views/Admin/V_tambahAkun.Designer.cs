namespace Sak_Gabah.Views.Admin
{
    partial class V_tambahAkun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_tambahAkun));
            usernametextBox = new TextBox();
            namaKaryawantextBox = new TextBox();
            nomorTelepontextBox = new TextBox();
            batalbutton = new Button();
            tambahbutton = new Button();
            emailtextBox = new TextBox();
            SuspendLayout();
            // 
            // usernametextBox
            // 
            usernametextBox.BorderStyle = BorderStyle.None;
            usernametextBox.Font = new Font("Century Gothic", 12F);
            usernametextBox.Location = new Point(62, 53);
            usernametextBox.Multiline = true;
            usernametextBox.Name = "usernametextBox";
            usernametextBox.PlaceholderText = "WAJIB DIISI";
            usernametextBox.Size = new Size(235, 29);
            usernametextBox.TabIndex = 0;
            usernametextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // namaKaryawantextBox
            // 
            namaKaryawantextBox.BorderStyle = BorderStyle.None;
            namaKaryawantextBox.Font = new Font("Century Gothic", 12F);
            namaKaryawantextBox.Location = new Point(62, 127);
            namaKaryawantextBox.Multiline = true;
            namaKaryawantextBox.Name = "namaKaryawantextBox";
            namaKaryawantextBox.PlaceholderText = "WAJIB DIISI";
            namaKaryawantextBox.Size = new Size(235, 29);
            namaKaryawantextBox.TabIndex = 1;
            namaKaryawantextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // nomorTelepontextBox
            // 
            nomorTelepontextBox.BorderStyle = BorderStyle.None;
            nomorTelepontextBox.Font = new Font("Century Gothic", 12F);
            nomorTelepontextBox.Location = new Point(62, 201);
            nomorTelepontextBox.Multiline = true;
            nomorTelepontextBox.Name = "nomorTelepontextBox";
            nomorTelepontextBox.PlaceholderText = "WAJIB DIISI";
            nomorTelepontextBox.Size = new Size(235, 29);
            nomorTelepontextBox.TabIndex = 2;
            nomorTelepontextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // batalbutton
            // 
            batalbutton.BackColor = Color.Transparent;
            batalbutton.FlatAppearance.BorderSize = 0;
            batalbutton.FlatStyle = FlatStyle.Flat;
            batalbutton.ForeColor = Color.Transparent;
            batalbutton.Location = new Point(36, 335);
            batalbutton.Name = "batalbutton";
            batalbutton.Size = new Size(129, 52);
            batalbutton.TabIndex = 5;
            batalbutton.UseVisualStyleBackColor = false;
            batalbutton.Click += batalbutton_Click;
            // 
            // tambahbutton
            // 
            tambahbutton.BackColor = Color.Transparent;
            tambahbutton.FlatAppearance.BorderSize = 0;
            tambahbutton.FlatStyle = FlatStyle.Flat;
            tambahbutton.ForeColor = Color.Transparent;
            tambahbutton.Location = new Point(191, 335);
            tambahbutton.Name = "tambahbutton";
            tambahbutton.Size = new Size(129, 52);
            tambahbutton.TabIndex = 6;
            tambahbutton.UseVisualStyleBackColor = false;
            tambahbutton.Click += tambahbutton_Click;
            // 
            // emailtextBox
            // 
            emailtextBox.BorderStyle = BorderStyle.None;
            emailtextBox.Font = new Font("Century Gothic", 12F);
            emailtextBox.Location = new Point(62, 275);
            emailtextBox.Multiline = true;
            emailtextBox.Name = "emailtextBox";
            emailtextBox.PlaceholderText = "WAJIB DIISI";
            emailtextBox.Size = new Size(235, 29);
            emailtextBox.TabIndex = 7;
            emailtextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // V_tambahAkun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(356, 409);
            Controls.Add(emailtextBox);
            Controls.Add(batalbutton);
            Controls.Add(tambahbutton);
            Controls.Add(nomorTelepontextBox);
            Controls.Add(namaKaryawantextBox);
            Controls.Add(usernametextBox);
            Name = "V_tambahAkun";
            Text = "TambahAkun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernametextBox;
        private TextBox namaKaryawantextBox;
        private TextBox nomorTelepontextBox;
        private Button batalbutton;
        private Button tambahbutton;
        private TextBox emailtextBox;
    }
}