using TicketSeller.Model;

namespace TicketSeller.Views.Munkaképernyő.TicketSell
{
    public enum PayHelper
    {
        Money,
        CreditCard
    }

    public class TicketSellModel : Stage
    {
        public TicketSellModel()
        {
            Customer = new Customer();
            Ticket = new Ticket();
            TicketDestination = new City();
        }
        public Customer Customer { get; set; }
        public Ticket Ticket { get; set; }
        public City TicketDestination { get; set; }
        public PayHelper? PayMethod { get; set; }

        public bool PayWithCreditCard() => PayMethod == PayHelper.CreditCard;
        public bool PayMethodIsValid() => PayMethod != null;


        public City GetTicketDestination(List<City> avaliableDestinations, ComboBox userDestination)
        {
            var selectedDest = userDestination.SelectedItem;

            if (selectedDest == null) return null;

            foreach (var t in avaliableDestinations)
            {
                if (selectedDest.ToString() == t.Name)
                {
                    return t;
                }
            }
            return null;
        }
        public Ticket GetTicket(List<Ticket> avaliableTickets, ComboBox userTicket)
        {
            var selectedTicket = userTicket.SelectedItem;

            if (selectedTicket == null) return null;

            foreach (var t in avaliableTickets)
            {
                if (selectedTicket.ToString() == t.Name)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
