using Microsoft.EntityFrameworkCore;
using TicketSeller.Model;
using TicketSeller.Model.Context;
using TicketSeller.Repositories.Interfaces;

namespace TicketSeller.Repositories
{
    internal class CashRepository : BaseRepository, ICashRepository
    {
        private TicketSellerDbContext dbContext;

        public CashRepository(TicketSellerDbContext ctx)
        {
            dbContext = ctx;
        }

        public IQueryable<City> GetAll()
        {
            return dbContext.Cities;
        }

        public City GetByCityName(string name)
        {
            return dbContext.Cities.Where(c => c.Name == name).FirstOrDefault() ?? new City();
        }

        public City GetById(int id)
        {
            return dbContext.Cities.Where(c => c.Id == id).FirstOrDefault() ?? new City();
        }

        public IQueryable<Services> GetServices(string name)
        {
            throw new NotImplementedException();
        }

        public Worker GetWorker(string cityName, int cashId)
        {
            City actCity = dbContext.Cities.Where(w => w.Name == cityName).First();
            List<Worker> workers = dbContext.Workers.Where(c => c.CityId == actCity.Id).Include(f => f.Finances).ToList();

            int casherId = 0;

            foreach (var city in dbContext.Cities)
            {
                if(actCity.Name == city.Name)
                {
                    break;
                }
                else
                {
                    casherId += city.CashCount.Value;
                }
            }


            casherId += cashId;

            return workers.Where(w=>w.Id == casherId).FirstOrDefault();
        }
    }
}
