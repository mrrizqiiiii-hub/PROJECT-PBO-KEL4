namespace Sak_Gabah.Views.Supplier
{
    partial class V_gantiPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_gantiPassword));
            passwordlamatextBox = new TextBox();
            passwordbarutextBox = new TextBox();
            batalbutton = new Button();
            ubahbutton = new Button();
            SuspendLayout();
            // 
            // passwordlamatextBox
            // 
            passwordlamatextBox.BorderStyle = BorderStyle.None;
            passwordlamatextBox.Font = new Font("Century Gothic", 14.25F);
            passwordlamatextBox.Location = new Point(96, 75);
            passwordlamatextBox.Multiline = true;
            passwordlamatextBox.Name = "passwordlamatextBox";
            passwordlamatextBox.PlaceholderText = "Password Baru";
            passwordlamatextBox.Size = new Size(463, 47);
            passwordlamatextBox.TabIndex = 0;
            passwordlamatextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordbarutextBox
            // 
            passwordbarutextBox.BorderStyle = BorderStyle.None;
            passwordbarutextBox.Font = new Font("Century Gothic", 14.25F);
            passwordbarutextBox.Location = new Point(96, 191);
            passwordbarutextBox.Multiline = true;
            passwordbarutextBox.Name = "passwordbarutextBox";
            passwordbarutextBox.PlaceholderText = "Password Lama";
            passwordbarutextBox.Size = new Size(463, 47);
            passwordbarutextBox.TabIndex = 0;
            passwordbarutextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // batalbutton
            // 
            batalbutton.BackColor = Color.Transparent;
            batalbutton.FlatAppearance.BorderSize = 0;
            batalbutton.FlatStyle = FlatStyle.Flat;
            batalbutton.Location = new Point(132, 282);
            batalbutton.Name = "batalbutton";
            batalbutton.Size = new Size(168, 75);
            batalbutton.TabIndex = 1;
            batalbutton.UseVisualStyleBackColor = false;
            batalbutton.Click += batalbutton_Click;
            // 
            // ubahbutton
            // 
            ubahbutton.BackColor = Color.Transparent;
            ubahbutton.FlatAppearance.BorderSize = 0;
            ubahbutton.FlatStyle = FlatStyle.Flat;
            ubahbutton.Location = new Point(338, 282);
            ubahbutton.Name = "ubahbutton";
            ubahbutton.Size = new Size(168, 75);
            ubahbutton.TabIndex = 1;
            ubahbutton.UseVisualStyleBackColor = false;
            ubahbutton.Click += ubahbutton_Click;
            // 
            // V_gantiPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(652, 392);
            Controls.Add(ubahbutton);
            Controls.Add(batalbutton);
            Controls.Add(passwordbarutextBox);
            Controls.Add(passwordlamatextBox);
            Name = "V_gantiPassword";
            Text = "V_GantiPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordlamatextBox;
        private TextBox passwordbarutextBox;
        private Button batalbutton;
        private Button ubahbutton;
    }
}