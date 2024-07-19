namespace Projeto_Aeronautica
{
    partial class AirlinesUserControl
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
            listBoxAirlines = new ListBox();
            label67 = new Label();
            textBoxAirline = new TextBox();
            label1 = new Label();
            textBoxEditAirline = new TextBox();
            tabControlAirline = new TabControl();
            tabPageNewAirline = new TabPage();
            buttonAddAirline = new Button();
            label2 = new Label();
            textBoxAirlineId = new TextBox();
            tabPageManageAirline = new TabPage();
            buttonConsultFleet = new Button();
            buttonDeleteAirline = new Button();
            buttonEditAirline = new Button();
            label3 = new Label();
            textBoxEditAirlineId = new TextBox();
            labelAirlinesCount = new Label();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label19 = new Label();
            tabControlAirline.SuspendLayout();
            tabPageNewAirline.SuspendLayout();
            tabPageManageAirline.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxAirlines
            // 
            listBoxAirlines.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxAirlines.FormattingEnabled = true;
            listBoxAirlines.ItemHeight = 21;
            listBoxAirlines.Location = new Point(181, 115);
            listBoxAirlines.Name = "listBoxAirlines";
            listBoxAirlines.Size = new Size(299, 403);
            listBoxAirlines.TabIndex = 14;
            listBoxAirlines.SelectedIndexChanged += listBoxAirlines_SelectedIndexChanged;
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label67.ForeColor = SystemColors.HotTrack;
            label67.Location = new Point(42, 222);
            label67.Name = "label67";
            label67.Size = new Size(56, 21);
            label67.TabIndex = 11;
            label67.Text = "Name";
            // 
            // textBoxAirline
            // 
            textBoxAirline.Font = new Font("Segoe UI", 12F);
            textBoxAirline.Location = new Point(121, 219);
            textBoxAirline.Name = "textBoxAirline";
            textBoxAirline.Size = new Size(171, 29);
            textBoxAirline.TabIndex = 1;
            textBoxAirline.KeyPress += textBoxSanitize_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(42, 222);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 19;
            label1.Text = "Name";
            // 
            // textBoxEditAirline
            // 
            textBoxEditAirline.Location = new Point(121, 219);
            textBoxEditAirline.Name = "textBoxEditAirline";
            textBoxEditAirline.Size = new Size(171, 29);
            textBoxEditAirline.TabIndex = 5;
            textBoxEditAirline.KeyPress += textBoxSanitize_KeyPress;
            // 
            // tabControlAirline
            // 
            tabControlAirline.Controls.Add(tabPageNewAirline);
            tabControlAirline.Controls.Add(tabPageManageAirline);
            tabControlAirline.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlAirline.Location = new Point(545, 79);
            tabControlAirline.Name = "tabControlAirline";
            tabControlAirline.SelectedIndex = 0;
            tabControlAirline.Size = new Size(348, 445);
            tabControlAirline.TabIndex = 20;
            // 
            // tabPageNewAirline
            // 
            tabPageNewAirline.Controls.Add(buttonAddAirline);
            tabPageNewAirline.Controls.Add(label2);
            tabPageNewAirline.Controls.Add(textBoxAirlineId);
            tabPageNewAirline.Controls.Add(label67);
            tabPageNewAirline.Controls.Add(textBoxAirline);
            tabPageNewAirline.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageNewAirline.Location = new Point(4, 34);
            tabPageNewAirline.Name = "tabPageNewAirline";
            tabPageNewAirline.Padding = new Padding(3);
            tabPageNewAirline.Size = new Size(340, 407);
            tabPageNewAirline.TabIndex = 0;
            tabPageNewAirline.Text = " New Airline ";
            tabPageNewAirline.UseVisualStyleBackColor = true;
            // 
            // buttonAddAirline
            // 
            buttonAddAirline.BackColor = SystemColors.HotTrack;
            buttonAddAirline.FlatStyle = FlatStyle.Flat;
            buttonAddAirline.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAddAirline.ForeColor = Color.FromArgb(250, 250, 250);
            buttonAddAirline.Location = new Point(189, 329);
            buttonAddAirline.Name = "buttonAddAirline";
            buttonAddAirline.Size = new Size(103, 36);
            buttonAddAirline.TabIndex = 2;
            buttonAddAirline.Text = "Add";
            buttonAddAirline.UseVisualStyleBackColor = false;
            buttonAddAirline.Click += buttonAddAirline_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(42, 151);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 17;
            label2.Text = "ID";
            // 
            // textBoxAirlineId
            // 
            textBoxAirlineId.Enabled = false;
            textBoxAirlineId.Font = new Font("Segoe UI", 12F);
            textBoxAirlineId.Location = new Point(121, 151);
            textBoxAirlineId.Name = "textBoxAirlineId";
            textBoxAirlineId.Size = new Size(171, 29);
            textBoxAirlineId.TabIndex = 16;
            // 
            // tabPageManageAirline
            // 
            tabPageManageAirline.Controls.Add(buttonConsultFleet);
            tabPageManageAirline.Controls.Add(buttonDeleteAirline);
            tabPageManageAirline.Controls.Add(buttonEditAirline);
            tabPageManageAirline.Controls.Add(label3);
            tabPageManageAirline.Controls.Add(textBoxEditAirlineId);
            tabPageManageAirline.Controls.Add(textBoxEditAirline);
            tabPageManageAirline.Controls.Add(label1);
            tabPageManageAirline.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageManageAirline.Location = new Point(4, 34);
            tabPageManageAirline.Name = "tabPageManageAirline";
            tabPageManageAirline.Padding = new Padding(3);
            tabPageManageAirline.Size = new Size(340, 407);
            tabPageManageAirline.TabIndex = 1;
            tabPageManageAirline.Text = " Manage Airline ";
            tabPageManageAirline.UseVisualStyleBackColor = true;
            // 
            // buttonConsultFleet
            // 
            buttonConsultFleet.BackColor = SystemColors.HotTrack;
            buttonConsultFleet.FlatStyle = FlatStyle.Flat;
            buttonConsultFleet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonConsultFleet.ForeColor = Color.FromArgb(250, 250, 250);
            buttonConsultFleet.Location = new Point(189, 40);
            buttonConsultFleet.Name = "buttonConsultFleet";
            buttonConsultFleet.Size = new Size(103, 36);
            buttonConsultFleet.TabIndex = 3;
            buttonConsultFleet.Text = "Fleet";
            buttonConsultFleet.UseVisualStyleBackColor = false;
            buttonConsultFleet.Click += buttonConsultFleet_Click;
            // 
            // buttonDeleteAirline
            // 
            buttonDeleteAirline.BackColor = SystemColors.HotTrack;
            buttonDeleteAirline.FlatStyle = FlatStyle.Flat;
            buttonDeleteAirline.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonDeleteAirline.ForeColor = Color.FromArgb(250, 250, 250);
            buttonDeleteAirline.Location = new Point(47, 329);
            buttonDeleteAirline.Name = "buttonDeleteAirline";
            buttonDeleteAirline.Size = new Size(103, 36);
            buttonDeleteAirline.TabIndex = 7;
            buttonDeleteAirline.Text = "Remove";
            buttonDeleteAirline.UseVisualStyleBackColor = false;
            buttonDeleteAirline.Click += buttonDeleteAirline_Click;
            // 
            // buttonEditAirline
            // 
            buttonEditAirline.BackColor = SystemColors.HotTrack;
            buttonEditAirline.FlatStyle = FlatStyle.Flat;
            buttonEditAirline.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonEditAirline.ForeColor = Color.FromArgb(250, 250, 250);
            buttonEditAirline.Location = new Point(189, 329);
            buttonEditAirline.Name = "buttonEditAirline";
            buttonEditAirline.Size = new Size(103, 36);
            buttonEditAirline.TabIndex = 6;
            buttonEditAirline.Text = "Save";
            buttonEditAirline.UseVisualStyleBackColor = false;
            buttonEditAirline.Click += buttonEditAirline_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(42, 151);
            label3.Name = "label3";
            label3.Size = new Size(27, 21);
            label3.TabIndex = 26;
            label3.Text = "ID";
            // 
            // textBoxEditAirlineId
            // 
            textBoxEditAirlineId.Enabled = false;
            textBoxEditAirlineId.Font = new Font("Segoe UI", 12F);
            textBoxEditAirlineId.Location = new Point(121, 151);
            textBoxEditAirlineId.Name = "textBoxEditAirlineId";
            textBoxEditAirlineId.Size = new Size(171, 29);
            textBoxEditAirlineId.TabIndex = 4;
            // 
            // labelAirlinesCount
            // 
            labelAirlinesCount.BackColor = SystemColors.HotTrack;
            labelAirlinesCount.Font = new Font("Segoe UI", 12F);
            labelAirlinesCount.ForeColor = Color.FromArgb(250, 250, 250);
            labelAirlinesCount.Location = new Point(181, 523);
            labelAirlinesCount.Name = "labelAirlinesCount";
            labelAirlinesCount.Size = new Size(299, 20);
            labelAirlinesCount.TabIndex = 48;
            labelAirlinesCount.Text = "0";
            labelAirlinesCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.HotTrack;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(250, 250, 250);
            label12.Location = new Point(288, 86);
            label12.Name = "label12";
            label12.Size = new Size(68, 21);
            label12.TabIndex = 47;
            label12.Text = "Airlines";
            // 
            // label14
            // 
            label14.BackColor = SystemColors.HotTrack;
            label14.Location = new Point(181, 81);
            label14.Name = "label14";
            label14.Size = new Size(299, 34);
            label14.TabIndex = 49;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.HotTrack;
            label15.Location = new Point(181, 518);
            label15.Name = "label15";
            label15.Size = new Size(299, 34);
            label15.TabIndex = 50;
            // 
            // label19
            // 
            label19.BackColor = SystemColors.HotTrack;
            label19.Location = new Point(545, 518);
            label19.Name = "label19";
            label19.Size = new Size(345, 34);
            label19.TabIndex = 51;
            // 
            // AirlinesUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label19);
            Controls.Add(labelAirlinesCount);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(tabControlAirline);
            Controls.Add(listBoxAirlines);
            Name = "AirlinesUserControl";
            Size = new Size(1076, 624);
            tabControlAirline.ResumeLayout(false);
            tabPageNewAirline.ResumeLayout(false);
            tabPageNewAirline.PerformLayout();
            tabPageManageAirline.ResumeLayout(false);
            tabPageManageAirline.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxAirlines;
        private Label label3;
        private Label label2;
        private Label label67;
        private TextBox textBoxCity;
        private TextBox textBoxCountry;
        private TextBox textBoxAirline;
        private Label label1;
        private TextBox textBoxEditAirline;
        private TabControl tabControlAirline;
        private TabPage tabPageNewAirline;
        private TabPage tabPageManageAirline;
        private Label labelAirlinesCount;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label19;
        private TextBox textBoxAirlineId;
        private TextBox textBoxEditAirlineId;
        private Button buttonConsultFleet;
        private Button buttonDeleteAirline;
        private Button buttonEditAirline;
        private Button buttonAddAirline;
    }
}
