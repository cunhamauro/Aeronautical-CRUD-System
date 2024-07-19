namespace Projeto_Aeronautica
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panelLoginRegister = new Panel();
            pictureBox1 = new PictureBox();
            buttonLoginOrRegister = new Button();
            buttonCredits = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLoginRegister
            // 
            panelLoginRegister.Location = new Point(10, 109);
            panelLoginRegister.Name = "panelLoginRegister";
            panelLoginRegister.Size = new Size(264, 220);
            panelLoginRegister.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AISlogo;
            pictureBox1.Location = new Point(68, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // buttonLoginOrRegister
            // 
            buttonLoginOrRegister.BackColor = SystemColors.HotTrack;
            buttonLoginOrRegister.FlatStyle = FlatStyle.Flat;
            buttonLoginOrRegister.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoginOrRegister.ForeColor = Color.WhiteSmoke;
            buttonLoginOrRegister.Location = new Point(44, 337);
            buttonLoginOrRegister.Name = "buttonLoginOrRegister";
            buttonLoginOrRegister.Size = new Size(190, 29);
            buttonLoginOrRegister.TabIndex = 16;
            buttonLoginOrRegister.Tag = "register";
            buttonLoginOrRegister.Text = "Don't have an account? Register";
            buttonLoginOrRegister.UseVisualStyleBackColor = false;
            buttonLoginOrRegister.Click += buttonLoginOrRegister_Click;
            // 
            // buttonCredits
            // 
            buttonCredits.Anchor = AnchorStyles.None;
            buttonCredits.BackColor = Color.DodgerBlue;
            buttonCredits.BackgroundImage = Properties.Resources.icons8_informações_24;
            buttonCredits.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCredits.FlatAppearance.BorderSize = 0;
            buttonCredits.FlatStyle = FlatStyle.Flat;
            buttonCredits.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCredits.ForeColor = Color.AliceBlue;
            buttonCredits.Location = new Point(3, 388);
            buttonCredits.Name = "buttonCredits";
            buttonCredits.Size = new Size(19, 18);
            buttonCredits.TabIndex = 17;
            buttonCredits.TextAlign = ContentAlignment.TopCenter;
            buttonCredits.UseVisualStyleBackColor = false;
            buttonCredits.Click += buttonCredits_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(283, 409);
            Controls.Add(buttonCredits);
            Controls.Add(buttonLoginOrRegister);
            Controls.Add(pictureBox1);
            Controls.Add(panelLoginRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AIS";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLoginRegister;
        private PictureBox pictureBox1;
        private Button buttonLoginOrRegister;
        private Button buttonCredits;
    }
}