namespace Sak_Gabah.Views.Admin
{
    partial class V_tambahPengajuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_tambahPengajuan));
            textBox6 = new TextBox();
            batalButton = new Button();
            tambahbutton = new Button();
            deskripsitextBox = new TextBox();
            komoditascomboBox = new ComboBox();
            hargatextBox = new TextBox();
            merktextBox = new TextBox();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(279, 56);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(199, 311);
            textBox6.TabIndex = 7;
            // 
            // batalButton
            // 
            batalButton.BackColor = Color.Transparent;
            batalButton.FlatAppearance.BorderSize = 0;
            batalButton.FlatStyle = FlatStyle.Flat;
            batalButton.Location = new Point(105, 400);
            batalButton.Name = "batalButton";
            batalButton.Size = new Size(137, 62);
            batalButton.TabIndex = 24;
            batalButton.UseVisualStyleBackColor = false;
            batalButton.Click += batalButton_Click;
            // 
            // tambahbutton
            // 
            tambahbutton.BackColor = Color.Transparent;
            tambahbutton.FlatAppearance.BorderSize = 0;
            tambahbutton.FlatStyle = FlatStyle.Flat;
            tambahbutton.Location = new Point(270, 399);
            tambahbutton.Name = "tambahbutton";
            tambahbutton.Size = new Size(137, 62);
            tambahbutton.TabIndex = 24;
            tambahbutton.UseVisualStyleBackColor = false;
            tambahbutton.Click += tambahbutton_Click;
            // 
            // deskripsitextBox
            // 
            deskripsitextBox.BackColor = SystemColors.Window;
            deskripsitextBox.BorderStyle = BorderStyle.None;
            deskripsitextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deskripsitextBox.ForeColor = SystemColors.MenuText;
            deskripsitextBox.Location = new Point(279, 56);
            deskripsitextBox.Multiline = true;
            deskripsitextBox.Name = "deskripsitextBox";
            deskripsitextBox.Size = new Size(199, 311);
            deskripsitextBox.TabIndex = 25;
            // 
            // komoditascomboBox
            // 
            komoditascomboBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            komoditascomboBox.FormattingEnabled = true;
            komoditascomboBox.Location = new Point(59, 86);
            komoditascomboBox.Name = "komoditascomboBox";
            komoditascomboBox.Size = new Size(157, 25);
            komoditascomboBox.TabIndex = 26;
            komoditascomboBox.SelectedIndexChanged += komoditascomboBox_SelectedIndexChanged;
            // 
            // hargatextBox
            // 
            hargatextBox.BackColor = SystemColors.Window;
            hargatextBox.BorderStyle = BorderStyle.None;
            hargatextBox.Font = new Font("Century Gothic", 15.75F);
            hargatextBox.ForeColor = SystemColors.MenuText;
            hargatextBox.Location = new Point(48, 328);
            hargatextBox.Multiline = true;
            hargatextBox.Name = "hargatextBox";
            hargatextBox.PlaceholderText = "HARGA";
            hargatextBox.Size = new Size(180, 28);
            hargatextBox.TabIndex = 27;
            hargatextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // merktextBox
            // 
            merktextBox.BackColor = SystemColors.Window;
            merktextBox.BorderStyle = BorderStyle.None;
            merktextBox.Font = new Font("Century Gothic", 15.75F);
            merktextBox.ForeColor = SystemColors.MenuText;
            merktextBox.Location = new Point(48, 200);
            merktextBox.Multiline = true;
            merktextBox.Name = "merktextBox";
            merktextBox.PlaceholderText = "MERK";
            merktextBox.Size = new Size(180, 28);
            merktextBox.TabIndex = 27;
            merktextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // V_tambahPengajuan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(525, 474);
            Controls.Add(merktextBox);
            Controls.Add(hargatextBox);
            Controls.Add(komoditascomboBox);
            Controls.Add(deskripsitextBox);
            Controls.Add(tambahbutton);
            Controls.Add(batalButton);
            Controls.Add(textBox6);
            Name = "V_tambahPengajuan";
            Text = "TambahPengajuan";
            Load += V_tambahPengajuan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox6;
        private Button batalButton;
        private Button tambahbutton;
        private TextBox deskripsitextBox;
        private ComboBox komoditascomboBox;
        private TextBox hargatextBox;
        private TextBox merktextBox;
    }
}