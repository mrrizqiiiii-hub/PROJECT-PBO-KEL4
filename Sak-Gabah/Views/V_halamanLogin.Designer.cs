namespace Sak_Gabah.Views
{
    partial class V_halamanLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_halamanLogin));
            signInbutton = new Button();
            usernameTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            visiblebutton = new Button();
            viewRegisterbutton = new Button();
            SuspendLayout();
            // 
            // signInbutton
            // 
            signInbutton.BackColor = Color.Transparent;
            signInbutton.FlatAppearance.BorderSize = 0;
            signInbutton.FlatStyle = FlatStyle.Flat;
            signInbutton.ForeColor = Color.Transparent;
            signInbutton.Location = new Point(947, 434);
            signInbutton.Name = "signInbutton";
            signInbutton.Size = new Size(214, 45);
            signInbutton.TabIndex = 2;
            signInbutton.UseVisualStyleBackColor = false;
            signInbutton.Click += button1_Click;
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.BackColor = SystemColors.Control;
            usernameTxtBox.BorderStyle = BorderStyle.None;
            usernameTxtBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            usernameTxtBox.ForeColor = SystemColors.ControlDarkDark;
            usernameTxtBox.Location = new Point(965, 270);
            usernameTxtBox.Multiline = true;
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.PlaceholderText = "Username";
            usernameTxtBox.Size = new Size(211, 29);
            usernameTxtBox.TabIndex = 0;
            usernameTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.BackColor = SystemColors.Control;
            passwordTxtBox.BorderStyle = BorderStyle.None;
            passwordTxtBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            passwordTxtBox.ForeColor = SystemColors.ControlDarkDark;
            passwordTxtBox.Location = new Point(965, 348);
            passwordTxtBox.Multiline = true;
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '*';
            passwordTxtBox.PlaceholderText = "Password";
            passwordTxtBox.Size = new Size(174, 29);
            passwordTxtBox.TabIndex = 0;
            passwordTxtBox.Tag = "";
            passwordTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // visiblebutton
            // 
            visiblebutton.BackColor = Color.Transparent;
            visiblebutton.BackgroundImage = Properties.Resources.EyeClosed;
            visiblebutton.BackgroundImageLayout = ImageLayout.Stretch;
            visiblebutton.Location = new Point(1141, 343);
            visiblebutton.Name = "visiblebutton";
            visiblebutton.Size = new Size(35, 36);
            visiblebutton.TabIndex = 3;
            visiblebutton.UseVisualStyleBackColor = false;
            visiblebutton.Click += visiblebutton_Click;
            // 
            // viewRegisterbutton
            // 
            viewRegisterbutton.BackColor = Color.Transparent;
            viewRegisterbutton.FlatAppearance.BorderSize = 0;
            viewRegisterbutton.FlatStyle = FlatStyle.Flat;
            viewRegisterbutton.ForeColor = Color.Transparent;
            viewRegisterbutton.Location = new Point(937, 522);
            viewRegisterbutton.Name = "viewRegisterbutton";
            viewRegisterbutton.Size = new Size(240, 28);
            viewRegisterbutton.TabIndex = 2;
            viewRegisterbutton.UseVisualStyleBackColor = false;
            viewRegisterbutton.Click += viewRegisterbutton_Click;
            // 
            // V_halamanLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(visiblebutton);
            Controls.Add(viewRegisterbutton);
            Controls.Add(signInbutton);
            Controls.Add(passwordTxtBox);
            Controls.Add(usernameTxtBox);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Name = "V_halamanLogin";
            Text = "V_halamanLogin";
            FormClosed += V_halamanLogin_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button signInbutton;
        private TextBox usernameTxtBox;
        private TextBox passwordTxtBox;
        private Button visiblebutton;
        private Button viewRegisterbutton;
    }
}