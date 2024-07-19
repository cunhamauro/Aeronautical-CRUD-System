using ClassLibrary;
using System.Collections.Generic;

namespace Projeto_Aeronautica
{
    public partial class MainForm : Form
    {
        #region Global variables

        List<Airport> ListAirports = new List<Airport>();

        List<Aircraft> ListAircrafts = new List<Aircraft>();

        List<Airline> ListAirlines = new List<Airline>();

        List<Flight> ListFlights = new List<Flight>();

        List<Ticket> ListTickets = new List<Ticket>();

        User _user = new User();

        LoginForm _loginForm; // Access to the loginForm so I can go back to it after logging out or close both at the same time if wished so

        bool Logout = false; // Check if I want to logout (logou button) and return to login page or dont want to logout and just close everything

        #endregion

        #region File paths

        const string fileAirports = @"AIS_Data/airports.txt";

        const string fileAirlines = @"AIS_Data/airlines.txt";

        const string fileAircrafts = @"AIS_Data/aircraft.txt";

        const string fileFlights = @"AIS_Data/flights.txt";

        const string fileTickets = @"AIS_Data/tickets.txt";

        #endregion

        public MainForm(User user, LoginForm loginForm)
        {
            InitializeComponent();

            #region Load and update

            _user = user;
            labelUsername.Text = _user.Username;
            _loginForm = loginForm;

            #endregion
        }

        /// <summary>
        /// Airports user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAirports_Click(object sender, EventArgs e)
        {
            AirportsUserControl airportsUserControl = new(ListAirports, ListFlights);
            LoadUserControl(airportsUserControl, labelSelectAirports);
        }

        /// <summary>
        /// Aircrafts user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAircrafts_Click(object sender, EventArgs e)
        {
            AircraftsUserControl aircraftsUserControl = new(ListAircrafts, ListAirlines, ListFlights);
            LoadUserControl(aircraftsUserControl, labelSelectAircrafts);
        }

        /// <summary>
        /// Airlines user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAirlines_Click(object sender, EventArgs e)
        {
            AirlinesUserControl airlinesUserControl = new(ListAirlines, ListAircrafts);
            LoadUserControl(airlinesUserControl, labelSelectAirlines);
        }

        /// <summary>
        /// Flights user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFlights_Click(object sender, EventArgs e)
        {
            List<Aircraft> activeAircrafts = ListAircrafts.Where(a => a.Status).ToList();

            FlightsUserControl flightsUserControl = new(ListFlights, ListAirports, activeAircrafts, ListAirlines, ListTickets);
            LoadUserControl(flightsUserControl, labelSelectFlights);
        }

        /// <summary>
        /// Tickets user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTickets_Click(object sender, EventArgs e)
        {
            TicketsUserControl ticketsUserControl = new(ListFlights, ListAirports, ListAirlines, ListTickets);
            LoadUserControl(ticketsUserControl, labelSelectTickets);
        }

        /// <summary>
        /// Load the user control to the main form
        /// </summary>
        /// <param name="userControl">User control loaded</param>
        /// <param name="labelSelectedControl">Label for selected tab</param>
        private void LoadUserControl(UserControl userControl, Label labelSelectedControl)
        {
            SelectedTab(labelSelectedControl);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Show about/credits form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCredits_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
        }

        /// <summary>
        /// Update each second the date/time of Lisbon, New York & Tokyo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime utcNow = DateTime.UtcNow;

            // Lisbon Time (UTC+1 during Standard Time, UTC+0 during Daylight Saving Time)
            TimeZoneInfo lisbonTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            DateTime lisbonTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, lisbonTimeZone);
            labelDateLisbon.Text = lisbonTime.ToString("dd:MM:yyyy");
            labelClockLisbon.Text = lisbonTime.ToString("HH:mm:ss");

