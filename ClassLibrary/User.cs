using System.Text;

namespace ClassLibrary
{
    public class User
    {
        #region Global consts

        const int PASSWORD_SHIFT = 1; // So it doesnt convert anything to ; (because of file writing and reading)

        #endregion

        #region Properties

        public string Username { get; set; }

        public string Password { get; set; }

        #endregion

        #region Method

        /// <summary>
        /// Encrypt the users password
        /// </summary>
        /// <param name="password">Users password</param>
        /// <returns>Users encrypted password</returns>
        public static string EncryptPassword(string password)
        {
            StringBuilder encryptedPassword = new StringBuilder();

            // Encrypt with shift cipher
            foreach (char character in password)
            {
                char encryptedChar = (char)(character + PASSWORD_SHIFT);
                encryptedPassword.Append(encryptedChar);
            }

            // Reverse the encrypted string
            char[] charArray = encryptedPassword.ToString().ToCharArray();
            Array.Reverse(charArray);

            // Return the double encrypted password as a string
            return new string(charArray);
        }

        #endregion
    }
}
