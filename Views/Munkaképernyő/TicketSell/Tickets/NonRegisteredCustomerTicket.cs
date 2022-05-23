using TicketSeller.Model;
using TicketSeller.Views.Munkaképernyő.TicketSell.Models;

namespace TicketSeller.Views.Munkaképernyő.TicketSell.Tickets
{
    public partial class NonRegisteredCustomerTicket : UserControl
    {
        private static NonRegisteredCustomerTicket? instance;
        public NonRegisteredCustomerTicket()
        {
            InitializeComponent();
        }
        public static NonRegisteredCustomerTicket GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new NonRegisteredCustomerTicket();
            }
            return instance;
        }
        internal void LoadControl(Customer customer, Ticket ticket, ChooseTicket chooseTicket,City ticketDestination)
        {
            //ticket details
            ticketPrice.Text = chooseTicket.Price.ToString();
            ticketDistance.Text = chooseTicket.Distance.ToString();
            ticketFromCityName.Text = chooseTicket.FromCityName;
            ticketToCityName.Text = ticketDestination.Name;
            ticketName.Text = ticket.Name;
            ticketType.Text = ((bool)ticket.IsTicket == true ? "Jegy" : "");
        }
    }
}
