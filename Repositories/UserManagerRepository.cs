using Microsoft.EntityFrameworkCore;
using TicketSeller.Model;
using TicketSeller.Model.Context;
using TicketSeller.Repositories.Interfaces;
using TicketSeller.Views.Munkaképernyő.UserManager;

namespace TicketSeller.Repositories
{
    internal class UserManagerRepository : BaseRepository, IUserManagerRepository
    {
        private TicketSellerDbContext dbContext;

        public UserManagerRepository(TicketSellerDbContext ctx)
        {
            this.dbContext = ctx;
        }

        public void Add(Customer customer)
        {
            if (customer == null) return;

            dbContext.Customers.Add(customer);

            dbContext.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            dbContext.Customers.Remove(customer);
            dbContext.SaveChanges();
        }

        public IQueryable<Customer> GetCustomers()
        {
            return dbContext.Customers.Include(c=>c.Discount);
        }

        public void Edit(Customer customer)
        {
            var user = GetUserByIdentifier(customer.Identifier);
            if (user != null)
            {
                user.Name = customer.Name;
                user.BirthYear = customer.BirthYear;
                user.Discount = customer.Discount;
                dbContext.SaveChanges();
            }
            else
            {
                throw new Exception($"Customer Id:{customer.Id} not found in the database.");
            }
        }

        public Customer GetLastCustomer()
        {
            if (dbContext.Customers.Count() == 0) return null;
            else
            {
                var user = dbContext.Customers.OrderBy(p => p.Id).ToList().LastOrDefault();

                if (user == null) return null;

                return user;
            }
        }

        public string GetCustomerType(int birthYear)
        {
            int age = (int)DateTime.Now.Year - birthYear;
            return "";
        }

        public Customer GetUserByIdentifier(string id)
        {
            return dbContext.Customers.FirstOrDefault(c => c.Identifier == id);
        }

        public Discount GetDiscount(CustomerTypeHelper category)
        {
            Discount discount = null;
            switch (category)
            {
                case CustomerTypeHelper.Adult:
                    discount = dbContext.Discounts.FirstOrDefault(d => d.Type == "Felnőtt");
                    break;
                case CustomerTypeHelper.Retired:
                    discount = dbContext.Discounts.FirstOrDefault(d => d.Type == "Nyugdíjas");
                    break;
                case CustomerTypeHelper.YoungAdult:
                    discount = dbContext.Discounts.FirstOrDefault(d => d.Type == "26 éven aluli");
                    break;
                case CustomerTypeHelper.Student:
                    discount = dbContext.Discounts.FirstOrDefault(d => d.Type == "Diák");
                    break;
                case CustomerTypeHelper.Diasadvantaged:
                    discount = dbContext.Discounts.FirstOrDefault(d => d.Type == "Hátrányos helyzetű");
                    break;
                case CustomerTypeHelper.Worker:
                    discount = dbContext.Discounts.FirstOrDefault(d => d.Type == "Dolgozó");
                    break;
                default:
                    break;
            }

            if (discount == null) return null;

            return discount;
        }
    }
}
