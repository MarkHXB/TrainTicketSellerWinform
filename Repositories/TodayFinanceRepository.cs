using Microsoft.EntityFrameworkCore;
using TicketSeller.Repositories.Interfaces;

namespace TicketSeller.Repositories
{
    internal class TodayFinanceRepository : BaseRepository, ITodayFinanceRepository
    {
        public TodayFinanceRepository(DbContext ctx)
        {
            this.dbContext = ctx;
        }
    }
}
