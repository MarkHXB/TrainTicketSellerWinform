using TicketSeller.Model;
using TicketSeller.Views.Munkaképernyő.TicketSell;
using TicketSeller.Views.Munkaképernyő.TicketSell.Models;

namespace TicketSeller.Views.Munkaképernyő
{
    internal interface ITicketSellView
    {
        TicketSellModel Model { get; set; }

        ChooseUser ChooseUser { get; set; }
        ChooseTicket ChooseTicket { get; set; }
        ConfirmTicket ConfirmTicket { get; set; }

        List<string> FoundUsers { get; set; }
        List<City> TicketDestinations { get; set; }
        List<Ticket> TicketTickets { get; set; }


        event EventHandler SearchUserBarSelectedIndexChanged;
        event EventHandler SearchUserButton;
        event EventHandler SearchForTextChanged;
        event EventHandler ChooseUserButton;
        event EventHandler NotRegisteredButton;
        event EventHandler ConfirmTicketBack;
        event EventHandler ConfirmTicketBuy;
        event EventHandler PreTicketBackBtn;
        event EventHandler PreTicketNextBtn;

        void Show();
        void ShowRegisteredTicket();
        void ShowNonRegisteredTicket();
    }
}
