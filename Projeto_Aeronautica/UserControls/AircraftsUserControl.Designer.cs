namespace Projeto_Aeronautica
{
    partial class AircraftsUserControl
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
            buttonAddAircraft = new Button();
            listBoxAircrafts = new ListBox();
            label2 = new Label();
            label1 = new Label();
            numericUpDownCapacity = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            numericUpDownRows = new NumericUpDown();
            listBoxSeats = new ListBox();
            label6 = new Label();
            label3 = new Label();
            tabControlAircraft = new TabControl();
            tabPageNewAircraft = new TabPage();
            comboBoxBrand = new ComboBox();
            comboBoxModel = new ComboBox();
            comboBoxAirlines = new ComboBox();
            textBoxAircraftId = new TextBox();
            label17 = new Label();
            tabPageManageAircraft = new TabPage();
            label20 = new Label();
            buttonStatus = new Button();
            comboBoxEditBrand = new ComboBox();
            comboBoxEditModel = new ComboBox();
            comboBoxEditAirline = new ComboBox();
            label7 = new Label();
            textBoxAircraftIdEdit = new TextBox();
            label18 = new Label();
            buttonDeleteAircraft = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            buttonEditAircraft = new Button();
            numericUpDownEditRows = new NumericUpDown();
            numericUpDownEditCapacity = new NumericUpDown();
            label11 = new Label();
            labelSeatsCount = new Label();
            label12 = new Label();
            labelAircraftsCount = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRows).BeginInit();
            tabControlAircraft.SuspendLayout();
            tabPageNewAircraft.SuspendLayout();
            tabPageManageAircraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditCapacity).BeginInit();
            SuspendLayout();
            // 
            // buttonAddAircraft
            // 
            buttonAddAircraft.BackColor = SystemColors.HotTrack;
            buttonAddAircraft.FlatStyle = FlatStyle.Flat;
            buttonAddAircraft.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddAircraft.ForeColor = Color.FromArgb(250, 250, 250);
            buttonAddAircraft.Location = new Point(190, 329);
            buttonAddAircraft.Name = "buttonAddAircraft";
            buttonAddAircraft.Size = new Size(103, 36);
            buttonAddAircraft.TabIndex = 6;
            buttonAddAircraft.Text = "Add";
            buttonAddAircraft.UseVisualStyleBackColor = false;
            buttonAddAircraft.Click += buttonAddAircraft_Click;
            // 
            // listBoxAircrafts
            // 
            listBoxAircrafts.Font = new Font("Segoe UI", 12F);
            listBoxAircrafts.FormattingEnabled = true;
            listBoxAircrafts.ItemHeight = 21;
            listBoxAircrafts.Location = new Point(205, 119);
            listBoxAircrafts.Name = "listBoxAircrafts";
            listBoxAircrafts.Size = new Size(299, 403);
            listBoxAircrafts.TabIndex = 14;
            listBoxAircrafts.SelectedIndexChanged += listBoxAircrafts_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(50, 132);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 12;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(50, 87);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 11;
            label1.Text = "Brand";
            // 
            // numericUpDownCapacity
            // 
            numericUpDownCapacity.Font = new Font("Segoe UI", 12F);
            numericUpDownCapacity.Location = new Point(132, 174);
            numericUpDownCapacity.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCapacity.Name = "numericUpDownCapacity";
            numericUpDownCapacity.Size = new Size(161, 29);
            numericUpDownCapacity.TabIndex = 3;
            numericUpDownCapacity.Value = new decimal(new int[] { 104, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(49, 177);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 17;
            label4.Text = "Capacity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(50, 222);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 19;
            label5.Text = "Rows";
            // 
            // numericUpDownRows
            // 
            numericUpDownRows.Font = new Font("Segoe UI", 12F);
            numericUpDownRows.Location = new Point(132, 219);
            numericUpDownRows.Maximum = new decimal(new int[] { 26, 0, 0, 0 });
            numericUpDownRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRows.Name = "numericUpDownRows";
            numericUpDownRows.Size = new Size(161, 29);
            numericUpDownRows.TabIndex = 4;
            numericUpDownRows.Value = new decimal(new int[] { 26, 0, 0, 0 });
            // 
            // listBoxSeats
            // 
            listBoxSeats.Font = new Font("Segoe UI", 12F);
            listBoxSeats.FormattingEnabled = true;
            listBoxSeats.ItemHeight = 21;
            listBoxSeats.Location = new Point(129, 119);
            listBoxSeats.Name = "listBoxSeats";
            listBoxSeats.Size = new Size(54, 403);
            listBoxSeats.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(50, 267);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 22;
            label6.Text = "Airline";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HotTrack;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(250, 250, 250);
            label3.Location = new Point(132, 90);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 23;
            label3.Text = "Seats";
            // 
            // tabControlAircraft
            // 
            tabControlAircraft.Controls.Add(tabPageNewAircraft);
            tabControlAircraft.Controls.Add(tabPageManageAircraft);
            tabControlAircraft.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlAircraft.Location = new Point(569, 83);
            tabControlAircraft.Name = "tabControlAircraft";
            tabControlAircraft.SelectedIndex = 0;
            tabControlAircraft.Size = new Size(348, 445);
            tabControlAircraft.TabIndex = 24;
            tabControlAircraft.SelectedIndexChanged += tabControlAircraft_SelectedIndexChanged;
            // 
            // tabPageNewAircraft
            // 
            tabPageNewAircraft.BackColor = Color.FromArgb(250, 250, 250);
            tabPageNewAircraft.Controls.Add(comboBoxBrand);
            tabPageNewAircraft.Controls.Add(comboBoxModel);
            tabPageNewAircraft.Controls.Add(comboBoxAirlines);
            tabPageNewAircraft.Controls.Add(textBoxAircraftId);
            tabPageNewAircraft.Controls.Add(label17);
            tabPageNewAircraft.Controls.Add(label6);
            tabPageNewAircraft.Controls.Add(label1);
            tabPageNewAircraft.Controls.Add(label2);
            tabPageNewAircraft.Controls.Add(label5);
            tabPageNewAircraft.Controls.Add(buttonAddAircraft);
            tabPageNewAircraft.Controls.Add(numericUpDownRows);
            tabPageNewAircraft.Controls.Add(numericUpDownCapacity);
            tabPageNewAircraft.Controls.Add(label4);
            tabPageNewAircraft.Location = new Point(4, 34);
            tabPageNewAircraft.Name = "tabPageNewAircraft";
            tabPageNewAircraft.Padding = new Padding(3);
            tabPageNewAircraft.Size = new Size(340, 407);
            tabPageNewAircraft.TabIndex = 0;
            tabPageNewAircraft.Text = " New Aircraft ";
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Items.AddRange(new object[] { "Airbus", "Boeing" });
            comboBoxBrand.Location = new Point(132, 84);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(161, 29);
            comboBoxBrand.TabIndex = 1;
            comboBoxBrand.SelectedIndexChanged += comboBoxBrand_SelectedIndexChanged;
            comboBoxBrand.KeyPress += textBoxSanitize_KeyPress;
            // 
            // comboBoxModel
            // 
            comboBoxModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Items.AddRange(new object[] { "Airbus", "Boeing", "Bombardier" });
            comboBoxModel.Location = new Point(132, 129);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(161, 29);
            comboBoxModel.TabIndex = 2;
            comboBoxModel.KeyPress += textBoxSanitize_KeyPress;
            // 
            // comboBoxAirlines
            // 
            comboBoxAirlines.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAirlines.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAirlines.FormattingEnabled = true;
            comboBoxAirlines.Location = new Point(132, 264);
            comboBoxAirlines.Name = "comboBoxAirlines";
            comboBoxAirlines.Size = new Size(161, 29);
            comboBoxAirlines.TabIndex = 5;
            // 
            // textBoxAircraftId
            // 
            textBoxAircraftId.Enabled = false;
            textBoxAircraftId.Font = new Font("Segoe UI", 12F);
            textBoxAircraftId.Location = new Point(132, 39);
            textBoxAircraftId.Name = "textBoxAircraftId";
            textBoxAircraftId.Size = new Size(161, 29);
            textBoxAircraftId.TabIndex = 24;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.ForeColor = SystemColors.HotTrack;
            label17.Location = new Point(50, 42);
            label17.Name = "label17";
            label17.Size = new Size(27, 21);
            label17.TabIndex = 23;
            label17.Text = "ID";
            // 
            // tabPageManageAircraft
            // 
            tabPageManageAircraft.BackColor = Color.FromArgb(250, 250, 250);
            tabPageManageAircraft.Controls.Add(label20);
            tabPageManageAircraft.Controls.Add(buttonStatus);
            tabPageManageAircraft.Controls.Add(comboBoxEditBrand);
            tabPageManageAircraft.Controls.Add(comboBoxEditModel);
            tabPageManageAircraft.Controls.Add(comboBoxEditAirline);
            tabPageManageAircraft.Controls.Add(label7);
            tabPageManageAircraft.Controls.Add(textBoxAircraftIdEdit);
            tabPageManageAircraft.Controls.Add(label18);
            tabPageManageAircraft.Controls.Add(buttonDeleteAircraft);
            tabPageManageAircraft.Controls.Add(label8);
            tabPageManageAircraft.Controls.Add(label9);
            tabPageManageAircraft.Controls.Add(label10);
            tabPageManageAircraft.Controls.Add(buttonEditAircraft);
            tabPageManageAircraft.Controls.Add(numericUpDownEditRows);
            tabPageManageAircraft.Controls.Add(numericUpDownEditCapacity);
            tabPageManageAircraft.Controls.Add(label11);
            tabPageManageAircraft.Location = new Point(4, 34);
            tabPageManageAircraft.Name = "tabPageManageAircraft";
            tabPageManageAircraft.Padding = new Padding(3);
            tabPageManageAircraft.Size = new Size(340, 407);
            tabPageManageAircraft.TabIndex = 1;
            tabPageManageAircraft.Text = " Manage Aircraft ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label20.ForeColor = SystemColors.HotTrack;
            label20.Location = new Point(50, 64);
            label20.Name = "label20";
            label20.Size = new Size(57, 21);
            label20.TabIndex = 46;
            label20.Text = "Status";
            // 
            // buttonStatus
            // 
            buttonStatus.BackColor = Color.Gray;
            buttonStatus.FlatAppearance.BorderColor = Color.Black;
            buttonStatus.FlatStyle = FlatStyle.Flat;
            buttonStatus.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStatus.Location = new Point(132, 63);
            buttonStatus.Name = "buttonStatus";
            buttonStatus.Size = new Size(161, 25);
            buttonStatus.TabIndex = 44;
            buttonStatus.TextAlign = ContentAlignment.TopCenter;
            buttonStatus.UseVisualStyleBackColor = false;
            buttonStatus.BackColorChanged += buttonStatus_BackColorChanged;
            buttonStatus.Click += buttonStatus_Click;
            // 
            // comboBoxEditBrand
            // 
            comboBoxEditBrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxEditBrand.FormattingEnabled = true;
            comboBoxEditBrand.Items.AddRange(new object[] { "Airbus", "Boeing" });
            comboBoxEditBrand.Location = new Point(132, 105);
            comboBoxEditBrand.Name = "comboBoxEditBrand";
            comboBoxEditBrand.Size = new Size(161, 29);
            comboBoxEditBrand.TabIndex = 7;
            comboBoxEditBrand.SelectedIndexChanged += comboBoxBrand_SelectedIndexChanged;
            // 
            // comboBoxEditModel
            // 
            comboBoxEditModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxEditModel.FormattingEnabled = true;
            comboBoxEditModel.Items.AddRange(new object[] { "Airbus", "Boeing", "Bombardier" });
            comboBoxEditModel.Location = new Point(132, 150);
            comboBoxEditModel.Name = "comboBoxEditModel";
            comboBoxEditModel.Size = new Size(161, 29);
            comboBoxEditModel.TabIndex = 8;
            // 
            // comboBoxEditAirline
            // 
            comboBoxEditAirline.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEditAirline.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxEditAirline.FormattingEnabled = true;
            comboBoxEditAirline.Location = new Point(132, 285);
            comboBoxEditAirline.Name = "comboBoxEditAirline";
            comboBoxEditAirline.Size = new Size(161, 29);
            comboBoxEditAirline.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(50, 288);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 45;
            label7.Text = "Airline";
            // 
            // textBoxAircraftIdEdit
            // 
            textBoxAircraftIdEdit.Enabled = false;
            textBoxAircraftIdEdit.Font = new Font("Segoe UI", 12F);
            textBoxAircraftIdEdit.Location = new Point(132, 18);
            textBoxAircraftIdEdit.Name = "textBoxAircraftIdEdit";
            textBoxAircraftIdEdit.Size = new Size(161, 29);
            textBoxAircraftIdEdit.TabIndex = 36;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.ForeColor = SystemColors.HotTrack;
            label18.Location = new Point(50, 21);
            label18.Name = "label18";
            label18.Size = new Size(27, 21);
            label18.TabIndex = 35;
            label18.Text = "ID";
            // 
            // buttonDeleteAircraft
            // 
            buttonDeleteAircraft.BackColor = SystemColors.HotTrack;
            buttonDeleteAircraft.FlatStyle = FlatStyle.Flat;
            buttonDeleteAircraft.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonDeleteAircraft.ForeColor = Color.FromArgb(250, 250, 250);
            buttonDeleteAircraft.Location = new Point(50, 329);
            buttonDeleteAircraft.Name = "buttonDeleteAircraft";
            buttonDeleteAircraft.Size = new Size(103, 36);
            buttonDeleteAircraft.TabIndex = 13;
            buttonDeleteAircraft.Text = "Remove";
            buttonDeleteAircraft.UseVisualStyleBackColor = false;
            buttonDeleteAircraft.Click += buttonDeleteAircraft_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(50, 108);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 25;
            label8.Text = "Brand";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(50, 153);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 26;
            label9.Text = "Model";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(50, 243);
            label10.Name = "label10";
            label10.Size = new Size(50, 21);
            label10.TabIndex = 31;
            label10.Text = "Rows";
            // 
            // buttonEditAircraft
            // 
            buttonEditAircraft.BackColor = SystemColors.HotTrack;
            buttonEditAircraft.FlatStyle = FlatStyle.Flat;
            buttonEditAircraft.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonEditAircraft.ForeColor = Color.FromArgb(250, 250, 250);
            buttonEditAircraft.Location = new Point(190, 329);
            buttonEditAircraft.Name = "buttonEditAircraft";
            buttonEditAircraft.Size = new Size(103, 36);
            buttonEditAircraft.TabIndex = 12;
            buttonEditAircraft.Text = "Save";
            buttonEditAircraft.UseVisualStyleBackColor = false;
            buttonEditAircraft.Click += buttonEditAircraft_Click;
            // 
            // numericUpDownEditRows
            // 
            numericUpDownEditRows.Font = new Font("Segoe UI", 12F);
            numericUpDownEditRows.Location = new Point(132, 240);
            numericUpDownEditRows.Maximum = new decimal(new int[] { 26, 0, 0, 0 });
            numericUpDownEditRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownEditRows.Name = "numericUpDownEditRows";
            numericUpDownEditRows.Size = new Size(161, 29);
            numericUpDownEditRows.TabIndex = 10;
            numericUpDownEditRows.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownEditCapacity
            // 
            numericUpDownEditCapacity.Font = new Font("Segoe UI", 12F);
            numericUpDownEditCapacity.Location = new Point(132, 195);
            numericUpDownEditCapacity.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownEditCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownEditCapacity.Name = "numericUpDownEditCapacity";
            numericUpDownEditCapacity.Size = new Size(161, 29);
            numericUpDownEditCapacity.TabIndex = 9;
            numericUpDownEditCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(49, 198);
            label11.Name = "label11";
            label11.Size = new Size(76, 21);
            label11.TabIndex = 29;
            label11.Text = "Capacity";
            // 
            // labelSeatsCount
            // 
            labelSeatsCount.BackColor = SystemColors.HotTrack;
            labelSeatsCount.Font = new Font("Segoe UI", 12F);
            labelSeatsCount.ForeColor = Color.FromArgb(250, 250, 250);
            labelSeatsCount.Location = new Point(131, 527);
            labelSeatsCount.Name = "labelSeatsCount";
            labelSeatsCount.Size = new Size(50, 27);
            labelSeatsCount.TabIndex = 25;
            labelSeatsCount.Text = "0";
            labelSeatsCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.HotTrack;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(250, 250, 250);
            label12.Location = new Point(312, 90);
            label12.Name = "label12";
            label12.Size = new Size(74, 21);
            label12.TabIndex = 37;
            label12.Text = "Aircrafts";
            // 
            // labelAircraftsCount
            // 
            labelAircraftsCount.BackColor = SystemColors.HotTrack;
            labelAircraftsCount.Font = new Font("Segoe UI", 12F);
            labelAircraftsCount.ForeColor = Color.FromArgb(250, 250, 250);
            labelAircraftsCount.Location = new Point(205, 527);
            labelAircraftsCount.Name = "labelAircraftsCount";
            labelAircraftsCount.Size = new Size(299, 20);
            labelAircraftsCount.TabIndex = 38;
            labelAircraftsCount.Text = "0";
            labelAircraftsCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.BackColor = SystemColors.HotTrack;
            label13.Location = new Point(129, 85);
            label13.Name = "label13";
            label13.Size = new Size(54, 34);
            label13.TabIndex = 39;
            // 
            // label14
            // 
            label14.BackColor = SystemColors.HotTrack;
            label14.Location = new Point(205, 85);
            label14.Name = "label14";
            label14.Size = new Size(299, 34);
            label14.TabIndex = 40;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.HotTrack;
            label15.Location = new Point(205, 522);
            label15.Name = "label15";
            label15.Size = new Size(299, 34);
            label15.TabIndex = 41;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.HotTrack;
            label16.Location = new Point(129, 522);
            label16.Name = "label16";
            label16.Size = new Size(54, 34);
            label16.TabIndex = 42;
            // 
            // label19
            // 
            label19.BackColor = SystemColors.HotTrack;
            label19.Location = new Point(569, 522);
            label19.Name = "label19";
            label19.Size = new Size(345, 34);
            label19.TabIndex = 43;
            // 
            // AircraftsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label19);
            Controls.Add(labelAircraftsCount);
            Controls.Add(label12);
            Controls.Add(labelSeatsCount);
            Controls.Add(tabControlAircraft);
            Controls.Add(label3);
            Controls.Add(listBoxSeats);
            Controls.Add(listBoxAircrafts);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label16);
            Controls.Add(label15);
            Name = "AircraftsUserControl";
            Size = new Size(1076, 624);
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRows).EndInit();
            tabControlAircraft.ResumeLayout(false);
            tabPageNewAircraft.ResumeLayout(false);
            tabPageNewAircraft.PerformLayout();
            tabPageManageAircraft.ResumeLayout(false);
            tabPageManageAircraft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddAircraft;
        private ListBox listBoxAircrafts;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownCapacity;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownRows;
        private ListBox listBoxSeats;
        private Label label6;
        private Label label3;
        private TabControl tabControlAircraft;
        private TabPage tabPageNewAircraft;
        private TabPage tabPageManageAircraft;
        private Label labelSeatsCount;
        private Button buttonDeleteAircraft;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button buttonEditAircraft;
        private NumericUpDown numericUpDownEditRows;
        private NumericUpDown numericUpDownEditCapacity;
        private Label label11;
        private Label label12;
        private Label labelAircraftsCount;
        private TextBox textBoxAircraftId;
        private Label label17;
        private TextBox textBoxAircraftIdEdit;
        private Label label18;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label19;
        private ComboBox comboBoxAirlines;
        private ComboBox comboBoxEditAirline;
        private Label label7;
        private ComboBox comboBoxBrand;
        private ComboBox comboBoxModel;
        private ComboBox comboBoxEditBrand;
        private ComboBox comboBoxEditModel;
        private Button buttonStatus;
        private Label label20;
    }
}
