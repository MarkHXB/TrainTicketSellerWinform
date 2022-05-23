using TicketSeller.Configs;
using TicketSeller.Model.Context;
using TicketSeller.Presenter;
using TicketSeller.Views;


namespace TicketSeller
{
    internal static class Program
    {
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IMainView view = new MainView();

            TicketSellerDbContext dbContext = new TicketSellerDbContext();

            var config = new MainConfig(dbContext);

            #region TESTING_SECTION

            //config.SetMenuState(MenuStates.CashSelection);

            #endregion

            new MainPresenter(view, config);


            Application.Run((Form)view);
        }
    }
}