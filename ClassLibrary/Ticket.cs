namespace ClassLibrary
{
    public class Ticket
    {
        #region Properties

        public int Id { get; set; }

        public Flight Flight { get; set; }

        public Client Client { get; set; }

        public string Seat { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Update the seat of the ticket and in the flights list of available seats
        /// </summary>
        /// <param name="updatedSeat">Seat of ticket</param>
        public void UpdateSeat(string updatedSeat)
        {
                Flight.UpdateAvailableSeats(Seat, false);
                Flight.UpdateAvailableSeats(updatedSeat, true);
                Seat = updatedSeat;
        }

        /// <summary>
        /// ToString() override to output ticket information
        /// </summary>
        /// <returns>Ticket information</returns>
        public override string ToString()
        {
            return $"[{Id}] - {Flight.FlightNumber} - Seat: {Seat}";
        }

        #endregion
    }
}
