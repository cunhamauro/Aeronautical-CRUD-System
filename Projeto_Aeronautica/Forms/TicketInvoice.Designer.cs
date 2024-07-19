namespace Projeto_Aeronautica
{
    partial class TicketInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketInvoice));
            labelPrice = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            labelFlightInfo = new Label();
            label6 = new Label();
            label7 = new Label();
            labelIdNum = new Label();
            labelInvoiceNum = new Label();
            labelDate = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelPrice
            // 
            labelPrice.BackColor = Color.Transparent;
            labelPrice.Font = new Font("Cascadia Code", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(135, 534);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(134, 28);
            labelPrice.TabIndex = 0;
            labelPrice.Text = "00.00";
            labelPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Code", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 534);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 1;
            label1.Text = "TOTAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 597);
            label2.Name = "label2";
            label2.Size = new Size(244, 21);
            label2.TabIndex = 2;
            label2.Text = "*** HAVE A GOOD FLIGHT ***";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 571);
            label3.Name = "label3";
            label3.Size = new Size(247, 13);
            label3.TabIndex = 3;
            label3.Text = "==============================";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._9185570;
            pictureBox1.Location = new Point(16, 597);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 514);
            label4.Name = "label4";
            label4.Size = new Size(247, 13);
            label4.TabIndex = 5;
            label4.Text = "==============================";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 220);
            label5.Name = "label5";
            label5.Size = new Size(172, 21);
            label5.TabIndex = 6;
            label5.Text = "1 x Flight Ticket:";
            // 
            // labelFlightInfo
            // 
            labelFlightInfo.BackColor = Color.Transparent;
            labelFlightInfo.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFlightInfo.Location = new Point(26, 251);
            labelFlightInfo.Name = "labelFlightInfo";
            labelFlightInfo.Size = new Size(245, 263);
            labelFlightInfo.TabIndex = 7;
            labelFlightInfo.Text = "Flight description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 203);
            label6.Name = "label6";
            label6.Size = new Size(247, 13);
            label6.TabIndex = 8;
            label6.Text = "==============================";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 159);
            label7.Name = "label7";
            label7.Size = new Size(243, 13);
            label7.TabIndex = 9;
            label7.Text = "-----------------------------------------------------------";
            // 
            // labelIdNum
            // 
            labelIdNum.AutoSize = true;
            labelIdNum.BackColor = Color.Transparent;
            labelIdNum.Font = new Font("Cascadia Code", 12F);
            labelIdNum.Location = new Point(27, 177);
            labelIdNum.Name = "labelIdNum";
            labelIdNum.Size = new Size(109, 21);
            labelIdNum.TabIndex = 10;
            labelIdNum.Text = "Client ID.:";
            // 
            // labelInvoiceNum
            // 
            labelInvoiceNum.AutoSize = true;
            labelInvoiceNum.BackColor = Color.Transparent;
            labelInvoiceNum.Font = new Font("Cascadia Code", 12F);
            labelInvoiceNum.Location = new Point(24, 95);
            labelInvoiceNum.Name = "labelInvoiceNum";
            labelInvoiceNum.Size = new Size(109, 21);
            labelInvoiceNum.TabIndex = 11;
            labelInvoiceNum.Text = "Invoice Num";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.BackColor = Color.Transparent;
            labelDate.Font = new Font("Cascadia Code", 12F);
            labelDate.Location = new Point(24, 126);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(118, 21);
            labelDate.TabIndex = 12;
            labelDate.Text = "Invoice Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cascadia Code", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(95, 2);
            label8.Name = "label8";
            label8.Size = new Size(111, 63);
            label8.TabIndex = 13;
            label8.Text = "AIS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 72);
            label9.Name = "label9";
            label9.Size = new Size(247, 13);
            label9.TabIndex = 14;
            label9.Text = "==============================";
            // 
            // TicketInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.watercolor_paper_texture;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(295, 713);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(labelDate);
            Controls.Add(labelInvoiceNum);
            Controls.Add(labelIdNum);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelFlightInfo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelPrice);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TicketInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicketInvoice";
            Load += TicketInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label labelFlightInfo;
        private Label label6;
        private Label label7;
        private Label labelIdNum;
        private Label labelInvoiceNum;
        private Label labelDate;
        private Label label8;
        private Label label9;
    }
}