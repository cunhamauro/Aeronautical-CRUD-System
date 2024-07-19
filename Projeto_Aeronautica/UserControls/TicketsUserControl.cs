using ClassLibrary;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Projeto_Aeronautica
{
    public partial class TicketsUserControl : UserControl
    {
        #region Global variables

        int AGE_MIN = 12; // Minimum age for flying alone

        List<Flight> _listFlights;

        List<Airport> _listAirports;

        List<Airline> _listAirlines;

        List<Ticket> _listTickets;

        int counterTicketId = 1;

        #endregion

        public TicketsUserControl(List<Flight> listFlights, List<Airport> listAirports, List<Airline> listAirlines, List<Ticket> listTickets)
        {

            InitializeComponent();

            #region Load and update

            _listFlights = listFlights;
            _listAirports = listAirports;
            //_listAircrafts = listAircrafts;
            _listAirlines = listAirlines;
            _listTickets = listTickets;

            UpdateCounterId();

            comboBoxTitle.SelectedIndex = 0;

            LoadValidAirports();

            listBoxAirline.DataSource = _listAirlines;
            listBoxFlights.DataSource = _listFlights;
            listBoxFlights.DisplayMember = "ShortDescription";

            DatePickerNow(dateTimePickerDepartureDate);
            DatePickerNow(dateTimePickerArrivalDate);

            SetBirthDatePicker();

            #endregion
        }

        /// <summary>
        /// Set the clients birthday DateTimePicker to exact 18 years
        /// </summary>
        private void SetBirthDatePicker()
        {
            dateTimePickerBirth.Value = DateTime.Now.AddYears(-18); // Set to exactly 18 years, so its easier to get to actual birth (instead of .Now)
        }

        /// <summary>
        /// Set the DateTimePicker value and minimum date to .Now
        /// </summary>
        /// <param name="dateTimePicker"></param>
        private void DatePickerNow(DateTimePicker dateTimePicker)
        {
            dateTimePicker.Value = DateTime.Now.Date;
            dateTimePicker.MinDate = DateTime.Now.Date;
        }

        /// <summary>
        /// If dropdown opened remove Title option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTitle_DropDown(object sender, EventArgs e)
        {
            comboBoxTitle.Items.Remove("Title");
            comboBoxTitle.SelectedIndex = 0;
        }

        /// <summary>
        /// Load only origin/destination airports that have assigned flights
        /// </summary>
        private void LoadValidAirports()
        {
            var listOrigins = _listFlights.Select(f => f.Origin).Distinct().ToList();
            var listDestinations = _listFlights.Select(f => f.Destination).Distinct().ToList();

            listBoxAirportOrigin.DataSource = listOrigins;
            listBoxAirportDestination.DataSource = listDestinations;

            ExclusionOriginDestination();
        }

        /// <summary>
        /// Airports selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAirportOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExclusionOriginDestination();

            FilterBy();
        }

        /// <summary>
        /// Mutual exclusion selection between same airports
        /// </summary>
        private void ExclusionOriginDestination()
        {
            Airport airport = listBoxAirportOrigin.SelectedItem as Airport;

            if (airport != null)
            {
                List<Airport> listAirportDestination = new List<Airport>(_listAirports);
                listAirportDestination.Remove(airport);

                listBoxAirportDestination.DataSource = null;
                listBoxAirportDestination.DataSource = listAirportDestination;
            }

            listBoxAirportDestination.Enabled = true;
        }

        /// <summary>
        ///  Filter by selected checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxFilters_1(object sender, EventArgs e)
        {
            FilterBy();
        }

        /// <summary>
        /// Filtering by selected checkbox (Origin/Destination, Date, Airline)
        /// </summary>
        private void FilterBy()
        {
            // Filter by origin/destination
            bool filterByOriginDestination = checkBoxFilterOriginDestination.Checked;
            Airport origin = listBoxAirportOrigin.SelectedItem as Airport;
            Airport destination = listBoxAirportDestination.SelectedItem as Airport;
            if (filterByOriginDestination && (origin == null || destination == null))
            {
                MessageBox.Show("Please select a valid flight origin and destination!", "Invalid filter!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Filter by airline
            bool filterByAirline = checkBoxFilterAirline.Checked;
            Airline airline = listBoxAirline.SelectedItem as Airline;
            if (filterByAirline && airline == null)
            {
                MessageBox.Show("Please select a valid flight airline!", "Invalid filter!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Filter by date
            bool filterByDate = checkBoxFilterDate.Checked;
            DateTime departureDate = dateTimePickerDepartureDate.Value; // Hours, minutes and seconds are minimum
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            arrivalDate = new DateTime(arrivalDate.Year, arrivalDate.Month, arrivalDate.Day, 23, 59, 59); // Hours, minutes and seconds are max

            var filtered = _listFlights;

            // All possible filtering combinations between the 3 parameters
            if (filterByOriginDestination && !filterByAirline && !filterByDate)
            {
                filtered = _listFlights.Where(f => f.Origin == origin && f.Destination == destination).ToList();
            }
            else if (filterByOriginDestination && filterByAirline && !filterByDate)
            {
                filtered = _listFlights.Where(f => f.Origin == origin && f.Destination == destination && f.Airline == airline).ToList();
            }
            else if (filterByOriginDestination && filterByAirline && filterByDate)
            {
                filtered = _listFlights.Where(f => f.Origin == origin && f.Destination == destination && f.Airline == airline && f.DateDeparture >= departureDate && f.DateArrival <= arrivalDate).ToList();
            }
            else if (filterByOriginDestination && !filterByAirline && filterByDate)
            {
                filtered = _listFlights.Where(f => f.Origin == origin && f.Destination == destination && f.DateDeparture >= departureDate && f.DateArrival <= arrivalDate).ToList();
            }
            else if (!filterByOriginDestination && filterByAirline && filterByDate)
            {
                filtered = _listFlights.Where(f => f.DateDeparture >= departureDate && f.DateArrival <= arrivalDate && f.Airline == airline).ToList();
            }
            else if (!filterByOriginDestination && !filterByAirline && filterByDate)
            {
                filtered = _listFlights.Where(f => f.DateDeparture >= departureDate && f.DateArrival <= arrivalDate).ToList();
            }
            else if (!filterByOriginDestination && filterByAirline && !filterByDate)
            {
                filtered = _listFlights.Where(f => f.Airline == airline).ToList();
            }
            else
            {
                listBoxFlights.DataSource = null;
                listBoxFlights.DataSource = _listFlights;
                listBoxFlights.DisplayMember = "ShortDescription";
                return;
            }
            listBoxFlights.DataSource = null;
            listBoxFlights.DataSource = filtered;
            listBoxFlights.DisplayMember = "ShortDescription";
        }

        /// <summary>
        /// Load tickets of selected flight and control client input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            Flight flight = listBoxFlights.SelectedItem as Flight;

            if (flight != null)
            {
                RefreshListBox(flight);

                labelFlightDescription.Text = flight.FlightLabel();

                groupBoxClient.Enabled = true;

                if (flight.AvailableSeats.Count >= 1)
                {
                    buttonAddTicket.Enabled = true;
                }
                else if (flight.AvailableSeats.Count < 1)
                {
                    buttonAddTicket.Enabled = false;
                }
            }
            else
            {
                labelFlightDescription.Text = string.Empty;

                groupBoxClient.Enabled = false;
            }

            if (listBoxFlights.Items.Count == 0) // If there aren't any flights
            {
                groupBoxClient.Enabled = false; // Client inputs are disabled
            }
        }

        /// <summary>
        /// Validate the client input
        /// </summary>
        /// <param name="fullName">Clients full name</param>
        /// <param name="idNumber">Clients identification number</param>
        /// <param name="contactNum">Clients contact number</param>
        /// <param name="seat">Clients flight seat</param>
        /// <returns>Valid?</returns>
        private bool ValidClientInput(string fullName, string idNumber, string contactNum, string seat)
        {
            if (!ValidFullName(fullName))
            {
                MessageBox.Show("Please write a valid name for the ticket holder!", "Invalid client name!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(idNumber) || idNumber.Length < 8 || !ulong.TryParse(idNumber, out _))
            {
                MessageBox.Show("Please write a valid identification number for the ticket holder!", "Invalid client ID number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(contactNum) || contactNum.Length < 9 || contactNum.Length > 15 || !ulong.TryParse(contactNum, out _))
            {
                MessageBox.Show("Please write a valid contact number for the ticket holder!", "Invalid contact number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (seat == null)
            {
                MessageBox.Show("Please select an available seat for the flight!", "Invalid seat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Add a new ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTicket_Click(object sender, EventArgs e)
        {
            Flight flight = listBoxFlights.SelectedItem as Flight;

            if (flight != null)
            {
                string title = comboBoxTitle.Text;
                if (title == "Title")
                {
                    MessageBox.Show("Please select a title for the ticket holder!", "Invalid client title!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fullName = textBoxFullname.Text;
                string idNumber = textBoxIdNumber.Text;
                string contactNum = textBoxContactNumber.Text;

                string seat = listBoxAvailableSeats.SelectedItem.ToString(); // Selected seat

                if (!ValidClientInput(fullName, idNumber, contactNum, seat))
                {
                    return;
                }

                fullName = UpperLowerFormat(fullName); // Format full name

                if (!IdNotRepeated(idNumber, flight, true, null))
                {
                    MessageBox.Show("The inserted ID number is already registered in a ticket of the current flight!", "Duplicate ID number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if its a valid email through the MailAddress class that verifies the format
                MailAddress email;
                if (!string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    try
                    {
                        email = new MailAddress(textBoxEmail.Text);
                    }
                    catch (FormatException)
                    {
                        InvalidEmailMessage();
                        return;
                    }
                }
                else
                {
                    InvalidEmailMessage();
                    return;
                }

                // Check the age
                DateTime dateBirth = dateTimePickerBirth.Value;
                // Against current time minus 12 years (minimum to fly alone that was set)
                DateTime minYearsOld = DateTime.Now.AddYears(-1 * AGE_MIN);

                if (dateBirth > minYearsOld) // If its younger than 12 years
                {
                    DialogResult result = MessageBox.Show($"Children under {AGE_MIN} are not allowed to fly alone. Is the child accompanied?", "Age validation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show($"Ticket purchase was aborted!", "Invalid age!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                Client client = new Client()
                {
                    Title = title,
                    FullName = fullName,
                    ContactNumber = contactNum,
                    Email = email,
                    DateOfBirth = dateBirth,
                    IdNumber = idNumber,
                };

                decimal ticketPrice = flight.TicketPriceGenerator(); // Generate a price based on flight parameters and seat availability

                // Confirm ticket purchase
                BuyTicket buyTicket = new BuyTicket(flight, seat, client, ticketPrice);
                DialogResult purchaseResult = buyTicket.ShowDialog();
                if (purchaseResult == DialogResult.Cancel)
                {
                    MessageBox.Show($"Flight [{flight.FlightNumber}] ticket purchase was aborted!", "Purchase aborted!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Ticket ticket = new()
                {
                    Client = client,
                    Flight = flight,
                    Seat = seat,
                    Id = counterTicketId,
                };

                _listTickets.Add(ticket); // Add ticket to global list of tickets

                flight.UpdateTicketList(ticket, false); // Update the ticket list and seating system

                RefreshListBox(flight);
                UpdateCounterId();
                ClearInputNew();

                if (ticket.Flight.AvailableSeats.Count == 0) // If there arent any seats left on the selected flight
                {
                    buttonAddTicket.Enabled = false; // Disable the button to purchase tickets
                }
                TicketInvoice ticketInvoice = new(ticket, ticketPrice); // Print an invoice
                ticketInvoice.Show();

                PrintTicket printTicket = new(ticket); // Print a ticket
                printTicket.Show();
            }
            else
            {
                MessageBox.Show("Please select a valid flight!", "Invalid flight!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Message for invalid email input
        /// </summary>
        private void InvalidEmailMessage()
        {
            MessageBox.Show("Please write a valid email for the ticket holder!", "Invalid email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Check if clients full name is valid
        /// </summary>
        /// <param name="fullName">Clients full name</param>
        /// <returns>Full name valid?</returns>
        private bool ValidFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return false;
            }

            // Check if the fullname is composed of at least 2 names (John Doe is accepted / JohnDoe is not accepted)
            string[] names = fullName.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            return names.Length >= 2;
        }

        /// <summary>
        /// Check if the clients ID number is not already registered on the flight
        /// </summary>
        /// <param name="idNumber">ID number</param>
        /// <param name="flight">Flight</param>
        /// <param name="newTicket">For new ticket?</param>
        /// <param name="client">Client</param>
        /// <returns></returns>
        private bool IdNotRepeated(string idNumber, Flight flight, bool newTicket, Client client)
        {
            if (newTicket)
            {
                // Check if in a same flight a clients ID number is already being used (one person person per flight)
                foreach (Ticket ticket in _listTickets)
                {
                    if (ticket.Flight == flight && ticket.Client.IdNumber == idNumber)
                    {
                        return false;
                    }
                }
            }
            else
            {
                // Check if in a ticket being edited the number is already being used, excluding the current number
                foreach (Ticket ticket in _listTickets)
                {
                    if (ticket.Flight == flight && ticket.Client.IdNumber == idNumber && idNumber != client.IdNumber)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Convert first letter to uppercase and lowercase rest of string
        /// </summary>
        /// <param name="input">String to format</param>
        /// <returns>Formated string</returns>
        private string UpperLowerFormat(string input)
        {
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            if (words.Length == 1)
            {
                result += input.Substring(0, 1).ToUpper();
                result += input.Length > 1 ? input.Substring(1).ToLower() : string.Empty;
                return result;
            }
            else
            {
                for (int i = 0; i < words.Length; i++)
                {
                    result += words[i].Substring(0, 1).ToUpper();
                    result += words[i].Length > 1 ? words[i].Substring(1).ToLower() : string.Empty;
                    result += " ";
                }
                return result;
            }
        }

        /// <summary>
        /// Update ticket ID counter
        /// </summary>
        private void UpdateCounterId()
        {
            // Get ID by max ID, so even if a lower ID ticket is deleted, there is no ID repetition
            if (_listTickets.Count > 0)
            {
                counterTicketId = _listTickets.Select(a => a.Id).Max() + 1;
            }
            else
            {
                counterTicketId = 1;
            }
        }

        /// <summary>
        /// Refresh listbox
        /// </summary>
        /// <param name="flight">Flight datasource</param>
        private void RefreshListBox(Flight flight)
        {
            if (flight != null)
            {
                listBoxAvailableSeats.DataSource = null;
                var availableSeats = flight.AvailableSeats;

                availableSeats = availableSeats.OrderBy(a => a).ToList();

                listBoxAvailableSeats.DataSource = availableSeats;
                labelSeatsCount.Text = listBoxAvailableSeats.Items.Count.ToString();

                SeatAircraftConfiguration(flight.Aircraft.Seats);
            }
        }

        /// <summary>
        /// Recreate the aircrafts seating configuration
        /// </summary>
        /// <param name="seats">List of seats of the aircraft</param>
        private void SeatAircraftConfiguration(List<string> seats)
        {
            listBoxSeatConfiguration.Items.Clear();

            List<string> seatConfig = new List<string>();
            string currentRow = "A"; // Start with the first row
            string rowSeats = ""; // String to accumulate seats in the current row

            foreach (string seat in seats)
            {
                string seatRow = seat.Substring(0, 1); // Get the row character as a string

                if (seatRow != currentRow)
                {
                    // Add the accumulated seats of the current row to the list
                    seatConfig.Add(rowSeats.Trim());
                    // Start a new row
                    currentRow = seatRow;
                    rowSeats = "";
                }

                // Add the seat to the current row string
                rowSeats += $"{seat} ";
            }

            // Add the last rows seats to the list after the loop ends
            if (!string.IsNullOrEmpty(rowSeats))
            {
                seatConfig.Add(rowSeats.Trim());
            }

            // Add each seat configuration to the ListBox
            foreach (string config in seatConfig)
            {
                listBoxSeatConfiguration.Items.Add(config);
            }
        }

        /// <summary>
        /// Search ticket and load tickets information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchIdNumber_Click(object sender, EventArgs e)
        {
            string ticketIdStr = textBoxSearchIdNum.Text;
            bool ticketFound = false;

            if (!string.IsNullOrWhiteSpace(ticketIdStr) && int.TryParse(ticketIdStr, out int ticketId))
            {
                foreach (Ticket ticket in _listTickets)
                {
                    if (ticket.Id == ticketId)
                    {
                        ticketFound = true;

                        labelCurrentSeat.Text = ticket.Seat;
                        textBoxEditContactNumber.Text = ticket.Client.ContactNumber;
                        textBoxEditEmail.Text = ticket.Client.Email.ToString();
                        textBoxEditFullname.Text = ticket.Client.FullName;
                        textBoxEditIdNumber.Text = ticket.Client.IdNumber;
                        dateTimePickerEditBirth.Value = ticket.Client.DateOfBirth;
                        comboBoxEditTitle.SelectedItem = ticket.Client.Title;

                        labelAirline.Text = ticket.Flight.Airline.Name;
                        labelFlightNumber.Text = $"[{ticket.Flight.FlightNumber}]";
                        labelOrigin.Text = ticket.Flight.Origin.ToString();
                        labelDestination.Text = ticket.Flight.Destination.ToString();
                        labelDateDeparture.Text = ticket.Flight.DateDeparture.ToString();
                        labelDateArrival.Text = ticket.Flight.DateArrival.ToString();
                        labelDuration.Text = ticket.Flight.Duration.ToString();

                        EnableEditControls(true);

                        listBoxEditSeat.DataSource = null;

                        // Get all available seats from the flight
                        List<string> availableSeats = new(ticket.Flight.AvailableSeats);

                        // Add the clients current seat to display it in the list box
                        availableSeats.Add(ticket.Seat);
                        availableSeats = availableSeats.OrderBy(a => a).ToList();

                        // Count the number of available seats minus 1 that is the current taken one
                        labelSeatsCountEdit.Text = $"{availableSeats.Count() - 1}";

                        listBoxEditSeat.DataSource = availableSeats;
                        listBoxEditSeat.SelectedItem = ticket.Seat;

                        buttonDeleteTicket.Enabled = true;
                        buttonEditTicket.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please write a valid ticket number!", "Invalid ticket number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ticketFound)
            {
                MessageBox.Show($"Ticket number [{ticketIdStr}] not found!", "Invalid ticket number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit the ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditTicket_Click(object sender, EventArgs e)
        {
            string ticketIdStr = textBoxSearchIdNum.Text;
            int ticketId = int.Parse(ticketIdStr);

            foreach (Ticket ticket in _listTickets)
            {
                if (ticket.Id == ticketId)
                {
                    string fullName = textBoxEditFullname.Text;
                    string idNumber = textBoxEditIdNumber.Text;
                    string editedSeat = listBoxEditSeat.SelectedItem.ToString();
                    string contactNum = textBoxEditContactNumber.Text;

                    if (!ValidClientInput(fullName, idNumber, contactNum, editedSeat))
                    {
                        return;
                    }

                    fullName = UpperLowerFormat(textBoxEditFullname.Text);

                    if (!IdNotRepeated(idNumber, ticket.Flight, false, ticket.Client))
                    {
                        MessageBox.Show("The inserted ID number is already registered in a ticket of the current flight!", "Duplicate ID number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MailAddress email;
                    if (!string.IsNullOrWhiteSpace(textBoxEditEmail.Text))
                    {
                        try
                        {
                            email = new MailAddress(textBoxEditEmail.Text);
                        }
                        catch (FormatException)
                        {
                            InvalidEmailMessage();
                            return;
                        }
                    }
                    else
                    {
                        InvalidEmailMessage();
                        return;
                    }

                    bool reprintTicket = false;
                    // Check if any of the client's data that is printed in the ticket changed
                    if (ticket.Client.FullName != fullName || ticket.Client.IdNumber != idNumber
                        || ticket.Client.Title != comboBoxEditTitle.Text || ticket.Seat != editedSeat)
                    {
                        reprintTicket = true;
                    }

                    // Update the ticket's client data
                    ticket.Client.FullName = fullName;
                    ticket.Client.IdNumber = idNumber;
                    ticket.Client.Email = email;
                    ticket.Client.ContactNumber = contactNum;
                    ticket.Client.Title = comboBoxEditTitle.Text;
                    ticket.Client.DateOfBirth = dateTimePickerEditBirth.Value;

                    ticket.UpdateSeat(editedSeat);

                    labelCurrentSeat.Text = ticket.Seat;

                    RefreshListBox(ticket.Flight);
                    ClearInputManage();

                    // Reprint the ticket if there are any changes on it
                    if (reprintTicket)
                    {
                        PrintTicket printTicket = new(ticket);
                        printTicket.Show();
                    }
                }
            }
        }

        /// <summary>
        /// Remove the ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteTicket_Click(object sender, EventArgs e)
        {
            string ticketIdStr = textBoxSearchIdNum.Text;
            int ticketId = int.Parse(ticketIdStr);

            var tickets = _listTickets.ToList();

            foreach (Ticket ticket in tickets)
            {
                if (ticket.Id == ticketId)
                {

                    DialogResult result = MessageBox.Show($"Cancel ticket [{ticket.Id}] for flight [{ticket.Flight.FlightNumber}] ?", "Confirm cancel!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ticket.Flight.UpdateTicketList(ticket, true);
                        _listTickets.Remove(ticket);
                    }
                    else
                    {
                        MessageBox.Show($"Ticket [{ticket.Id}] for flight [{ticket.Flight.FlightNumber}] was not canceled!", "Not canceled!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            Flight flight = listBoxFlights.SelectedItem as Flight;

            if (flight != null)
            {
                flight.AvailableSeats.Order();
                flight.AvailableSeats = flight.AvailableSeats.OrderBy(seat => seat).ToList();
                RefreshListBox(flight);
                ClearInputManage();
            }
        }

        /// <summary>
        /// Clear inputs when a new ticket is added
        /// </summary>
        private void ClearInputNew()
        {
            // Inserts "Title" back into the combobox at index 0
            comboBoxTitle.Items.Insert(0, "Title");

            // Selected index set to 0 to show "Title" like default
            comboBoxTitle.SelectedIndex = 0;

            textBoxFullname.Clear();
            textBoxEmail.Clear();
            textBoxIdNumber.Clear();
            textBoxContactNumber.Clear();

            dateTimePickerBirth.Value = DateTime.Now.AddYears(-18); // Resets date of birth to exact 18 years
        }

        /// <summary>
        /// Clear inputs when a ticket is edited
        /// </summary>
        private void ClearInputManage()
        {
            // Clear search bar
            textBoxSearchIdNum.Clear();

            EnableEditControls(false);

            // Clear listbox of available seats in edit
            ClearEditAvailableSeats();
        }

        /// <summary>
        /// Set ticket edit controls visible/enable
        /// </summary>
        /// <param name="enable">Enable/Visible?</param>
        private void EnableEditControls(bool enable)
        {
            groupBoxEditClient.Visible = enable;
            groupBoxEditClient.Enabled = enable;
            groupBoxFlightInfo.Visible = enable;
            groupBoxFlightInfo.Enabled = enable;

            panelAvailableSeatsEdit.Enabled = enable;
            panelAvailableSeatsEdit.Visible = enable;

            buttonEditTicket.Enabled = enable;
            buttonDeleteTicket.Enabled = enable;
            buttonEditTicket.Visible = enable;
            buttonDeleteTicket.Visible = enable;
        }

        /// <summary>
        /// Clear available seats listbox in edit
        /// </summary>
        private void ClearEditAvailableSeats()
        {
            listBoxEditSeat.SelectedItem = null;
            listBoxEditSeat.DataSource = null;

            labelSeatsCountEdit.Text = "0";
        }

        /// <summary>
        /// Cancel the current ticket edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            textBoxSearchIdNum.Enabled = true;
            textBoxSearchIdNum.Clear();

            ClearInputManage();
        }

        /// <summary>
        /// Set date and filter results based on date changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerDepartureArrival_ValueChanged(object sender, EventArgs e)
        {
            // Set the arrival datepicker minimum date to the departures datepicker selected date date
            dateTimePickerArrivalDate.MinDate = dateTimePickerDepartureDate.Value;

            if (dateTimePickerArrivalDate.Value < dateTimePickerDepartureDate.Value)
            {
                dateTimePickerArrivalDate.Value = dateTimePickerArrivalDate.MinDate;
            }

            FilterBy();
        }

        /// <summary>
        /// Filter results based on airport destination changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAirportDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy();
        }

        /// <summary>
        /// Filter results based on airline changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAirline_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy();
        }

        /// <summary>
        /// Textbox sanitization for new ticket inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSanitize_KeyPress(object sender, KeyPressEventArgs e)
        {
            Sanitize(e);
        }

        /// <summary>
        /// Textbox sanitization for ticket edit inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxEditSanitize_KeyPress(object sender, KeyPressEventArgs e)
        {
            Sanitize(e);
        }

        /// <summary>
        /// Check if a forbidden character is pressed
        /// </summary>
        /// <param name="e"></param>
        private void Sanitize(KeyPressEventArgs e)
        {
            // Define the list of allowed characters (letters (with accents), numbers, space, etc)
            string pattern = @"^[\p{L}0-9 @._]+$"; // Allow @ . _ for emails

            // Verify if the typed character is not included in the allowed characters, but allow control characters (backspace, enter, tab, etc...)
            if (!char.IsControl(e.KeyChar) && !Regex.IsMatch(e.KeyChar.ToString(), pattern))
            {
                e.Handled = true; // Doesnt allow the character insertion
                MessageBox.Show("Only alphanumerical, underscore, dots and @ characters allowed!", "Forbidden character!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Check what tab is selected to reload seat config
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlTicket.SelectedTab == tabPageNewTicket)
            {
                Flight flight = listBoxFlights.SelectedItem as Flight;
                if (flight != null)
                {
                    SeatAircraftConfiguration(flight.Aircraft.Seats);
                }
            }
        }
    }
}
