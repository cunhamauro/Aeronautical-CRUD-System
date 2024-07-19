namespace Projeto_Aeronautica
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            label1 = new Label();
            label2 = new Label();
            labelVersionDate = new Label();
            labelVersion = new Label();
            linkLabelGithub = new LinkLabel();
            linkLabelLinkedin = new LinkLabel();
            label31 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(37, 88);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 0;
            label1.Text = "Developed by";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HotTrack;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(23, 104);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 1;
            label2.Text = "Mauro Cunha";
            // 
            // labelVersionDate
            // 
            labelVersionDate.BackColor = SystemColors.HotTrack;
            labelVersionDate.Font = new Font("Segoe UI", 12F);
            labelVersionDate.ForeColor = Color.AliceBlue;
            labelVersionDate.Location = new Point(-7, 26);
            labelVersionDate.Name = "labelVersionDate";
            labelVersionDate.Size = new Size(175, 21);
            labelVersionDate.TabIndex = 2;
            labelVersionDate.Text = "dd mm yyyy";
            labelVersionDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelVersion
            // 
            labelVersion.BackColor = SystemColors.HotTrack;
            labelVersion.Font = new Font("Segoe UI", 12F);
            labelVersion.ForeColor = Color.AliceBlue;
            labelVersion.Location = new Point(-7, 8);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(175, 21);
            labelVersion.TabIndex = 3;
            labelVersion.Text = "Version 0.0.0";
            labelVersion.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabelGithub
            // 
            linkLabelGithub.ActiveLinkColor = Color.DodgerBlue;
            linkLabelGithub.AutoSize = true;
            linkLabelGithub.BackColor = SystemColors.HotTrack;
            linkLabelGithub.DisabledLinkColor = Color.Black;
            linkLabelGithub.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            linkLabelGithub.ForeColor = Color.Black;
            linkLabelGithub.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelGithub.LinkColor = Color.Black;
            linkLabelGithub.Location = new Point(21, 127);
            linkLabelGithub.Name = "linkLabelGithub";
            linkLabelGithub.Size = new Size(53, 17);
            linkLabelGithub.TabIndex = 1;
            linkLabelGithub.TabStop = true;
            linkLabelGithub.Text = "GitHub";
            linkLabelGithub.VisitedLinkColor = Color.Black;
            linkLabelGithub.LinkClicked += linkLabelGithub_Linkedin_LinkClicked;
            // 
            // linkLabelLinkedin
            // 
            linkLabelLinkedin.ActiveLinkColor = Color.Black;
            linkLabelLinkedin.AutoSize = true;
            linkLabelLinkedin.BackColor = SystemColors.HotTrack;
            linkLabelLinkedin.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            linkLabelLinkedin.ForeColor = Color.DodgerBlue;
            linkLabelLinkedin.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelLinkedin.LinkColor = Color.Aquamarine;
            linkLabelLinkedin.Location = new Point(72, 127);
            linkLabelLinkedin.Name = "linkLabelLinkedin";
            linkLabelLinkedin.Size = new Size(64, 17);
            linkLabelLinkedin.TabIndex = 2;
            linkLabelLinkedin.TabStop = true;
            linkLabelLinkedin.Text = "Linkedin";
            linkLabelLinkedin.VisitedLinkColor = Color.DodgerBlue;
            linkLabelLinkedin.LinkClicked += linkLabelGithub_Linkedin_LinkClicked;
            // 
            // label31
            // 
            label31.BackColor = SystemColors.HotTrack;
            label31.Location = new Point(-2, -10);
            label31.Name = "label31";
            label31.Size = new Size(174, 175);
            label31.TabIndex = 112;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HotTrack;
            pictureBox1.Image = Properties.Resources.AISlogo;
            pictureBox1.Location = new Point(51, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 113;
            pictureBox1.TabStop = false;
            // 
            // Credits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(156, 157);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabelLinkedin);
            Controls.Add(linkLabelGithub);
            Controls.Add(labelVersion);
            Controls.Add(labelVersionDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label31);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Credits";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About AIS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelVersionDate;
        private Label labelVersion;
        private LinkLabel linkLabelGithub;
        private LinkLabel linkLabelLinkedin;
        private Label label31;
        private PictureBox pictureBox1;
    }
}