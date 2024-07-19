namespace Projeto_Aeronautica
{
    partial class TicketsUserControl
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
            label14 = new Label();
            listBoxAirportDestination = new ListBox();
            label13 = new Label();
            listBoxAirportOrigin = new ListBox();
            label11 = new Label();
            dateTimePickerArrivalDate = new DateTimePicker();
            label2 = new Label();
            dateTimePickerDepartureDate = new DateTimePicker();
            listBoxAvailableSeats = new ListBox();
            listBoxFlights = new ListBox();
            checkBoxFilterDate = new CheckBox();
            checkBoxFilterOriginDestination = new CheckBox();
            textBoxFullname = new TextBox();
            comboBoxTitle = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            textBoxIdNumber = new TextBox();
            label6 = new Label();
            textBoxEmail = new TextBox();
            label9 = new Label();
            textBoxContactNumber = new TextBox();
            listBoxAirline = new ListBox();
            checkBoxFilterAirline = new CheckBox();
            groupBoxClient = new GroupBox();
            label4 = new Label();
            dateTimePickerBirth = new DateTimePicker();
            tabControlTicket = new TabControl();
            tabPageNewTicket = new TabPage();
            listBoxSeatConfiguration = new ListBox();
            buttonAddTicket = new Button();
            label19 = new Label();
            labelFlightDescription = new Label();
            label3 = new Label();
            labelSeatsCount = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label22 = new Label();
            pictureBox1 = new PictureBox();
            tabPageManageTicket = new TabPage();
            buttonSearchIdNumber = new Button();
            buttonEditTicket = new Button();
            buttonDeleteTicket = new Button();
            buttonCancelEdit = new Button();
            groupBoxFlightInfo = new GroupBox();
            labelAirline = new Label();
            labelFlightNumber = new Label();
            labelCurrentSeat = new Label();
            label21 = new Label();
            label20 = new Label();
            labelDuration = new Label();
            label23 = new Label();
            label24 = new Label();
            labelDestination = new Label();
            labelOrigin = new Label();
            labelDateArrival = new Label();
            labelDateDeparture = new Label();
            groupBoxEditClient = new GroupBox();
            label10 = new Label();
            textBoxEditFullname = new TextBox();
            comboBoxEditTitle = new ComboBox();
            dateTimePickerEditBirth = new DateTimePicker();
            label12 = new Label();
            textBoxEditIdNumber = new TextBox();
            label15 = new Label();
            label16 = new Label();
            textBoxEditContactNumber = new TextBox();
            textBoxEditEmail = new TextBox();
            label18 = new Label();
            label8 = new Label();
            textBoxSearchIdNum = new TextBox();
            panelAvailableSeatsEdit = new Panel();
            label7 = new Label();
            listBoxEditSeat = new ListBox();
            label17 = new Label();
            labelSeatsCountEdit = new Label();
            label25 = new Label();
            groupBoxClient.SuspendLayout();
            tabControlTicket.SuspendLayout();
            tabPageNewTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPageManageTicket.SuspendLayout();
            groupBoxFlightInfo.SuspendLayout();
            groupBoxEditClient.SuspendLayout();
            panelAvailableSeatsEdit.SuspendLayout();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.HotTrack;
            label14.Location = new Point(287, 11);
            label14.Name = "label14";
            label14.Size = new Size(99, 21);
            label14.TabIndex = 89;
            label14.Text = "Destination";
            // 
            // listBoxAirportDestination
            // 
            listBoxAirportDestination.Font = new Font("Segoe UI", 12F);
            listBoxAirportDestination.FormattingEnabled = true;
            listBoxAirportDestination.ItemHeight = 21;
            listBoxAirportDestination.Location = new Point(287, 34);
            listBoxAirportDestination.Name = "listBoxAirportDestination";
            listBoxAirportDestination.Size = new Size(227, 67);
            listBoxAirportDestination.TabIndex = 2;
            listBoxAirportDestination.SelectedIndexChanged += listBoxAirportDestination_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = SystemColors.HotTrack;
            label13.Location = new Point(23, 12);
            label13.Name = "label13";
            label13.Size = new Size(58, 21);
            label13.TabIndex = 87;
            label13.Text = "Origin";
            // 
            // listBoxAirportOrigin
            // 
            listBoxAirportOrigin.Font = new Font("Segoe UI", 12F);
            listBoxAirportOrigin.FormattingEnabled = true;
            listBoxAirportOrigin.ItemHeight = 21;
            listBoxAirportOrigin.Location = new Point(27, 34);
            listBoxAirportOrigin.Name = "listBoxAirportOrigin";
            listBoxAirportOrigin.Size = new Size(230, 67);
            listBoxAirportOrigin.TabIndex = 1;
            listBoxAirportOrigin.SelectedIndexChanged += listBoxAirportOrigin_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(282, 127);
            label11.Name = "label11";
            label11.Size = new Size(61, 21);
            label11.TabIndex = 78;
            label11.Text = "Arrival";
            // 
            // dateTimePickerArrivalDate
            // 
            dateTimePickerArrivalDate.CustomFormat = "";
            dateTimePickerArrivalDate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerArrivalDate.Location = new Point(285, 149);
            dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            dateTimePickerArrivalDate.Size = new Size(227, 26);
            dateTimePickerArrivalDate.TabIndex = 7;
            dateTimePickerArrivalDate.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            dateTimePickerArrivalDate.ValueChanged += dateTimePickerDepartureArrival_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(26, 127);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 72;
            label2.Text = "Departure";
            // 
            // dateTimePickerDepartureDate
            // 
            dateTimePickerDepartureDate.CustomFormat = "";
            dateTimePickerDepartureDate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerDepartureDate.Location = new Point(28, 149);
            dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            dateTimePickerDepartureDate.Size = new Size(227, 26);
            dateTimePickerDepartureDate.TabIndex = 6;
            dateTimePickerDepartureDate.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            dateTimePickerDepartureDate.ValueChanged += dateTimePickerDepartureArrival_ValueChanged;
            // 
            // listBoxAvailableSeats
            // 
            listBoxAvailableSeats.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxAvailableSeats.FormattingEnabled = true;
            listBoxAvailableSeats.ItemHeight = 21;
            listBoxAvailableSeats.Location = new Point(696, 67);
            listBoxAvailableSeats.Name = "listBoxAvailableSeats";
            listBoxAvailableSeats.Size = new Size(54, 403);
            listBoxAvailableSeats.TabIndex = 17;
            // 
            // listBoxFlights
            // 
            listBoxFlights.Font = new Font("Segoe UI", 12F);
            listBoxFlights.FormattingEnabled = true;
            listBoxFlights.ItemHeight = 21;
            listBoxFlights.Location = new Point(28, 208);
            listBoxFlights.Name = "listBoxFlights";
            listBoxFlights.Size = new Size(227, 88);
            listBoxFlights.TabIndex = 9;
            listBoxFlights.SelectedIndexChanged += listBoxFlights_SelectedIndexChanged;
            // 
            // checkBoxFilterDate
            // 
            checkBoxFilterDate.AutoSize = true;
            checkBoxFilterDate.Font = new Font("Segoe UI", 9.75F);
            checkBoxFilterDate.Location = new Point(519, 158);
            checkBoxFilterDate.Name = "checkBoxFilterDate";
            checkBoxFilterDate.Size = new Size(103, 21);
            checkBoxFilterDate.TabIndex = 8;
            checkBoxFilterDate.Text = "Filter by date";
            checkBoxFilterDate.UseVisualStyleBackColor = true;
            checkBoxFilterDate.CheckedChanged += checkBoxFilters_1;
            // 
            // checkBoxFilterOriginDestination
            // 
            checkBoxFilterOriginDestination.AutoSize = true;
            checkBoxFilterOriginDestination.Font = new Font("Segoe UI", 9.75F);
            checkBoxFilterOriginDestination.Location = new Point(28, 103);
            checkBoxFilterOriginDestination.Name = "checkBoxFilterOriginDestination";
            checkBoxFilterOriginDestination.Size = new Size(180, 21);
            checkBoxFilterOriginDestination.TabIndex = 3;
            checkBoxFilterOriginDestination.Text = "Filter by origin/destination";
            checkBoxFilterOriginDestination.UseVisualStyleBackColor = true;
            checkBoxFilterOriginDestination.CheckedChanged += checkBoxFilters_1;
            // 
            // textBoxFullname
            // 
            textBoxFullname.Font = new Font("Segoe UI", 12F);
            textBoxFullname.Location = new Point(102, 40);
            textBoxFullname.Name = "textBoxFullname";
            textBoxFullname.Size = new Size(502, 29);
            textBoxFullname.TabIndex = 12;
            textBoxFullname.KeyPress += textBoxSanitize_KeyPress;
            // 
            // comboBoxTitle
            // 
            comboBoxTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTitle.Font = new Font("Segoe UI", 12F);
            comboBoxTitle.FormattingEnabled = true;
            comboBoxTitle.Items.AddRange(new object[] { "Title", "Mrs.", "Mr.", "Ms.", "Miss", "Dr.", "Prof." });
            comboBoxTitle.Location = new Point(23, 40);
            comboBoxTitle.Name = "comboBoxTitle";
            comboBoxTitle.Size = new Size(63, 29);
            comboBoxTitle.TabIndex = 11;
            comboBoxTitle.DropDown += comboBoxTitle_DropDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(102, 16);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 94;
            label1.Text = "Full name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(20, 74);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 97;
            label5.Text = "ID number";
            // 
            // textBoxIdNumber
            // 
            textBoxIdNumber.Font = new Font("Segoe UI", 12F);
            textBoxIdNumber.Location = new Point(21, 95);
            textBoxIdNumber.Name = "textBoxIdNumber";
            textBoxIdNumber.Size = new Size(233, 29);
            textBoxIdNumber.TabIndex = 13;
            textBoxIdNumber.KeyPress += textBoxSanitize_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(352, 74);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 101;
            label6.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(352, 95);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(252, 29);
            textBoxEmail.TabIndex = 15;
            textBoxEmail.KeyPress += textBoxSanitize_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(354, 128);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 104;
            label9.Text = "Contact number";
            // 
            // textBoxContactNumber
            // 
            textBoxContactNumber.Font = new Font("Segoe UI", 12F);
            textBoxContactNumber.Location = new Point(352, 150);
            textBoxContactNumber.Name = "textBoxContactNumber";
            textBoxContactNumber.Size = new Size(252, 29);
            textBoxContactNumber.TabIndex = 16;
            textBoxContactNumber.KeyPress += textBoxSanitize_KeyPress;
            // 
            // listBoxAirline
            // 
            listBoxAirline.Font = new Font("Segoe UI", 12F);
            listBoxAirline.FormattingEnabled = true;
            listBoxAirline.ItemHeight = 21;
            listBoxAirline.Location = new Point(545, 33);
            listBoxAirline.Name = "listBoxAirline";
            listBoxAirline.Size = new Size(123, 67);
            listBoxAirline.TabIndex = 4;
            listBoxAirline.SelectedIndexChanged += listBoxAirline_SelectedIndexChanged;
            // 
            // checkBoxFilterAirline
            // 
            checkBoxFilterAirline.AutoSize = true;
            checkBoxFilterAirline.Font = new Font("Segoe UI", 9.75F);
            checkBoxFilterAirline.Location = new Point(547, 102);
            checkBoxFilterAirline.Name = "checkBoxFilterAirline";
            checkBoxFilterAirline.Size = new Size(112, 21);
            checkBoxFilterAirline.TabIndex = 5;
            checkBoxFilterAirline.Text = "Filter by airline";
            checkBoxFilterAirline.UseVisualStyleBackColor = true;
            checkBoxFilterAirline.CheckedChanged += checkBoxFilters_1;
            // 
            // groupBoxClient
            // 
            groupBoxClient.Controls.Add(label4);
            groupBoxClient.Controls.Add(dateTimePickerBirth);
            groupBoxClient.Controls.Add(textBoxFullname);
            groupBoxClient.Controls.Add(comboBoxTitle);
            groupBoxClient.Controls.Add(label1);
            groupBoxClient.Controls.Add(textBoxIdNumber);
            groupBoxClient.Controls.Add(label9);
            groupBoxClient.Controls.Add(label5);
            groupBoxClient.Controls.Add(textBoxContactNumber);
            groupBoxClient.Controls.Add(textBoxEmail);
            groupBoxClient.Controls.Add(label6);
            groupBoxClient.Enabled = false;
            groupBoxClient.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxClient.Location = new Point(27, 306);
            groupBoxClient.Name = "groupBoxClient";
            groupBoxClient.Size = new Size(641, 199);
            groupBoxClient.TabIndex = 108;
            groupBoxClient.TabStop = false;
            groupBoxClient.Text = "Client";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(18, 128);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 106;
            label4.Text = "Date of birth";
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.CustomFormat = "";
            dateTimePickerBirth.Font = new Font("Segoe UI", 12F);
            dateTimePickerBirth.Location = new Point(21, 150);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(233, 29);
            dateTimePickerBirth.TabIndex = 14;
            dateTimePickerBirth.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // tabControlTicket
            // 
            tabControlTicket.Controls.Add(tabPageNewTicket);
            tabControlTicket.Controls.Add(tabPageManageTicket);
            tabControlTicket.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlTicket.Location = new Point(62, 23);
            tabControlTicket.Name = "tabControlTicket";
            tabControlTicket.SelectedIndex = 0;
            tabControlTicket.Size = new Size(939, 564);
            tabControlTicket.TabIndex = 109;
            tabControlTicket.SelectedIndexChanged += tabControlTicket_SelectedIndexChanged;
            // 
            // tabPageNewTicket
            // 
            tabPageNewTicket.Controls.Add(listBoxSeatConfiguration);
            tabPageNewTicket.Controls.Add(buttonAddTicket);
            tabPageNewTicket.Controls.Add(label19);
            tabPageNewTicket.Controls.Add(labelFlightDescription);
            tabPageNewTicket.Controls.Add(label3);
            tabPageNewTicket.Controls.Add(labelSeatsCount);
            tabPageNewTicket.Controls.Add(label29);
            tabPageNewTicket.Controls.Add(label30);
            tabPageNewTicket.Controls.Add(label31);
            tabPageNewTicket.Controls.Add(listBoxAirportOrigin);
            tabPageNewTicket.Controls.Add(groupBoxClient);
            tabPageNewTicket.Controls.Add(listBoxFlights);
            tabPageNewTicket.Controls.Add(listBoxAvailableSeats);
            tabPageNewTicket.Controls.Add(checkBoxFilterAirline);
            tabPageNewTicket.Controls.Add(listBoxAirline);
            tabPageNewTicket.Controls.Add(dateTimePickerDepartureDate);
            tabPageNewTicket.Controls.Add(checkBoxFilterOriginDestination);
            tabPageNewTicket.Controls.Add(label2);
            tabPageNewTicket.Controls.Add(checkBoxFilterDate);
            tabPageNewTicket.Controls.Add(dateTimePickerArrivalDate);
            tabPageNewTicket.Controls.Add(label14);
            tabPageNewTicket.Controls.Add(label11);
            tabPageNewTicket.Controls.Add(listBoxAirportDestination);
            tabPageNewTicket.Controls.Add(label13);
            tabPageNewTicket.Controls.Add(label22);
            tabPageNewTicket.Controls.Add(pictureBox1);
            tabPageNewTicket.Location = new Point(4, 34);
            tabPageNewTicket.Name = "tabPageNewTicket";
            tabPageNewTicket.Padding = new Padding(3);
            tabPageNewTicket.Size = new Size(931, 526);
            tabPageNewTicket.TabIndex = 0;
            tabPageNewTicket.Text = " New Ticket ";
            tabPageNewTicket.UseVisualStyleBackColor = true;
            // 
            // listBoxSeatConfiguration
            // 
            listBoxSeatConfiguration.BorderStyle = BorderStyle.None;
            listBoxSeatConfiguration.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxSeatConfiguration.FormattingEnabled = true;
            listBoxSeatConfiguration.HorizontalScrollbar = true;
            listBoxSeatConfiguration.ItemHeight = 18;
            listBoxSeatConfiguration.Location = new Point(781, 155);
            listBoxSeatConfiguration.Name = "listBoxSeatConfiguration";
            listBoxSeatConfiguration.SelectionMode = SelectionMode.None;
            listBoxSeatConfiguration.Size = new Size(116, 288);
            listBoxSeatConfiguration.TabIndex = 117;
            // 
            // buttonAddTicket
            // 
            buttonAddTicket.BackColor = SystemColors.HotTrack;
            buttonAddTicket.FlatStyle = FlatStyle.Flat;
            buttonAddTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddTicket.ForeColor = Color.FromArgb(250, 250, 250);
            buttonAddTicket.Location = new Point(788, 463);
            buttonAddTicket.Name = "buttonAddTicket";
            buttonAddTicket.Size = new Size(103, 36);
            buttonAddTicket.TabIndex = 18;
            buttonAddTicket.Text = "Purchase";
            buttonAddTicket.UseVisualStyleBackColor = false;
            buttonAddTicket.Click += buttonAddTicket_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.HotTrack;
            label19.Location = new Point(27, 185);
            label19.Name = "label19";
            label19.Size = new Size(61, 21);
            label19.TabIndex = 116;
            label19.Text = "Flights";
            // 
            // labelFlightDescription
            // 
            labelFlightDescription.BackColor = Color.White;
            labelFlightDescription.BorderStyle = BorderStyle.FixedSingle;
            labelFlightDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFlightDescription.ForeColor = Color.Black;
            labelFlightDescription.Location = new Point(284, 208);
            labelFlightDescription.Name = "labelFlightDescription";
            labelFlightDescription.Size = new Size(384, 88);
            labelFlightDescription.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(542, 11);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 114;
            label3.Text = "Airline";
            // 
            // labelSeatsCount
            // 
            labelSeatsCount.BackColor = SystemColors.HotTrack;
            labelSeatsCount.Font = new Font("Segoe UI", 12F);
            labelSeatsCount.ForeColor = Color.FromArgb(250, 250, 250);
            labelSeatsCount.Location = new Point(699, 473);
            labelSeatsCount.Name = "labelSeatsCount";
            labelSeatsCount.Size = new Size(50, 27);
            labelSeatsCount.TabIndex = 113;
            labelSeatsCount.Text = "0";
            labelSeatsCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // label29
            // 
            label29.BackColor = SystemColors.HotTrack;
            label29.Location = new Point(696, 468);
            label29.Name = "label29";
            label29.Size = new Size(54, 34);
            label29.TabIndex = 112;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = SystemColors.HotTrack;
            label30.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.FromArgb(250, 250, 250);
            label30.Location = new Point(699, 38);
            label30.Name = "label30";
            label30.Size = new Size(50, 21);
            label30.TabIndex = 110;
            label30.Text = "Seats";
            // 
            // label31
            // 
            label31.BackColor = SystemColors.HotTrack;
            label31.Location = new Point(696, 33);
            label31.Name = "label31";
            label31.Size = new Size(54, 34);
            label31.TabIndex = 111;
            // 
            // label22
            // 
            label22.BackColor = SystemColors.HotTrack;
            label22.Location = new Point(775, 149);
            label22.Name = "label22";
            label22.Size = new Size(128, 299);
            label22.TabIndex = 118;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.airplaneNose4;
            pictureBox1.Location = new Point(768, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 119;
            pictureBox1.TabStop = false;
            // 
            // tabPageManageTicket
            // 
            tabPageManageTicket.Controls.Add(buttonSearchIdNumber);
            tabPageManageTicket.Controls.Add(buttonEditTicket);
            tabPageManageTicket.Controls.Add(buttonDeleteTicket);
            tabPageManageTicket.Controls.Add(buttonCancelEdit);
            tabPageManageTicket.Controls.Add(groupBoxFlightInfo);
            tabPageManageTicket.Controls.Add(groupBoxEditClient);
            tabPageManageTicket.Controls.Add(label8);
            tabPageManageTicket.Controls.Add(textBoxSearchIdNum);
            tabPageManageTicket.Controls.Add(panelAvailableSeatsEdit);
            tabPageManageTicket.Location = new Point(4, 34);
            tabPageManageTicket.Name = "tabPageManageTicket";
            tabPageManageTicket.Padding = new Padding(3);
            tabPageManageTicket.Size = new Size(931, 526);
            tabPageManageTicket.TabIndex = 1;
            tabPageManageTicket.Text = " Manage Ticket ";
            tabPageManageTicket.UseVisualStyleBackColor = true;
            // 
            // buttonSearchIdNumber
            // 
            buttonSearchIdNumber.BackColor = SystemColors.HotTrack;
            buttonSearchIdNumber.FlatStyle = FlatStyle.Flat;
            buttonSearchIdNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearchIdNumber.ForeColor = Color.FromArgb(250, 250, 250);
            buttonSearchIdNumber.Location = new Point(250, 51);
            buttonSearchIdNumber.Name = "buttonSearchIdNumber";
            buttonSearchIdNumber.Size = new Size(103, 36);
            buttonSearchIdNumber.TabIndex = 20;
            buttonSearchIdNumber.Text = "Search";
            buttonSearchIdNumber.UseVisualStyleBackColor = false;
            buttonSearchIdNumber.Click += buttonSearchIdNumber_Click;
            // 
            // buttonEditTicket
            // 
            buttonEditTicket.BackColor = SystemColors.HotTrack;
            buttonEditTicket.Enabled = false;
            buttonEditTicket.FlatStyle = FlatStyle.Flat;
            buttonEditTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditTicket.ForeColor = Color.FromArgb(250, 250, 250);
            buttonEditTicket.Location = new Point(788, 463);
            buttonEditTicket.Name = "buttonEditTicket";
            buttonEditTicket.Size = new Size(103, 36);
            buttonEditTicket.TabIndex = 29;
            buttonEditTicket.Text = "Save";
            buttonEditTicket.UseVisualStyleBackColor = false;
            buttonEditTicket.Visible = false;
            buttonEditTicket.Click += buttonEditTicket_Click;
            // 
            // buttonDeleteTicket
            // 
            buttonDeleteTicket.BackColor = SystemColors.HotTrack;
            buttonDeleteTicket.Enabled = false;
            buttonDeleteTicket.FlatStyle = FlatStyle.Flat;
            buttonDeleteTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteTicket.ForeColor = Color.FromArgb(250, 250, 250);
            buttonDeleteTicket.Location = new Point(788, 412);
            buttonDeleteTicket.Name = "buttonDeleteTicket";
            buttonDeleteTicket.Size = new Size(103, 36);
            buttonDeleteTicket.TabIndex = 30;
            buttonDeleteTicket.Text = "Remove";
            buttonDeleteTicket.UseVisualStyleBackColor = false;
            buttonDeleteTicket.Visible = false;
            buttonDeleteTicket.Click += buttonDeleteTicket_Click;
            // 
            // buttonCancelEdit
            // 
            buttonCancelEdit.BackColor = SystemColors.HotTrack;
            buttonCancelEdit.FlatStyle = FlatStyle.Flat;
            buttonCancelEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelEdit.ForeColor = Color.FromArgb(250, 250, 250);
            buttonCancelEdit.Location = new Point(375, 51);
            buttonCancelEdit.Name = "buttonCancelEdit";
            buttonCancelEdit.Size = new Size(103, 36);
            buttonCancelEdit.TabIndex = 21;
            buttonCancelEdit.Text = "Cancel";
            buttonCancelEdit.UseVisualStyleBackColor = false;
            buttonCancelEdit.Click += buttonCancelEdit_Click;
            // 
            // groupBoxFlightInfo
            // 
            groupBoxFlightInfo.Controls.Add(labelAirline);
            groupBoxFlightInfo.Controls.Add(labelFlightNumber);
            groupBoxFlightInfo.Controls.Add(labelCurrentSeat);
            groupBoxFlightInfo.Controls.Add(label21);
            groupBoxFlightInfo.Controls.Add(label20);
            groupBoxFlightInfo.Controls.Add(labelDuration);
            groupBoxFlightInfo.Controls.Add(label23);
            groupBoxFlightInfo.Controls.Add(label24);
            groupBoxFlightInfo.Controls.Add(labelDestination);
            groupBoxFlightInfo.Controls.Add(labelOrigin);
            groupBoxFlightInfo.Controls.Add(labelDateArrival);
            groupBoxFlightInfo.Controls.Add(labelDateDeparture);
            groupBoxFlightInfo.Enabled = false;
            groupBoxFlightInfo.Font = new Font("Segoe UI Light", 12F);
            groupBoxFlightInfo.Location = new Point(27, 110);
            groupBoxFlightInfo.Name = "groupBoxFlightInfo";
            groupBoxFlightInfo.Size = new Size(641, 166);
            groupBoxFlightInfo.TabIndex = 128;
            groupBoxFlightInfo.TabStop = false;
            groupBoxFlightInfo.Text = "Flight";
            groupBoxFlightInfo.Visible = false;
            // 
            // labelAirline
            // 
            labelAirline.AutoSize = true;
            labelAirline.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            labelAirline.ForeColor = SystemColors.HotTrack;
            labelAirline.Location = new Point(18, 26);
            labelAirline.Name = "labelAirline";
            labelAirline.Size = new Size(75, 25);
            labelAirline.TabIndex = 127;
            labelAirline.Text = "Airline";
            // 
            // labelFlightNumber
            // 
            labelFlightNumber.AutoSize = true;
            labelFlightNumber.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            labelFlightNumber.ForeColor = SystemColors.HotTrack;
            labelFlightNumber.Location = new Point(248, 30);
            labelFlightNumber.Name = "labelFlightNumber";
            labelFlightNumber.Size = new Size(147, 25);
            labelFlightNumber.TabIndex = 126;
            labelFlightNumber.Text = "Flight Number";
            // 
            // labelCurrentSeat
            // 
            labelCurrentSeat.AutoSize = true;
            labelCurrentSeat.Font = new Font("Segoe UI", 12F);
            labelCurrentSeat.ForeColor = Color.Black;
            labelCurrentSeat.Location = new Point(581, 59);
            labelCurrentSeat.Name = "labelCurrentSeat";
            labelCurrentSeat.Size = new Size(38, 21);
            labelCurrentSeat.TabIndex = 114;
            labelCurrentSeat.Text = "N/A";
            labelCurrentSeat.TextAlign = ContentAlignment.TopRight;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label21.ForeColor = SystemColors.HotTrack;
            label21.Location = new Point(554, 107);
            label21.Name = "label21";
            label21.Size = new Size(73, 21);
            label21.TabIndex = 125;
            label21.Text = "Duration";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label20.ForeColor = SystemColors.HotTrack;
            label20.Location = new Point(528, 38);
            label20.Name = "label20";
            label20.Size = new Size(99, 21);
            label20.TabIndex = 113;
            label20.Text = "Current seat";
            // 
            // labelDuration
            // 
            labelDuration.Font = new Font("Segoe UI", 12F);
            labelDuration.ForeColor = Color.Black;
            labelDuration.Location = new Point(519, 128);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(105, 21);
            labelDuration.TabIndex = 124;
            labelDuration.Text = "00:00:00";
            labelDuration.TextAlign = ContentAlignment.TopRight;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label23.ForeColor = SystemColors.HotTrack;
            label23.Location = new Point(248, 58);
            label23.Name = "label23";
            label23.Size = new Size(27, 21);
            label23.TabIndex = 122;
            label23.Text = "To";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label24.ForeColor = SystemColors.HotTrack;
            label24.Location = new Point(18, 58);
            label24.Name = "label24";
            label24.Size = new Size(48, 21);
            label24.TabIndex = 121;
            label24.Text = "From";
            // 
            // labelDestination
            // 
            labelDestination.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDestination.ForeColor = Color.Black;
            labelDestination.Location = new Point(248, 81);
            labelDestination.Name = "labelDestination";
            labelDestination.Size = new Size(239, 47);
            labelDestination.TabIndex = 119;
            labelDestination.Text = "Destination";
            // 
            // labelOrigin
            // 
            labelOrigin.Font = new Font("Segoe UI", 12F);
            labelOrigin.ForeColor = Color.Black;
            labelOrigin.Location = new Point(18, 81);
            labelOrigin.Name = "labelOrigin";
            labelOrigin.Size = new Size(212, 47);
            labelOrigin.TabIndex = 118;
            labelOrigin.Text = "Origin";
            // 
            // labelDateArrival
            // 
            labelDateArrival.AutoSize = true;
            labelDateArrival.Font = new Font("Segoe UI", 12F);
            labelDateArrival.ForeColor = Color.Black;
            labelDateArrival.Location = new Point(248, 128);
            labelDateArrival.Name = "labelDateArrival";
            labelDateArrival.Size = new Size(90, 21);
            labelDateArrival.TabIndex = 117;
            labelDateArrival.Text = "Date arrival";
            // 
            // labelDateDeparture
            // 
            labelDateDeparture.AutoSize = true;
            labelDateDeparture.Font = new Font("Segoe UI", 12F);
            labelDateDeparture.ForeColor = Color.Black;
            labelDateDeparture.Location = new Point(18, 128);
            labelDateDeparture.Name = "labelDateDeparture";
            labelDateDeparture.Size = new Size(114, 21);
            labelDateDeparture.TabIndex = 116;
            labelDateDeparture.Text = "Date departure";
            // 
            // groupBoxEditClient
            // 
            groupBoxEditClient.Controls.Add(label10);
            groupBoxEditClient.Controls.Add(textBoxEditFullname);
            groupBoxEditClient.Controls.Add(comboBoxEditTitle);
            groupBoxEditClient.Controls.Add(dateTimePickerEditBirth);
            groupBoxEditClient.Controls.Add(label12);
            groupBoxEditClient.Controls.Add(textBoxEditIdNumber);
            groupBoxEditClient.Controls.Add(label15);
            groupBoxEditClient.Controls.Add(label16);
            groupBoxEditClient.Controls.Add(textBoxEditContactNumber);
            groupBoxEditClient.Controls.Add(textBoxEditEmail);
            groupBoxEditClient.Controls.Add(label18);
            groupBoxEditClient.Enabled = false;
            groupBoxEditClient.Font = new Font("Segoe UI Light", 12F);
            groupBoxEditClient.Location = new Point(27, 306);
            groupBoxEditClient.Name = "groupBoxEditClient";
            groupBoxEditClient.Size = new Size(641, 199);
            groupBoxEditClient.TabIndex = 109;
            groupBoxEditClient.TabStop = false;
            groupBoxEditClient.Text = "Client";
            groupBoxEditClient.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(18, 128);
            label10.Name = "label10";
            label10.Size = new Size(107, 21);
            label10.TabIndex = 106;
            label10.Text = "Date of birth";
            // 
            // textBoxEditFullname
            // 
            textBoxEditFullname.Font = new Font("Segoe UI", 12F);
            textBoxEditFullname.Location = new Point(102, 40);
            textBoxEditFullname.Name = "textBoxEditFullname";
            textBoxEditFullname.Size = new Size(502, 29);
            textBoxEditFullname.TabIndex = 23;
            textBoxEditFullname.KeyPress += textBoxEditSanitize_KeyPress;
            // 
            // comboBoxEditTitle
            // 
            comboBoxEditTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEditTitle.FormattingEnabled = true;
            comboBoxEditTitle.Items.AddRange(new object[] { "Mrs.", "Mr.", "Ms.", "Miss", "Dr.", "Prof." });
            comboBoxEditTitle.Location = new Point(23, 40);
            comboBoxEditTitle.Name = "comboBoxEditTitle";
            comboBoxEditTitle.Size = new Size(63, 29);
            comboBoxEditTitle.TabIndex = 22;
            // 
            // dateTimePickerEditBirth
            // 
            dateTimePickerEditBirth.CustomFormat = "";
            dateTimePickerEditBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerEditBirth.Location = new Point(21, 150);
            dateTimePickerEditBirth.Name = "dateTimePickerEditBirth";
            dateTimePickerEditBirth.Size = new Size(233, 29);
            dateTimePickerEditBirth.TabIndex = 25;
            dateTimePickerEditBirth.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(102, 16);
            label12.Name = "label12";
            label12.Size = new Size(85, 21);
            label12.TabIndex = 94;
            label12.Text = "Full name";
            // 
            // textBoxEditIdNumber
            // 
            textBoxEditIdNumber.Font = new Font("Segoe UI", 12F);
            textBoxEditIdNumber.Location = new Point(21, 95);
            textBoxEditIdNumber.Name = "textBoxEditIdNumber";
            textBoxEditIdNumber.Size = new Size(233, 29);
            textBoxEditIdNumber.TabIndex = 24;
            textBoxEditIdNumber.KeyPress += textBoxEditSanitize_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = SystemColors.HotTrack;
            label15.Location = new Point(354, 128);
            label15.Name = "label15";
            label15.Size = new Size(133, 21);
            label15.TabIndex = 104;
            label15.Text = "Contact number";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.ForeColor = SystemColors.HotTrack;
            label16.Location = new Point(20, 74);
            label16.Name = "label16";
            label16.Size = new Size(91, 21);
            label16.TabIndex = 97;
            label16.Text = "ID number";
            // 
            // textBoxEditContactNumber
            // 
            textBoxEditContactNumber.Font = new Font("Segoe UI", 12F);
            textBoxEditContactNumber.Location = new Point(352, 150);
            textBoxEditContactNumber.Name = "textBoxEditContactNumber";
            textBoxEditContactNumber.Size = new Size(252, 29);
            textBoxEditContactNumber.TabIndex = 27;
            textBoxEditContactNumber.KeyPress += textBoxEditSanitize_KeyPress;
            // 
            // textBoxEditEmail
            // 
            textBoxEditEmail.Font = new Font("Segoe UI", 12F);
            textBoxEditEmail.Location = new Point(352, 95);
            textBoxEditEmail.Name = "textBoxEditEmail";
            textBoxEditEmail.Size = new Size(252, 29);
            textBoxEditEmail.TabIndex = 26;
            textBoxEditEmail.KeyPress += textBoxEditSanitize_KeyPress;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.ForeColor = SystemColors.HotTrack;
            label18.Location = new Point(352, 74);
            label18.Name = "label18";
            label18.Size = new Size(53, 21);
            label18.TabIndex = 101;
            label18.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(27, 30);
            label8.Name = "label8";
            label8.Size = new Size(195, 21);
            label8.TabIndex = 1;
            label8.Text = "Search by ticket number";
            // 
            // textBoxSearchIdNum
            // 
            textBoxSearchIdNum.Location = new Point(27, 52);
            textBoxSearchIdNum.Name = "textBoxSearchIdNum";
            textBoxSearchIdNum.Size = new Size(200, 33);
            textBoxSearchIdNum.TabIndex = 19;
            textBoxSearchIdNum.KeyPress += textBoxEditSanitize_KeyPress;
            // 
            // panelAvailableSeatsEdit
            // 
            panelAvailableSeatsEdit.Controls.Add(label7);
            panelAvailableSeatsEdit.Controls.Add(listBoxEditSeat);
            panelAvailableSeatsEdit.Controls.Add(label17);
            panelAvailableSeatsEdit.Controls.Add(labelSeatsCountEdit);
            panelAvailableSeatsEdit.Controls.Add(label25);
            panelAvailableSeatsEdit.Enabled = false;
            panelAvailableSeatsEdit.Location = new Point(682, 18);
            panelAvailableSeatsEdit.Name = "panelAvailableSeatsEdit";
            panelAvailableSeatsEdit.Size = new Size(88, 500);
            panelAvailableSeatsEdit.TabIndex = 110;
            panelAvailableSeatsEdit.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.HotTrack;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(250, 250, 250);
            label7.Location = new Point(17, 20);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 129;
            label7.Text = "Seats";
            // 
            // listBoxEditSeat
            // 
            listBoxEditSeat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxEditSeat.FormattingEnabled = true;
            listBoxEditSeat.ItemHeight = 21;
            listBoxEditSeat.Location = new Point(14, 49);
            listBoxEditSeat.Name = "listBoxEditSeat";
            listBoxEditSeat.Size = new Size(54, 403);
            listBoxEditSeat.TabIndex = 28;
            // 
            // label17
            // 
            label17.BackColor = SystemColors.HotTrack;
            label17.Location = new Point(14, 15);
            label17.Name = "label17";
            label17.Size = new Size(54, 34);
            label17.TabIndex = 130;
            // 
            // labelSeatsCountEdit
            // 
            labelSeatsCountEdit.BackColor = SystemColors.HotTrack;
            labelSeatsCountEdit.Font = new Font("Segoe UI", 12F);
            labelSeatsCountEdit.ForeColor = Color.FromArgb(250, 250, 250);
            labelSeatsCountEdit.Location = new Point(17, 455);
            labelSeatsCountEdit.Name = "labelSeatsCountEdit";
            labelSeatsCountEdit.Size = new Size(50, 27);
            labelSeatsCountEdit.TabIndex = 132;
            labelSeatsCountEdit.Text = "0";
            labelSeatsCountEdit.TextAlign = ContentAlignment.TopCenter;
            // 
            // label25
            // 
            label25.BackColor = SystemColors.HotTrack;
            label25.Location = new Point(14, 450);
            label25.Name = "label25";
            label25.Size = new Size(54, 34);
            label25.TabIndex = 131;
            // 
            // TicketsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlTicket);
            Name = "TicketsUserControl";
            Size = new Size(1076, 624);
            groupBoxClient.ResumeLayout(false);
            groupBoxClient.PerformLayout();
            tabControlTicket.ResumeLayout(false);
            tabPageNewTicket.ResumeLayout(false);
            tabPageNewTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPageManageTicket.ResumeLayout(false);
            tabPageManageTicket.PerformLayout();
            groupBoxFlightInfo.ResumeLayout(false);
            groupBoxFlightInfo.PerformLayout();
            groupBoxEditClient.ResumeLayout(false);
            groupBoxEditClient.PerformLayout();
            panelAvailableSeatsEdit.ResumeLayout(false);
            panelAvailableSeatsEdit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label14;
        private ListBox listBoxAirportDestination;
        private Label label13;
        private ListBox listBoxAirportOrigin;
        private Label label11;
        private DateTimePicker dateTimePickerArrivalDate;
        private Label label2;
        private DateTimePicker dateTimePickerDepartureDate;
        private ListBox listBoxAvailableSeats;
        private ListBox listBoxFlights;
        private CheckBox checkBoxFilterDate;
        private CheckBox checkBoxFilterOriginDestination;
        private TextBox textBoxFullname;
        private ComboBox comboBoxTitle;
        private Label label1;
        private Label label5;
        private TextBox textBoxIdNumber;
        private Label label6;
        private TextBox textBoxEmail;
        private Label label7;
        private Label label9;
        private TextBox textBoxContactNumber;
        private ListBox listBoxAirline;
        private CheckBox checkBoxFilterAirline;
        private GroupBox groupBoxClient;
        private Label label4;
        private DateTimePicker dateTimePickerBirth;
        private TabControl tabControlTicket;
        private TabPage tabPageNewTicket;
        private TabPage tabPageManageTicket;
        private TextBox textBoxSearchIdNum;
        private Label label8;
        private GroupBox groupBoxEditClient;
        private Label label10;
        private DateTimePicker dateTimePickerEditBirth;
        private TextBox textBoxEditFullname;
        private ComboBox comboBoxEditTitle;
        private Label label12;
        private TextBox textBoxEditIdNumber;
        private Label label15;
        private Label label16;
        private TextBox textBoxEditContactNumber;
        private TextBox textBoxEditEmail;
        private Label label18;
        private ListBox listBoxEditSeat;
        private Label labelCurrentSeat;
        private Label label20;
        private Label label21;
        private Label labelDuration;
        private Label label23;
        private Label label24;
        private Label labelDestination;
        private Label labelOrigin;
        private Label labelDateArrival;
        private Label labelDateDeparture;
        private Label labelAirline;
        private Label labelFlightNumber;
        private GroupBox groupBoxFlightInfo;
        private Label label30;
        private Label label31;
        private Label label3;
        private Label labelSeatsCount;
        private Label label29;
        private Label labelFlightDescription;
        private Label labelSeatsCountEdit;
        private Label label25;
        private Label label17;
        private Label label19;
        private Button buttonAddTicket;
        private Button buttonCancelEdit;
        private Button buttonSearchIdNumber;
        private Button buttonEditTicket;
        private Button buttonDeleteTicket;
        private Panel panelAvailableSeatsEdit;
        private ListBox listBoxSeatConfiguration;
        private Label label22;
        private PictureBox pictureBox1;
    }
}
