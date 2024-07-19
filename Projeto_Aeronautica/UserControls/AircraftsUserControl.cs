using ClassLibrary;
using System.Text.RegularExpressions;

namespace Projeto_Aeronautica
{
    public partial class AircraftsUserControl : UserControl
    {
        #region Global variables

        const int MAX_ROWS = 26; // Max rows I allow an aircraft to have so A -> Z

        List<Aircraft> _listAircrafts;

        List<Airline> _listAirlines;

        List<Flight> _listFlights;

        int counterAircraftId = 1;


        #endregion

        public AircraftsUserControl(List<Aircraft> listAircrafts, List<Airline> listAirlines, List<Flight> listFlights)
        {
            InitializeComponent();

            #region Load and update

            _listFlights = listFlights;
            _listAircrafts = listAircrafts;
            _listAirlines = listAirlines;

            listBoxAircrafts.DataSource = _listAircrafts;
            listBoxAircrafts.DisplayMember = "AircraftWithStatus";

            comboBoxAirlines.DataSource = _listAirlines;
            comboBoxEditAirline.BindingContext = new BindingContext(); // Separate datasource bindings
            comboBoxEditAirline.DataSource = _listAirlines;

            UpdateCounterId();
            RefreshListBox(null, false);
            LoadAircraftEditData();

            #endregion
        }

        /// <summary>
        /// Add aircraft to the list of aircrafts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAircraft_Click(object sender, EventArgs e)
        {
            Airline airline = comboBoxAirlines.SelectedItem as Airline;

            string brand = comboBoxBrand.Text;
            string model = comboBoxModel.Text;
            int capacity = (int)numericUpDownCapacity.Value;
            int rows = (int)numericUpDownRows.Value;

            if (!ValidAircraftInput(brand, model, capacity, rows, airline))
            {
                return;
            }

            Aircraft aircraft = new Aircraft()
            {
                Id = counterAircraftId,
                Brand = brand,
                Model = model,
                Airline = airline,
                Capacity = capacity,
                Rows = rows
            };

            _listAircrafts.Add(aircraft);
            UpdateCounterId();
            RefreshListBox(aircraft, false);
        }

        /// <summary>
        /// Call to load aircraft data do edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAircrafts_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAircraftEditData();
        }

        /// <summary>
        /// Load selected aircraft data to edit
        /// </summary>
        private void LoadAircraftEditData()
        {
            Aircraft aircraft = listBoxAircrafts.SelectedItem as Aircraft;

            if (aircraft == null)
            {
                textBoxAircraftIdEdit.Text = "Select an Aircraft";
                EnableControls(false);

                return;
            }

            listBoxSeats.DataSource = null;
            listBoxSeats.DataSource = aircraft.Seats;
            labelSeatsCount.Text = listBoxSeats.Items.Count.ToString();

            if (aircraft.Status)
            {
                buttonStatus.BackColor = Color.Lime;
            }
            else
            {
                buttonStatus.BackColor = Color.Red;
            }

            EnableControls(true);

            comboBoxEditBrand.Text = aircraft.Brand;
            comboBoxEditModel.Text = aircraft.Model;

            numericUpDownEditCapacity.Value = aircraft.Capacity;
            numericUpDownEditRows.Value = aircraft.Rows;
            comboBoxEditAirline.SelectedItem = aircraft.Airline;
            textBoxAircraftIdEdit.Text = aircraft.Id.ToString();
        }

        /// <summary>
        /// Enable controls to edit aircraft
        /// </summary>
        /// <param name="enable">Enable to edit aircraft?</param>
        private void EnableControls(bool enable)
        {
            numericUpDownEditCapacity.Enabled = enable;
            numericUpDownEditRows.Enabled = enable;
            comboBoxEditAirline.Enabled = enable;

            buttonStatus.Enabled = enable;

            if (!enable)
            {
                buttonStatus.BackColor = Color.Gray;
            }

            comboBoxEditBrand.Enabled = enable;
            comboBoxEditModel.Enabled = enable;

            buttonDeleteAircraft.Enabled = enable;
            buttonEditAircraft.Enabled = enable;
        }

