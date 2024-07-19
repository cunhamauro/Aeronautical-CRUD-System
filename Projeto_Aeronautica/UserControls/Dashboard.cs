using ClassLibrary;
using System.Data;

namespace Projeto_Aeronautica
{
    public partial class Dashboard : UserControl
    {
        #region Global variables

        List<Airport> _listAirports;

        List<Aircraft> _listAircrafts;

        List<Airline> _listAirlines;

        List<Flight> _listFlights;

        List<Ticket> _listTickets;

        #endregion

        public Dashboard(List<Airport> listAirports, List<Aircraft> listAircrafts, List<Airline> listAirlines, List<Flight> listFlights, List<Ticket> listTickets, int numActiveAircrafts, int numInactiveAircrafts)
        {
            InitializeComponent();

            #region Load and update

            _listAirports = listAirports;
            _listAircrafts = listAircrafts;
            _listAirlines = listAirlines;
            _listFlights = listFlights;
            _listTickets = listTickets;

            LoadData(numActiveAircrafts, numInactiveAircrafts);

            #endregion
        }

        /// <summary>
        /// Load statistics data
        /// </summary>
        private void LoadData(int numActiveAircrafts, int numInactiveAircrafts)
        {
            // Conditionals that check the data so N/A can be displayed correctly when not available
            if (_listAirports.Count < 1 && _listFlights.Count < 1)
            {
                labelNumAirports.Text = "0";
                labelPopularDestination.Text = "N/A";
            }
            else if (_listAirports.Count > 0 && _listFlights.Count < 1)
            {
                labelNumAirports.Text = _listAirports.Count().ToString();
                labelPopularDestination.Text = "N/A";
            }
            else
            {
                labelNumAirports.Text = _listAirports.Count().ToString();
                labelPopularDestination.Text = _listFlights.GroupBy(f => f.Destination).OrderByDescending(g => g.Count()).First().Key.ToString();
            }

            if (_listAirlines.Count < 1 && _listFlights.Count < 1)
            {
                labelNumAirlines.Text = "0";
                labelPopularAirline.Text = "N/A";
            }
            else if (_listAirlines.Count > 0 && _listFlights.Count < 1)
            {
                labelNumAirlines.Text = _listAirlines.Count().ToString();
                labelPopularAirline.Text = "N/A";
            }
            else
            {
                labelNumAirlines.Text = _listAirlines.Count().ToString();
                labelPopularAirline.Text = _listFlights.GroupBy(f => f.Airline.Name).OrderByDescending(g => g.Count()).First().Key.ToString();
            }

             labelNumAircrafts.Text = _listAircrafts.Count().ToString();

             labelNumFlights.Text = _listFlights.Count().ToString();

              labelNumTickets.Text = _listTickets.Count().ToString();


            labelNumActiveAircrafts.Text = numActiveAircrafts.ToString();
            labelNumInactiveAircrafts.Text = numInactiveAircrafts.ToString();
        }
    }
}
