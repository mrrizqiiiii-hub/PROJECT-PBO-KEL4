namespace Sak_Gabah.Views.Supplier
{
    partial class V_editPengajuanSetoran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_editPengajuanSetoran));
            jumlahStoktextBox = new TextBox();
            tambahbutton = new Button();
            batalbutton = new Button();
            merkeditcomboBox = new ComboBox();
            SuspendLayout();
            // 
            // jumlahStoktextBox
            // 
            jumlahStoktextBox.BorderStyle = BorderStyle.None;
            jumlahStoktextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jumlahStoktextBox.Location = new Point(91, 146);
            jumlahStoktextBox.Multiline = true;
            jumlahStoktextBox.Name = "jumlahStoktextBox";
            jumlahStoktextBox.Size = new Size(328, 43);
            jumlahStoktextBox.TabIndex = 5;
            jumlahStoktextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // tambahbutton
            // 
            tambahbutton.BackColor = Color.Transparent;
            tambahbutton.BackgroundImageLayout = ImageLayout.None;
            tambahbutton.FlatAppearance.BorderSize = 0;
            tambahbutton.FlatStyle = FlatStyle.Flat;
            tambahbutton.ForeColor = Color.Transparent;
            tambahbutton.Location = new Point(264, 221);
            tambahbutton.Name = "tambahbutton";
            tambahbutton.Size = new Size(132, 60);
            tambahbutton.TabIndex = 8;
            tambahbutton.UseVisualStyleBackColor = false;
            tambahbutton.Click += tambahbutton_Click;
            // 
            // batalbutton
            // 
            batalbutton.BackColor = Color.Transparent;
            batalbutton.BackgroundImageLayout = ImageLayout.None;
            batalbutton.FlatAppearance.BorderSize = 0;
            batalbutton.FlatStyle = FlatStyle.Flat;
            batalbutton.ForeColor = Color.Transparent;
            batalbutton.Location = new Point(105, 221);
            batalbutton.Name = "batalbutton";
            batalbutton.Size = new Size(129, 60);
            batalbutton.TabIndex = 7;
            batalbutton.UseVisualStyleBackColor = false;
            batalbutton.Click += batalbutton_Click;
            // 
            // merkeditcomboBox
            // 
            merkeditcomboBox.FormattingEnabled = true;
            merkeditcomboBox.Location = new Point(91, 66);
            merkeditcomboBox.Name = "merkeditcomboBox";
            merkeditcomboBox.Size = new Size(328, 23);
            merkeditcomboBox.TabIndex = 9;
            // 
            // V_editPengajuanSetoran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(512, 307);
            Controls.Add(merkeditcomboBox);
            Controls.Add(tambahbutton);
            Controls.Add(batalbutton);
            Controls.Add(jumlahStoktextBox);
            Name = "V_editPengajuanSetoran";
            Text = "V_editPengajuanSetoran";
            Load += V_editPengajuanSetoran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox jumlahStoktextBox;
        private Button tambahbutton;
        private Button batalbutton;
        private ComboBox merkeditcomboBox;
    }
}