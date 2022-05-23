using TicketSeller.Model.Context;
using TicketSeller.Views;

namespace TicketSeller.Configs
{
    internal partial class MainConfig
    {
        private TicketSellerDbContext _dbContext { get; set; }
        private MenuStates _menuState { get; set; }
    }
}
