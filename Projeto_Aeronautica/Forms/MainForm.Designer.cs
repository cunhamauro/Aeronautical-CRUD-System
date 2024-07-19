namespace Projeto_Aeronautica
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMain = new Panel();
            panel2 = new Panel();
            buttonLogout = new Button();
            pictureBox2 = new PictureBox();
            labelClockNewYork = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            labelDateTokyo = new Label();
            labelDateNewYork = new Label();
            label7 = new Label();
            labelClockTokyo = new Label();
            label4 = new Label();
            labelUsername = new Label();
            labelClockLisbon = new Label();
            labelDateLisbon = new Label();
            buttonTickets = new Button();
            buttonFlights = new Button();
            buttonAircrafts = new Button();
            buttonAirlines = new Button();
            buttonAirports = new Button();
            buttonHome = new Button();
            panel3 = new Panel();
            buttonCredits = new Button();
            labelSelectAirports = new Label();
            labelSelectAirlines = new Label();
            labelSelectAircrafts = new Label();
            labelSelectFlights = new Label();
            labelSelectTickets = new Label();
            labelSelectHome = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.Location = new Point(117, 63);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1076, 624);
            panelMain.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(buttonLogout);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(labelClockNewYork);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(labelDateTokyo);
            panel2.Controls.Add(labelDateNewYork);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(labelClockTokyo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(labelUsername);
            panel2.Controls.Add(labelClockLisbon);
            panel2.Controls.Add(labelDateLisbon);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Segoe UI", 9.75F);
            panel2.ForeColor = Color.LightCyan;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1193, 63);
            panel2.TabIndex = 1;
            // 
            // buttonLogout
            // 
            buttonLogout.BackgroundImage = Properties.Resources.icons8_logout_48;
            buttonLogout.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.ForeColor = Color.DodgerBlue;
            buttonLogout.Location = new Point(1154, 15);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(26, 32);
            buttonLogout.TabIndex = 0;
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_user_60;
            pictureBox2.Location = new Point(1098, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // labelClockNewYork
            // 
            labelClockNewYork.AutoSize = true;
            labelClockNewYork.Font = new Font("Segoe UI", 12F);
            labelClockNewYork.ForeColor = Color.AliceBlue;
            labelClockNewYork.Location = new Point(347, 19);
            labelClockNewYork.Name = "labelClockNewYork";
            labelClockNewYork.Size = new Size(0, 21);
            labelClockNewYork.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.AliceBlue;
            label8.Location = new Point(159, 19);
            label8.Name = "label8";
            label8.Size = new Size(94, 21);
            label8.TabIndex = 10;
            label8.Text = "NEW YORK";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AISlogo;
            pictureBox1.Location = new Point(-3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // labelDateTokyo
            // 
            labelDateTokyo.Font = new Font("Segoe UI", 12F);
            labelDateTokyo.Location = new Point(780, 19);
            labelDateTokyo.Name = "labelDateTokyo";
            labelDateTokyo.Size = new Size(93, 24);
            labelDateTokyo.TabIndex = 13;
            labelDateTokyo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelDateNewYork
            // 
            labelDateNewYork.Font = new Font("Segoe UI", 12F);
            labelDateNewYork.Location = new Point(251, 19);
            labelDateNewYork.Name = "labelDateNewYork";
            labelDateNewYork.Size = new Size(93, 24);
            labelDateNewYork.TabIndex = 11;
            labelDateNewYork.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.AliceBlue;
            label7.Location = new Point(721, 19);
            label7.Name = "label7";
            label7.Size = new Size(62, 21);
            label7.TabIndex = 8;
            label7.Text = "TOKYO";
            // 
            // labelClockTokyo
            // 
            labelClockTokyo.AutoSize = true;
            labelClockTokyo.Font = new Font("Segoe UI", 12F);
            labelClockTokyo.ForeColor = Color.AliceBlue;
            labelClockTokyo.Location = new Point(875, 19);
            labelClockTokyo.Name = "labelClockTokyo";
            labelClockTokyo.Size = new Size(0, 21);
            labelClockTokyo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.AliceBlue;
            label4.Location = new Point(457, 19);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 6;
            label4.Text = "LISBON";
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.AliceBlue;
            labelUsername.Location = new Point(916, 19);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(172, 26);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "user";
            labelUsername.TextAlign = ContentAlignment.TopRight;
            // 
            // labelClockLisbon
            // 
            labelClockLisbon.AutoSize = true;
            labelClockLisbon.Font = new Font("Segoe UI", 12F);
            labelClockLisbon.ForeColor = Color.AliceBlue;
            labelClockLisbon.Location = new Point(613, 19);
            labelClockLisbon.Name = "labelClockLisbon";
            labelClockLisbon.Size = new Size(0, 21);
            labelClockLisbon.TabIndex = 2;
            // 
            // labelDateLisbon
            // 
            labelDateLisbon.Font = new Font("Segoe UI", 12F);
            labelDateLisbon.Location = new Point(521, 19);
            labelDateLisbon.Name = "labelDateLisbon";
            labelDateLisbon.Size = new Size(93, 24);
            labelDateLisbon.TabIndex = 12;
            labelDateLisbon.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonTickets
            // 
            buttonTickets.FlatAppearance.BorderColor = Color.DodgerBlue;
            buttonTickets.FlatStyle = FlatStyle.Flat;
            buttonTickets.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonTickets.ForeColor = Color.AliceBlue;
            buttonTickets.Image = Properties.Resources.icons8_bilhete_24;
            buttonTickets.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTickets.Location = new Point(0, 50);
            buttonTickets.Name = "buttonTickets";
            buttonTickets.Padding = new Padding(2, 0, 13, 0);
            buttonTickets.Size = new Size(118, 51);
            buttonTickets.TabIndex = 2;
            buttonTickets.Text = "Tickets";
            buttonTickets.TextAlign = ContentAlignment.MiddleRight;
            buttonTickets.UseVisualStyleBackColor = true;
            buttonTickets.Click += buttonTickets_Click;
            // 
            // buttonFlights
            // 
            buttonFlights.FlatAppearance.BorderColor = Color.DodgerBlue;
            buttonFlights.FlatStyle = FlatStyle.Flat;
            buttonFlights.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonFlights.ForeColor = Color.AliceBlue;
            buttonFlights.Image = Properties.Resources.icons8_calendário_24;
            buttonFlights.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFlights.Location = new Point(0, 100);
            buttonFlights.Name = "buttonFlights";
            buttonFlights.Padding = new Padding(2, 0, 13, 0);
            buttonFlights.Size = new Size(118, 51);
            buttonFlights.TabIndex = 3;
            buttonFlights.Text = "Flights";
            buttonFlights.TextAlign = ContentAlignment.MiddleRight;
            buttonFlights.UseVisualStyleBackColor = true;
            buttonFlights.Click += buttonFlights_Click;
            // 
            // buttonAircrafts
            // 
            buttonAircrafts.FlatAppearance.BorderColor = Color.DodgerBlue;
            buttonAircrafts.FlatStyle = FlatStyle.Flat;
            buttonAircrafts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAircrafts.ForeColor = Color.AliceBlue;
            buttonAircrafts.Image = Properties.Resources.icons8_aeroporto_24;
            buttonAircrafts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAircrafts.Location = new Point(0, 150);
            buttonAircrafts.Name = "buttonAircrafts";
            buttonAircrafts.Padding = new Padding(2, 0, 7, 0);
            buttonAircrafts.Size = new Size(118, 51);
            buttonAircrafts.TabIndex = 4;
            buttonAircrafts.Text = "Aircrafts";
            buttonAircrafts.TextAlign = ContentAlignment.MiddleRight;
            buttonAircrafts.UseVisualStyleBackColor = true;
            buttonAircrafts.Click += buttonAircrafts_Click;
            // 
            // buttonAirlines
            // 
            buttonAirlines.FlatAppearance.BorderColor = Color.DodgerBlue;
            buttonAirlines.FlatStyle = FlatStyle.Flat;
            buttonAirlines.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAirlines.ForeColor = Color.AliceBlue;
            buttonAirlines.Image = Properties.Resources.icons8_pilot_hat_24;
            buttonAirlines.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAirlines.Location = new Point(0, 200);
            buttonAirlines.Name = "buttonAirlines";
            buttonAirlines.Padding = new Padding(3, 0, 9, 0);
            buttonAirlines.Size = new Size(118, 51);
            buttonAirlines.TabIndex = 5;
            buttonAirlines.Text = "Airlines";
            buttonAirlines.TextAlign = ContentAlignment.MiddleRight;
            buttonAirlines.UseVisualStyleBackColor = true;
            buttonAirlines.Click += buttonAirlines_Click;
            // 
            // buttonAirports
            // 
            buttonAirports.FlatAppearance.BorderColor = Color.DodgerBlue;
            buttonAirports.FlatStyle = FlatStyle.Flat;
            buttonAirports.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAirports.ForeColor = Color.AliceBlue;
            buttonAirports.Image = Properties.Resources.icons8_airport_24;
            buttonAirports.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAirports.Location = new Point(0, 250);
            buttonAirports.Name = "buttonAirports";
            buttonAirports.Padding = new Padding(3, 0, 7, 0);
            buttonAirports.Size = new Size(118, 51);
            buttonAirports.TabIndex = 6;
            buttonAirports.Text = "Airports";
            buttonAirports.TextAlign = ContentAlignment.MiddleRight;
            buttonAirports.UseVisualStyleBackColor = true;
            buttonAirports.Click += buttonAirports_Click;
            // 
            // buttonHome
            // 
            buttonHome.FlatAppearance.BorderColor = Color.DodgerBlue;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonHome.ForeColor = Color.AliceBlue;
            buttonHome.Image = Properties.Resources.icons8_casa_24;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(0, 0);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(2, 0, 15, 0);
            buttonHome.Size = new Size(118, 51);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "Home";
            buttonHome.TextAlign = ContentAlignment.MiddleRight;
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(buttonCredits);
            panel3.Controls.Add(labelSelectAirports);
            panel3.Controls.Add(labelSelectAirlines);
            panel3.Controls.Add(labelSelectAircrafts);
            panel3.Controls.Add(labelSelectFlights);
            panel3.Controls.Add(labelSelectTickets);
            panel3.Controls.Add(labelSelectHome);
            panel3.Controls.Add(buttonHome);
            panel3.Controls.Add(buttonAirports);
            panel3.Controls.Add(buttonTickets);
            panel3.Controls.Add(buttonAirlines);
            panel3.Controls.Add(buttonFlights);
            panel3.Controls.Add(buttonAircrafts);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(118, 624);
            panel3.TabIndex = 2;
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
            buttonCredits.Location = new Point(3, 603);
            buttonCredits.Name = "buttonCredits";
            buttonCredits.Size = new Size(19, 18);
            buttonCredits.TabIndex = 18;
            buttonCredits.TextAlign = ContentAlignment.TopCenter;
            buttonCredits.UseVisualStyleBackColor = false;
            buttonCredits.Click += buttonCredits_Click;
            // 
            // labelSelectAirports
            // 
            labelSelectAirports.BackColor = Color.DodgerBlue;
            labelSelectAirports.Location = new Point(106, 250);
            labelSelectAirports.Name = "labelSelectAirports";
            labelSelectAirports.Size = new Size(12, 51);
            labelSelectAirports.TabIndex = 11;
            labelSelectAirports.Visible = false;
            // 
            // labelSelectAirlines
            // 
            labelSelectAirlines.BackColor = Color.DodgerBlue;
            labelSelectAirlines.Location = new Point(106, 200);
            labelSelectAirlines.Name = "labelSelectAirlines";
            labelSelectAirlines.Size = new Size(12, 51);
            labelSelectAirlines.TabIndex = 10;
            labelSelectAirlines.Visible = false;
            // 
            // labelSelectAircrafts
            // 
            labelSelectAircrafts.BackColor = Color.DodgerBlue;
            labelSelectAircrafts.Location = new Point(106, 150);
            labelSelectAircrafts.Name = "labelSelectAircrafts";
            labelSelectAircrafts.Size = new Size(12, 51);
            labelSelectAircrafts.TabIndex = 9;
            labelSelectAircrafts.Visible = false;
            // 
            // labelSelectFlights
            // 
            labelSelectFlights.BackColor = Color.DodgerBlue;
            labelSelectFlights.Location = new Point(106, 100);
            labelSelectFlights.Name = "labelSelectFlights";
            labelSelectFlights.Size = new Size(12, 51);
            labelSelectFlights.TabIndex = 8;
            labelSelectFlights.Visible = false;
            // 
            // labelSelectTickets
            // 
            labelSelectTickets.BackColor = Color.DodgerBlue;
            labelSelectTickets.Location = new Point(106, 50);
            labelSelectTickets.Name = "labelSelectTickets";
            labelSelectTickets.Size = new Size(12, 51);
            labelSelectTickets.TabIndex = 7;
            labelSelectTickets.Visible = false;
            // 
            // labelSelectHome
            // 
            labelSelectHome.BackColor = Color.DodgerBlue;
            labelSelectHome.Location = new Point(106, 0);
            labelSelectHome.Name = "labelSelectHome";
            labelSelectHome.Size = new Size(12, 51);
            labelSelectHome.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 687);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AIS - Aeronautical Information System";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panel2;
        private Button buttonHome;
        private Button buttonAirports;
        private Button buttonAirlines;
        private Button buttonAircrafts;
        private Button buttonFlights;
        private Button buttonTickets;
        private Panel panel3;
        private Label labelUsername;
        private Label labelClockLisbon;
        private System.Windows.Forms.Timer timer1;
        private Label labelClockNewYork;
        private Label label7;
        private Label labelClockTokyo;
        private Label label4;
        private Label labelSelectHome;
        private Label labelSelectAirports;
        private Label labelSelectAirlines;
        private Label labelSelectAircrafts;
        private Label labelSelectFlights;
        private Label labelSelectTickets;
        private Label labelDateTokyo;
        private Label labelDateLisbon;
        private Label labelDateNewYork;
        private PictureBox pictureBox1;
        private Label label8;
        private PictureBox pictureBox2;
        private Button buttonCredits;
        private Button buttonLogout;
    }
}