        /// <summary>
        /// Clear aircraft edit inputs
        /// </summary>
        private void ClearInputs()
        {
            // Dont clear inputs on creating new aircrafts because they are almost always the same brand/model
            comboBoxEditBrand.Text = string.Empty;
            comboBoxEditModel.Text = string.Empty;
        }

        /// <summary>
        /// Update aircraft ID counter
        /// </summary>
        private void UpdateCounterId()
        {
            // Get ID by max ID, so even if a lower ID aircraft is deleted, there is no ID repetition
            if (_listAircrafts.Count > 0)
            {
                counterAircraftId = _listAircrafts.Select(a => a.Id).Max() + 1;
            }
            else
            {
                counterAircraftId = 1;
            }
            textBoxAircraftId.Text = counterAircraftId.ToString();
        }

        /// <summary>
        /// Edit selected aircraft
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAircraft_Click(object sender, EventArgs e)
        {
            Aircraft aircraft = listBoxAircrafts.SelectedItem as Aircraft;

            if (aircraft == null)
            {
                MessageBox.Show("Please select an aircraft to edit!", "Aircraft not selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AircraftInUse(aircraft))
            {
                MessageBox.Show($"Aircraft [{aircraft.Id}] is assigned to a scheduled or active flight!", "Edition not allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Airline airline = comboBoxEditAirline.SelectedItem as Airline;

            string brand = comboBoxEditBrand.Text;
            string model = comboBoxEditModel.Text;

            int capacity = (int)numericUpDownEditCapacity.Value;
            int rows = (int)numericUpDownEditRows.Value;

            if (!ValidAircraftInput(brand, model, capacity, rows, airline))
            {
                return;
            }

            bool status;
            // Get the status from the button appearence selected
            if (buttonStatus.BackColor == Color.Red)
            {
                status = false;
            }
            else // (buttonStatus.BackColor == Color.Lime)
            {
                status = true;
            }

            aircraft.Brand = brand;
            aircraft.Model = model;
            aircraft.Capacity = capacity;
            aircraft.Rows = rows;
            aircraft.Airline = airline;
            aircraft.Status = status;

            RefreshListBox(aircraft, false);
            listBoxAircrafts.SelectedItem = aircraft;
        }

        /// <summary>
        /// Validate aircraft inputs [new/edit]
        /// </summary>
        /// <param name="brand">Aircraft brand</param>
        /// <param name="model">Aircraft model</param>
        /// <param name="capacity">Aircraft capacity</param>
        /// <param name="rows">Aircraft number of rows</param>
        /// <param name="airline">Aircraft assigned airline</param>
        /// <returns>Aircraft input valid?</returns>
        private bool ValidAircraftInput(string brand, string model, int capacity, int rows, Airline airline)
        {
            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Input data is not valid!", "Validation error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (airline == null)
            {
                MessageBox.Show("Please assign an airline to the aircraft!", "Airline not selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (rows > MAX_ROWS)
            {
                MessageBox.Show($"The maximum number of rows allowed is {MAX_ROWS}!", "Invalid number of rows!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (capacity < rows)
            {
                MessageBox.Show("Seating capacity must be equal or greater than the number of rows!", "Invalid seat configuration!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Delete selected aircraft
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteAircraft_Click(object sender, EventArgs e)
        {
            Aircraft aircraft = listBoxAircrafts.SelectedItem as Aircraft;

            if (aircraft != null)
            {
                if (!AircraftInUse(aircraft))
                {
                    _listAircrafts.Remove(aircraft);
                    RefreshListBox(null, true);
                    UpdateCounterId();
                }
                else
                {
                    MessageBox.Show($"Aircraft [{aircraft.Id}] is assigned to a scheduled or active flight!", "Deletion not allowed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select an aircraft to remove!", "Aircraft not selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Check if the aircraft is in use
        /// </summary>
        /// <param name="aircraft"></param>
        /// <returns>Aircraft in use</returns>
        private bool AircraftInUse(Aircraft aircraft)
        {
            foreach (Flight flight in _listFlights)
            {
                if (flight.Aircraft == aircraft)
                {
                    return true;
                }
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
        /// Refresh aircrafts and seats list box
        /// </summary>
        /// <param name="aircraft">Aircrafts seats data source</param>
        private void RefreshListBox(Aircraft aircraft, bool remove)
        {
            listBoxAircrafts.DataSource = null;
            listBoxAircrafts.DataSource = _listAircrafts;
            listBoxAircrafts.DisplayMember = "AircraftWithStatus";

            if (aircraft != null) // If valid parameter aircraft
            {
                listBoxSeats.DataSource = null;
                listBoxSeats.DataSource = aircraft.Seats;
                listBoxAircrafts.SelectedItem = aircraft;
                listBoxSeats.SelectedIndex = 0;
            }
            else // If null parameter aircraft
            {
                if (listBoxAircrafts.Items.Count > 0) // And aircrafts listbox is not empty
                {
                    listBoxAircrafts.SelectedIndex = 0; // Select first aircraft
                }
                else // If aircrafts listbox is empty
                {
                    listBoxSeats.DataSource = null;
                    listBoxSeats.Items.Clear(); // Clear the seats listbox
                }
            }

            if (remove) // If aircraft was removed
            {
                if (listBoxAircrafts.Items.Count == 0)
                {
                    ClearInputs();
                    EnableControls(false);
                }
                else // And there are still items in the listbox
                {
                    listBoxAircrafts.SelectedIndex = 0; // Set selected item to first of listbox
                }
            }

            labelSeatsCount.Text = listBoxSeats.Items.Count.ToString();
            labelAircraftsCount.Text = listBoxAircrafts.Items.Count.ToString();
        }

        /// <summary>
        /// Suggest aircraft models based on the suggested brands if selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBrand = sender as ComboBox;
            string name = comboBrand.Name;
            ComboBox comboModel = new ComboBox();

            if (name == "comboBoxBrand")
            {
                comboModel = comboBoxModel;
            }
            else if (name == "comboBoxEditBrand")
            {
                comboModel = comboBoxEditModel;
            }

            comboModel.Items.Clear();
            comboModel.Text = string.Empty;

            if (comboBrand.Text == "Airbus")
            {
                AircraftModelSugestions("A330", "A320", comboModel);
            }
            else if (comboBrand.Text == "Boeing")
            {
                AircraftModelSugestions("747", "777", comboModel);
            }
        }

        /// <summary>
        /// Add aircraft suggested models to combobox
        /// </summary>
        /// <param name="model">Aircraft brand model</param>
        private void AircraftModelSugestions(string model1, string model2, ComboBox comboModel)
        {
            comboModel.Items.Add(model1);
            comboModel.Items.Add(model2);
        }

        /// <summary>
        /// Change color/status of aircraft status button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStatus_Click(object sender, EventArgs e)
        {
            if (buttonStatus.BackColor == Color.Red)
            {
                buttonStatus.BackColor = Color.Lime;
            }
            else if (buttonStatus.BackColor == Color.Lime)
            {
                buttonStatus.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Reset aircraft status button to its actual state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlAircraft_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aircraft aircraft = listBoxAircrafts.SelectedItem as Aircraft;
            if (aircraft != null)
            {
                if (aircraft.Status)
                {
                    buttonStatus.BackColor = Color.Lime;
                }
                else if (!aircraft.Status)
                {
                    buttonStatus.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// Change the appearence of aircraft status button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStatus_BackColorChanged(object sender, EventArgs e)
        {
            if (buttonStatus.BackColor == Color.Lime)
            {
                buttonStatus.Text = "Active";
                buttonStatus.ForeColor = Color.Green;
                buttonStatus.FlatAppearance.BorderColor = Color.Green;
            }
            else if (buttonStatus.BackColor == Color.Red)
            {
                buttonStatus.Text = "Inactive";
                buttonStatus.ForeColor = Color.DarkRed;
                buttonStatus.FlatAppearance.BorderColor = Color.DarkRed;
            }
            else
            {
                buttonStatus.Text = "";
                buttonStatus.ForeColor = Color.Gray;
                buttonStatus.FlatAppearance.BorderColor = Color.Black;
            }
        }
    }
}
