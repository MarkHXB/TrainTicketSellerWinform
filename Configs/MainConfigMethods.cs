using TicketSeller.Model.Context;
using TicketSeller.Views;

namespace TicketSeller.Configs
{
    internal partial class MainConfig
    {
        public MainConfig(TicketSellerDbContext dbContext)
        {
            _dbContext = dbContext;
            _menuState = MenuStates.CashSelection;
        }

        // .. GET
        public MenuStates GetCurrentMenuState() => _menuState;
        // .. SET
        public void SetMenuState(MenuStates state) => _menuState = state;

        // .. GET
        public TicketSellerDbContext GetDbContext() => _dbContext;
    }
}
