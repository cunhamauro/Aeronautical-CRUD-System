namespace Projeto_Aeronautica.UserControls
{
    partial class Login
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
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonSeePassword = new Button();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F);
            textBoxUsername.Location = new Point(36, 47);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Login username";
            textBoxUsername.Size = new Size(190, 29);
            textBoxUsername.TabIndex = 0;
            textBoxUsername.KeyPress += textBoxLogin_KeyPress;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.Location = new Point(36, 114);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Login password";
            textBoxPassword.Size = new Size(190, 29);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.KeyPress += textBoxLogin_KeyPress;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.WhiteSmoke;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.HotTrack;
            buttonLogin.Location = new Point(68, 170);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(121, 33);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(32, 91);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // buttonSeePassword
            // 
            buttonSeePassword.BackColor = SystemColors.HotTrack;
            buttonSeePassword.BackgroundImage = Properties.Resources.icons8_eye_20;
            buttonSeePassword.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSeePassword.FlatAppearance.BorderSize = 0;
            buttonSeePassword.FlatStyle = FlatStyle.Flat;
            buttonSeePassword.Location = new Point(235, 121);
            buttonSeePassword.Name = "buttonSeePassword";
            buttonSeePassword.Size = new Size(16, 16);
            buttonSeePassword.TabIndex = 10;
            buttonSeePassword.UseVisualStyleBackColor = false;
            buttonSeePassword.Click += buttonSeePassword_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            Controls.Add(buttonSeePassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "Login";
            Size = new Size(264, 220);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Label label2;
        private Label label1;
        private Button buttonSeePassword;
    }
}
