using ClassLibrary;
using System.Text.RegularExpressions;

namespace Projeto_Aeronautica
{
    public partial class AirlinesUserControl : UserControl
    {
        #region Global variables

        List<Airline> _listAirlines;

        List<Aircraft> _listAircrafts;

        int counterAirlineId = 1;

        #endregion

        public AirlinesUserControl(List<Airline> listAirlines, List<Aircraft> listAircrafts)
        {
            InitializeComponent();

            #region Load and update

            _listAirlines = listAirlines;
            listBoxAirlines.DataSource = _listAirlines;
            _listAircrafts = listAircrafts;

            UpdateCounterId();
            LoadAirlineEditData();
            RefreshListBox(false);

            #endregion
        }

        /// <summary>
        /// Add airline to the list of airlines
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAirline_Click(object sender, EventArgs e)
        {
            string name = textBoxAirline.Text;

            if (!ValidAirlineInput(name, null))
            {
                return;
            }

            Airline airline = new Airline()
            {
                Id = counterAirlineId,
                Name = name,
            };

            _listAirlines.Add(airline);
            UpdateCounterId();
            RefreshListBox(false);
            listBoxAirlines.SelectedItem = airline;
            ClearInputs(false);
        }

        /// <summary>
        /// Edit selected airline
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAirline_Click(object sender, EventArgs e)
        {
            Airline airline = listBoxAirlines.SelectedItem as Airline;

            if (airline != null)
            {
                string oldName = airline.Name;
                string name = textBoxEditAirline.Text;

                if (!ValidAirlineInput(name, oldName))
                {
                    return;
                }

                airline.Name = name;
                RefreshListBox(false);
                listBoxAirlines.SelectedItem = airline;
            }
            else
            {
                MessageBox.Show("Please select an airline to edit!", "Airline not selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Delete selected airline
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteAirline_Click(object sender, EventArgs e)
        {
            Airline airline = listBoxAirlines.SelectedItem as Airline;

            if (airline != null)
            {
                if (!AirlineInUse(airline))
                {
                    _listAirlines.Remove(airline);
                    UpdateCounterId();
                    RefreshListBox(true);
                    ClearInputs(false);
                }
                else
                {
                    MessageBox.Show($"Airline [{airline.Name}] has active aircrafts!", "Deletion not allowed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select an airline to remove!", "Airline not selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Validate airline input data (new/edit)
        /// </summary>
        /// <param name="name">Airline name</param>
        /// <param name="oldName">Airline old name if edited</param>
        /// <returns>Valid airline inputs?</returns>
        private bool ValidAirlineInput(string name, string oldName)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Input data is not valid!", "Validation error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (RepeatedAirline(name, oldName))
            {
                MessageBox.Show($"The airline name [{name}] is already being used!", "Invalid airline name!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Update airline ID counter
        /// </summary>
        private void UpdateCounterId()
        {
            // Get ID by max ID, so even if a lower ID airline is deleted, there is no ID repetition
            if (_listAirlines.Count > 0)
            {
                counterAirlineId = _listAirlines.Select(a => a.Id).Max() + 1;
            }
            else
            {
                counterAirlineId = 1;
            }
            textBoxAirlineId.Text = counterAirlineId.ToString();
        }

        /// <summary>
        /// Check if the airline is in use
        /// </summary>
        /// <param name="airline">Airline</param>
        /// <returns>Airline in use?</returns>
        private bool AirlineInUse(Airline airline)
        {
            foreach (Aircraft aircraft in _listAircrafts)
            {
                if (airline == aircraft.Airline)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Call to load arline data to edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAirlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAirlineEditData();
        }

        /// <summary>
        /// Load selected airline data to edit
        /// </summary>
        private void LoadAirlineEditData()
        {
            Airline airline = listBoxAirlines.SelectedItem as Airline;

            if (airline == null)
            {
                textBoxEditAirlineId.Text = "Select an Airline";
                EnableControls(false);
                return;
            }

            EnableControls(true);

            textBoxEditAirline.Text = airline.Name;
            textBoxEditAirlineId.Text = airline.Id.ToString();
        }

        /// <summary>
        /// Enable controls to edit airline
        /// </summary>
        /// <param name="enable">Enable to edit airline?</param>
        private void EnableControls(bool enable)
        {
            textBoxEditAirline.Enabled = enable;

            buttonDeleteAirline.Enabled = enable;
            buttonEditAirline.Enabled = enable;
            buttonConsultFleet.Enabled = enable;
        }

        /// <summary>
        /// Clear airline inputs (new/edit)
        /// </summary>
        /// <param name="edit">Clear airline edit inputs?</param>
        private void ClearInputs(bool edit)
        {
            if (edit)
            {
                textBoxEditAirline.Clear();
            }
            else
            {
                textBoxAirline.Clear();
            }
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
        /// Refresh airlines list box
        /// </summary>
        private void RefreshListBox(bool remove)
        {
            listBoxAirlines.DataSource = null;
            listBoxAirlines.DataSource = _listAirlines;

            if (remove) // If airline was removed
            {
                if (listBoxAirlines.Items.Count == 0)
                {
                    ClearInputs(true);
                    EnableControls(false);
                }
                else // And there are still items in the listbox
                {
                    listBoxAirlines.SelectedIndex = 0; // Set selected item to first of listbox
                }
            }

            labelAirlinesCount.Text = listBoxAirlines.Items.Count.ToString();
        }

        /// <summary>
        /// Check if the airline name is already in use
        /// </summary>
        /// <param name="newAirlineName">New airline name</param>
        /// <param name="oldAirlineName">Old airline name</param>
        /// <param name="newAirline">Adding a new airline?</param>
        /// <returns>Airline name already in use?</returns>
        private bool RepeatedAirline(string newAirlineName, string oldAirlineName)
        {
            foreach (Airline airline in _listAirlines)
            {
                if (oldAirlineName == null) // New airline
                {
                    if (airline.Name.ToLower() == newAirlineName.ToLower()) // If airline name is in use
                    {
                        return true;
                    }
                }
                else // Edit current airline
                {
                    if (airline.Name.ToLower() == newAirlineName.ToLower() && newAirlineName.ToLower() != oldAirlineName.ToLower()) // If airline name is in use and it isn't the same as the name from the airline that's being edited
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Consult the aircraft fleet of the selected airline
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConsultFleet_Click(object sender, EventArgs e)
        {
            Airline airline = listBoxAirlines.SelectedItem as Airline;

            if (airline != null)
            {
                AirlineFleet airlineFleet = new AirlineFleet(airline, _listAircrafts);
                airlineFleet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an airline to consult its fleet!", "Airline not selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
