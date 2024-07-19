namespace ClassLibrary
{
    public class Aircraft
    {
        #region Attributes

        bool _status = true; // Status is true by default (Aircraft is operational after construction)

        int _rows;

        #endregion

        #region Properties

        public int Id { get; set; }

        public string Brand { get; set; } // Brand + Model (Ex.: Airbus A220)

        public string Model { get; set; } // Brand + Model (Ex.: Airbus A220)

        public Airline Airline { get; set; }

        public int Capacity { get; set; }

        public int Rows
        {
            get
            {
                return _rows; 
            }
            set
            {
                _rows = value;
                GenerateSeats();
            } 
        }

        public List<string> Seats { get; set; } // Calculated based on capacity and rows and generates: "A1, A2, B1, B2, C1, C2"

        public bool Status // Aircraft active or not
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public string AircraftWithStatus { get { return $"[{Id}] - {Brand} {Model} - {Airline.Name} [{GetStatus()}]"; } }

        #endregion

        #region Methods

        /// <summary>
        /// Generate seats of the aircraft based on capacity and rows
        /// </summary>
        private void GenerateSeats()
        {
            if (Seats == null)
            {
                Seats = new List<string>();
            }

            List<string> seatsGenerated = new List<string>();

            const string ROW_LETTER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Max 26 rows

            int seatsPerRow = Capacity / Rows;

            int remainingSeats = Capacity % Rows;

            for (int row = 0; row < Rows; row++)
            {
                for (int seat = 1; seat <= seatsPerRow; seat++)
                {
                    seatsGenerated.Add($"{ROW_LETTER[row]}{seat}");
                }
            }

            // If there are any seats remaining that were not allocated in division of rows, add to last row

            for (int seat = seatsPerRow + 1; seat <= seatsPerRow + remainingSeats; seat++)
            {
                seatsGenerated.Add($"{ROW_LETTER[Rows - 1]}{seat}");
            }

            Seats = seatsGenerated;
        }

        /// <summary>
        /// ToString() override to output aircraft information
        /// </summary>
        /// <returns>Plane information</returns>
        public override string ToString()
        {
            return $"[{Id}] - {Brand} {Model} - {Airline.Name}";
        }

        /// <summary>
        /// Plane status active or inactive
        /// </summary>
        /// <returns>String aircraft status</returns>
        public string GetStatus()
        {
            if (Status)
            {
                return "Active";
            }
            else
            {
                return "Inactive";
            }
        }

        #endregion
    }
}