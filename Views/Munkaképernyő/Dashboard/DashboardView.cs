using System.ComponentModel;

namespace TicketSeller.Views.Munkaképernyő.Statistics
{
    public partial class DashboardView : Form, IDashboardView
    {
        private static DashboardView instance;
        private TicketStatistics ticketStatistics;
        private MoneyStatistics moneyStatistics;

        public DashboardView()
        {
            InitializeComponent();

            ticketStatistics = new TicketStatistics();
            moneyStatistics = new MoneyStatistics();

            InitializeEvents();
        }

        public TicketStatistics TicketStatistics
        {
            get => ticketStatistics;
            set => ticketStatistics = value;
        }
        public MoneyStatistics MoneyStatistics
        {
            get => moneyStatistics;
            set => moneyStatistics = value;
        }


        #region EVENTS
        public event EventHandler FormLoad;
        public event EventHandler Refresh;
        #endregion

        private void InitializeEvents()
        {
            this.Load += delegate
            {
                FormLoad?.Invoke(this, EventArgs.Empty);

                if (TicketStatistics.IsSuccessfuly)
                {
                    TicketStatistics.Load(ref chart1);
                }
                else notificationsLb.Text = TicketStatistics.Message;

                if (MoneyStatistics.IsSuccessfuly)
                {
                    MoneyStatistics.Load(ref chart2);
                }
                else notificationsLb.Text = MoneyStatistics.Message;

                updatedLb.Text = "Frissítve lett ekkor: " + DateTime.Now.ToShortTimeString();
            };
            updateBtn.Click += delegate 
            { 
                Refresh?.Invoke(this, EventArgs.Empty);

                if (TicketStatistics.IsSuccessfuly)
                {
                    TicketStatistics.Load(ref chart1);
                }
                else notificationsLb.Text = TicketStatistics.Message;

                if (MoneyStatistics.IsSuccessfuly)
                {
                    MoneyStatistics.Load(ref chart2);
                }
                else notificationsLb.Text = MoneyStatistics.Message;

                updatedLb.Text = "Frissítve lett ekkor: " + DateTime.Now.ToShortTimeString();
            };
        }
        public static DashboardView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DashboardView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
