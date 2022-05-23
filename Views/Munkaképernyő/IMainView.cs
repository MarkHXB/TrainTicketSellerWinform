using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSeller.Model;

namespace TicketSeller.Views
{
    public enum MenuStates
    {
        Dashboard,
        TicketSell,
        UserManager,
        TodayFinance,
        CashSelection
    }
    internal interface IMainView
    {
        // -- PROPS --
        string Message { get; set; }
        bool expandMenuBar { get; set; }
        string FormTitle { get; set; }
        string FormName { get; set; }

        string CashierInfo { get; set; }


        // -- FORM COMPONENTS --
        Panel menuPanel { get; set; }
        System.Windows.Forms.Timer sideBarTimer { get; set; }


        void RedirectToTicketSell();
        void RedirectToUserManager();
        void RedirectToCashSelection();
        void RedirectToTodayFinance();


        // -- EVENTS --
        event EventHandler LoadForm;
        event EventHandler ShowTicketSell;
        event EventHandler ShowUserManager;
        event EventHandler ShowTodayFinance;
        event EventHandler ShowDashboard;
        event EventHandler ToggleMenu;
        event EventHandler SideBarAnimation;
    }
}
