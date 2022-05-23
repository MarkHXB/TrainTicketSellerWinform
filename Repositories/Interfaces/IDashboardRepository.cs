using TicketSeller.Model;

namespace TicketSeller.Repositories.Interfaces
{
    internal interface IDashboardRepository
    {
        IEnumerable<Finance> GetCurrentDayFinance();
        IEnumerable<Finance> GetCurrentWeekFinance();
    }
}
