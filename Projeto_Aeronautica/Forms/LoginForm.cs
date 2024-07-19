using ClassLibrary;
using Projeto_Aeronautica.UserControls;

namespace Projeto_Aeronautica
{
    public partial class LoginForm : Form
    {
        #region Global variable

        List<User> ListUsers = new List<User>();

        #endregion

        #region File path

        const string fileUsers = @"AIS_Data/users.txt";

        #endregion

        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the user control to the login form
        /// </summary>
        /// <param name="userControl">User control loaded</param>
        private void LoadUserControl(UserControl userControl)
        {
            panelLoginRegister.Controls.Clear();
            panelLoginRegister.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// When opening form load all data (read from files .txt)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(fileUsers))
            {
                try
                {
                    ListUsers = DataManager.LoadUsers(fileUsers);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error loading Users data!", "Users data error!");
                }
            }

            #region Load and update

            Login login = new Login(ListUsers, this);
            LoadUserControl(login);

            #endregion
        }

        /// <summary>
        /// Button for login or register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoginOrRegister_Click(object sender, EventArgs e)
        {
            if (buttonLoginOrRegister.Tag == "register")
            {
                buttonLoginOrRegister.Text = "Already have an account? Login";
                buttonLoginOrRegister.Tag = "login";
                Register register = new Register(ListUsers, panelLoginRegister, this);
                LoadUserControl(register);
            }
            else if (buttonLoginOrRegister.Tag == "login")
            {
                buttonLoginOrRegister.Text = "Don't have an account? Register";
                buttonLoginOrRegister.Tag = "register";
                Login login = new Login(ListUsers, this);
                LoadUserControl(login);
            }
        }

        /// <summary>
        /// Show about/credits form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCredits_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
        }

        /// <summary>
        /// When closing form save all data (write to files .txt)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save Users
            try
            {
                DataManager.SaveUsers(ListUsers, fileUsers);
            }
            catch (Exception)
            {

                MessageBox.Show("Error saving Users data!", "Users data error!");
            }
        }

        /// <summary>
        /// Show/Hide login form
        /// </summary>
        public void FormShow(bool show)
        {
            if (show)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
        }

        /// <summary>
        /// Close the login form
        /// </summary>
        public void FormClose()
        {
            this.Close();
        }
    }
}
