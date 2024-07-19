using ClassLibrary;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Projeto_Aeronautica
{
    public partial class AirportsUserControl : UserControl
    {
        #region Global variables

        List<Airport> _listAirports;

        List<Flight> _listFlights;

        List<Airport> listAirportsApi;

        #endregion

        public AirportsUserControl(List<Airport> listAirports, List<Flight> listFlights)
        {
            InitializeComponent();

            #region Load and update

            _listFlights = listFlights;
            _listAirports = listAirports;
            listBoxAirports.DataSource = _listAirports;
            comboBoxSearchAirportBy.SelectedIndex = 0; // Start with search by IATA by default

            LoadAirportEditData();
            RefreshListBox(false);
            SetControlsApiAirports(false);

            #endregion
        }

        /// <summary>
        /// Add airport to the list of airports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAirport_Click(object sender, EventArgs e)
        {
            string iata = textBoxIATA.Text.ToUpper();
            string country = UpperLowerFormat(textBoxCountry.Text);
            string city = UpperLowerFormat(textBoxCity.Text);

            if (!ValidAirportInput(iata, null, country, city))
            {
                return;
            }

            Airport airport = new Airport()
            {
                IATA = iata,
                Country = country,
                City = city,
            };

            _listAirports.Add(airport);
            RefreshListBox(false);
            listBoxAirports.SelectedItem = airport;
            ClearInputs(false);

        }

        /// <summary>
        /// Edit selected airport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAirport_Click(object sender, EventArgs e)
        {
            Airport airport = listBoxAirports.SelectedItem as Airport;

            if (airport != null)
            {
                string oldIata = airport.IATA;

                string iata = textBoxEditIata.Text.ToUpper();
                string country = UpperLowerFormat(textBoxEditCountry.Text);
                string city = UpperLowerFormat(textBoxEditCity.Text);

                if (!ValidAirportInput(iata, oldIata, country, city))
                {
                    return;
                }
                airport.IATA = iata;
                airport.Country = country;
                airport.City = city;

                RefreshListBox(false);
                listBoxAirports.SelectedItem = airport;
            }
            else
            {
                MessageBox.Show("Please select an airport to edit!", "Airport not selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validate airport inputs (new/edit)
        /// </summary>
        /// <param name="iata">Airport IATA code</param>
        /// <param name="oldIata">Airport old IATA if edited</param>
        /// <param name="country">Airport country</param>
        /// <param name="city">Airport city</param>
        /// <returns>Valid airport inputs?</returns>
        private bool ValidAirportInput(string iata, string oldIata, string country, string city)
        {
            if (string.IsNullOrWhiteSpace(iata) || string.IsNullOrWhiteSpace(country) || string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("Input data is not valid!", "Validation error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IataFormat(iata))
            {
                MessageBox.Show($"IATA codes consist of 3 alphabetical characters!", "Invalid IATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (RepeatedIata(iata, oldIata))
            {
                MessageBox.Show($"The IATA [{iata}] is already being used!", "Invalid IATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Delete selected airport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteAirport_Click(object sender, EventArgs e)
        {
            Airport airport = listBoxAirports.SelectedItem as Airport;

            if (airport != null)
            {
                if (!AirportInUse(airport))
                {
                    _listAirports.Remove(airport);

                    RefreshListBox(true);
                    ClearInputs(false);
                }
                else
                {
                    MessageBox.Show($"Airport [{airport.IATA}] is part of a scheduled or active flight!", "Deletion not allowed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select an airport to remove!", "Airport not selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Check if the airport is in use
        /// </summary>
        /// <param name="airport">Airport</param>
        /// <returns>Airport in use?</returns>
        private bool AirportInUse(Airport airport)
        {
            foreach (Flight flight in _listFlights)
            {
                if (airport == flight.Origin || airport == flight.Destination)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Call to load airport data to edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAirportEditData();
        }

        /// <summary>
        /// Load selected airport data to edit
        /// </summary>
        private void LoadAirportEditData()
        {
            Airport airport = listBoxAirports.SelectedItem as Airport;

            if (airport == null)
            {
                textBoxEditIata.Text = "Select an Airport";
                EnableControls(false);

                return;
            }

            EnableControls(true);

            textBoxEditIata.Text = airport.IATA;
            textBoxEditCity.Text = airport.City;
            textBoxEditCountry.Text = airport.Country;
        }

        /// <summary>
        /// Enable controls to edit airport
        /// </summary>
        /// <param name="enable">Enable to edit airport?</param>
        private void EnableControls(bool enable)
        {
            textBoxEditIata.Enabled = enable;
            textBoxEditCity.Enabled = enable;
            textBoxEditCountry.Enabled = enable;

            buttonDeleteAirport.Enabled = enable;
            buttonEditAirport.Enabled = enable;
        }

        /// <summary>
        /// Clear airport inputs (new/edit)
        /// </summary>
        /// <param name="edit">Clear airport edit inputs?</param>
        private void ClearInputs(bool edit)
        {
            if (edit)
            {
                textBoxEditCity.Clear();
                textBoxEditCountry.Clear();
            }
            else
            {
                textBoxCity.Clear();
                textBoxCountry.Clear();
                textBoxIATA.Clear();
            }
        }

        /// <summary>
        /// Check if the IATA code is already in use
        /// </summary>
        /// <param name="newIata">New IATA code</param>
        /// <param name="oldIata">Old IATA code</param>
        /// <param name="newAirport">Adding a new airport?</param>
        /// <returns>IATA already in use?</returns>
        private bool RepeatedIata(string newIata, string oldIata)
        {
            foreach (Airport airport in _listAirports)
            {
                if (oldIata == null) // New airport
                {
                    if (airport.IATA == newIata) // If IATA code is in use
                    {
                        return true;
                    }
                }
                else // Edit current airport
                {
                    if (airport.IATA == newIata && newIata != oldIata) // If IATA code is in use and it isn't the same as the IATA from the airport that's being edited
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Check if the IATA code format is correct
        /// </summary>
        /// <param name="iata">IATA code</param>
        /// <returns>IATA correct?</returns>
        private bool IataFormat(string iata)
        {
            if (iata.Length == 3)
            {
                return iata.All(Char.IsLetter); // Check if IATA is alphabetical only
            }
            return false;
        }

        /// <summary>
        /// Check if a forbidden character is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSanitize_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Define the list of allowed characters (letters (with accents), numbers, space, etc)
            string pattern = @"^[\p{L}0-9 ]+$";

            // Verify if the typed character is not included in the allowed characters, but allow control characters (backspace, enter, tab, etc...)
            if (!char.IsControl(e.KeyChar) && !Regex.IsMatch(e.KeyChar.ToString(), pattern))
            {
                e.Handled = true; // Doesnt allow the character insertion
                MessageBox.Show("Only alphanumerical characters allowed!", "Forbidden character!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Refresh airports list box
        /// </summary>
        private void RefreshListBox(bool remove)
        {
            listBoxAirports.DataSource = null;
            listBoxAirports.DataSource = _listAirports;

            if (remove) // If airport was removed
            {
                if (listBoxAirports.Items.Count == 0)
                {
                    ClearInputs(true);
                    EnableControls(false);
                }
                else // And there are still items in the listbox
                {
                    listBoxAirports.SelectedIndex = 0; // Set selected item to first of listbox
                }
            }
            labelAirportsCount.Text = listBoxAirports.Items.Count.ToString();
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
        /// Load the listbox with the API airports
        /// </summary>
        /// <param name="downloadedAirports">List of airports downloaded</param>
        private void RefreshApiAirportsListBox(bool loaded)
        {
            listBoxAirportsApi.DataSource = null;
            listBoxAirportsApi.DataSource = listAirportsApi;
            labelAirportsApiCount.Text = listBoxAirportsApi.Items.Count.ToString();

            SetControlsApiAirports(loaded);
        }

        /// <summary>
        /// Download the airports from the API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonGetAirportsApi_Click(object sender, EventArgs e)
        // Keep void instead of changing to Task because its a windows forms control event
        {
            if (CheckConnection()) // There is an internet connection
            {
                using (HttpClient client = new HttpClient())
                {
                    try // Try to fetch the API airports
                    {
                        HttpResponseMessage response = await client.GetAsync("https://gist.githubusercontent.com/tdreyno/4278655/raw/7b0762c09b519f40397e4c3e100b097d861f5588/airports.json");
                        response.EnsureSuccessStatusCode();
                        string json = await response.Content.ReadAsStringAsync();

                        // ApiAirport properties: code, state, country
                        // Airport properties: IATA, City, Country
                        List<ApiAirport> apiAirport = new List<ApiAirport>();
                        apiAirport = JsonSerializer.Deserialize<List<ApiAirport>>(json);

                        List<Airport> convertedAirports = new List<Airport>();

                        // Convert from class ApiAirport to Airport
                        convertedAirports = apiAirport.Where(apiAirport => !string.IsNullOrWhiteSpace(apiAirport.state) && !string.IsNullOrWhiteSpace(apiAirport.country)) // Some of the APIs airports come with empty states, etc
                        .Select(apiAirport => new Airport
                        {
                            IATA = apiAirport.code,
                            Country = apiAirport.country,
                            City = apiAirport.state
                        }).ToList();

                        listAirportsApi = new();
                        foreach (Airport ap in convertedAirports)
                        {
                            listAirportsApi.Add(ap);
                        }

                        listAirportsApi = listAirportsApi.OrderBy(a => a.Country).ToList();

                        RefreshApiAirportsListBox(true);
                    }
                    catch (HttpRequestException ex)
                    {

                        MessageBox.Show(ex.Message, "Error fetching API airports!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        /// <summary>
        /// Set visible/enable API airports related controls
        /// </summary>
        /// <param name="loaded">API airports loaded?</param>
        private void SetControlsApiAirports(bool loaded)
        {
            if (loaded)
            {
                buttonGetAirportsApi.Enabled = false;
                buttonGetAirportsApi.Visible = false;
                buttonAddAirportApi.Enabled = true;
                textBoxSearchAirportApi.Enabled = true;
                buttonSearchApiAirport.Enabled = true;
                comboBoxSearchAirportBy.Enabled = true;
            }
            else
            {
                buttonGetAirportsApi.Enabled = true;
                buttonGetAirportsApi.Visible = true;
                buttonAddAirportApi.Enabled = false;
                textBoxSearchAirportApi.Enabled = false;
                buttonSearchApiAirport.Enabled = false;
                comboBoxSearchAirportBy.Enabled = false;
            }
        }

        /// <summary>
        /// Check the Internet connection to allow the download
        /// </summary>
        /// <returns>Internet connection?</returns>
        private bool CheckConnection()
        {
            WebClient client = new WebClient();

            try
            {
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No Internet connection!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        /// <summary>
        /// Import an airport from the API list to the active list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAirportApi_Click(object sender, EventArgs e)
        {
            Airport airport = listBoxAirportsApi.SelectedItem as Airport;

            if (airport == null)
            {
                MessageBox.Show($"Please select an airport from the API to import to the airport list!", "Select an airport!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RepeatedIata(airport.IATA, null))
            {
                MessageBox.Show($"There is already an airport with the IATA [{airport.IATA}] in the active list of airports!", "Duplicate IATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _listAirports.Add(airport);
            RefreshListBox(false);

            listBoxAirports.SelectedItem = airport; // Select the imported airport in the receiving list
        }

        /// <summary>
        /// Search an API airport through the selected parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchApiAirport_Click(object sender, EventArgs e)
        {
            string search = textBoxSearchAirportApi.Text;

            if (string.IsNullOrWhiteSpace(search))
            {
                MessageBox.Show($"Please write a valid search input to filter the API airports!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (comboBoxSearchAirportBy.Text == "IATA") // Search by IATA
            {
                Airport airport = listAirportsApi.FirstOrDefault(a => a.IATA.ToUpper() == search.ToUpper());

                if (airport == null)
                {
                    MessageBox.Show($"No airport with the IATA [{search}] was found!", "No matching IATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listBoxAirportsApi.SelectedItem = airport;
            }
            else if (comboBoxSearchAirportBy.Text == "Country") // Search by Country
            {
                Airport airport = listAirportsApi.FirstOrDefault(a => a.Country.ToUpper() == search.ToUpper());

                if (airport == null)
                {
                    MessageBox.Show($"No airport with the Country [{search}] was found!", "No matching Country!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listBoxAirportsApi.SelectedItem = airport;
            } 
            else if (comboBoxSearchAirportBy.Text == "City") // Search by City
            {
                Airport airport = listAirportsApi.FirstOrDefault(a => a.City.ToUpper() == search.ToUpper());

                if (airport == null)
                {
                    MessageBox.Show($"No airport with the City [{search}] was found!", "No matching City!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listBoxAirportsApi.SelectedItem = airport;
            }
            else
            {
                return;
            }

            textBoxSearchAirportApi.Clear();
        }

        /// <summary>
        /// Change the textbox placeholder according to search parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSearchAirportBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchAirportBy.Text == "IATA")
            {
                textBoxSearchAirportApi.PlaceholderText = "IATA";
            }
            else if (comboBoxSearchAirportBy.Text == "Country")
            {
                textBoxSearchAirportApi.PlaceholderText = "Country";
            }
            else if (comboBoxSearchAirportBy.Text == "City")
            {
                textBoxSearchAirportApi.PlaceholderText = "City";
            }
            else
            {
                return;
            }
        }
    }
}
