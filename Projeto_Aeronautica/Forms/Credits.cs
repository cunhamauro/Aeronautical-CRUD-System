using System.Diagnostics;

namespace Projeto_Aeronautica
{
    public partial class Credits : Form
    {
        #region Global consts

        const string SW_VERSION = "1.0.0";

        const string SW_DATE = "1st July 2024";

        #endregion

        public Credits()
        {
            InitializeComponent();

            #region Load and update

            labelVersion.Text = $"Version {SW_VERSION}";
            labelVersionDate.Text = $"{SW_DATE}";

            #endregion
        }

        /// <summary>
        /// Github & Linkedin hyperlink 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelGithub_Linkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linklabel = sender as LinkLabel;
            string link = linklabel.Text;
            string url;

            if (link == "GitHub")
            {
                url = "https://github.com/cunhamauro";
            }
            else if (link == "Linkedin")
            {
                url = "https://www.linkedin.com/in/cunhamauro/";
            }
            else
            {
                return;
            }

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the URL: " + ex.Message);
            }
        }
    }
}
