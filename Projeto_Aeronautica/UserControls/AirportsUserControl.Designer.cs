namespace Projeto_Aeronautica
{
    partial class AirportsUserControl
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
            textBoxIATA = new TextBox();
            textBoxCountry = new TextBox();
            textBoxCity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBoxAirports = new ListBox();
            tabControlAirport = new TabControl();
            tabPageNewAirport = new TabPage();
            buttonAddAirport = new Button();
            tabPageManageAirport = new TabPage();
            buttonEditAirport = new Button();
            buttonDeleteAirport = new Button();
            textBoxEditCity = new TextBox();
            textBoxEditCountry = new TextBox();
            textBoxEditIata = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            labelAirportsCount = new Label();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label19 = new Label();
            labelAirportsApiCount = new Label();
            label5 = new Label();
            label6 = new Label();
            label10 = new Label();
            listBoxAirportsApi = new ListBox();
            buttonGetAirportsApi = new Button();
            textBoxSearchAirportApi = new TextBox();
            buttonAddAirportApi = new Button();
            comboBoxSearchAirportBy = new ComboBox();
            buttonSearchApiAirport = new Button();
            tabControlAirport.SuspendLayout();
            tabPageNewAirport.SuspendLayout();
            tabPageManageAirport.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxIATA
            // 
            textBoxIATA.Font = new Font("Segoe UI", 12F);
            textBoxIATA.Location = new Point(120, 98);
            textBoxIATA.Name = "textBoxIATA";
            textBoxIATA.Size = new Size(172, 29);
            textBoxIATA.TabIndex = 1;
            textBoxIATA.KeyPress += textBoxSanitize_KeyPress;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Font = new Font("Segoe UI", 12F);
            textBoxCountry.Location = new Point(120, 159);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(172, 29);
            textBoxCountry.TabIndex = 2;
            textBoxCountry.KeyPress += textBoxSanitize_KeyPress;
            // 
            // textBoxCity
            // 
            textBoxCity.Font = new Font("Segoe UI", 12F);
            textBoxCity.Location = new Point(120, 222);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(172, 29);
            textBoxCity.TabIndex = 3;
            textBoxCity.KeyPress += textBoxSanitize_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(35, 101);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 3;
            label1.Text = "IATA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(35, 162);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 4;
            label2.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(39, 225);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 5;
            label3.Text = "City";
            // 
            // listBoxAirports
            // 
            listBoxAirports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxAirports.FormattingEnabled = true;
            listBoxAirports.HorizontalScrollbar = true;
            listBoxAirports.ItemHeight = 21;
            listBoxAirports.Location = new Point(370, 116);
            listBoxAirports.Name = "listBoxAirports";
            listBoxAirports.Size = new Size(237, 403);
            listBoxAirports.TabIndex = 6;
            listBoxAirports.SelectedIndexChanged += listBoxAirports_SelectedIndexChanged;
            // 
            // tabControlAirport
            // 
            tabControlAirport.Controls.Add(tabPageNewAirport);
            tabControlAirport.Controls.Add(tabPageManageAirport);
            tabControlAirport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlAirport.Location = new Point(659, 80);
            tabControlAirport.Name = "tabControlAirport";
            tabControlAirport.SelectedIndex = 0;
            tabControlAirport.Size = new Size(348, 445);
            tabControlAirport.TabIndex = 8;
            // 
            // tabPageNewAirport
            // 
            tabPageNewAirport.Controls.Add(buttonAddAirport);
            tabPageNewAirport.Controls.Add(label3);
            tabPageNewAirport.Controls.Add(textBoxCity);
            tabPageNewAirport.Controls.Add(label2);
            tabPageNewAirport.Controls.Add(textBoxIATA);
            tabPageNewAirport.Controls.Add(label1);
            tabPageNewAirport.Controls.Add(textBoxCountry);
            tabPageNewAirport.Location = new Point(4, 34);
            tabPageNewAirport.Name = "tabPageNewAirport";
            tabPageNewAirport.Padding = new Padding(3);
            tabPageNewAirport.Size = new Size(340, 407);
            tabPageNewAirport.TabIndex = 0;
            tabPageNewAirport.Text = " New Airport ";
            tabPageNewAirport.UseVisualStyleBackColor = true;
            // 
            // buttonAddAirport
            // 
            buttonAddAirport.BackColor = SystemColors.HotTrack;
            buttonAddAirport.FlatStyle = FlatStyle.Flat;
            buttonAddAirport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAddAirport.ForeColor = Color.FromArgb(250, 250, 250);
            buttonAddAirport.Location = new Point(189, 329);
            buttonAddAirport.Name = "buttonAddAirport";
            buttonAddAirport.Size = new Size(103, 36);
            buttonAddAirport.TabIndex = 4;
            buttonAddAirport.Text = "Add";
            buttonAddAirport.UseVisualStyleBackColor = false;
            buttonAddAirport.Click += buttonAddAirport_Click;
            // 
            // tabPageManageAirport
            // 
            tabPageManageAirport.Controls.Add(buttonEditAirport);
            tabPageManageAirport.Controls.Add(buttonDeleteAirport);
            tabPageManageAirport.Controls.Add(textBoxEditCity);
            tabPageManageAirport.Controls.Add(textBoxEditCountry);
            tabPageManageAirport.Controls.Add(textBoxEditIata);
            tabPageManageAirport.Controls.Add(label9);
            tabPageManageAirport.Controls.Add(label8);
            tabPageManageAirport.Controls.Add(label7);
            tabPageManageAirport.Location = new Point(4, 34);
            tabPageManageAirport.Name = "tabPageManageAirport";
            tabPageManageAirport.Padding = new Padding(3);
            tabPageManageAirport.Size = new Size(340, 407);
            tabPageManageAirport.TabIndex = 1;
            tabPageManageAirport.Text = " Manage Airport ";
            tabPageManageAirport.UseVisualStyleBackColor = true;
            // 
            // buttonEditAirport
            // 
            buttonEditAirport.BackColor = SystemColors.HotTrack;
            buttonEditAirport.FlatStyle = FlatStyle.Flat;
            buttonEditAirport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonEditAirport.ForeColor = Color.FromArgb(250, 250, 250);
            buttonEditAirport.Location = new Point(189, 329);
            buttonEditAirport.Name = "buttonEditAirport";
            buttonEditAirport.Size = new Size(103, 36);
            buttonEditAirport.TabIndex = 8;
            buttonEditAirport.Text = "Save";
            buttonEditAirport.UseVisualStyleBackColor = false;
            buttonEditAirport.Click += buttonEditAirport_Click;
            // 
            // buttonDeleteAirport
            // 
            buttonDeleteAirport.BackColor = SystemColors.HotTrack;
            buttonDeleteAirport.FlatStyle = FlatStyle.Flat;
            buttonDeleteAirport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonDeleteAirport.ForeColor = Color.FromArgb(250, 250, 250);
            buttonDeleteAirport.Location = new Point(47, 329);
            buttonDeleteAirport.Name = "buttonDeleteAirport";
            buttonDeleteAirport.Size = new Size(103, 36);
            buttonDeleteAirport.TabIndex = 9;
            buttonDeleteAirport.Text = "Remove";
            buttonDeleteAirport.UseVisualStyleBackColor = false;
            buttonDeleteAirport.Click += buttonDeleteAirport_Click;
            // 
            // textBoxEditCity
            // 
            textBoxEditCity.Font = new Font("Segoe UI", 12F);
            textBoxEditCity.Location = new Point(120, 222);
            textBoxEditCity.Name = "textBoxEditCity";
            textBoxEditCity.Size = new Size(172, 29);
            textBoxEditCity.TabIndex = 7;
            textBoxEditCity.KeyPress += textBoxSanitize_KeyPress;
            // 
            // textBoxEditCountry
            // 
            textBoxEditCountry.Font = new Font("Segoe UI", 12F);
            textBoxEditCountry.Location = new Point(120, 159);
            textBoxEditCountry.Name = "textBoxEditCountry";
            textBoxEditCountry.Size = new Size(172, 29);
            textBoxEditCountry.TabIndex = 6;
            textBoxEditCountry.KeyPress += textBoxSanitize_KeyPress;
            // 
            // textBoxEditIata
            // 
            textBoxEditIata.Font = new Font("Segoe UI", 12F);
            textBoxEditIata.Location = new Point(120, 98);
            textBoxEditIata.Name = "textBoxEditIata";
            textBoxEditIata.Size = new Size(172, 29);
            textBoxEditIata.TabIndex = 5;
            textBoxEditIata.KeyPress += textBoxSanitize_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(39, 225);
            label9.Name = "label9";
            label9.Size = new Size(40, 21);
            label9.TabIndex = 28;
            label9.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(35, 162);
            label8.Name = "label8";
            label8.Size = new Size(72, 21);
            label8.TabIndex = 27;
            label8.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(35, 101);
            label7.Name = "label7";
            label7.Size = new Size(44, 21);
            label7.TabIndex = 26;
            label7.Text = "IATA";
            // 
            // labelAirportsCount
            // 
            labelAirportsCount.BackColor = SystemColors.HotTrack;
            labelAirportsCount.Font = new Font("Segoe UI", 12F);
            labelAirportsCount.ForeColor = Color.FromArgb(250, 250, 250);
            labelAirportsCount.Location = new Point(370, 524);
            labelAirportsCount.Name = "labelAirportsCount";
            labelAirportsCount.Size = new Size(237, 20);
            labelAirportsCount.TabIndex = 44;
            labelAirportsCount.Text = "0";
            labelAirportsCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.HotTrack;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(250, 250, 250);
            label12.Location = new Point(451, 88);
            label12.Name = "label12";
            label12.Size = new Size(71, 21);
            label12.TabIndex = 43;
            label12.Text = "Airports";
            // 
            // label14
            // 
            label14.BackColor = SystemColors.HotTrack;
            label14.Location = new Point(370, 82);
            label14.Name = "label14";
            label14.Size = new Size(237, 34);
            label14.TabIndex = 45;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.HotTrack;
            label15.Location = new Point(370, 519);
            label15.Name = "label15";
            label15.Size = new Size(237, 34);
            label15.TabIndex = 46;
            // 
            // label19
            // 
            label19.BackColor = SystemColors.HotTrack;
            label19.Location = new Point(659, 519);
            label19.Name = "label19";
            label19.Size = new Size(345, 34);
            label19.TabIndex = 47;
            // 
            // labelAirportsApiCount
            // 
            labelAirportsApiCount.BackColor = SystemColors.HotTrack;
            labelAirportsApiCount.Font = new Font("Segoe UI", 12F);
            labelAirportsApiCount.ForeColor = Color.FromArgb(250, 250, 250);
            labelAirportsApiCount.Location = new Point(79, 524);
            labelAirportsApiCount.Name = "labelAirportsApiCount";
            labelAirportsApiCount.Size = new Size(107, 20);
            labelAirportsApiCount.TabIndex = 50;
            labelAirportsApiCount.Text = "0";
            labelAirportsApiCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.HotTrack;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(250, 250, 250);
            label5.Location = new Point(81, 91);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 49;
            label5.Text = "Search by:";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.HotTrack;
            label6.Location = new Point(76, 82);
            label6.Name = "label6";
            label6.Size = new Size(237, 77);
            label6.TabIndex = 51;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.HotTrack;
            label10.Location = new Point(76, 519);
            label10.Name = "label10";
            label10.Size = new Size(237, 34);
            label10.TabIndex = 52;
            // 
            // listBoxAirportsApi
            // 
            listBoxAirportsApi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxAirportsApi.FormattingEnabled = true;
            listBoxAirportsApi.HorizontalScrollbar = true;
            listBoxAirportsApi.ItemHeight = 21;
            listBoxAirportsApi.Location = new Point(76, 158);
            listBoxAirportsApi.Name = "listBoxAirportsApi";
            listBoxAirportsApi.Size = new Size(237, 361);
            listBoxAirportsApi.TabIndex = 48;
            // 
            // buttonGetAirportsApi
            // 
            buttonGetAirportsApi.BackColor = SystemColors.HotTrack;
            buttonGetAirportsApi.FlatStyle = FlatStyle.Flat;
            buttonGetAirportsApi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGetAirportsApi.ForeColor = Color.WhiteSmoke;
            buttonGetAirportsApi.Location = new Point(126, 309);
            buttonGetAirportsApi.Name = "buttonGetAirportsApi";
            buttonGetAirportsApi.Size = new Size(140, 41);
            buttonGetAirportsApi.TabIndex = 53;
            buttonGetAirportsApi.Text = "Fetch Airports";
            buttonGetAirportsApi.UseVisualStyleBackColor = false;
            buttonGetAirportsApi.Click += buttonGetAirportsApi_Click;
            // 
            // textBoxSearchAirportApi
            // 
            textBoxSearchAirportApi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearchAirportApi.Location = new Point(84, 124);
            textBoxSearchAirportApi.MaxLength = 35;
            textBoxSearchAirportApi.Name = "textBoxSearchAirportApi";
            textBoxSearchAirportApi.PlaceholderText = "IATA";
            textBoxSearchAirportApi.Size = new Size(182, 29);
            textBoxSearchAirportApi.TabIndex = 54;
            textBoxSearchAirportApi.KeyPress += textBoxSanitize_KeyPress;
            // 
            // buttonAddAirportApi
            // 
            buttonAddAirportApi.BackColor = Color.WhiteSmoke;
            buttonAddAirportApi.FlatAppearance.BorderSize = 0;
            buttonAddAirportApi.FlatStyle = FlatStyle.Flat;
            buttonAddAirportApi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddAirportApi.ForeColor = SystemColors.HotTrack;
            buttonAddAirportApi.Location = new Point(191, 522);
            buttonAddAirportApi.Name = "buttonAddAirportApi";
            buttonAddAirportApi.Size = new Size(119, 28);
            buttonAddAirportApi.TabIndex = 55;
            buttonAddAirportApi.Text = "Import airport";
            buttonAddAirportApi.UseVisualStyleBackColor = false;
            buttonAddAirportApi.Click += buttonAddAirportApi_Click;
            // 
            // comboBoxSearchAirportBy
            // 
            comboBoxSearchAirportBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchAirportBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSearchAirportBy.FormattingEnabled = true;
            comboBoxSearchAirportBy.Items.AddRange(new object[] { "IATA", "Country", "City" });
            comboBoxSearchAirportBy.Location = new Point(172, 89);
            comboBoxSearchAirportBy.Name = "comboBoxSearchAirportBy";
            comboBoxSearchAirportBy.Size = new Size(132, 29);
            comboBoxSearchAirportBy.TabIndex = 56;
            comboBoxSearchAirportBy.SelectedIndexChanged += comboBoxSearchAirportBy_SelectedIndexChanged;
            // 
            // buttonSearchApiAirport
            // 
            buttonSearchApiAirport.BackColor = Color.WhiteSmoke;
            buttonSearchApiAirport.BackgroundImage = Properties.Resources.icons8_pesquisar_50;
            buttonSearchApiAirport.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearchApiAirport.FlatStyle = FlatStyle.Flat;
            buttonSearchApiAirport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearchApiAirport.ForeColor = SystemColors.HotTrack;
            buttonSearchApiAirport.Location = new Point(272, 123);
            buttonSearchApiAirport.Name = "buttonSearchApiAirport";
            buttonSearchApiAirport.Size = new Size(33, 31);
            buttonSearchApiAirport.TabIndex = 57;
            buttonSearchApiAirport.UseVisualStyleBackColor = false;
            buttonSearchApiAirport.Click += buttonSearchApiAirport_Click;
            // 
            // AirportsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(buttonSearchApiAirport);
            Controls.Add(comboBoxSearchAirportBy);
            Controls.Add(buttonAddAirportApi);
            Controls.Add(textBoxSearchAirportApi);
            Controls.Add(buttonGetAirportsApi);
            Controls.Add(labelAirportsApiCount);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(listBoxAirportsApi);
            Controls.Add(label19);
            Controls.Add(labelAirportsCount);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(tabControlAirport);
            Controls.Add(listBoxAirports);
            Name = "AirportsUserControl";
            Size = new Size(1076, 624);
            tabControlAirport.ResumeLayout(false);
            tabPageNewAirport.ResumeLayout(false);
            tabPageNewAirport.PerformLayout();
            tabPageManageAirport.ResumeLayout(false);
            tabPageManageAirport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIATA;
        private TextBox textBoxCountry;
        private TextBox textBoxCity;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBoxAirports;
        private TabControl tabControlAirport;
        private TabPage tabPageNewAirport;
        private TabPage tabPageManageAirport;
        private TextBox textBoxEditIata;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBoxEditCity;
        private TextBox textBoxEditCountry;
        private Label labelAirportsCount;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label19;
        private Button buttonDeleteAirport;
        private Button buttonEditAirport;
        private Button buttonAddAirport;
        private Label labelAirportsApiCount;
        private Label label5;
        private Label label6;
        private Label label10;
        private ListBox listBoxAirportsApi;
        private Button buttonGetAirportsApi;
        private TextBox textBoxSearchAirportApi;
        private Button buttonAddAirportApi;
        private ComboBox comboBoxSearchAirportBy;
        private Button buttonSearchApiAirport;
    }
}
