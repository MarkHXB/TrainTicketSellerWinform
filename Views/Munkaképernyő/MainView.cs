using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSeller.Model;

namespace TicketSeller.Views
{
    public partial class MainView : Form, IMainView
    {
        private string message;
        private bool expandSidebar = true;
        private Cashier _cashier;

        public MainView()
        {
            InitializeComponent();

            _cashier = new Cashier();

            this.IsMdiContainer = true;

            InitializeEvents();
        }

        #region PROPS
        public string Message 
        { 
            get => message; 
            set => message = value;
        }
        public Panel menuPanel 
        { 
            get => menuPnl; 
            set => menuPnl = value;
        }
        public bool expandMenuBar 
        { 
            get => expandSidebar;
            set => expandSidebar = value;
        }
        public string FormTitle 
        {
            get => mainTitle.Text;
            set => mainTitle.Text = value;
        }
        public string FormName
        {
            get => this.Text;
            set => this.Text = value;
        }
        public Cashier cashier 
        { 
            get => _cashier;
            set => _cashier = value;
        }
        System.Windows.Forms.Timer IMainView.sideBarTimer 
        {
            get => sideBarTimer; 
            set => sideBarTimer = value; 
        }
        public string CashierInfo
        {
            get => cashierInfo.Text;
            set => cashierInfo.Text = value;
        }
        #endregion

        #region EVENTS
        public event EventHandler LoadForm;
        public event EventHandler ToggleMenu;
        public event EventHandler SideBarAnimation;
        public event EventHandler ShowTicketSell;
        public event EventHandler ShowUserManager;
        public event EventHandler ShowTodayFinance;
        public event EventHandler ShowDashboard;
        #endregion

        #region METHODS
        public void InitializeEvents()
        {
            this.Load += delegate { LoadForm?.Invoke(this, EventArgs.Empty); };
            menuBtn.Click += delegate { ToggleMenu?.Invoke(this, EventArgs.Empty); };
            dashboardBtn.Click += delegate { ShowDashboard?.Invoke(this, EventArgs.Empty); };
            dashboardLb.Click += delegate { ShowDashboard?.Invoke(this, EventArgs.Empty); };
            sellTicketBtn.Click += delegate { ShowTicketSell?.Invoke(this, EventArgs.Empty); };
            sellTicketLb.Click += delegate { ShowTicketSell?.Invoke(this, EventArgs.Empty); };
            userManagerBtn.Click += delegate { ShowUserManager?.Invoke(this, EventArgs.Empty); };
            userManagerLb.Click += delegate { ShowUserManager?.Invoke(this, EventArgs.Empty); };
            todayFinanceBtn.Click += delegate { ShowTodayFinance?.Invoke(this, EventArgs.Empty); };
            todayFinanceLbl.Click += delegate { ShowTodayFinance?.Invoke(this, EventArgs.Empty); };
            sideBarTimer.Tick += delegate { SideBarAnimation?.Invoke(this, EventArgs.Empty); };
        }

        // -- REDIRECTIONS --
        public void RedirectToTicketSell()
        {
            ShowTicketSell?.Invoke(this, EventArgs.Empty);
        }

        public void RedirectToTodayFinance()
        {
            ShowTodayFinance?.Invoke(this, EventArgs.Empty);
        }

        public void RedirectToUserManager()
        {
            ShowUserManager?.Invoke(this, EventArgs.Empty);
        }

        public void RedirectToCashSelection()
        {
            throw new NotImplementedException();
        }

        public void RedirectToDashBoard()
        {
            ShowDashboard?.Invoke(this, EventArgs.Empty);
        }
        #endregion
    }
}
