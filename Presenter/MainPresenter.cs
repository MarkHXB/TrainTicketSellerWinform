using TicketSeller.Configs;
using TicketSeller.Model;
using TicketSeller.Repositories;
using TicketSeller.Repositories.Interfaces;
using TicketSeller.Views;
using TicketSeller.Views.Kezdőképernyő;
using TicketSeller.Views.Munkaképernyő;
using TicketSeller.Views.Munkaképernyő.Statistics;

namespace TicketSeller.Presenter
{
    internal class MainPresenter
    {
        private IMainView view;
        private Cashier cashier;
        private MainConfig config;

        private static IDashboardView dashboardView;

        public MainPresenter(IMainView view, MainConfig config)
        {
            this.view = view;
            this.config = config;
            cashier = null;

            InitializeEvents();
        }


        void InitializeEvents()
        {
            this.view.LoadForm += OnLoadForm;
            this.view.ToggleMenu += ToggleMenuOnClick;
            this.view.ShowUserManager += OnShowUserManager;
            this.view.ShowTodayFinance += OnShowTodayFinance;
            this.view.ShowTicketSell += OnShowTicketSell;
            this.view.SideBarAnimation += OnSideBarAnimation;
            this.view.ShowDashboard += OnShowDashboard;
        }


        // -- REDIRECTOR --
        void RedirectToPage()
        {
            DisplayCurrentCashier();

            switch (config.GetCurrentMenuState())
            {
                case MenuStates.Dashboard:
                    RedirectToDashboard();
                    break;
                case MenuStates.TicketSell:
                    RedirectToTicketSell();
                    break;
                case MenuStates.UserManager:
                    RedirectToUserManager();
                    break;
                case MenuStates.TodayFinance:
                    RedirectToTodayFinance();
                    break;
                case MenuStates.CashSelection:
                    RedirectToCashSelection();
                    break;
                default:
                    break;
            }

            GC.SuppressFinalize(this);
        }


        // -- METHODS --
        private void DisplayCurrentCashier()
        {
            if (cashier != null)
            {
                view.CashierInfo = cashier.ToString();
            }
        }
        private bool IsValidCashier()
        {
            if (cashier == null || cashier.Worker == null) return false;
            return true;
        }


        // -- REDIRECTIONS --
        public void RedirectToDashboard()
        {
            if (!IsValidCashier())
            {
                RedirectToCashSelection();
                return;
            }

            if (config.GetCurrentMenuState() != MenuStates.Dashboard)
            {
                DisplayCurrentCashier();
                config.SetMenuState(MenuStates.Dashboard);
            }

            IDashboardView view = DashboardView.GetInstance((MainView)this.view);
            IDashboardRepository repository = new DashboardRepository(config.GetDbContext());
            this.view.FormTitle = "Kezdőlap";
            this.view.FormName = "Kezdőlap";
            this.view.menuPanel.Visible = true;
            this.view.menuPanel.Enabled = true;
            config.SetMenuState(MenuStates.Dashboard);
            new DashboardPresenter(view, repository);

        }
        public void RedirectToTicketSell()
        {
            if (!IsValidCashier())
            {
                RedirectToCashSelection();
                return;
            }
            dashboardView = null;
            ITicketSellView view = TicketSellView.GetInstance((MainView)this.view);
            ITicketSellRepository repository = new TicketSellRepository(config.GetDbContext());
            this.view.FormTitle = "Jegy eladás";
            this.view.FormName = "Jegy eladás";
            this.view.menuPanel.Visible = true;
            this.view.menuPanel.Enabled = true;
            config.SetMenuState(MenuStates.TicketSell);

            new TicketSellRepresenter(view, repository, cashier);
        }
        public void RedirectToUserManager()
        {
            if (!IsValidCashier())
            {
                RedirectToCashSelection();
                return;
            }

            IUserManagerView view = UserManagerView.GetInstance((MainView)this.view);
            IUserManagerRepository repository = new UserManagerRepository(config.GetDbContext());
            this.view.FormTitle = "Felhasználó kezelés";
            this.view.FormName = "Felhasználó kezelés";
            this.view.menuPanel.Visible = true;
            this.view.menuPanel.Enabled = true;
            config.SetMenuState(MenuStates.UserManager);
            new UserManagerPresenter(view, repository);
        }
        public void RedirectToTodayFinance()
        {
            if (!IsValidCashier())
            {
                RedirectToCashSelection();
                return;
            }

            ITodayFinanceView view = TodayFinanceView.GetInstance((MainView)this.view);
            ITodayFinanceRepository repository = new TodayFinanceRepository(config.GetDbContext());
            this.view.FormTitle = "Napi bevétel";
            this.view.FormName = "Napi bevétel";
            this.view.menuPanel.Visible = true;
            this.view.menuPanel.Enabled = true;
            config.SetMenuState(MenuStates.TodayFinance);
            new TodayFinancePresenter(view, repository, cashier);
        }
        public void RedirectToCashSelection()
        {
            ICashSelectionView view = CashSelectionView.GetInstance((MainView)this.view);
            ICashRepository repository = new CashRepository(config.GetDbContext());
            this.view.FormTitle = "Kassza választás";
            this.view.FormName = "Kassza választás";
            this.view.menuPanel.Visible = false;
            this.view.menuPanel.Enabled = false;
            cashier = new Cashier();
            new CashSelectionPresenter(view, repository, cashier, this);
        }


        // -- EVENTS --
        private void OnLoadForm(object? sender, EventArgs e)
        {
            RedirectToPage();
        }
        private void OnShowTodayFinance(object? sender, EventArgs e)
        {
            config.SetMenuState(MenuStates.TodayFinance);
            RedirectToPage();
        }
        private void OnShowUserManager(object? sender, EventArgs e)
        {
            config.SetMenuState(MenuStates.UserManager);
            RedirectToPage();
        }
        private void OnShowTicketSell(object? sender, EventArgs e)
        {
            config.SetMenuState(MenuStates.TicketSell);
            RedirectToPage();
        }
        private void ToggleMenuOnClick(object? sender, EventArgs e)
        {
            view.sideBarTimer.Start();
        }
        private void OnSideBarAnimation(object? sender, EventArgs e)
        {
            if (view.expandMenuBar)
            {
                view.menuPanel.Width -= 10;
                if (view.menuPanel.Width == view.menuPanel.MinimumSize.Width)
                {
                    view.expandMenuBar = false;
                    view.sideBarTimer.Stop();
                }
            }
            else
            {
                view.menuPanel.Width += 10;
                if (view.menuPanel.Width == view.menuPanel.MaximumSize.Width)
                {
                    view.expandMenuBar = true;
                    view.sideBarTimer.Stop();
                }
            }
        }
        private void OnShowDashboard(object? sender, EventArgs e)
        {
            config.SetMenuState(MenuStates.Dashboard);
            RedirectToPage();
        }
    }
}
