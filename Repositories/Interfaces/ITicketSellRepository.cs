using TicketSeller.Model;

namespace TicketSeller.Repositories.Interfaces
{
    public interface ITicketSellRepository
    {
        IQueryable<Customer> GetAllCustomers();
        void Add();
        Discount GetDiscount(int id);
        Discount GetDiscountByTicketId(int id);
        IQueryable<City> GetAllCities();
        IQueryable<Ticket> GetAllTickets();
        Worker GetWorker(int id);
        int GetFromToDistance(City from, City to);
        void SetCustomerBoughtTicketCountToNull(Customer customer);
        void SellTicket(Customer customer, Ticket ticket, Worker worker, int price, bool payWithCreditCard);
        void SellTicket(Discount discount, Ticket ticket, Worker worker, int price, bool payWithCreditCard);
        Customer GetCustomerByIdentifier(string identifier);
    }
}
