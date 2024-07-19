namespace ClassLibrary
{
    public class Flight
    {
        #region Attributes

        Aircraft _aircraft;

        Airport _destination;

        #endregion

        #region Properties

        public int Id { get; set; }

        public DateTime DateDeparture { get; set; }

        public DateTime DateArrival { get; set; }

        public TimeSpan Duration { get; set; }

        public Airline Airline { get; set; }

        public Airport Origin { get; set; }

        public Airport Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                _destination = value;
                FlightNumberGenerator();
            }
        }

        public Aircraft Aircraft
        {
            get
            {
                return _aircraft;
            }
            set
            {
                _aircraft = value;
                LoadAvailableSeats(); // Load the seats from the chosen aircraft to allocate them for the flight
            }
        }

        public List<string> AvailableSeats { get; set; }

        public List<Ticket> TicketList { get; set; } = new List<Ticket>();

        public string FlightNumber { get; set; }

        public string ShortDescription { get { return $"[{FlightNumber}] - {Airline.Name}"; } }

        #endregion

        #region Methods

        /// <summary>
        /// Generate the flight number of the flight
        /// </summary>
        private void FlightNumberGenerator()
        {
            FlightNumber = $"{Airline.Name[0]}{Origin.IATA}{Id}{Destination.IATA}".ToUpper();
        }

        /// <summary>
        /// Load available seats from the aircraft for the flight
        /// </summary>
        private void LoadAvailableSeats()
        {
            if (AvailableSeats == null)
            {
                AvailableSeats = new List<string>();
            }

            AvailableSeats.Clear();
            foreach (var seat in Aircraft.Seats)
            {
                AvailableSeats.Add(seat);
            }
        }

        /// <summary>
        /// Update the available seats of the flight
        /// </summary>
        /// <param name="seat">Seat</param>
        /// <param name="seatTaken">Seat to be removed?</param>
        public void UpdateAvailableSeats(string seat, bool removeSeat)
        {
            if (removeSeat)
            {
                AvailableSeats.Remove(seat); // Remove seat from the available seats
            }
            else
            {
                AvailableSeats.Add(seat); // Add back the seat to the list of available seats
            }
        }

        /// <summary>
        /// Update the ticket list of the flight
        /// </summary>
        /// <param name="ticket">Ticket</param>
        public void UpdateTicketList(Ticket ticket, bool removeTicket)
        {
            string seat = ticket.Seat;

            if (removeTicket)
            {
                UpdateAvailableSeats(seat, false); // Send the seat of the ticket to be added back to the list of available seats
                TicketList.Remove(ticket); // Remove the ticket from the flights ticket list
            }
            else
            {
                TicketList.Add(ticket); // Add the ticket to the flights ticket list
                UpdateAvailableSeats(seat, true); // Send the seat of the ticket to be removed from the list of available seats
            }
        }

        /// <summary>
        /// Generate a price for the flights ticket
        /// </summary>
        /// <returns>Ticket price</returns>
        public decimal TicketPriceGenerator()
        {
            // Algorithm to generate a price based on the duration of the flight and seat rarity (Not applicable for real use, but for illustrating distinct pricing scenarios)
            int totalMinutes = (int)Duration.TotalMinutes;
            decimal basePrice = 25 + (totalMinutes / 10);
            decimal availableSeatsPercent = (decimal) AvailableSeats.Count() / Aircraft.Capacity;

            decimal price = basePrice + (basePrice * (1 - availableSeatsPercent)) * 3;

            return price;
        }

        /// <summary>
        /// ToString() override to output flight information
        /// </summary>
        /// <returns>Flight information</returns>
        public override string ToString()
        {
            return $"[{FlightNumber}] {Origin.City} ➤ {Destination.City} - {DateDeparture} ➤ {DateArrival} - {Airline.Name}";
        }

        /// <summary>
        /// Return formated string to print on invoice
        /// </summary>
        /// <returns>Flight information string</returns>
        public string FlightDescription()
        {
            return
                $"[{FlightNumber}]\n\n" +
                $"From\n{Origin}\n{DateDeparture}\n\nTo\n{Destination}\n{DateArrival}";
        }

        /// <summary>
        /// Return formated string to output on ticket user control
        /// </summary>
        /// <returns>Flight information string</returns>
        public string FlightLabel()
        {
            return
                $"From: {Origin}\nDeparture: {DateDeparture}\n" +
                $"To: {Destination}\nArrival: {DateArrival}";
        }

        #endregion
    }
}
