using Microsoft.EntityFrameworkCore;
using TicketSeller.Model;
using TicketSeller.Model.Context;
using TicketSeller.Repositories.Interfaces;

namespace TicketSeller.Repositories
{
    internal class DashboardRepository : BaseRepository, IDashboardRepository
    {
        private TicketSellerDbContext dbContext;

        public DashboardRepository(TicketSellerDbContext ctx)
        {
            dbContext = ctx;
        }

        public bool EqualsUpToDay(DateTime dt1, DateTime dt2)
        {
            return dt1.Year == dt2.Year && dt1.Month == dt2.Month && dt1.Day == dt2.Day;
        }

        public bool EqualsBetween(DateTime checkDate, DateTime fromDate)
        {
            DateTime toDate = fromDate.AddDays(6d);
            return checkDate >= fromDate && checkDate <= toDate;
        }

        public IEnumerable<Finance> GetCurrentDayFinance()
        {
            DateTime now = DateTime.Now;
            return dbContext.Finances
                        .Where(f => f.DateTime.Year == now.Year && f.DateTime.Month == now.Month && f.DateTime.Day == now.Day)
                        .Include(t => t.Ticket)
                        .ToList();
        }

        public IEnumerable<Finance> GetCurrentWeekFinance()
        {
            DateTime now = DateTime.Now;
            int ctWeek = GetWeekNumberOfMonth(now);

            var finances = new List<Finance>();

            foreach (var finance in dbContext.Finances)
            {
                if(ctWeek == GetWeekNumberOfMonth(finance.DateTime))
                {           
                    finances.Add(finance);
                }
            }

            return finances;

            //return dbContext.Finances
            //            .Where(f => f.DateTime.Month == now.Month)
            //            .Include(t => t.Ticket)
            //            .ToList();
        }

        public int GetWeekNumberOfMonth(DateTime date)
        {
            date = date.Date;
            DateTime firstMonthDay = new DateTime(date.Year, date.Month, 1);
            DateTime firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            if (firstMonthMonday > date)
            {
                firstMonthDay = firstMonthDay.AddMonths(-1);
                firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            }
            return (date - firstMonthMonday).Days / 7 + 1;
        }
    }
}
