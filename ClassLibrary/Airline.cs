using System.Diagnostics.Metrics;

namespace ClassLibrary
{
    public class Airline
    {
        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Aircraft> AirlineAircrafts { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// ToString() override to output airline name
        /// </summary>
        /// <returns>Airline name</returns>
        public override string ToString()
        {
            return $"[{Id}] - {Name}";
        }

        #endregion
    }
}
