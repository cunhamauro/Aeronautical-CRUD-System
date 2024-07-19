using ClassLibrary;

namespace Projeto_Aeronautica
{
    public partial class AirlineFleet : Form
    {
        #region Global variables

        Airline _airline;

        List<Aircraft> _listAircrafts;

        #endregion

        public AirlineFleet(Airline airline, List<Aircraft> listAircrafts)
        {
            InitializeComponent();

            #region Load and update

            _airline = airline;
            _listAircrafts = listAircrafts;
            LoadAirlineFleet();

            #endregion
        }

        /// <summary>
        /// Load airline fleet data
        /// </summary>
        private void LoadAirlineFleet()
        {
            var airlineAircrafts = _listAircrafts.Where(a => a.Airline == _airline).ToList();
            labelAirline.Text = $"{_airline.Name} fleet";
            listBoxAirlineAircrafts.DataSource = airlineAircrafts;
            labelAircraftsCount.Text = listBoxAirlineAircrafts.Items.Count.ToString();

        }

        /// <summary>
        /// Change text (title) of form according to the airline
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AirlineFleet_Load(object sender, EventArgs e)
        {
            this.Text = $"{_airline.Name} fleet";
        }
    }
}
