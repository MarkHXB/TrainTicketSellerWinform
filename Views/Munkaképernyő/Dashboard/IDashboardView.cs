namespace TicketSeller.Views.Munkaképernyő.Statistics
{
    internal interface IDashboardView
    {
        TicketStatistics TicketStatistics { get; set; }
        MoneyStatistics MoneyStatistics { get; set; }

        event EventHandler FormLoad;
        event EventHandler Refresh;

        void Show();
    }
}
