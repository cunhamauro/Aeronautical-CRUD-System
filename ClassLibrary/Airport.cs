namespace ClassLibrary
{
    public class Airport
    {
        #region Properties

        public string IATA { get; set; } // IATA code of airport (Ex.: OPO)

        public string Country { get; set; } // Country of airport (Ex.: Portugal)

        public string City { get; set; } // City of airport (Ex.: Porto)

        #endregion

        #region Methods

        /// <summary>
        /// ToString() override to output airport information
        /// </summary>
        /// <returns>Airport information</returns>
        public override string ToString()
        {
            return $"[{IATA}] - {City}, {Country}";
        }

        #endregion
    }
}
