using ClassLibrary;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Projeto_Aeronautica
{
    public partial class FlightsUserControl : UserControl
    {
        #region Global variables

        const int FLIGHT_TIME_MARGIN = 60; // Allowed margin in minutes between flights

        const int FLIGHT_DATE_THRESHOLD = 30; // Threshold to remove flights from current time (simulating that have already departed/boarded)

        const int FLIGHT_SCHEDULE_MARGIN = 1; // Threshold to allow the scheduling of a flight (Minimum 24 hours in advance)

        List<Flight> _listFlights;

        List<Airport> _listAirports;

        List<Aircraft> _listAircrafts;

        List<Airline> _listAirlines;

        List<Ticket> _listTickets;

        List<Airport> listAirportOrigin;

        List<Airport> listAirportDestination;

        int counterFlightId = 1;

        DateTime dateDeparture;
        DateTime dateArrival;

        DateTime editDateDeparture;
        DateTime editDateArrival;

        #endregion

        public FlightsUserControl(List<Flight> listFlights, List<Airport> listAirports, List<Aircraft> listAircrafts, List<Airline> listAirlines, List<Ticket> listTickets)
        {
            InitializeComponent();

            #region Load and update

            _listFlights = listFlights;
            _listAirports = listAirports;
            _listAircrafts = listAircrafts;
            _listAirlines = listAirlines;
            _listTickets = listTickets;

            RemoveDepartedFlights(); // Clear flights that have already departed or will depart in the next 30 minutes
            UpdateCounterId();

            dateTimePickerArrivalDate.MinDate = dateTimePickerDepartureDate.Value; // Arrival minimum date is equal to departures current date

            listBoxFlights.DataSource = _listFlights;
            listBoxAirlines.DataSource = _listAirlines;

            // Separation of datasources so listbox selection doesn't conflict and works with mutual exclusion
            listAirportOrigin = new List<Airport>(_listAirports);
            listAirportDestination = new List<Airport>(_listAirports);

            listBoxAirportOrigin.DataSource = listAirportOrigin;
            listBoxAirportDestination.DataSource = listAirportDestination;

            // Set numerics and datepickers related to date/time to current time
            NumericHoursMinutesNow(numericUpDownArrivalHours, numericUpDownArrivalMinutes);
            NumericHoursMinutesNow(numericUpDownDepartureHours, numericUpDownDepartureMinutes);
            DatePickerNow(dateTimePickerDepartureDate);
            DatePickerNow(dateTimePickerEditDepartureDate);

            // Load correct date by default
            dateDeparture = GetDates(dateTimePickerDepartureDate, numericUpDownDepartureHours, numericUpDownDepartureMinutes);
            dateArrival = GetDates(dateTimePickerArrivalDate, numericUpDownArrivalHours, numericUpDownArrivalMinutes);

            // Load the sugested duration based on current time (will be 0 because date/time of departure and arrival is equal to current time)
            SugestFlightDuration(dateDeparture, dateArrival, numericUpDownDurationHours, numericUpDownDurationMinutes);

            // Updates flights listbox
            UpdateListBoxFlights();

            // Updates available flights with the default data
            UpdateAvailableAircraftsNew();

            // Updates the flight data to edit
            UpdateFlightEditData();

            #endregion
        }

        /// <summary>
        /// Make departure and arrival datepicker minimum date currents
        /// </summary>
        /// <param name="dateTimePicker">DateTimePicker</param>
        private void DatePickerNow(DateTimePicker dateTimePicker)
        {
            dateTimePicker.Value = DateTime.Now.Date;
            dateTimePicker.MinDate = DateTime.Now.Date;
        }

        /// <summary>
        /// Make hours and minutes numericupdown values to current hours and minutes
        /// </summary>
        /// <param name="numericHours"></param>
        /// <param name="numericMinutes"></param>
        private void NumericHoursMinutesNow(NumericUpDown numericHours, NumericUpDown numericMinutes)
        {
            numericHours.Value = DateTime.Now.Hour;
            numericMinutes.Value = DateTime.Now.Minute;
        }

        /// <summary>
        /// Get the flight duration
        /// </summary>
        /// <param name="numericHours">Hours of flight</param>
        /// <param name="numericMinutes">Minutes of flight</param>
        /// <returns>Duration of flight</returns>
        private TimeSpan GetDuration(NumericUpDown numericHours, NumericUpDown numericMinutes)
        {
            int hours = (int)numericHours.Value;
            int minutes = (int)numericMinutes.Value;

            return new TimeSpan(hours, minutes, 0);
        }

        /// <summary>
        /// Add flight to the list of flights
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddFlight_Click(object sender, EventArgs e)
        {
            Airport airportOrigin = listBoxAirportOrigin.SelectedItem as Airport;
            Airport airportDestination = listBoxAirportDestination.SelectedItem as Airport;

            if (airportOrigin != null && airportDestination != null)
            {
                Airline airline = listBoxAirlines.SelectedItem as Airline;
                Aircraft aircraft = listBoxAircrafts.SelectedItem as Aircraft;

                TimeSpan duration = GetDuration(numericUpDownDurationHours, numericUpDownDurationMinutes);

                if (dateDeparture < DateTime.Now.AddDays(FLIGHT_SCHEDULE_MARGIN))
                {
                    MessageBox.Show("Flights must be scheduled at least 24 hours before the departure time!", "Invalid date schedule!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidFlightInput(dateDeparture, dateArrival, duration, aircraft))
                {
                    return;
                }

                if (airline != null)
                {
                    Flight flight = new Flight()
                    {
                        Id = counterFlightId,
                        DateDeparture = dateDeparture,
                        DateArrival = dateArrival,
                        Duration = duration,
                        Aircraft = aircraft,
                        Airline = airline,
                        Origin = airportOrigin,
                        Destination = airportDestination,
                    };

                    _listFlights.Add(flight);

                    UpdateAvailableAircraftsNew();
                    UpdateListBoxFlights();

                    UpdateCounterId();

                    listBoxFlights.SelectedItem = flight;
                }
                else
                {
                    MessageBox.Show("Please assign an airline to the flight!", "Airline not selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid flight origin and destination!", "Invalid itinerary!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Refresh flights list box and update its count
        /// </summary>
        private void UpdateListBoxFlights()
        {
            listBoxFlights.DataSource = null;
            listBoxFlights.DataSource = _listFlights;

            labelFlightsCount.Text = listBoxFlights.Items.Count.ToString();
        }

        /// <summary>
        /// Validate flights input
        /// </summary>
        /// <param name="dateDepart">Date of flights departure</param>
        /// <param name="dateArrive">Date of flights arrival</param>
        /// <param name="duration">Date of flights duration</param>
        /// <param name="aircraft">Aircraft assigned to the flight</param>
        /// <returns>Flight inputs valid?</returns>
        private bool ValidFlightInput(DateTime dateDepart, DateTime dateArrive, TimeSpan duration, Aircraft aircraft)
        {
            if (dateDepart >= dateArrive)
            {
                MessageBox.Show("Date of arrival must come after date of departure!", "Invalid date schedule!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (duration.TotalMinutes == 0)
            {
                MessageBox.Show("Please select a valid flight duration time!", "Invalid flight duration!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (aircraft == null)
            {
                MessageBox.Show("Please assign an aircraft to the flight!", "Aircraft not selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Update flight ID counter
        /// </summary>
        private void UpdateCounterId()
        {
            // Get ID by max ID, so even if a lower ID flight is deleted, there is no ID repetition
            if (_listFlights.Count > 0)
            {
                counterFlightId = _listFlights.Select(a => a.Id).Max() + 1;
            }
            else
            {
                counterFlightId = 1;
            }
        }

        /// <summary>
        /// Combine date, hours and minutes into complete flight date
        /// </summary>
        /// <param name="dateTimePicker">Date [Day, Month & Year]</param>
        /// <param name="numericUpDownHours">Hours</param>
        /// <param name="numericUpDownMinutes">Minutes</param>
        /// <returns>Complete flight date</returns>
        private DateTime GetDates(DateTimePicker dateTimePicker, NumericUpDown numericUpDownHours, NumericUpDown numericUpDownMinutes)
        {
            int hours = (int)numericUpDownHours.Value;
            int minutes = (int)numericUpDownMinutes.Value;

            DateTime date = dateTimePicker.Value;

            DateTime completeDate = new DateTime(date.Year, date.Month, date.Day, hours, minutes, 0);

            return completeDate;
        }

        /// <summary>
        /// Call to update available aircrafts for new flight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAirlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAvailableAircraftsNew();
        }

        /// <summary>
        /// Load the available aircrafts for selected airline for new flight
        /// </summary>
        private void UpdateAvailableAircraftsNew()
        {
            Airline airline = listBoxAirlines.SelectedItem as Airline;
            Airport airportOrigin = listBoxAirportOrigin.SelectedItem as Airport;

            if (airline == null || airportOrigin == null)
            {
                return;
            }

            var availableAircrafts = AvailableAirlineAircrafts(airline, dateDeparture, dateArrival, airportOrigin); // Fetch the available aircrafts for the selected airline

            listBoxAircrafts.DataSource = null;
            listBoxAircrafts.DataSource = availableAircrafts;

        }

        /// <summary>
        /// Load the available aircrafts to edit a flight
        /// </summary>
        private void UpdateAvailableAircraftsEdit()
        {
            // Flight that's being edited
            Flight flightToEdit = listBoxFlights.SelectedItem as Flight;

            if (flightToEdit == null)
            {
                return;
            }

            // The airline of the flight being edited
            Airline airline = flightToEdit.Airline;

            // Get a list with all available aircrafts for that airline
            var availableAircrafts = AvailableAirlineAircrafts(airline, editDateDeparture, editDateArrival, flightToEdit.Origin);

            // Get aircraft from current flight
            Aircraft currentAircraft = flightToEdit.Aircraft;

            // Verify if the current aircraft of the flight being edited can be part of the available aircrafts for the new edited dates
            // If the aircraft on the given dates is already scheduled for another flight, he cant be included
            if (AircraftEditAvailableOnDate(currentAircraft, editDateDeparture, editDateArrival, flightToEdit))
            {
                if (!availableAircrafts.Contains(currentAircraft)) // If the aircraft is available and is not already inside
                {
                    availableAircrafts.Add(flightToEdit.Aircraft); // Then you can add him
                }
            }
            else // If the aircraft is not available
            {
                if (availableAircrafts.Contains(currentAircraft)) // And he is inside
                {
                    availableAircrafts.Remove(flightToEdit.Aircraft); // Then remove him
                }
            }

            listBoxEditAircraft.DataSource = null;
            availableAircrafts = availableAircrafts.OrderBy(a => a.Id).ToList();
            listBoxEditAircraft.DataSource = availableAircrafts;
        }

        /// <summary>
        /// Get all available aircrafts for a given airline
        /// </summary>
        /// <param name="airline">Airline</param>
        /// <param name="departure">Departure date/time</param>
        /// <param name="arrival">Arrival date/time</param>
        /// <returns>List of available aircrafts</returns>
        private List<Aircraft> AvailableAirlineAircrafts(Airline airline, DateTime departure, DateTime arrival, Airport origin)
        {
            List<Aircraft> availableAircrafts = new List<Aircraft>();

            if (airline != null)
            {
                foreach (Aircraft aircraft in _listAircrafts)
                {
                    if (aircraft.Airline == airline && AircraftAvailableOnDate(aircraft, departure, arrival, origin)) // Verify if the aircraft is available on the given date
                    {
                        availableAircrafts.Add(aircraft);
                    }
                }
            }

            return availableAircrafts;
        }

        /// <summary>
        /// Check if an aircraft is available to fly in a selected date
        /// </summary>
        /// <param name="aircraft">Aircraft to check availability</param>
        /// <param name="checkDateDeparture">Date of departure</param>
        /// <param name="checkDateArrival">Date of arrival</param>
        /// <returns>Is the aircraft available for the flight</returns>
        private bool AircraftAvailableOnDate(Aircraft aircraft, DateTime checkDateDeparture, DateTime checkDateArrival, Airport origin)
        {
            // Find the latest flight before the departure date
            Flight previousFlight = _listFlights.Where(f => f.Aircraft == aircraft && f.DateArrival < checkDateDeparture).OrderByDescending(f => f.DateArrival).FirstOrDefault();

            // Find the earliest next flight after the departure date
            Flight nextFlight = _listFlights.Where(f => f.Aircraft == aircraft && f.DateDeparture > checkDateArrival).OrderBy(f => f.DateDeparture).FirstOrDefault();

            if (previousFlight != null) // If a previous flight exists
            {
                // Check if the aircraft is at the destination of the previous flight and the dates match
                if (previousFlight.Destination != origin)
                {
                    return false; // The aircraft is not at the required origin airport
                }
                else
                {
                    // If the departure of the new flight is before the adjusted arrival time, the aircraft is not available
                    if (checkDateDeparture < previousFlight.DateArrival.AddMinutes(FLIGHT_TIME_MARGIN))
                    {
                        return false;
                    }
                }
            }

            if (nextFlight != null) // If a scheduled next flight exists
            {
                // If the arrival of the new flight is after the adjusted departure time of the next flight, the aircraft is not available
                if (checkDateArrival > nextFlight.DateDeparture.AddMinutes(-FLIGHT_TIME_MARGIN))
                {
                    return false;
                }
            }

            // Check for any overlapping flights
            foreach (var flight in _listFlights)
            {
                if (aircraft == flight.Aircraft)
                {
                    if ((checkDateDeparture >= flight.DateDeparture.AddMinutes(-FLIGHT_TIME_MARGIN) && checkDateDeparture <= flight.DateArrival.AddMinutes(FLIGHT_TIME_MARGIN)) ||
                        (checkDateArrival >= flight.DateDeparture.AddMinutes(-FLIGHT_TIME_MARGIN) && checkDateArrival <= flight.DateArrival.AddMinutes(FLIGHT_TIME_MARGIN)) ||
                        (checkDateDeparture <= flight.DateDeparture.AddMinutes(-FLIGHT_TIME_MARGIN) && checkDateArrival >= flight.DateArrival.AddMinutes(FLIGHT_TIME_MARGIN)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Check if an aircraft is available to fly while editing a flight
        /// </summary>
        /// <param name="aircraft">Aircraft to check availability</param>
        /// <param name="checkDateDeparture">Date of departure</param>
        /// <param name="checkDateArrival">Date of arrival</param>
        /// <returns>Is the aircraft available for the flight</returns>
        private bool AircraftEditAvailableOnDate(Aircraft aircraft, DateTime checkDateDeparture, DateTime checkDateArrival, Flight editFlight)
        {
            Airport origin = editFlight.Origin;

            // Find the latest flight before the checkDateDeparture, excluding the flight being edited so it doesn't self match
            Flight previousFlight = _listFlights.Where(f => f.Aircraft == aircraft && f.DateArrival < checkDateDeparture && f != editFlight).OrderByDescending(f => f.DateArrival).FirstOrDefault();

            // Find the earliest flight after the checkDateDeparture, excluding the flight being edited so it doesn't self match
            Flight nextFlight = _listFlights.Where(f => f.Aircraft == aircraft && f.DateDeparture > checkDateArrival && f != editFlight).OrderBy(f => f.DateDeparture).FirstOrDefault();

            if (previousFlight != null) // If a previous flight before the current flight being edited/checked exists
            {
                // Ensure the new flight's origin matches the previous flight's destination
                if (previousFlight.Destination != origin)
                {
                    return false;
                }

                // Allow a margin after the previous flight's arrival;
                if (checkDateDeparture < previousFlight.DateArrival.AddMinutes(FLIGHT_TIME_MARGIN))
                {
                    return false;
                }
            }

            if (nextFlight != null) // If a scheduled next flight exists
            {
                if (checkDateArrival > nextFlight.DateDeparture.AddMinutes(-FLIGHT_TIME_MARGIN))
                {
                    return false;
                }
            }

            // Check for any overlapping flights, excluding the flight being edited
            foreach (var flight in _listFlights)
            {
                if (aircraft == flight.Aircraft && flight != editFlight)
                {
                    if ((checkDateDeparture >= flight.DateDeparture.AddMinutes(-FLIGHT_TIME_MARGIN) && checkDateDeparture <= flight.DateArrival.AddMinutes(FLIGHT_TIME_MARGIN)) ||
                        (checkDateArrival >= flight.DateDeparture.AddMinutes(-FLIGHT_TIME_MARGIN) && checkDateArrival <= flight.DateArrival.AddMinutes(FLIGHT_TIME_MARGIN)) ||
                        (checkDateDeparture <= flight.DateDeparture.AddMinutes(-FLIGHT_TIME_MARGIN) && checkDateArrival >= flight.DateArrival.AddMinutes(FLIGHT_TIME_MARGIN)))
                    {
                        return false;
                    }
                }
            }

            // If all checks pass, the aircraft is available for the current flight that is being edited
            return true;
        }

        /// <summary>
        /// Load selected flight info to edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            Flight flight = listBoxFlights.SelectedItem as Flight;
            if (flight != null)
            {
                UpdateAvailableSeats(flight);
                UpdateFlightEditData();
                UpdateAvailableAircraftsEdit();
                SelectOwnEditAircraft();
            }
        }

        /// <summary>
        /// Update the available seats listbox and its count
        /// </summary>
        /// <param name="flight"></param>
        private void UpdateAvailableSeats(Flight flight)
        {
            if (flight == null) // Clear available seats
            {
                listBoxAvailableSeats.DataSource = null;
                listBoxAvailableSeats.Items.Clear();
                labelSeatsCount.Text = listBoxAvailableSeats.Items.Count.ToString();
            }
            else // Update them
            {
                listBoxAvailableSeats.DataSource = null;
                listBoxAvailableSeats.DataSource = flight.AvailableSeats.OrderBy(seat => seat).ToList();
                labelSeatsCount.Text = listBoxAvailableSeats.Items.Count.ToString();
            }
        }

        /// <summary>
        /// Load flight data to edit and set edit controls
        /// </summary>
        private void UpdateFlightEditData()
        {
            Flight flight = listBoxFlights.SelectedItem as Flight;

            if (flight == null) // No flight selected
            {
                textBoxEditAirline.Text = "Select a Flight";
                textBoxEditAirportDestination.Text = "Select a Flight";
                textBoxEditAirportOrigin.Text = "Select a Flight";

                EnableControls(false);

                return;
            }

            // Flight selected
            EnableControls(true);

            textBoxEditAirline.Text = flight.Airline.Name;
            textBoxEditAirportOrigin.Text = flight.Origin.ToString();
            textBoxEditAirportDestination.Text = flight.Destination.ToString();
            dateTimePickerEditDepartureDate.Value = flight.DateDeparture.Date;
            dateTimePickerEditArrivalDate.Value = flight.DateArrival.Date;

            numericUpDownEditDurationHours.Value = flight.Duration.Hours;
            numericUpDownEditDurationMinutes.Value = flight.Duration.Minutes;

            numericUpDownEditDepartureHours.Value = flight.DateDeparture.Hour;
            numericUpDownEditDepartureMinutes.Value = flight.DateDeparture.Minute;

            numericUpDownEditArrivalHours.Value = flight.DateArrival.Hour;
            numericUpDownEditArrivalMinutes.Value = flight.DateArrival.Minute;

            numericUpDownEditDurationHours.Value = flight.Duration.Hours;
            numericUpDownEditDurationMinutes.Value = flight.Duration.Minutes;
        }

        /// <summary>
        /// Enables or disables edit controls
        /// </summary>
        /// <param name="enable">Enable controls?</param>
        private void EnableControls(bool enable)
        {
            buttonConsultTickets.Enabled = enable;
            buttonDeleteFlight.Enabled = enable;
            buttonEditFlight.Enabled = enable;

            dateTimePickerEditArrivalDate.Enabled = enable;
            dateTimePickerEditDepartureDate.Enabled = enable;

            numericUpDownEditArrivalHours.Enabled = enable;
            numericUpDownEditArrivalMinutes.Enabled = enable;
            numericUpDownEditDepartureHours.Enabled = enable;
            numericUpDownEditDepartureMinutes.Enabled = enable;
            numericUpDownEditDurationHours.Enabled = enable;
            numericUpDownEditDurationMinutes.Enabled = enable;
        }

        /// <summary>
        /// Mutual exclusion selection between same airports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAirportOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Airport airport = listBoxAirportOrigin.SelectedItem as Airport;

            if (airport != null)
            {
                // Airports Origin: A [B] C
                // Airports Destination: A C
                listAirportDestination = new List<Airport>(_listAirports);
                listAirportDestination.Remove(airport);

                listBoxAirportDestination.DataSource = null;
                listBoxAirportDestination.DataSource = listAirportDestination;

                // Update available aircrafts when different origin is selected
                UpdateAvailableAircraftsNew();
            }

            listBoxAirportDestination.Enabled = true;
        }

        /// <summary>
        /// Filter available aircrafts through departure date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            // dateTimePicker arrival date will always be the same or after departure date
            dateTimePickerArrivalDate.MinDate = dateTimePickerDepartureDate.Value;

            if (dateTimePickerArrivalDate.Value < dateTimePickerDepartureDate.Value)
            {
                dateTimePickerArrivalDate.Value = dateTimePickerArrivalDate.MinDate;
            }

            dateDeparture = GetDates(dateTimePickerDepartureDate, numericUpDownDepartureHours, numericUpDownDepartureMinutes);
            dateArrival = GetDates(dateTimePickerArrivalDate, numericUpDownArrivalHours, numericUpDownArrivalMinutes);

            // Update the available aircrafts for a new flight based on the calculated dates and times
            UpdateAvailableAircraftsNew();

            // Sugest a flight duration based on the calculated dates and times
            SugestFlightDuration(dateDeparture, dateArrival, numericUpDownDurationHours, numericUpDownDurationMinutes);
        }

        /// <summary>
        /// Filter available aircrafts to edit through departure date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerEditDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            // dateTimePicker arrival date will always be the same or after departure date
            dateTimePickerEditArrivalDate.MinDate = dateTimePickerEditDepartureDate.Value;

            if (dateTimePickerEditArrivalDate.Value < dateTimePickerEditDepartureDate.Value)
            {
                dateTimePickerEditArrivalDate.Value = dateTimePickerEditArrivalDate.MinDate;
            }

            editDateDeparture = GetDates(dateTimePickerEditDepartureDate, numericUpDownEditDepartureHours, numericUpDownEditDepartureMinutes);
            editDateArrival = GetDates(dateTimePickerEditArrivalDate, numericUpDownEditArrivalHours, numericUpDownEditArrivalMinutes);

            // Update the available aircrafts for a edited flight based on the calculated dates and times
            UpdateAvailableAircraftsEdit();

            // Sugest a flight duration on edit based on the calculated dates and times
            SugestFlightDuration(editDateDeparture, editDateArrival, numericUpDownEditDurationHours, numericUpDownEditDurationMinutes);
        }

        /// <summary>
        /// Filter available aircrafts through arrival date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            dateDeparture = GetDates(dateTimePickerDepartureDate, numericUpDownDepartureHours, numericUpDownDepartureMinutes);
            dateArrival = GetDates(dateTimePickerArrivalDate, numericUpDownArrivalHours, numericUpDownArrivalMinutes);

            // Update the available aircrafts for a new flight based on the calculated dates and times
            UpdateAvailableAircraftsNew();

            // Sugest a flight duration based on the calculated dates and times
            SugestFlightDuration(dateDeparture, dateArrival, numericUpDownDurationHours, numericUpDownDurationMinutes);
        }

        /// <summary>
        /// Filter available aircrafts to edit through arrival date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerEditArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            editDateDeparture = GetDates(dateTimePickerEditDepartureDate, numericUpDownEditDepartureHours, numericUpDownEditDepartureMinutes);
            editDateArrival = GetDates(dateTimePickerEditArrivalDate, numericUpDownEditArrivalHours, numericUpDownEditArrivalMinutes);

            // Update the available aircrafts for a edited flight based on the calculated dates and times
            UpdateAvailableAircraftsEdit();

            // Sugest a flight duration on edit based on the calculated dates and times
            SugestFlightDuration(editDateDeparture, editDateArrival, numericUpDownEditDurationHours, numericUpDownEditDurationMinutes);
        }

        /// <summary>
        /// Edit selected flight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditFlight_Click(object sender, EventArgs e)
        {
            Flight flight = listBoxFlights.SelectedItem as Flight;

            if (flight != null)
            {
                // Only allow dates, duration and aircraft changes
                Aircraft aircraft = listBoxEditAircraft.SelectedItem as Aircraft;

                TimeSpan duration = GetDuration(numericUpDownEditDurationHours, numericUpDownEditDurationMinutes);

                if (editDateDeparture < DateTime.Now.AddDays(FLIGHT_SCHEDULE_MARGIN))
                {
                    MessageBox.Show("Flights must be scheduled at least 24 hours before the departure time!", "Invalid date schedule!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidFlightInput(editDateDeparture, editDateArrival, duration, aircraft))
                {
                    return;
                }

                flight.DateDeparture = editDateDeparture;
                flight.DateArrival = editDateArrival;
                flight.Duration = duration;
                flight.Aircraft = aircraft;

                UpdateAvailableAircraftsEdit();
                UpdateListBoxFlights();
                UpdateAvailableSeats(flight);

                listBoxFlights.SelectedItem = flight;
            }
            else
            {
                MessageBox.Show("Please select a flight to edit!", "Flight not selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Delete selected flight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteFlight_Click(object sender, EventArgs e)
        {
            Flight flight = listBoxFlights.SelectedItem as Flight;

            if (flight != null)
            {
                if (FlightHasTickets(flight))
                {
                    DialogResult answer = MessageBox.Show($"Flight [{flight.FlightNumber}] has tickets allocated! Do you still wish to cancel de flight?", "Confirm flight cancelation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (answer == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    DialogResult answer = MessageBox.Show($"Do you confirm the cancellation of flight [{flight.FlightNumber}]?", "Confirm flight cancelation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (answer == DialogResult.No)
                    {
                        return;
                    }
                }

                // Get the tickets from the global list that match the tickets form the removed flight
                var ticketsRemove = _listTickets.Where(t => t.Flight == flight).ToList();
                int numTickets = ticketsRemove.Count;

                // Remove those tickets if there are any
                if (numTickets > 0)
                {
                    foreach (Ticket removeTicket in ticketsRemove)
                    {
                        _listTickets.Remove(removeTicket);
                    }
                }

                // And lastly remove the flight (which includes the internal tickets)
                _listFlights.Remove(flight);

                UpdateFlightEditData();
                UpdateAvailableAircraftsEdit();
                UpdateListBoxFlights();
                UpdateAvailableSeats(null);
                UpdateAvailableAircraftsNew();

                if (listBoxFlights.Items.Count > 0)
                {
                    listBoxFlights.SelectedIndex = 0;
                }

                // Personalized message regarding the number of tickets cancelled following the flight cancellation
                if (numTickets == 1)
                {
                    TicketsCancelledMessage($"{numTickets}", " was");
                }
                else if (numTickets == 0)
                {
                    TicketsCancelledMessage("No", "s were");
                }
                else
                {
                    TicketsCancelledMessage($"{numTickets}", "s were");
                }
            }
            else
            {
                MessageBox.Show("Please select a flight to remove!", "Flight not selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Message to show number of tickets cancelled
        /// </summary>
        /// <param name="numTickets">Number of tickets cancelled</param>
        /// <param name="noun">Singular or plural string format</param>
        private void TicketsCancelledMessage(string numTickets, string noun)
        {
            MessageBox.Show($"{numTickets} ticket{noun} canceled following the flight cancellation!", "Tickets cancelled!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Check if the flight has tickets
        /// </summary>
        /// <param name="flight">Flight</param>
        /// <returns>Flight has tickets?</returns>
        private bool FlightHasTickets(Flight flight)
        {
            bool hasTicketsGlobal = false;
            bool hasTicketsInternal = false;

            foreach (Ticket ticket in _listTickets) // Check the global tickets list
            {
                if (ticket.Flight == flight)
                {
                    hasTicketsGlobal = true;
                }
            }

            if (flight.TicketList.Count > 0) // Check the internal flights ticket list
            {
                hasTicketsInternal = true;
            }

            // Extra security, used more still in development phase, but if for some reason there is some file corruption, it helps diagnose
            if (hasTicketsGlobal != hasTicketsInternal) // Check for the global and internal list of tickets synchronization
            {
                MessageBox.Show($"Global list of tickets doesn't match flight's internal ticket list!", "Ticket synchronization error!");
                return true;
            }
            else
            {
                return hasTicketsGlobal;
            }
        }

        /// <summary>
        /// Consult the tickets bought for the selected flight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConsultTickets_Click(object sender, EventArgs e)
        {
            Flight flight = listBoxFlights.SelectedItem as Flight;

            if (flight != null)
            {
                FlightTickets flightTickets = new FlightTickets(flight, _listTickets);

                flightTickets.ShowDialog();
            }
        }

        /// <summary>
        /// Update available new aircrafts based on hour/minute changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownDepartureArrivalNewFlight_ValueChanged(object sender, EventArgs e)
        {
            dateDeparture = GetDates(dateTimePickerDepartureDate, numericUpDownDepartureHours, numericUpDownDepartureMinutes);
            dateArrival = GetDates(dateTimePickerArrivalDate, numericUpDownArrivalHours, numericUpDownArrivalMinutes);

            // Update the available aircrafts for a new flight based on the calculated dates and times
            UpdateAvailableAircraftsNew();

            // Sugest a flight duration based on the calculated dates and times
            SugestFlightDuration(dateDeparture, dateArrival, numericUpDownDurationHours, numericUpDownDurationMinutes);

            // When altering the departure hours, update the arrival hours to match
            int departureCurrentHour = (int)numericUpDownDepartureHours.Value;
            numericUpDownArrivalHours.Minimum = departureCurrentHour;
        }

        /// <summary>
        /// Update available aircrafts on flight edit based on hour/minute changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownDepartureArrivalEditFlight_ValueChanged(object sender, EventArgs e)
        {
            editDateDeparture = GetDates(dateTimePickerEditDepartureDate, numericUpDownEditDepartureHours, numericUpDownEditDepartureMinutes);
            editDateArrival = GetDates(dateTimePickerEditArrivalDate, numericUpDownEditArrivalHours, numericUpDownEditArrivalMinutes);

            // Update the available aircrafts for a edited flight based on the calculated dates and times
            UpdateAvailableAircraftsEdit();

            // Sugest a flight duration on edit based on the calculated dates and times
            SugestFlightDuration(editDateDeparture, editDateArrival, numericUpDownEditDurationHours, numericUpDownEditDurationMinutes);
        }

        /// <summary>
        /// Call to select own aircraft of the edited flight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectOwnEditAircraft();
        }

        /// <summary>
        /// On tab page management select the aircraft of the edited flight
        /// </summary>
        private void SelectOwnEditAircraft()
        {
            if (tabControlFlight.SelectedTab == tabPageManageFlight)
            {
                try
                {
                    Flight flight = listBoxFlights.SelectedItem as Flight;

                    if (flight != null)
                    {
                        listBoxEditAircraft.SelectedItem = flight.Aircraft;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Sugest a flight duration based on departure and arrival times
        /// </summary>
        /// <param name="departure">Departure date/time</param>
        /// <param name="arrival">Arrival date/time</param>
        /// <param name="hours">NumericUpdown duration hours</param>
        /// <param name="minutes">NumericUpdown duration minutes</param>
        private void SugestFlightDuration(DateTime departure, DateTime arrival, NumericUpDown hours, NumericUpDown minutes)
        {
            // It is only a 'suggestion' because of timezone date/time discrepancies, so the user can change it if needed
            if (arrival >= departure)
            {
                TimeSpan duration = arrival - departure;

                int durationHours = (int)duration.TotalHours;
                int durationMinutes = duration.Minutes;

                hours.Value = durationHours;
                minutes.Value = durationMinutes;
            }
        }

        /// <summary>
        /// Remove departed flights
        /// </summary>
        private void RemoveDepartedFlights()
        {
            // Filter flights that have already departed or are departing within the next 30 minutes
            var flightsToRemove = _listFlights
                .Where(f => f.DateDeparture <= DateTime.Now.AddMinutes(-FLIGHT_DATE_THRESHOLD)).ToList();

            foreach (var flight in flightsToRemove)
            {
                // Remove associated tickets, if any
                if (flight.TicketList != null)
                {
                    foreach (var ticket in flight.TicketList.ToList())
                    {
                        _listTickets.Remove(ticket);
                    }
                }

                // Remove the flight itself
                _listFlights.Remove(flight);
            }
        }

        /// <summary>
        /// Update the available aircrafts when different destination is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAirportDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            Airport airport = listBoxAirportDestination.SelectedItem as Airport;

            if (airport != null)
            {
                UpdateAvailableAircraftsNew();
            }
        }
    }
}
