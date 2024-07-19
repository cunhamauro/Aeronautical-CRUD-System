using ClassLibrary;

namespace Projeto_Aeronautica
{
    public partial class TicketInvoice : Form
    {
        // Printing an invoice just for simulation purposes

        #region Global variables

        Ticket _ticket;

        decimal _ticketPrice;

        #endregion

        public TicketInvoice(Ticket ticket, decimal ticketPrice)
        {
            InitializeComponent();

            #region Load and update

            _ticket = ticket;
            _ticketPrice = ticketPrice;
            LoadInvoice();

            #endregion
        }

        /// <summary>
        /// Load invoice info
        /// </summary>
        private void LoadInvoice()
        {
            labelDate.Text = DateTime.Now.ToString();
            labelIdNum.Text = $"Client ID.: {_ticket.Client.IdNumber}";
            labelInvoiceNum.Text = $"FT{_ticket.Id}";
            labelPrice.Text = $"{_ticketPrice:C2}";
            labelFlightInfo.Text = _ticket.Flight.FlightDescription();
        }

        /// <summary>
        /// Change text (title) of form according to the ticket ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicketInvoice_Load(object sender, EventArgs e)
        {
            this.Text = $"FT{_ticket.Id}";
        }
    }
}
