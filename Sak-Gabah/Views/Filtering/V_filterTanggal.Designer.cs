namespace Sak_Gabah.Views.Admin
{
    partial class V_filterTanggal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_filterTanggal));
            batalbutton = new Button();
            caributton = new Button();
            tanggalAwalPicker = new DateTimePicker();
            tanggalAkhirPicker = new DateTimePicker();
            SuspendLayout();
            // 
            // batalbutton
            // 
            batalbutton.BackColor = Color.Transparent;
            batalbutton.FlatStyle = FlatStyle.Flat;
            batalbutton.ForeColor = Color.Transparent;
            batalbutton.Location = new Point(40, 315);
            batalbutton.Name = "batalbutton";
            batalbutton.Size = new Size(154, 61);
            batalbutton.TabIndex = 0;
            batalbutton.UseVisualStyleBackColor = false;
            // 
            // caributton
            // 
            caributton.BackColor = Color.Transparent;
            caributton.FlatStyle = FlatStyle.Flat;
            caributton.ForeColor = Color.Transparent;
            caributton.Location = new Point(220, 314);
            caributton.Name = "caributton";
            caributton.Size = new Size(153, 61);
            caributton.TabIndex = 1;
            caributton.UseVisualStyleBackColor = false;
            caributton.Click += caributton_Click;
            // 
            // tanggalAwalPicker
            // 
            tanggalAwalPicker.CalendarFont = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            tanggalAwalPicker.Location = new Point(102, 95);
            tanggalAwalPicker.Name = "tanggalAwalPicker";
            tanggalAwalPicker.Size = new Size(210, 23);
            tanggalAwalPicker.TabIndex = 2;
            // 
            // tanggalAkhirPicker
            // 
            tanggalAkhirPicker.CalendarFont = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            tanggalAkhirPicker.Location = new Point(102, 220);
            tanggalAkhirPicker.Name = "tanggalAkhirPicker";
            tanggalAkhirPicker.Size = new Size(210, 23);
            tanggalAkhirPicker.TabIndex = 3;
            // 
            // V_filterTanggal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(413, 419);
            Controls.Add(tanggalAkhirPicker);
            Controls.Add(tanggalAwalPicker);
            Controls.Add(caributton);
            Controls.Add(batalbutton);
            Name = "V_filterTanggal";
            Text = "FilterTanggal";
            ResumeLayout(false);
        }

        #endregion

        private Button batalbutton;
        private Button caributton;
        private DateTimePicker tanggalAwalPicker;
        private DateTimePicker tanggalAkhirPicker;
    }
}