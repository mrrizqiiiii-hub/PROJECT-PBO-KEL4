namespace Sak_Gabah.Views.Supplier
{
    partial class V_editPengajuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_editPengajuan));
            merktextBox = new TextBox();
            hargatextBox = new TextBox();
            komoditascomboBox = new ComboBox();
            deskripsitextBox = new TextBox();
            tambahbutton = new Button();
            batalButton = new Button();
            SuspendLayout();
            // 
            // merktextBox
            // 
            merktextBox.BackColor = SystemColors.Window;
            merktextBox.BorderStyle = BorderStyle.None;
            merktextBox.Font = new Font("Century Gothic", 12F);
            merktextBox.ForeColor = SystemColors.MenuText;
            merktextBox.Location = new Point(45, 203);
            merktextBox.Multiline = true;
            merktextBox.Name = "merktextBox";
            merktextBox.PlaceholderText = "MERK";
            merktextBox.Size = new Size(180, 28);
            merktextBox.TabIndex = 30;
            merktextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // hargatextBox
            // 
            hargatextBox.BackColor = SystemColors.Window;
            hargatextBox.BorderStyle = BorderStyle.None;
            hargatextBox.Font = new Font("Century Gothic", 12F);
            hargatextBox.ForeColor = SystemColors.MenuText;
            hargatextBox.Location = new Point(46, 335);
            hargatextBox.Multiline = true;
            hargatextBox.Name = "hargatextBox";
            hargatextBox.PlaceholderText = "HARGA";
            hargatextBox.Size = new Size(180, 28);
            hargatextBox.TabIndex = 31;
            hargatextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // komoditascomboBox
            // 
            komoditascomboBox.FormattingEnabled = true;
            komoditascomboBox.Location = new Point(58, 86);
            komoditascomboBox.Name = "komoditascomboBox";
            komoditascomboBox.Size = new Size(157, 23);
            komoditascomboBox.TabIndex = 29;
            komoditascomboBox.SelectedIndexChanged += komoditascomboBox_SelectedIndexChanged;
            // 
            // deskripsitextBox
            // 
            deskripsitextBox.BackColor = SystemColors.Window;
            deskripsitextBox.BorderStyle = BorderStyle.None;
            deskripsitextBox.Font = new Font("Century Gothic", 12F);
            deskripsitextBox.ForeColor = SystemColors.MenuText;
            deskripsitextBox.Location = new Point(273, 58);
            deskripsitextBox.Multiline = true;
            deskripsitextBox.Name = "deskripsitextBox";
            deskripsitextBox.Size = new Size(199, 311);
            deskripsitextBox.TabIndex = 28;
            // 
            // tambahbutton
            // 
            tambahbutton.BackColor = Color.Transparent;
            tambahbutton.FlatAppearance.BorderSize = 0;
            tambahbutton.FlatStyle = FlatStyle.Flat;
            tambahbutton.Location = new Point(267, 403);
            tambahbutton.Name = "tambahbutton";
            tambahbutton.Size = new Size(137, 62);
            tambahbutton.TabIndex = 32;
            tambahbutton.UseVisualStyleBackColor = false;
            tambahbutton.Click += tambahbutton_Click;
            // 
            // batalButton
            // 
            batalButton.BackColor = Color.Transparent;
            batalButton.FlatAppearance.BorderSize = 0;
            batalButton.FlatStyle = FlatStyle.Flat;
            batalButton.Location = new Point(102, 404);
            batalButton.Name = "batalButton";
            batalButton.Size = new Size(137, 62);
            batalButton.TabIndex = 33;
            batalButton.UseVisualStyleBackColor = false;
            batalButton.Click += batalButton_Click;
            // 
            // V_editPengajuan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(517, 479);
            Controls.Add(tambahbutton);
            Controls.Add(batalButton);
            Controls.Add(merktextBox);
            Controls.Add(hargatextBox);
            Controls.Add(komoditascomboBox);
            Controls.Add(deskripsitextBox);
            Name = "V_editPengajuan";
            Text = "V_editPengajuan";
            Load += V_editPengajuan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox merktextBox;
        private TextBox hargatextBox;
        private ComboBox komoditascomboBox;
        private TextBox deskripsitextBox;
        private Button tambahbutton;
        private Button batalButton;
    }
}