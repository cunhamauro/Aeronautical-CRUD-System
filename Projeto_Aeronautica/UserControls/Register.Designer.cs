namespace Projeto_Aeronautica.UserControls
{
    partial class Register
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
            buttonRegister = new Button();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            buttonSeePassword = new Button();
            buttonSeePasswordConfirm = new Button();
            textBoxConfirmPassword = new TextBox();
            labelPassInfo = new Label();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.WhiteSmoke;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.ForeColor = SystemColors.HotTrack;
            buttonRegister.Location = new Point(68, 176);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(121, 33);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.Location = new Point(36, 89);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(190, 29);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.KeyPress += textBoxRegister_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(32, 66);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F);
            textBoxUsername.Location = new Point(36, 32);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Register username";
            textBoxUsername.Size = new Size(190, 29);
            textBoxUsername.TabIndex = 3;
            textBoxUsername.KeyPress += textBoxRegister_KeyPress;
            // 
            // buttonSeePassword
            // 
            buttonSeePassword.BackColor = SystemColors.HotTrack;
            buttonSeePassword.BackgroundImage = Properties.Resources.icons8_eye_20;
            buttonSeePassword.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSeePassword.FlatAppearance.BorderSize = 0;
            buttonSeePassword.FlatStyle = FlatStyle.Flat;
            buttonSeePassword.Location = new Point(235, 96);
            buttonSeePassword.Name = "buttonSeePassword";
            buttonSeePassword.Size = new Size(16, 16);
            buttonSeePassword.TabIndex = 8;
            buttonSeePassword.UseVisualStyleBackColor = false;
            buttonSeePassword.Click += buttonSeePassword_Click;
            // 
            // buttonSeePasswordConfirm
            // 
            buttonSeePasswordConfirm.BackColor = SystemColors.HotTrack;
            buttonSeePasswordConfirm.BackgroundImage = Properties.Resources.icons8_eye_20;
            buttonSeePasswordConfirm.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSeePasswordConfirm.FlatAppearance.BorderSize = 0;
            buttonSeePasswordConfirm.FlatStyle = FlatStyle.Flat;
            buttonSeePasswordConfirm.Location = new Point(235, 134);
            buttonSeePasswordConfirm.Name = "buttonSeePasswordConfirm";
            buttonSeePasswordConfirm.Size = new Size(16, 16);
            buttonSeePasswordConfirm.TabIndex = 11;
            buttonSeePasswordConfirm.UseVisualStyleBackColor = false;
            buttonSeePasswordConfirm.Click += buttonSeePasswordConfirm_Click;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new Font("Segoe UI", 12F);
            textBoxConfirmPassword.Location = new Point(36, 127);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '*';
            textBoxConfirmPassword.PlaceholderText = "Confirm password";
            textBoxConfirmPassword.Size = new Size(190, 29);
            textBoxConfirmPassword.TabIndex = 9;
            // 
            // labelPassInfo
            // 
            labelPassInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassInfo.ForeColor = Color.White;
            labelPassInfo.Location = new Point(109, 70);
            labelPassInfo.Name = "labelPassInfo";
            labelPassInfo.Size = new Size(18, 18);
            labelPassInfo.TabIndex = 12;
            labelPassInfo.Text = "*";
            labelPassInfo.Click += labelPassInfo_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            Controls.Add(buttonSeePasswordConfirm);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(buttonSeePassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassInfo);
            Name = "Register";
            Size = new Size(264, 220);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegister;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private Button buttonSeePassword;
        private Button buttonSeePasswordConfirm;
        private TextBox textBoxConfirmPassword;
        private Label labelPassInfo;
    }
}
