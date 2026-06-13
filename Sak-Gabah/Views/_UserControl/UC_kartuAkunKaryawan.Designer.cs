namespace Sak_Gabah.Views._UserControl
{
    partial class UC_kartuAkunKaryawan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernamelabel = new Label();
            namaLengkaplabel = new Label();
            statusAkunlabel = new Label();
            resetbutton = new Button();
            gantiStatusbutton = new Button();
            SuspendLayout();
            // 
            // usernamelabel
            // 
            usernamelabel.BackColor = Color.ForestGreen;
            usernamelabel.BorderStyle = BorderStyle.Fixed3D;
            usernamelabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernamelabel.ForeColor = Color.PaleGreen;
            usernamelabel.Location = new Point(34, 14);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(235, 46);
            usernamelabel.TabIndex = 19;
            usernamelabel.Text = "USERNAME";
            usernamelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // namaLengkaplabel
            // 
            namaLengkaplabel.BackColor = Color.ForestGreen;
            namaLengkaplabel.BorderStyle = BorderStyle.Fixed3D;
            namaLengkaplabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namaLengkaplabel.ForeColor = Color.PaleGreen;
            namaLengkaplabel.Location = new Point(34, 65);
            namaLengkaplabel.Name = "namaLengkaplabel";
            namaLengkaplabel.Size = new Size(235, 72);
            namaLengkaplabel.TabIndex = 20;
            namaLengkaplabel.Text = "NAMA LENGKAP";
            namaLengkaplabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusAkunlabel
            // 
            statusAkunlabel.BackColor = Color.ForestGreen;
            statusAkunlabel.BorderStyle = BorderStyle.Fixed3D;
            statusAkunlabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusAkunlabel.ForeColor = Color.PaleGreen;
            statusAkunlabel.Location = new Point(34, 142);
            statusAkunlabel.Name = "statusAkunlabel";
            statusAkunlabel.Size = new Size(235, 72);
            statusAkunlabel.TabIndex = 20;
            statusAkunlabel.Text = "STATUS AKUN";
            statusAkunlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resetbutton
            // 
            resetbutton.BackColor = Color.DarkGreen;
            resetbutton.FlatStyle = FlatStyle.Flat;
            resetbutton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetbutton.ForeColor = Color.LightGreen;
            resetbutton.Location = new Point(163, 235);
            resetbutton.Name = "resetbutton";
            resetbutton.Size = new Size(106, 67);
            resetbutton.TabIndex = 29;
            resetbutton.Text = "RESET PASSWORD";
            resetbutton.UseVisualStyleBackColor = false;
            resetbutton.Click += resetbutton_Click;
            // 
            // gantiStatusbutton
            // 
            gantiStatusbutton.BackColor = Color.Red;
            gantiStatusbutton.FlatStyle = FlatStyle.Flat;
            gantiStatusbutton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gantiStatusbutton.ForeColor = Color.LightGreen;
            gantiStatusbutton.Location = new Point(34, 235);
            gantiStatusbutton.Name = "gantiStatusbutton";
            gantiStatusbutton.Size = new Size(112, 67);
            gantiStatusbutton.TabIndex = 29;
            gantiStatusbutton.Text = "NONAKTIF";
            gantiStatusbutton.UseVisualStyleBackColor = false;
            gantiStatusbutton.Click += gantiStatusbutton_Click;
            // 
            // UC_kartuAkunKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            Controls.Add(gantiStatusbutton);
            Controls.Add(resetbutton);
            Controls.Add(statusAkunlabel);
            Controls.Add(namaLengkaplabel);
            Controls.Add(usernamelabel);
            Name = "UC_kartuAkunKaryawan";
            Size = new Size(302, 329);
            ResumeLayout(false);
        }

        #endregion

        private Label usernamelabel;
        private Label namaLengkaplabel;
        private Label statusAkunlabel;
        private Button resetbutton;
        private Button gantiStatusbutton;
    }
}
