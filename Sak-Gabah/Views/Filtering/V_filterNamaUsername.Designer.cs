namespace Sak_Gabah.Views.Admin
{
    partial class V_filterNama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_filterNama));
            batalbutton = new Button();
            caributton = new Button();
            namaUsernametextBox = new TextBox();
            SuspendLayout();
            // 
            // batalbutton
            // 
            batalbutton.BackColor = Color.Transparent;
            batalbutton.FlatAppearance.BorderSize = 0;
            batalbutton.FlatStyle = FlatStyle.Flat;
            batalbutton.Location = new Point(41, 188);
            batalbutton.Name = "batalbutton";
            batalbutton.Size = new Size(145, 70);
            batalbutton.TabIndex = 0;
            batalbutton.UseVisualStyleBackColor = false;
            batalbutton.Click += batalbutton_Click;
            // 
            // caributton
            // 
            caributton.BackColor = Color.Transparent;
            caributton.FlatAppearance.BorderSize = 0;
            caributton.FlatStyle = FlatStyle.Flat;
            caributton.Location = new Point(217, 190);
            caributton.Name = "caributton";
            caributton.Size = new Size(144, 70);
            caributton.TabIndex = 1;
            caributton.UseVisualStyleBackColor = false;
            caributton.Click += button2_Click;
            // 
            // namaUsernametextBox
            // 
            namaUsernametextBox.BorderStyle = BorderStyle.None;
            namaUsernametextBox.Location = new Point(85, 90);
            namaUsernametextBox.Multiline = true;
            namaUsernametextBox.Name = "namaUsernametextBox";
            namaUsernametextBox.Size = new Size(230, 52);
            namaUsernametextBox.TabIndex = 2;
            // 
            // V_filterNamaKomoditas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(402, 299);
            Controls.Add(namaUsernametextBox);
            Controls.Add(caributton);
            Controls.Add(batalbutton);
            Name = "V_filterNamaKomoditas";
            Text = "Filter_Nama_Username";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button batalbutton;
        private Button caributton;
        private TextBox namaUsernametextBox;
    }
}