using TicketSeller.Model;

namespace TicketSeller.Repositories.Interfaces
{
    internal interface ICashRepository
    {
        IQueryable<City> GetAll();
        City GetById(int id);
        City GetByCityName(string name);
        IQueryable<Services> GetServices(string name);
        Worker GetWorker(string cityName, int cashId);
    }
}
