using ClassLibrary;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projeto_Aeronautica.UserControls
{
    public partial class Login : UserControl
    {
        #region Global variables

        List<User> _listUsers;

        LoginForm _loginForm;

        #endregion

        public Login(List<User> listUsers, LoginForm loginForm)
        {
            InitializeComponent();

            #region Load and update

            _listUsers = listUsers;
            _loginForm = loginForm;

            #endregion
        }

        /// <summary>
        /// Login authentication (username and password)
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Login authenticated</returns>
        public bool LoginAuthenticated(string username, string password)
        {
            foreach (User user in _listUsers)
            {
                if (user.Username == username) // Find the username
                {
                    if (user.Password == User.EncryptPassword(password)) // Match the users password the the encrypted input password
                    {
                        return true; // Authenticated
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Login the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (!ValidPassword(password))
            {
                MessageBox.Show("The inserted password is not valid!", "Invalid password!");
                return;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("The inserted username is not valid!", "Invalid username!");
                return;
            }

            if (LoginAuthenticated(username, password))
            {
                User user = _listUsers.FirstOrDefault(x => x.Username == username);
                _loginForm.FormShow(false);
                MainForm mainForm = new MainForm(user, _loginForm);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("The inserted username/password is not valid!", "Failed authentication!");
            }
        }

        /// <summary>
        /// Check if the password is valid
        /// </summary>
        /// <param name="password">Password to validate</param>
        /// <returns>Password valid?</returns>
        private bool ValidPassword(string password)
        {
            // Define the regex pattern for letters and numbers only and check if the length is between 5 and 15
            string pattern = @"^[a-zA-Z0-9_]{4,20}$";

            return Regex.IsMatch(password, pattern);

        }

        /// <summary>
        /// Check if a forbidden character is pressed
        /// </summary>
        /// <param name="e"></param>
        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Define the list of allowed characters (letters (with accents), numbers, space, etc)
            string pattern = @"^[\p{L}0-9 _]+$";

            // Verify if the typed character is not included in the allowed characters, but allow control characters (backspace, enter, tab, etc...)
            if (!char.IsControl(e.KeyChar) && !Regex.IsMatch(e.KeyChar.ToString(), pattern))
            {
                e.Handled = true; // Doesnt allow the character insertion
                MessageBox.Show("Only alphanumerical and underscore characters are allowed!", "Forbidden character!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Reveal/Hide the password input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSeePassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '*')
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else if (textBoxPassword.PasswordChar == '\0')
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
    }
}
