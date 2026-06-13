namespace Sak_Gabah.Views
{
    partial class V_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_register));
            emailtextBox = new TextBox();
            usernametextBox = new TextBox();
            passwordtextBox = new TextBox();
            signInbutton = new Button();
            signUpbutton = new Button();
            visiblebutton = new Button();
            SuspendLayout();
            // 
            // emailtextBox
            // 
            emailtextBox.BackColor = SystemColors.Menu;
            emailtextBox.BorderStyle = BorderStyle.None;
            emailtextBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            emailtextBox.ForeColor = SystemColors.GrayText;
            emailtextBox.Location = new Point(970, 258);
            emailtextBox.Multiline = true;
            emailtextBox.Name = "emailtextBox";
            emailtextBox.PlaceholderText = "Email";
            emailtextBox.Size = new Size(202, 28);
            emailtextBox.TabIndex = 0;
            // 
            // usernametextBox
            // 
            usernametextBox.BackColor = SystemColors.Menu;
            usernametextBox.BorderStyle = BorderStyle.None;
            usernametextBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            usernametextBox.ForeColor = SystemColors.GrayText;
            usernametextBox.Location = new Point(970, 326);
            usernametextBox.Multiline = true;
            usernametextBox.Name = "usernametextBox";
            usernametextBox.PlaceholderText = "Username";
            usernametextBox.Size = new Size(202, 28);
            usernametextBox.TabIndex = 0;
            // 
            // passwordtextBox
            // 
            passwordtextBox.BackColor = SystemColors.Menu;
            passwordtextBox.BorderStyle = BorderStyle.None;
            passwordtextBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            passwordtextBox.ForeColor = SystemColors.GrayText;
            passwordtextBox.Location = new Point(970, 393);
            passwordtextBox.Multiline = true;
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.PasswordChar = '*';
            passwordtextBox.PlaceholderText = "Password";
            passwordtextBox.Size = new Size(163, 28);
            passwordtextBox.TabIndex = 0;
            // 
            // signInbutton
            // 
            signInbutton.BackColor = Color.Transparent;
            signInbutton.FlatAppearance.BorderSize = 0;
            signInbutton.FlatStyle = FlatStyle.Flat;
            signInbutton.ForeColor = Color.Transparent;
            signInbutton.Location = new Point(938, 594);
            signInbutton.Name = "signInbutton";
            signInbutton.Size = new Size(239, 34);
            signInbutton.TabIndex = 3;
            signInbutton.UseVisualStyleBackColor = false;
            signInbutton.Click += signInbutton_Click;
            // 
            // signUpbutton
            // 
            signUpbutton.BackColor = Color.Transparent;
            signUpbutton.FlatAppearance.BorderSize = 0;
            signUpbutton.FlatStyle = FlatStyle.Flat;
            signUpbutton.ForeColor = Color.Transparent;
            signUpbutton.Location = new Point(948, 520);
            signUpbutton.Name = "signUpbutton";
            signUpbutton.Size = new Size(214, 43);
            signUpbutton.TabIndex = 3;
            signUpbutton.UseVisualStyleBackColor = false;
            signUpbutton.Click += signUpbutton_Click_1;
            // 
            // visiblebutton
            // 
            visiblebutton.BackColor = Color.Transparent;
            visiblebutton.BackgroundImage = Properties.Resources.EyeClosed;
            visiblebutton.BackgroundImageLayout = ImageLayout.Stretch;
            visiblebutton.Location = new Point(1137, 389);
            visiblebutton.Name = "visiblebutton";
            visiblebutton.Size = new Size(35, 36);
            visiblebutton.TabIndex = 4;
            visiblebutton.UseVisualStyleBackColor = false;
            visiblebutton.Click += visiblebutton_Click;
            // 
            // V_register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(visiblebutton);
            Controls.Add(signUpbutton);
            Controls.Add(signInbutton);
            Controls.Add(passwordtextBox);
            Controls.Add(usernametextBox);
            Controls.Add(emailtextBox);
            DoubleBuffered = true;
            Name = "V_register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailtextBox;
        private TextBox usernametextBox;
        private TextBox passwordtextBox;
        private Button signInbutton;
        private Button signUpbutton;
        private Button visiblebutton;
    }
}