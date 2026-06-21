namespace Sak_Gabah.Views.Admin
{
    partial class V_kelolaAkun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_kelolaAkun));
            emailtextBox = new TextBox();
            kembalibutton = new Button();
            gantiPasswordbutton = new Button();
            simpanPerubahabutton = new Button();
            alamattextBox = new TextBox();
            noTelpontextBox = new TextBox();
            namaLengkaptextBox = new TextBox();
            usernametextBox = new TextBox();
            SuspendLayout();
            // 
            // emailtextBox
            // 
            emailtextBox.BackColor = SystemColors.ControlLightLight;
            emailtextBox.BorderStyle = BorderStyle.None;
            emailtextBox.Font = new Font("Century Gothic", 12F);
            emailtextBox.Location = new Point(53, 198);
            emailtextBox.Multiline = true;
            emailtextBox.Name = "emailtextBox";
            emailtextBox.ReadOnly = true;
            emailtextBox.Size = new Size(155, 34);
            emailtextBox.TabIndex = 0;
            emailtextBox.Text = "Blabla@gmail.com";
            emailtextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // kembalibutton
            // 
            kembalibutton.BackColor = Color.Transparent;
            kembalibutton.FlatAppearance.BorderSize = 0;
            kembalibutton.FlatStyle = FlatStyle.Flat;
            kembalibutton.ForeColor = Color.Transparent;
            kembalibutton.Location = new Point(71, 437);
            kembalibutton.Name = "kembalibutton";
            kembalibutton.Size = new Size(98, 44);
            kembalibutton.TabIndex = 8;
            kembalibutton.UseVisualStyleBackColor = false;
            kembalibutton.Click += kembalibutton_Click;
            // 
            // gantiPasswordbutton
            // 
            gantiPasswordbutton.BackColor = Color.Transparent;
            gantiPasswordbutton.FlatAppearance.BorderSize = 0;
            gantiPasswordbutton.FlatStyle = FlatStyle.Flat;
            gantiPasswordbutton.ForeColor = Color.Transparent;
            gantiPasswordbutton.Location = new Point(184, 438);
            gantiPasswordbutton.Name = "gantiPasswordbutton";
            gantiPasswordbutton.Size = new Size(98, 44);
            gantiPasswordbutton.TabIndex = 9;
            gantiPasswordbutton.UseVisualStyleBackColor = false;
            gantiPasswordbutton.Click += gantiPasswordbutton_Click;
            // 
            // simpanPerubahabutton
            // 
            simpanPerubahabutton.BackColor = Color.Transparent;
            simpanPerubahabutton.FlatAppearance.BorderSize = 0;
            simpanPerubahabutton.FlatStyle = FlatStyle.Flat;
            simpanPerubahabutton.ForeColor = Color.Transparent;
            simpanPerubahabutton.Location = new Point(303, 438);
            simpanPerubahabutton.Name = "simpanPerubahabutton";
            simpanPerubahabutton.Size = new Size(98, 44);
            simpanPerubahabutton.TabIndex = 10;
            simpanPerubahabutton.UseVisualStyleBackColor = false;
            simpanPerubahabutton.Click += simpanPerubahabutton_Click;
            // 
            // alamattextBox
            // 
            alamattextBox.BorderStyle = BorderStyle.None;
            alamattextBox.Font = new Font("Century Gothic", 12F);
            alamattextBox.Location = new Point(53, 361);
            alamattextBox.Multiline = true;
            alamattextBox.Name = "alamattextBox";
            alamattextBox.Size = new Size(368, 34);
            alamattextBox.TabIndex = 0;
            alamattextBox.Text = "Tegal Besar";
            alamattextBox.TextAlign = HorizontalAlignment.Center;
            alamattextBox.TextChanged += textBox2_TextChanged;
            // 
            // noTelpontextBox
            // 
            noTelpontextBox.BorderStyle = BorderStyle.None;
            noTelpontextBox.Font = new Font("Century Gothic", 12F);
            noTelpontextBox.Location = new Point(273, 277);
            noTelpontextBox.Multiline = true;
            noTelpontextBox.Name = "noTelpontextBox";
            noTelpontextBox.Size = new Size(155, 34);
            noTelpontextBox.TabIndex = 0;
            noTelpontextBox.Text = "0852";
            noTelpontextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // namaLengkaptextBox
            // 
            namaLengkaptextBox.BorderStyle = BorderStyle.None;
            namaLengkaptextBox.Font = new Font("Century Gothic", 12F);
            namaLengkaptextBox.Location = new Point(273, 198);
            namaLengkaptextBox.Multiline = true;
            namaLengkaptextBox.Name = "namaLengkaptextBox";
            namaLengkaptextBox.Size = new Size(155, 34);
            namaLengkaptextBox.TabIndex = 0;
            namaLengkaptextBox.Text = "Nabil Amin";
            namaLengkaptextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // usernametextBox
            // 
            usernametextBox.BorderStyle = BorderStyle.None;
            usernametextBox.Font = new Font("Century Gothic", 12F);
            usernametextBox.Location = new Point(53, 277);
            usernametextBox.Multiline = true;
            usernametextBox.Name = "usernametextBox";
            usernametextBox.Size = new Size(155, 34);
            usernametextBox.TabIndex = 11;
            usernametextBox.Text = "Abing";
            usernametextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // V_kelolaAkun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(472, 516);
            Controls.Add(usernametextBox);
            Controls.Add(simpanPerubahabutton);
            Controls.Add(gantiPasswordbutton);
            Controls.Add(kembalibutton);
            Controls.Add(alamattextBox);
            Controls.Add(namaLengkaptextBox);
            Controls.Add(noTelpontextBox);
            Controls.Add(emailtextBox);
            Name = "V_kelolaAkun";
            Text = "KelolaAkun";
            Load += V_kelolaAkun_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailtextBox;
        private Button kembalibutton;
        private Button gantiPasswordbutton;
        private Button simpanPerubahabutton;
        private TextBox alamattextBox;
        private TextBox noTelpontextBox;
        private TextBox namaLengkaptextBox;
        private TextBox usernametextBox;
    }
}