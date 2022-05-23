using Microsoft.EntityFrameworkCore;
using TicketSeller.Model;
using TicketSeller.Model.Context;
using TicketSeller.Repositories.Common;
using TicketSeller.Repositories.Interfaces;

namespace TicketSeller.Repositories
{
    internal class TicketSellRepository : ITicketSellRepository
    {
        private TicketSellerDbContext dbContext;

        public TicketSellRepository(TicketSellerDbContext ctx)
        {
            dbContext = ctx;
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public IQueryable<City> GetAllCities()
        {
            return dbContext.Cities;
        }

        public IQueryable<Customer> GetAllCustomers()
        {
            return dbContext.Customers;
        }

        public IQueryable<Ticket> GetAllTickets()
        {
            return dbContext.Tickets;
        }

        //if user is not registered
        public Discount GetDiscountByTicketId(int id)
        {
            if (id == 0) return null;

            var d = dbContext.Discounts.Where(i => i.TicketId == id).Include(t=>t.Ticket).FirstOrDefault();

            bool isValid = DiscountValidator.Validate(d.Ticket, dbContext.Discounts.ToList());

            if(isValid)
                return d;
            return null;
        }

        public int GetFromToDistance(City from, City to)
        {
            var distance = dbContext.Distances.Where(d => d.FromCityId == from.Id && d.DestinationId == to.Id).First().Distance1;

            if (distance == null || distance == 0) return 0;

            return distance;
        }

        public Worker GetWorker(int id)
        {
            return dbContext.Workers.Where(w => w.Id == id).First();
        }

        public void SellTicket(Customer customer, Ticket ticket, Worker worker, int price, bool payWithCreditCard)
        {
            if (customer == null || ticket == null || worker == null) return;

            var _customer = dbContext.Customers.Where(c => c.Id == customer.Id).First();
            var _ticket = dbContext.Tickets.Where(c => c.Id == ticket.Id).First();
            var _worker = dbContext.Workers.Where(c => c.Id == worker.Id).First();

            if (_customer == null || _ticket == null || _worker == null) return;

            //Customer table
            _customer.Ticket = ticket;
            _customer.BoughtTicket = customer.BoughtTicket;

            //Finance
            var _finance = new Finance()
            {
                Customer = _customer,
                Worker = _worker,
                Ticket = _ticket,
                PayWithCreditCard = payWithCreditCard,
                DateTime = DateTime.Now,
                Price = price
            };
            dbContext.Finances.Add(_finance);

            dbContext.SaveChanges();
        }

        public void SellTicket(Discount discount, Ticket ticket, Worker worker, int price, bool payWithCreditCard)
        {
            if (discount == null || ticket == null || worker == null) return;

            var _discount = dbContext.Discounts.Where(c => c.Id == discount.Id).First();
            var _ticket = dbContext.Tickets.Where(c => c.Id == ticket.Id).First();
            var _worker = dbContext.Workers.Where(c => c.Id == worker.Id).First();

            if (_discount == null || _ticket == null || _worker == null) return;

            //Finance
            var _finance = new Finance()
            {
                Worker = _worker,
                Ticket = _ticket,
                PayWithCreditCard = payWithCreditCard,
                DateTime = DateTime.Now,
                Price = price
            };
            dbContext.Finances.Add(_finance);

            dbContext.SaveChanges();
        }

        public void SetCustomerBoughtTicketCountToNull(Customer customer)
        {
            if (customer == null) return;

            var c = dbContext.Customers.Where(i => i.Id == customer.Id).First();

            if (c == null) return;

            c.BoughtTicket = 0;

            dbContext.SaveChanges();
        }

        Discount ITicketSellRepository.GetDiscount(int id)
        {
            return dbContext.Discounts.First(d => d.Id == id);
        }

        //if user is registered
        Customer ITicketSellRepository.GetCustomerByIdentifier(string identifier)
        {
            if (string.IsNullOrEmpty(identifier)) return null;

            identifier = identifier.ToLower().Trim();
            var customer = dbContext.Customers.Where(c => c.Identifier == identifier).Include(d => d.Discount).FirstOrDefault();

            if (customer != null)
                DiscountValidator.Validate(ref customer, dbContext.Discounts.ToList());

            return customer;
        }
    }
}
