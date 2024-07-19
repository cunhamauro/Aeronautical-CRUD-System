using System.Net.Mail;

namespace ClassLibrary
{
    public class Client
    {
        #region Properties

        public string Title { get; set; } // Mr. / Mrs. / etc

        public string FullName { get; set; } // Name + Surname, etc

        public string IdNumber { get; set; }

        public string ContactNumber { get; set; }

        public MailAddress Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// ToString() override to output client information
        /// </summary>
        /// <returns>Client information</returns>
        public override string ToString()
        {
            return $"{Title} {FullName}";
        }

        #endregion
    }
}