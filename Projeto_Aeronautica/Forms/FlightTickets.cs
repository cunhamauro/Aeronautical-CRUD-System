using ClassLibrary;

namespace Projeto_Aeronautica
{
    public partial class FlightTickets : Form
    {
        #region Global variables

        Flight _flight;

        List<Ticket> _listTickets;

        #endregion

        public FlightTickets(Flight flight, List<Ticket> listTickets)
        {
            InitializeComponent();

            #region Load and update

            _flight = flight;
            _listTickets = listTickets;
            LoadFlightTickets();

            #endregion
        }

        /// <summary>
        /// Load flight info
        /// </summary>
        private void LoadFlightTickets()
        {
            List<Ticket> tickets = _listTickets.Where(t => t.Flight == _flight).ToList();

            labelFlightNumber.Text = $"{_flight.FlightNumber} tickets";
            listBoxFlightTickets.DataSource = tickets;
            labelTicketsCount.Text = listBoxFlightTickets.Items.Count.ToString();

        }

        /// <summary>
        /// Change text (title) of form according to the flight number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlightTickets_Load(object sender, EventArgs e)
        {
            this.Text = $"[{_flight.FlightNumber}] tickets";
        }
    }
}