            // New York Time (UTC-5 during Standard Time, UTC-4 during Daylight Saving Time)
            TimeZoneInfo nyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime nyTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, nyTimeZone);
            labelDateNewYork.Text = nyTime.ToString("dd:MM:yyyy");
            labelClockNewYork.Text = nyTime.ToString("HH:mm:ss");

            // Tokyo Time (UTC+9)
            TimeZoneInfo tokyoTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            DateTime tokyoTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, tokyoTimeZone);
            labelDateTokyo.Text = tokyoTime.ToString("dd:MM:yyyy");
            labelClockTokyo.Text = tokyoTime.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Dashboard user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new(ListAirports, ListAircrafts, ListAirlines, ListFlights, ListTickets, CountAircrafts(true), CountAircrafts(false));
            LoadUserControl(dashboard, labelSelectHome);
        }

        /// <summary>
        /// Count the number of active/inactive aircrafts
        /// </summary>
        /// <param name="active">Aircraft active?</param>
        /// <returns>Count of active/inactive aircrafts</returns>
        private int CountAircrafts(bool active)
        {
            if (active)
            {
                return ListAircrafts.Where(a => a.Status).Count();

            }
            else
            {
                return ListAircrafts.Where(a => !a.Status).Count();
            }
        }

        /// <summary>
        /// Selected label changes based on selected user control
        /// </summary>
        /// <param name="selectedLabel">Selected label</param>
        private void SelectedTab(Label selectedLabel)
        {
            labelSelectAirlines.Visible = false;
            labelSelectAircrafts.Visible = false;
            labelSelectAirports.Visible = false;
            labelSelectFlights.Visible = false;
            labelSelectHome.Visible = false;
            labelSelectTickets.Visible = false;

            selectedLabel.Visible = true;
        }

        /// <summary>
        /// Error message for data saving/loading exceptions
        /// </summary>
        /// <param name="operation">Saving/Loading</param>
        /// <param name="list">Affected list</param>
        private void DataErrorMessage(string operation, string list)
        {
            MessageBox.Show($"Error {operation} {list} data!", $"{list} data error!");
        }

        /// <summary>
        /// When closing form save all data (write to files .txt)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save Airports
            try
            {
                DataManager.SaveAirports(ListAirports, fileAirports);
            }
            catch (Exception)
            {

                DataErrorMessage("saving", "airports");
            }

            // Save Airlines
            try
            {
                DataManager.SaveAirlines(ListAirlines, fileAirlines);
            }
            catch (Exception)
            {

                DataErrorMessage("saving", "airliness");
            }

            // Save Aircrafts
            try
            {
                DataManager.SaveAircrafts(ListAircrafts, fileAircrafts);
            }
            catch (Exception)
            {

                DataErrorMessage("saving", "aircrafts");
            }

            // Save Flights
            try
            {
                DataManager.SaveFlights(ListFlights, fileFlights);
            }
            catch (Exception)
            {

                DataErrorMessage("saving", "flights");
            }

            // Save Tickets
            try
            {
                DataManager.SaveTickets(ListTickets, fileTickets);
            }
            catch (Exception)
            {

                DataErrorMessage("saving", "tickets");
            }

            // Check if the closing is only for logout (Go back to login page)
            if (Logout)
            {
                _loginForm.FormShow(true);
            }
            else // Or to actually close everything
            {
                _loginForm.FormClose();
            }
        }

        /// <summary>
        /// When opening form load all data (read from files .txt)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load Airports
            if (File.Exists(fileAirports))
            {
                try
                {
                    ListAirports = DataManager.LoadAirports(fileAirports);
                }
                catch (Exception)
                {
                    DataErrorMessage("loading", "airports");
                }
            }

            // Load Airlines
            if (File.Exists(fileAirlines))
            {
                try
                {
                    ListAirlines = DataManager.LoadAirlines(fileAirlines);
                }
                catch (Exception)
                {
                    DataErrorMessage("loading", "airlines");
                }
            }

            // Load Aircrafts
            if (File.Exists(fileAircrafts))
            {
                try
                {
                    ListAircrafts = DataManager.LoadAircrafts(ListAirlines, fileAircrafts);
                }
                catch (Exception)
                {
                    DataErrorMessage("loading", "aircrafts");
                }
            }

            // Load Flights
            if (File.Exists(fileFlights))
            {
                try
                {
                    ListFlights = DataManager.LoadFlights(ListAircrafts, ListAirports, fileFlights);
                }
                catch (Exception)
                {
                    DataErrorMessage("loading", "flights");
                }
            }

            // Load Tickets
            if (File.Exists(fileTickets))
            {
                try
                {
                    ListTickets = DataManager.LoadTickets(ListFlights, fileTickets);
                }
                catch (Exception)
                {
                    DataErrorMessage("loading", "tickets");
                }
            }

            #region Load and update

            labelSelectHome.Visible = true;

            Dashboard dashboard = new(ListAirports, ListAircrafts, ListAirlines, ListFlights, ListTickets, CountAircrafts(true), CountAircrafts(false));
            LoadUserControl(dashboard, labelSelectHome);

            #endregion
        }

        /// <summary>
        /// Logout of the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Logout = true;
            this.Close();
        }
    }
}
