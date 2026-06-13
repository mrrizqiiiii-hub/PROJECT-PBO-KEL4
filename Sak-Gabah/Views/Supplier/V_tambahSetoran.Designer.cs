namespace Sak_Gabah.Views.Admin
{
    partial class V_tambahSetoran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_tambahSetoran));
            batalbutton = new Button();
            tambahbutton = new Button();
            jumlahStoktextBox = new TextBox();
            merkcomboBox = new ComboBox();
            SuspendLayout();
            // 
            // batalbutton
            // 
            batalbutton.BackColor = Color.Transparent;
            batalbutton.BackgroundImageLayout = ImageLayout.None;
            batalbutton.FlatAppearance.BorderSize = 0;
            batalbutton.FlatStyle = FlatStyle.Flat;
            batalbutton.ForeColor = Color.Transparent;
            batalbutton.Location = new Point(97, 226);
            batalbutton.Name = "batalbutton";
            batalbutton.Size = new Size(123, 60);
            batalbutton.TabIndex = 0;
            batalbutton.UseVisualStyleBackColor = false;
            // 
            // tambahbutton
            // 
            tambahbutton.BackColor = Color.Transparent;
            tambahbutton.BackgroundImageLayout = ImageLayout.None;
            tambahbutton.FlatAppearance.BorderSize = 0;
            tambahbutton.FlatStyle = FlatStyle.Flat;
            tambahbutton.ForeColor = Color.Transparent;
            tambahbutton.Location = new Point(247, 226);
            tambahbutton.Name = "tambahbutton";
            tambahbutton.Size = new Size(123, 60);
            tambahbutton.TabIndex = 1;
            tambahbutton.UseVisualStyleBackColor = false;
            tambahbutton.Click += tambahbutton_Click;
            // 
            // jumlahStoktextBox
            // 
            jumlahStoktextBox.BorderStyle = BorderStyle.None;
            jumlahStoktextBox.Location = new Point(77, 151);
            jumlahStoktextBox.Multiline = true;
            jumlahStoktextBox.Name = "jumlahStoktextBox";
            jumlahStoktextBox.Size = new Size(328, 43);
            jumlahStoktextBox.TabIndex = 3;
            // 
            // merkcomboBox
            // 
            merkcomboBox.FormattingEnabled = true;
            merkcomboBox.Location = new Point(77, 67);
            merkcomboBox.Name = "merkcomboBox";
            merkcomboBox.Size = new Size(328, 23);
            merkcomboBox.TabIndex = 4;
            // 
            // V_tambahSetoran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(476, 314);
            Controls.Add(merkcomboBox);
            Controls.Add(jumlahStoktextBox);
            Controls.Add(tambahbutton);
            Controls.Add(batalbutton);
            Name = "V_tambahSetoran";
            Text = "TambahSetoran";
            Load += V_tambahSetoran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button batalbutton;
        private Button tambahbutton;
        private TextBox textBox;
        private TextBox jumlahStoktextBox;
        private ComboBox merkcomboBox;
    }
}