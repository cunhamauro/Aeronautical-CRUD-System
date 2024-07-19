using ClassLibrary;
using System.Text.RegularExpressions;

namespace Projeto_Aeronautica.UserControls
{
    public partial class Register : UserControl
    {
        #region Global variables

        List<User> _listUsers;

        Panel _loginPanel;

        LoginForm _loginForm;

        #endregion

        public Register(List<User> listUsers, Panel loginPanel, LoginForm loginForm)
        {
            InitializeComponent();

            #region Load and update

            _listUsers = listUsers;
            _loginPanel = loginPanel;
            _loginForm = loginForm;

            #endregion
        }

        /// <summary>
        /// Register a new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("The inserted username is not valid!", "Invalid username!");
                return;
            }

            if (UsernameTaken(username))
            {
                MessageBox.Show($"The username {username} is already in use!", "Username taken!");
                return;
            }

            if (!ValidPassword(password))
            {
                MessageBox.Show("The inserted password is not valid!", "Invalid password!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("The inserted passwords are not a match!", "Invalid passwords!");
                return;
            }

            User user = new User()
            {
                Username = username,
                Password = User.EncryptPassword(password),
            };

            _listUsers.Add(user);
            Login login = new Login(_listUsers, _loginForm);
            LoadUserControl(login); // After successfully registering go to the login usercontrol
        }

        /// <summary>
        /// Verify if the username is already in use
        /// </summary>
        /// <param name="username">Username to verify</param>
        /// <returns>Username in use?</returns>
        private bool UsernameTaken(string username)
        {
            bool usernameTaken = false;

            foreach (User user in _listUsers)
            {
                if (user.Username == username)
                {
                    usernameTaken = true;
                }
            }

            return usernameTaken;
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
        /// Load the user control to the login form
        /// </summary>
        /// <param name="userControl">User control loaded</param>
        private void LoadUserControl(UserControl userControl)
        {
            _loginPanel.Controls.Clear();
            _loginPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Check if a forbidden character is pressed
        /// </summary>
        /// <param name="e"></param>
        private void textBoxRegister_KeyPress(object sender, KeyPressEventArgs e)
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

        /// <summary>
        /// Reveal/Hide the confirmation password input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSeePasswordConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmPassword.PasswordChar == '*')
            {
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else if (textBoxConfirmPassword.PasswordChar == '\0')
            {
                textBoxConfirmPassword.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Show information about the password criteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelPassInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password must have a length between 4 and 20 characters of letters and/or numbers and the use of underscore is allowed!", "Password information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
