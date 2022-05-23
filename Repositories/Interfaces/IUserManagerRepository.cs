using TicketSeller.Model;
using TicketSeller.Views.Munkaképernyő.UserManager;

namespace TicketSeller.Repositories.Interfaces
{
    internal interface IUserManagerRepository
    {
        IQueryable<Customer> GetCustomers();
        void Add(Customer customer);
        void Edit(Customer customer);
        void Delete(Customer customer);
        Discount GetDiscount(CustomerTypeHelper category);
        Customer GetLastCustomer();
        string GetCustomerType(int birthyear);
        Customer GetUserByIdentifier(string id);
    }
}
