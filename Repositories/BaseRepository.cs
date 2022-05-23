using Microsoft.EntityFrameworkCore;

namespace TicketSeller.Repositories
{
    internal abstract class BaseRepository
    {
        protected DbContext dbContext;
    }
}
