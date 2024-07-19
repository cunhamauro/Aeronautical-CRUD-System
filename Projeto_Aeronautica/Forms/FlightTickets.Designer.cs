namespace Projeto_Aeronautica
{
    partial class FlightTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTickets));
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            labelFlightNumber = new Label();
            listBoxFlightTickets = new ListBox();
            labelTicketsCount = new Label();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.HotTrack;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(250, 250, 250);
            label12.Location = new Point(139, 75);
            label12.Name = "label12";
            label12.Size = new Size(63, 21);
            label12.TabIndex = 62;
            label12.Text = "Tickets";
            // 
            // label14
            // 
            label14.BackColor = SystemColors.HotTrack;
            label14.Location = new Point(32, 70);
            label14.Name = "label14";
            label14.Size = new Size(299, 34);
            label14.TabIndex = 63;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.HotTrack;
            label15.Location = new Point(32, 421);
            label15.Name = "label15";
            label15.Size = new Size(299, 34);
            label15.TabIndex = 64;
            // 
            // labelFlightNumber
            // 
            labelFlightNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFlightNumber.ForeColor = SystemColors.HotTrack;
            labelFlightNumber.Location = new Point(32, 21);
            labelFlightNumber.Name = "labelFlightNumber";
            labelFlightNumber.Size = new Size(299, 33);
            labelFlightNumber.TabIndex = 61;
            labelFlightNumber.Text = "Flight Number";
            labelFlightNumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // listBoxFlightTickets
            // 
            listBoxFlightTickets.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxFlightTickets.FormattingEnabled = true;
            listBoxFlightTickets.ItemHeight = 21;
            listBoxFlightTickets.Location = new Point(32, 104);
            listBoxFlightTickets.Name = "listBoxFlightTickets";
            listBoxFlightTickets.Size = new Size(299, 319);
            listBoxFlightTickets.TabIndex = 65;
            // 
            // labelTicketsCount
            // 
            labelTicketsCount.BackColor = SystemColors.HotTrack;
            labelTicketsCount.Font = new Font("Segoe UI", 12F);
            labelTicketsCount.ForeColor = Color.FromArgb(250, 250, 250);
            labelTicketsCount.Location = new Point(32, 426);
            labelTicketsCount.Name = "labelTicketsCount";
            labelTicketsCount.Size = new Size(299, 20);
            labelTicketsCount.TabIndex = 66;
            labelTicketsCount.Text = "0";
            labelTicketsCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // FlightTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 486);
            Controls.Add(labelTicketsCount);
            Controls.Add(listBoxFlightTickets);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(labelFlightNumber);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FlightTickets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlightTickets";
            Load += FlightTickets_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label14;
        private Label label15;
        private Label labelFlightNumber;
        private ListBox listBoxFlightTickets;
        private Label labelTicketsCount;
    }
}