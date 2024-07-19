namespace Projeto_Aeronautica
{
    partial class AirlineFleet
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirlineFleet));
            listBoxAirlineAircrafts = new ListBox();
            labelAirline = new Label();
            labelAircraftsCount = new Label();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // listBoxAirlineAircrafts
            // 
            listBoxAirlineAircrafts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxAirlineAircrafts.FormattingEnabled = true;
            listBoxAirlineAircrafts.ItemHeight = 21;
            listBoxAirlineAircrafts.Location = new Point(32, 104);
            listBoxAirlineAircrafts.Name = "listBoxAirlineAircrafts";
            listBoxAirlineAircrafts.Size = new Size(299, 319);
            listBoxAirlineAircrafts.TabIndex = 0;
            // 
            // labelAirline
            // 
            labelAirline.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAirline.ForeColor = SystemColors.HotTrack;
            labelAirline.Location = new Point(32, 21);
            labelAirline.Name = "labelAirline";
            labelAirline.Size = new Size(299, 33);
            labelAirline.TabIndex = 1;
            labelAirline.Text = "Airline's fleet";
            labelAirline.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelAircraftsCount
            // 
            labelAircraftsCount.BackColor = SystemColors.HotTrack;
            labelAircraftsCount.Font = new Font("Segoe UI", 12F);
            labelAircraftsCount.ForeColor = Color.FromArgb(250, 250, 250);
            labelAircraftsCount.Location = new Point(32, 426);
            labelAircraftsCount.Name = "labelAircraftsCount";
            labelAircraftsCount.Size = new Size(299, 20);
            labelAircraftsCount.TabIndex = 52;
            labelAircraftsCount.Text = "0";
            labelAircraftsCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.HotTrack;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(250, 250, 250);
            label12.Location = new Point(139, 75);
            label12.Name = "label12";
            label12.Size = new Size(74, 21);
            label12.TabIndex = 51;
            label12.Text = "Aircrafts";
            // 
            // label14
            // 
            label14.BackColor = SystemColors.HotTrack;
            label14.Location = new Point(32, 70);
            label14.Name = "label14";
            label14.Size = new Size(299, 34);
            label14.TabIndex = 53;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.HotTrack;
            label15.Location = new Point(32, 421);
            label15.Name = "label15";
            label15.Size = new Size(299, 34);
            label15.TabIndex = 54;
            // 
            // AirlineFleet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 486);
            Controls.Add(labelAircraftsCount);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(labelAirline);
            Controls.Add(listBoxAirlineAircrafts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AirlineFleet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AirlineFleet";
            Load += AirlineFleet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAirlineAircrafts;
        private Label labelAirline;
        private Label labelAircraftsCount;
        private Label label12;
        private Label label14;
        private Label label15;
        private System.Windows.Forms.Timer timer1;
    }
}