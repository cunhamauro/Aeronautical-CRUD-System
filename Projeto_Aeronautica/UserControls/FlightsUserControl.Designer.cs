namespace Projeto_Aeronautica
{
    partial class FlightsUserControl
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
            label6 = new Label();
            listBoxAirlines = new ListBox();
            listBoxAvailableSeats = new ListBox();
            listBoxFlights = new ListBox();
            label7 = new Label();
            listBoxAircrafts = new ListBox();
            label11 = new Label();
            dateTimePickerArrivalDate = new DateTimePicker();
            label2 = new Label();
            dateTimePickerDepartureDate = new DateTimePicker();
            label4 = new Label();
            label13 = new Label();
            listBoxAirportOrigin = new ListBox();
            label14 = new Label();
            listBoxAirportDestination = new ListBox();
            tabControlFlight = new TabControl();
            tabPageNewFlight = new TabPage();
            numericUpDownArrivalMinutes = new NumericUpDown();
            numericUpDownArrivalHours = new NumericUpDown();
            numericUpDownDepartureMinutes = new NumericUpDown();
            numericUpDownDepartureHours = new NumericUpDown();
            numericUpDownDurationMinutes = new NumericUpDown();
            numericUpDownDurationHours = new NumericUpDown();
            buttonAddFlight = new Button();
            label1 = new Label();
            label3 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label15 = new Label();
            tabPageManageFlight = new TabPage();
            buttonDeleteFlight = new Button();
            buttonConsultTickets = new Button();
            buttonEditFlight = new Button();
            numericUpDownEditArrivalMinutes = new NumericUpDown();
            numericUpDownEditArrivalHours = new NumericUpDown();
            numericUpDownEditDepartureMinutes = new NumericUpDown();
            numericUpDownEditDepartureHours = new NumericUpDown();
            numericUpDownEditDurationMinutes = new NumericUpDown();
            numericUpDownEditDurationHours = new NumericUpDown();
            label5 = new Label();
            label8 = new Label();
            textBoxEditAirportDestination = new TextBox();
            textBoxEditAirportOrigin = new TextBox();
            textBoxEditAirline = new TextBox();
            listBoxEditAircraft = new ListBox();
            label18 = new Label();
            dateTimePickerEditArrivalDate = new DateTimePicker();
            label27 = new Label();
            label22 = new Label();
            dateTimePickerEditDepartureDate = new DateTimePicker();
            label21 = new Label();
            label16 = new Label();
            label19 = new Label();
            label20 = new Label();
            label23 = new Label();
            label28 = new Label();
            label17 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            labelSeatsCount = new Label();
            labelFlightsCount = new Label();
            label24 = new Label();
            tabControlFlight.SuspendLayout();
            tabPageNewFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownArrivalMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownArrivalHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepartureMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepartureHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationHours).BeginInit();
            tabPageManageFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditArrivalMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditArrivalHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditDepartureMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditDepartureHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditDurationMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditDurationHours).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(37, 166);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 36;
            label6.Text = "Airline";
            // 
            // listBoxAirlines
            // 
            listBoxAirlines.Font = new Font("Segoe UI", 12F);
            listBoxAirlines.FormattingEnabled = true;
            listBoxAirlines.ItemHeight = 21;
            listBoxAirlines.Location = new Point(39, 190);
            listBoxAirlines.Name = "listBoxAirlines";
            listBoxAirlines.Size = new Size(225, 109);
            listBoxAirlines.TabIndex = 9;
            listBoxAirlines.SelectedIndexChanged += listBoxAirlines_SelectedIndexChanged;
            // 
            // listBoxAvailableSeats
            // 
            listBoxAvailableSeats.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxAvailableSeats.FormattingEnabled = true;
            listBoxAvailableSeats.ItemHeight = 21;
            listBoxAvailableSeats.Location = new Point(968, 96);
            listBoxAvailableSeats.Name = "listBoxAvailableSeats";
            listBoxAvailableSeats.Size = new Size(54, 466);
            listBoxAvailableSeats.TabIndex = 34;
            // 
            // listBoxFlights
            // 
            listBoxFlights.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxFlights.FormattingEnabled = true;
            listBoxFlights.ItemHeight = 21;
            listBoxFlights.Location = new Point(40, 430);
            listBoxFlights.Name = "listBoxFlights";
            listBoxFlights.Size = new Size(894, 130);
            listBoxFlights.TabIndex = 28;
            listBoxFlights.SelectedIndexChanged += listBoxFlights_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(289, 166);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 39;
            label7.Text = "Aircraft";
            // 
            // listBoxAircrafts
            // 
            listBoxAircrafts.Font = new Font("Segoe UI", 12F);
            listBoxAircrafts.FormattingEnabled = true;
            listBoxAircrafts.ItemHeight = 21;
            listBoxAircrafts.Location = new Point(291, 190);
            listBoxAircrafts.Name = "listBoxAircrafts";
            listBoxAircrafts.Size = new Size(225, 109);
            listBoxAircrafts.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(545, 132);
            label11.Name = "label11";
            label11.Size = new Size(61, 21);
            label11.TabIndex = 49;
            label11.Text = "Arrival";
            // 
            // dateTimePickerArrivalDate
            // 
            dateTimePickerArrivalDate.CustomFormat = "";
            dateTimePickerArrivalDate.Font = new Font("Segoe UI", 12F);
            dateTimePickerArrivalDate.Location = new Point(549, 158);
            dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            dateTimePickerArrivalDate.Size = new Size(216, 29);
            dateTimePickerArrivalDate.TabIndex = 6;
            dateTimePickerArrivalDate.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            dateTimePickerArrivalDate.ValueChanged += dateTimePickerArrivalDate_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(545, 19);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 43;
            label2.Text = "Departure";
            // 
            // dateTimePickerDepartureDate
            // 
            dateTimePickerDepartureDate.CustomFormat = "";
            dateTimePickerDepartureDate.Font = new Font("Segoe UI", 12F);
            dateTimePickerDepartureDate.Location = new Point(549, 44);
            dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            dateTimePickerDepartureDate.Size = new Size(216, 29);
            dateTimePickerDepartureDate.TabIndex = 3;
            dateTimePickerDepartureDate.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            dateTimePickerDepartureDate.ValueChanged += dateTimePickerDepartureDate_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(544, 244);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 52;
            label4.Text = "Duration";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = SystemColors.HotTrack;
            label13.Location = new Point(37, 20);
            label13.Name = "label13";
            label13.Size = new Size(58, 21);
            label13.TabIndex = 58;
            label13.Text = "Origin";
            // 
            // listBoxAirportOrigin
            // 
            listBoxAirportOrigin.Font = new Font("Segoe UI", 12F);
            listBoxAirportOrigin.FormattingEnabled = true;
            listBoxAirportOrigin.ItemHeight = 21;
            listBoxAirportOrigin.Location = new Point(39, 44);
            listBoxAirportOrigin.Name = "listBoxAirportOrigin";
            listBoxAirportOrigin.Size = new Size(225, 109);
            listBoxAirportOrigin.TabIndex = 1;
            listBoxAirportOrigin.SelectedIndexChanged += listBoxAirportOrigin_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.HotTrack;
            label14.Location = new Point(287, 20);
            label14.Name = "label14";
            label14.Size = new Size(99, 21);
            label14.TabIndex = 60;
            label14.Text = "Destination";
            // 
            // listBoxAirportDestination
            // 
            listBoxAirportDestination.Font = new Font("Segoe UI", 12F);
            listBoxAirportDestination.FormattingEnabled = true;
            listBoxAirportDestination.ItemHeight = 21;
            listBoxAirportDestination.Location = new Point(291, 44);
            listBoxAirportDestination.Name = "listBoxAirportDestination";
            listBoxAirportDestination.Size = new Size(225, 109);
            listBoxAirportDestination.TabIndex = 2;
            listBoxAirportDestination.SelectedIndexChanged += listBoxAirportDestination_SelectedIndexChanged;
            // 
            // tabControlFlight
            // 
            tabControlFlight.Controls.Add(tabPageNewFlight);
            tabControlFlight.Controls.Add(tabPageManageFlight);
            tabControlFlight.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlFlight.Location = new Point(41, 30);
            tabControlFlight.Name = "tabControlFlight";
            tabControlFlight.SelectedIndex = 0;
            tabControlFlight.Size = new Size(897, 370);
            tabControlFlight.TabIndex = 61;
            tabControlFlight.SelectedIndexChanged += tabControlFlight_SelectedIndexChanged;
            // 
            // tabPageNewFlight
            // 
            tabPageNewFlight.Controls.Add(numericUpDownArrivalMinutes);
            tabPageNewFlight.Controls.Add(numericUpDownArrivalHours);
            tabPageNewFlight.Controls.Add(numericUpDownDepartureMinutes);
            tabPageNewFlight.Controls.Add(numericUpDownDepartureHours);
            tabPageNewFlight.Controls.Add(numericUpDownDurationMinutes);
            tabPageNewFlight.Controls.Add(numericUpDownDurationHours);
            tabPageNewFlight.Controls.Add(buttonAddFlight);
            tabPageNewFlight.Controls.Add(listBoxAircrafts);
            tabPageNewFlight.Controls.Add(label14);
            tabPageNewFlight.Controls.Add(listBoxAirlines);
            tabPageNewFlight.Controls.Add(listBoxAirportDestination);
            tabPageNewFlight.Controls.Add(label13);
            tabPageNewFlight.Controls.Add(dateTimePickerArrivalDate);
            tabPageNewFlight.Controls.Add(listBoxAirportOrigin);
            tabPageNewFlight.Controls.Add(label11);
            tabPageNewFlight.Controls.Add(label2);
            tabPageNewFlight.Controls.Add(label4);
            tabPageNewFlight.Controls.Add(dateTimePickerDepartureDate);
            tabPageNewFlight.Controls.Add(label7);
            tabPageNewFlight.Controls.Add(label6);
            tabPageNewFlight.Controls.Add(label1);
            tabPageNewFlight.Controls.Add(label3);
            tabPageNewFlight.Controls.Add(label9);
            tabPageNewFlight.Controls.Add(label10);
            tabPageNewFlight.Controls.Add(label12);
            tabPageNewFlight.Controls.Add(label15);
            tabPageNewFlight.Location = new Point(4, 34);
            tabPageNewFlight.Name = "tabPageNewFlight";
            tabPageNewFlight.Padding = new Padding(3);
            tabPageNewFlight.Size = new Size(889, 332);
            tabPageNewFlight.TabIndex = 0;
            tabPageNewFlight.Text = " New Flight ";
            tabPageNewFlight.UseVisualStyleBackColor = true;
            // 
            // numericUpDownArrivalMinutes
            // 
            numericUpDownArrivalMinutes.Font = new Font("Segoe UI", 12F);
            numericUpDownArrivalMinutes.Location = new Point(609, 193);
            numericUpDownArrivalMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownArrivalMinutes.Name = "numericUpDownArrivalMinutes";
            numericUpDownArrivalMinutes.Size = new Size(43, 29);
            numericUpDownArrivalMinutes.TabIndex = 8;
            numericUpDownArrivalMinutes.ValueChanged += numericUpDownDepartureArrivalNewFlight_ValueChanged;
            // 
            // numericUpDownArrivalHours
            // 
            numericUpDownArrivalHours.Font = new Font("Segoe UI", 12F);
            numericUpDownArrivalHours.Location = new Point(549, 193);
            numericUpDownArrivalHours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownArrivalHours.Name = "numericUpDownArrivalHours";
            numericUpDownArrivalHours.Size = new Size(41, 29);
            numericUpDownArrivalHours.TabIndex = 7;
            numericUpDownArrivalHours.ValueChanged += numericUpDownDepartureArrivalNewFlight_ValueChanged;
            // 
            // numericUpDownDepartureMinutes
            // 
            numericUpDownDepartureMinutes.Font = new Font("Segoe UI", 12F);
            numericUpDownDepartureMinutes.Location = new Point(609, 79);
            numericUpDownDepartureMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownDepartureMinutes.Name = "numericUpDownDepartureMinutes";
            numericUpDownDepartureMinutes.Size = new Size(43, 29);
            numericUpDownDepartureMinutes.TabIndex = 5;
            numericUpDownDepartureMinutes.ValueChanged += numericUpDownDepartureArrivalNewFlight_ValueChanged;
            // 
            // numericUpDownDepartureHours
            // 
            numericUpDownDepartureHours.Font = new Font("Segoe UI", 12F);
            numericUpDownDepartureHours.Location = new Point(549, 79);
            numericUpDownDepartureHours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownDepartureHours.Name = "numericUpDownDepartureHours";
            numericUpDownDepartureHours.Size = new Size(41, 29);
            numericUpDownDepartureHours.TabIndex = 4;
            numericUpDownDepartureHours.ValueChanged += numericUpDownDepartureArrivalNewFlight_ValueChanged;
            // 
            // numericUpDownDurationMinutes
            // 
            numericUpDownDurationMinutes.Font = new Font("Segoe UI", 12F);
            numericUpDownDurationMinutes.Location = new Point(609, 268);
            numericUpDownDurationMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownDurationMinutes.Name = "numericUpDownDurationMinutes";
            numericUpDownDurationMinutes.Size = new Size(43, 29);
            numericUpDownDurationMinutes.TabIndex = 12;
            // 
            // numericUpDownDurationHours
            // 
            numericUpDownDurationHours.Font = new Font("Segoe UI", 12F);
            numericUpDownDurationHours.Location = new Point(549, 268);
            numericUpDownDurationHours.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDownDurationHours.Name = "numericUpDownDurationHours";
            numericUpDownDurationHours.Size = new Size(41, 29);
            numericUpDownDurationHours.TabIndex = 11;
            // 
            // buttonAddFlight
            // 
            buttonAddFlight.BackColor = SystemColors.HotTrack;
            buttonAddFlight.FlatStyle = FlatStyle.Flat;
            buttonAddFlight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddFlight.ForeColor = Color.FromArgb(250, 250, 250);
            buttonAddFlight.Location = new Point(747, 263);
            buttonAddFlight.Name = "buttonAddFlight";
            buttonAddFlight.Size = new Size(103, 36);
            buttonAddFlight.TabIndex = 13;
            buttonAddFlight.Text = "Add";
            buttonAddFlight.UseVisualStyleBackColor = false;
            buttonAddFlight.Click += buttonAddFlight_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(588, 271);
            label1.Name = "label1";
            label1.Size = new Size(21, 21);
            label1.TabIndex = 71;
            label1.Text = "H";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(650, 271);
            label3.Name = "label3";
            label3.Size = new Size(24, 21);
            label3.TabIndex = 72;
            label3.Text = "M";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(588, 82);
            label9.Name = "label9";
            label9.Size = new Size(21, 21);
            label9.TabIndex = 77;
            label9.Text = "H";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(588, 196);
            label10.Name = "label10";
            label10.Size = new Size(21, 21);
            label10.TabIndex = 78;
            label10.Text = "H";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(650, 196);
            label12.Name = "label12";
            label12.Size = new Size(24, 21);
            label12.TabIndex = 79;
            label12.Text = "M";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.ForeColor = SystemColors.HotTrack;
            label15.Location = new Point(650, 82);
            label15.Name = "label15";
            label15.Size = new Size(24, 21);
            label15.TabIndex = 80;
            label15.Text = "M";
            // 
            // tabPageManageFlight
            // 
            tabPageManageFlight.Controls.Add(buttonDeleteFlight);
            tabPageManageFlight.Controls.Add(buttonConsultTickets);
            tabPageManageFlight.Controls.Add(buttonEditFlight);
            tabPageManageFlight.Controls.Add(numericUpDownEditArrivalMinutes);
            tabPageManageFlight.Controls.Add(numericUpDownEditArrivalHours);
            tabPageManageFlight.Controls.Add(numericUpDownEditDepartureMinutes);
            tabPageManageFlight.Controls.Add(numericUpDownEditDepartureHours);
            tabPageManageFlight.Controls.Add(numericUpDownEditDurationMinutes);
            tabPageManageFlight.Controls.Add(numericUpDownEditDurationHours);
            tabPageManageFlight.Controls.Add(label5);
            tabPageManageFlight.Controls.Add(label8);
            tabPageManageFlight.Controls.Add(textBoxEditAirportDestination);
            tabPageManageFlight.Controls.Add(textBoxEditAirportOrigin);
            tabPageManageFlight.Controls.Add(textBoxEditAirline);
            tabPageManageFlight.Controls.Add(listBoxEditAircraft);
            tabPageManageFlight.Controls.Add(label18);
            tabPageManageFlight.Controls.Add(dateTimePickerEditArrivalDate);
            tabPageManageFlight.Controls.Add(label27);
            tabPageManageFlight.Controls.Add(label22);
            tabPageManageFlight.Controls.Add(dateTimePickerEditDepartureDate);
            tabPageManageFlight.Controls.Add(label21);
            tabPageManageFlight.Controls.Add(label16);
            tabPageManageFlight.Controls.Add(label19);
            tabPageManageFlight.Controls.Add(label20);
            tabPageManageFlight.Controls.Add(label23);
            tabPageManageFlight.Location = new Point(4, 34);
            tabPageManageFlight.Name = "tabPageManageFlight";
            tabPageManageFlight.Padding = new Padding(3);
            tabPageManageFlight.Size = new Size(889, 332);
            tabPageManageFlight.TabIndex = 1;
            tabPageManageFlight.Text = " Manage Flight ";
            tabPageManageFlight.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFlight
            // 
            buttonDeleteFlight.BackColor = SystemColors.HotTrack;
            buttonDeleteFlight.FlatStyle = FlatStyle.Flat;
            buttonDeleteFlight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteFlight.ForeColor = Color.FromArgb(250, 250, 250);
            buttonDeleteFlight.Location = new Point(484, 264);
            buttonDeleteFlight.Name = "buttonDeleteFlight";
            buttonDeleteFlight.Size = new Size(103, 36);
            buttonDeleteFlight.TabIndex = 25;
            buttonDeleteFlight.Text = "Remove";
            buttonDeleteFlight.UseVisualStyleBackColor = false;
            buttonDeleteFlight.Click += buttonDeleteFlight_Click;
            // 
            // buttonConsultTickets
            // 
            buttonConsultTickets.BackColor = SystemColors.HotTrack;
            buttonConsultTickets.FlatStyle = FlatStyle.Flat;
            buttonConsultTickets.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConsultTickets.ForeColor = Color.FromArgb(250, 250, 250);
            buttonConsultTickets.Location = new Point(616, 263);
            buttonConsultTickets.Name = "buttonConsultTickets";
            buttonConsultTickets.Size = new Size(103, 36);
            buttonConsultTickets.TabIndex = 24;
            buttonConsultTickets.Text = "Tickets";
            buttonConsultTickets.UseVisualStyleBackColor = false;
            buttonConsultTickets.Click += buttonConsultTickets_Click;
            // 
            // buttonEditFlight
            // 
            buttonEditFlight.BackColor = SystemColors.HotTrack;
            buttonEditFlight.FlatStyle = FlatStyle.Flat;
            buttonEditFlight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditFlight.ForeColor = Color.FromArgb(250, 250, 250);
            buttonEditFlight.Location = new Point(747, 263);
            buttonEditFlight.Name = "buttonEditFlight";
            buttonEditFlight.Size = new Size(103, 36);
            buttonEditFlight.TabIndex = 23;
            buttonEditFlight.Text = "Save";
            buttonEditFlight.UseVisualStyleBackColor = false;
            buttonEditFlight.Click += buttonEditFlight_Click;
            // 
            // numericUpDownEditArrivalMinutes
            // 
            numericUpDownEditArrivalMinutes.Font = new Font("Segoe UI", 12F);
            numericUpDownEditArrivalMinutes.Location = new Point(620, 163);
            numericUpDownEditArrivalMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownEditArrivalMinutes.Name = "numericUpDownEditArrivalMinutes";
            numericUpDownEditArrivalMinutes.Size = new Size(43, 29);
            numericUpDownEditArrivalMinutes.TabIndex = 19;
            numericUpDownEditArrivalMinutes.ValueChanged += numericUpDownDepartureArrivalEditFlight_ValueChanged;
            // 
            // numericUpDownEditArrivalHours
            // 
            numericUpDownEditArrivalHours.Font = new Font("Segoe UI", 12F);
            numericUpDownEditArrivalHours.Location = new Point(562, 163);
            numericUpDownEditArrivalHours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownEditArrivalHours.Name = "numericUpDownEditArrivalHours";
            numericUpDownEditArrivalHours.Size = new Size(39, 29);
            numericUpDownEditArrivalHours.TabIndex = 18;
            numericUpDownEditArrivalHours.ValueChanged += numericUpDownDepartureArrivalEditFlight_ValueChanged;
            // 
            // numericUpDownEditDepartureMinutes
            // 
            numericUpDownEditDepartureMinutes.Font = new Font("Segoe UI", 12F);
            numericUpDownEditDepartureMinutes.Location = new Point(359, 163);
            numericUpDownEditDepartureMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownEditDepartureMinutes.Name = "numericUpDownEditDepartureMinutes";
            numericUpDownEditDepartureMinutes.Size = new Size(43, 29);
            numericUpDownEditDepartureMinutes.TabIndex = 16;
            numericUpDownEditDepartureMinutes.ValueChanged += numericUpDownDepartureArrivalEditFlight_ValueChanged;
            // 
            // numericUpDownEditDepartureHours
            // 
            numericUpDownEditDepartureHours.Font = new Font("Segoe UI", 12F);
            numericUpDownEditDepartureHours.Location = new Point(301, 163);
            numericUpDownEditDepartureHours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownEditDepartureHours.Name = "numericUpDownEditDepartureHours";
            numericUpDownEditDepartureHours.Size = new Size(39, 29);
            numericUpDownEditDepartureHours.TabIndex = 15;
            numericUpDownEditDepartureHours.ValueChanged += numericUpDownDepartureArrivalEditFlight_ValueChanged;
            // 
            // numericUpDownEditDurationMinutes
            // 
            numericUpDownEditDurationMinutes.Font = new Font("Segoe UI", 12F);
            numericUpDownEditDurationMinutes.Location = new Point(359, 270);
            numericUpDownEditDurationMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownEditDurationMinutes.Name = "numericUpDownEditDurationMinutes";
            numericUpDownEditDurationMinutes.Size = new Size(43, 29);
            numericUpDownEditDurationMinutes.TabIndex = 22;
            // 
            // numericUpDownEditDurationHours
            // 
            numericUpDownEditDurationHours.Font = new Font("Segoe UI", 12F);
            numericUpDownEditDurationHours.Location = new Point(299, 270);
            numericUpDownEditDurationHours.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDownEditDurationHours.Name = "numericUpDownEditDurationHours";
            numericUpDownEditDurationHours.Size = new Size(41, 29);
            numericUpDownEditDurationHours.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(338, 273);
            label5.Name = "label5";
            label5.Size = new Size(21, 21);
            label5.TabIndex = 99;
            label5.Text = "H";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(400, 273);
            label8.Name = "label8";
            label8.Size = new Size(24, 21);
            label8.TabIndex = 100;
            label8.Text = "M";
            // 
            // textBoxEditAirportDestination
            // 
            textBoxEditAirportDestination.Enabled = false;
            textBoxEditAirportDestination.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEditAirportDestination.Location = new Point(562, 45);
            textBoxEditAirportDestination.Name = "textBoxEditAirportDestination";
            textBoxEditAirportDestination.Size = new Size(233, 29);
            textBoxEditAirportDestination.TabIndex = 95;
            // 
            // textBoxEditAirportOrigin
            // 
            textBoxEditAirportOrigin.Enabled = false;
            textBoxEditAirportOrigin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEditAirportOrigin.Location = new Point(299, 45);
            textBoxEditAirportOrigin.Name = "textBoxEditAirportOrigin";
            textBoxEditAirportOrigin.Size = new Size(232, 29);
            textBoxEditAirportOrigin.TabIndex = 94;
            // 
            // textBoxEditAirline
            // 
            textBoxEditAirline.Enabled = false;
            textBoxEditAirline.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEditAirline.Location = new Point(41, 45);
            textBoxEditAirline.Name = "textBoxEditAirline";
            textBoxEditAirline.Size = new Size(229, 29);
            textBoxEditAirline.TabIndex = 93;
            // 
            // listBoxEditAircraft
            // 
            listBoxEditAircraft.Font = new Font("Segoe UI", 12F);
            listBoxEditAircraft.FormattingEnabled = true;
            listBoxEditAircraft.ItemHeight = 21;
            listBoxEditAircraft.Location = new Point(41, 126);
            listBoxEditAircraft.Name = "listBoxEditAircraft";
            listBoxEditAircraft.Size = new Size(229, 172);
            listBoxEditAircraft.TabIndex = 20;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.ForeColor = SystemColors.HotTrack;
            label18.Location = new Point(38, 102);
            label18.Name = "label18";
            label18.Size = new Size(144, 21);
            label18.TabIndex = 65;
            label18.Text = "Select the aircraft";
            // 
            // dateTimePickerEditArrivalDate
            // 
            dateTimePickerEditArrivalDate.CustomFormat = "";
            dateTimePickerEditArrivalDate.Font = new Font("Segoe UI", 12F);
            dateTimePickerEditArrivalDate.Location = new Point(562, 126);
            dateTimePickerEditArrivalDate.Name = "dateTimePickerEditArrivalDate";
            dateTimePickerEditArrivalDate.Size = new Size(233, 29);
            dateTimePickerEditArrivalDate.TabIndex = 17;
            dateTimePickerEditArrivalDate.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            dateTimePickerEditArrivalDate.ValueChanged += dateTimePickerEditArrivalDate_ValueChanged;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label27.ForeColor = SystemColors.HotTrack;
            label27.Location = new Point(560, 102);
            label27.Name = "label27";
            label27.Size = new Size(99, 21);
            label27.TabIndex = 75;
            label27.Text = "Arrival date";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.HotTrack;
            label22.Location = new Point(294, 242);
            label22.Name = "label22";
            label22.Size = new Size(78, 21);
            label22.TabIndex = 78;
            label22.Text = "Duration";
            // 
            // dateTimePickerEditDepartureDate
            // 
            dateTimePickerEditDepartureDate.CustomFormat = "";
            dateTimePickerEditDepartureDate.Font = new Font("Segoe UI", 12F);
            dateTimePickerEditDepartureDate.Location = new Point(301, 126);
            dateTimePickerEditDepartureDate.Name = "dateTimePickerEditDepartureDate";
            dateTimePickerEditDepartureDate.Size = new Size(232, 29);
            dateTimePickerEditDepartureDate.TabIndex = 14;
            dateTimePickerEditDepartureDate.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            dateTimePickerEditDepartureDate.ValueChanged += dateTimePickerEditDepartureDate_ValueChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label21.ForeColor = SystemColors.HotTrack;
            label21.Location = new Point(299, 102);
            label21.Name = "label21";
            label21.Size = new Size(125, 21);
            label21.TabIndex = 69;
            label21.Text = "Departure date";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.ForeColor = SystemColors.HotTrack;
            label16.Location = new Point(338, 166);
            label16.Name = "label16";
            label16.Size = new Size(21, 21);
            label16.TabIndex = 105;
            label16.Text = "H";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F);
            label19.ForeColor = SystemColors.HotTrack;
            label19.Location = new Point(400, 166);
            label19.Name = "label19";
            label19.Size = new Size(24, 21);
            label19.TabIndex = 106;
            label19.Text = "M";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F);
            label20.ForeColor = SystemColors.HotTrack;
            label20.Location = new Point(599, 166);
            label20.Name = "label20";
            label20.Size = new Size(21, 21);
            label20.TabIndex = 107;
            label20.Text = "H";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.ForeColor = SystemColors.HotTrack;
            label23.Location = new Point(661, 167);
            label23.Name = "label23";
            label23.Size = new Size(24, 21);
            label23.TabIndex = 108;
            label23.Text = "M";
            // 
            // label28
            // 
            label28.BackColor = SystemColors.HotTrack;
            label28.Location = new Point(41, 396);
            label28.Name = "label28";
            label28.Size = new Size(893, 34);
            label28.TabIndex = 65;
            // 
            // label17
            // 
            label17.BackColor = SystemColors.HotTrack;
            label17.Location = new Point(40, 560);
            label17.Name = "label17";
            label17.Size = new Size(894, 34);
            label17.TabIndex = 66;
            // 
            // label29
            // 
            label29.BackColor = SystemColors.HotTrack;
            label29.Location = new Point(968, 560);
            label29.Name = "label29";
            label29.Size = new Size(54, 34);
            label29.TabIndex = 67;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = SystemColors.HotTrack;
            label30.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.FromArgb(250, 250, 250);
            label30.Location = new Point(971, 67);
            label30.Name = "label30";
            label30.Size = new Size(50, 21);
            label30.TabIndex = 68;
            label30.Text = "Seats";
            // 
            // label31
            // 
            label31.BackColor = SystemColors.HotTrack;
            label31.Location = new Point(968, 62);
            label31.Name = "label31";
            label31.Size = new Size(54, 34);
            label31.TabIndex = 69;
            // 
            // labelSeatsCount
            // 
            labelSeatsCount.BackColor = SystemColors.HotTrack;
            labelSeatsCount.Font = new Font("Segoe UI", 12F);
            labelSeatsCount.ForeColor = Color.FromArgb(250, 250, 250);
            labelSeatsCount.Location = new Point(971, 565);
            labelSeatsCount.Name = "labelSeatsCount";
            labelSeatsCount.Size = new Size(50, 27);
            labelSeatsCount.TabIndex = 70;
            labelSeatsCount.Text = "0";
            labelSeatsCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFlightsCount
            // 
            labelFlightsCount.BackColor = SystemColors.HotTrack;
            labelFlightsCount.Font = new Font("Segoe UI", 12F);
            labelFlightsCount.ForeColor = Color.FromArgb(250, 250, 250);
            labelFlightsCount.Location = new Point(40, 565);
            labelFlightsCount.Name = "labelFlightsCount";
            labelFlightsCount.Size = new Size(894, 20);
            labelFlightsCount.TabIndex = 71;
            labelFlightsCount.Text = "0";
            labelFlightsCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // label24
            // 
            label24.BackColor = SystemColors.HotTrack;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.FromArgb(250, 250, 250);
            label24.Location = new Point(41, 399);
            label24.Name = "label24";
            label24.Size = new Size(893, 25);
            label24.TabIndex = 72;
            label24.Text = "Flights";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FlightsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label24);
            Controls.Add(labelFlightsCount);
            Controls.Add(labelSeatsCount);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(label29);
            Controls.Add(label17);
            Controls.Add(label28);
            Controls.Add(tabControlFlight);
            Controls.Add(listBoxAvailableSeats);
            Controls.Add(listBoxFlights);
            Name = "FlightsUserControl";
            Size = new Size(1076, 624);
            tabControlFlight.ResumeLayout(false);
            tabPageNewFlight.ResumeLayout(false);
            tabPageNewFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownArrivalMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownArrivalHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepartureMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepartureHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationHours).EndInit();
            tabPageManageFlight.ResumeLayout(false);
            tabPageManageFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditArrivalMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditArrivalHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditDepartureMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditDepartureHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditDurationMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditDurationHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private ListBox listBoxAirlines;
        private ListBox listBoxAvailableSeats;
        private ListBox listBoxFlights;
        private Label label7;
        private ListBox listBoxAircrafts;
        private Label label11;
        private DateTimePicker dateTimePickerArrivalDate;
        private Label label2;
        private DateTimePicker dateTimePickerDepartureDate;
        private Label label4;
        private Label label13;
        private ListBox listBoxAirportOrigin;
        private Label label14;
        private ListBox listBoxAirportDestination;
        private TabControl tabControlFlight;
        private TabPage tabPageNewFlight;
        private TabPage tabPageManageFlight;
        private ListBox listBoxEditAircraft;
        private ListBox listBoxEditAirportDestination;
        private ListBox listBox3;
        private ListBox listBoxEditAirportOrigin;
        private Label label18;
        private DateTimePicker dateTimePickerEditDepartureDate;
        private Label label21;
        private Label label22;
        private DateTimePicker dateTimePickerEditArrivalDate;
        private Label label27;
        private Label label28;
        private Label label17;
        private Button buttonAddFlight;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label labelSeatsCount;
        private Label labelAircraftsCount;
        private Label label24;
        private TextBox textBoxEditAirportDestination;
        private TextBox textBoxEditAirportOrigin;
        private TextBox textBoxEditAirline;
        private Label labelFlightsCount;
        private NumericUpDown numericUpDownDurationMinutes;
        private NumericUpDown numericUpDownDurationHours;
        private Label label1;
        private Label label3;
        private NumericUpDown numericUpDownEditDurationMinutes;
        private NumericUpDown numericUpDownEditDurationHours;
        private Label label5;
        private Label label8;
        private NumericUpDown numericUpDownArrivalMinutes;
        private NumericUpDown numericUpDownArrivalHours;
        private NumericUpDown numericUpDownDepartureMinutes;
        private NumericUpDown numericUpDownDepartureHours;
        private NumericUpDown numericUpDownEditArrivalMinutes;
        private NumericUpDown numericUpDownEditArrivalHours;
        private NumericUpDown numericUpDownEditDepartureMinutes;
        private NumericUpDown numericUpDownEditDepartureHours;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label15;
        private Label label16;
        private Label label19;
        private Label label20;
        private Label label23;
        private Button buttonDeleteFlight;
        private Button buttonConsultTickets;
        private Button buttonEditFlight;
    }
}
