using TicketSeller.Views.Munkaképernyő.TodayFinance;

namespace TicketSeller.Views
{
    internal interface ITodayFinanceView
    {
        MoneyAndBankChart MoneyAndBankChart { get; set; }
        SumChart SumChart { get; set; }

        event EventHandler FormLoad;
        event EventHandler Refresh;

        void Show();
    }
}
