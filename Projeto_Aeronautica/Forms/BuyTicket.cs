using ClassLibrary;

namespace Projeto_Aeronautica
{
    public partial class BuyTicket : Form
    {
        #region Global variables

        Flight _flight;

        string _seat;

        decimal _ticketPrice;

        Client _client;

        #endregion

        public BuyTicket(Flight flight, string seat, Client client, decimal ticketPrice)
        {
            InitializeComponent();

            #region Load and update

            _flight = flight;
            _seat = seat;
            _client = client;
            _ticketPrice = ticketPrice;
            LoadFlightInfo(_ticketPrice);
            LoadClientInfo();

            #endregion
        }

        /// <summary>
        /// Load flight info data
        /// </summary>
        /// <param name="price"></param>
        private void LoadFlightInfo(decimal price)
        {
            labelAirline.Text = $"{_flight.Airline.Name}";
            labelFlightNumber.Text = $"[{_flight.FlightNumber}]";
            labelCurrentSeat.Text = _seat;
            labelDateDeparture.Text = _flight.DateDeparture.ToString();
            labelDateArrival.Text = _flight.DateArrival.ToString();
            labelOrigin.Text = _flight.Origin.ToString();
            labelDestination.Text = _flight.Destination.ToString();
            labelDuration.Text = _flight.Duration.ToString();

            labelTicketPrice.Text = $"{price:C2}";
        }

        /// <summary>
        /// Load client info data
        /// </summary>
        private void LoadClientInfo()
        {
            labelFullname.Text = $"{_client.Title} {_client.FullName}";
            labelIdNumber.Text = _client.IdNumber;
            labelContactNum.Text = _client.ContactNumber;
            labelEmail.Text = _client.Email.ToString();
            dateTimePickerBirth.Value = _client.DateOfBirth;
        }

        /// <summary>
        /// DialogResult to confirm ticket purchase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// DialogResult to cancel ticket purchase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
