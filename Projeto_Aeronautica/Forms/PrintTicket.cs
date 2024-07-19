using ClassLibrary;

namespace Projeto_Aeronautica
{
    public partial class PrintTicket : Form
    {
        #region Global variable

        Ticket _ticket = new Ticket();

        #endregion

        public PrintTicket(Ticket ticket)
        {
            InitializeComponent();

            #region Load and update

            _ticket = ticket;
            LoadTicketData();

            #endregion
        }

        /// <summary>
        /// Load ticket info
        /// </summary>
        private void LoadTicketData()
        {
            labelAirline.Text = _ticket.Flight.Airline.Name.ToString();
            labelTitleFullname.Text = $"{_ticket.Client.Title} {_ticket.Client.FullName}";
            labelFlightNumber.Text = $"[{_ticket.Flight.FlightNumber}]";
            labelIdNumber.Text = _ticket.Client.IdNumber;
            labelOrigin.Text = _ticket.Flight.Origin.ToString();
            labelDestination.Text = _ticket.Flight.Destination.ToString();
            labelDateDeparture.Text = _ticket.Flight.DateDeparture.ToString();
            labelDateArrival.Text = _ticket.Flight.DateArrival.ToString();
            labelBoardingTime.Text = GetBoardingTime(_ticket.Flight.DateDeparture);
            labelDuration.Text = _ticket.Flight.Duration.ToString();
            labelSeat.Text = _ticket.Seat;
        }

        /// <summary>
        /// Calculate the boarding time (30 minutes before departure)
        /// </summary>
        /// <param name="dateDeparture">Date of departure</param>
        /// <returns>Boarding time string</returns>
        private string GetBoardingTime(DateTime dateDeparture)
        {
            DateTime boardingTime = dateDeparture.AddMinutes(-30);
            return boardingTime.ToString();
        }

        /// <summary>
        /// Change text (title) of form according to the ticket ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintTicket_Load(object sender, EventArgs e)
        {
            this.Text = $"Ticket [{_ticket.Id}]";
        }
    }
}
