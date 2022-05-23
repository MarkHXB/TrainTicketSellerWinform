using TicketSeller.Model;

namespace TicketSeller.Views.Munkaképernyő.TicketSell.Models
{
    public class ChooseUser : Stage
    {
        public bool IsRegistered { get; set; }
        public string? SearchResult { get; set; }
        public string SearchValue { get; set; }
    }
}
