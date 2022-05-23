using TicketSeller.Model;
using TicketSeller.Views.Munkaképernyő.TicketSell.Models;

namespace TicketSeller.Views.Munkaképernyő.TicketSell.Tickets
{
    public partial class RegisteredCustomerTicket : UserControl, IDisposable
    {
        private static RegisteredCustomerTicket? instance;

        public RegisteredCustomerTicket()
        {
            InitializeComponent();
        }

        public static RegisteredCustomerTicket GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RegisteredCustomerTicket();
            }
            return instance;
        }

        internal void LoadControl(Customer customer, Ticket ticket, ChooseTicket chooseTicket,City ticketDestination)
        {
            //customer details
            customerName.Text = customer.Name;
            customerBirthyear.Text = customer.BirthYear.ToString();
            int btCount = (10 - customer.BoughtTicket) < 0 ? 0 : (10 - customer.BoughtTicket);
            customerBtCount.Text = btCount.ToString();
            customerCategory.Text = customer.Discount?.Type;

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
