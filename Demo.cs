using TicketSeller.Model;
using TicketSeller.Model.Context;

namespace TicketSeller
{
    public static class Demo
    {
        public static void Simulate1000Transactions()
        {
            try
            {
                using (TicketSellerDbContext db = new TicketSellerDbContext())
                {
                    var user1 = db.Customers.Where(u => u.Id == 1).First();
                    var user2 = db.Customers.Where(u => u.Id == 3).First();

                    var tickets = db.Tickets.ToList();

                    for (int i = 0; i < 1000; i++)
                    {
                        Finance finance = null;
                        Ticket ticket = GetRandomTicket(tickets);

                        if (i % 2 == 0)
                        {
                            finance = new Finance()
                            {
                                DateTime = new DateTime(2022,05,04),
                                CustomerId = user1.Id,
                                Ticket = ticket,               
                                WorkerId = 1,
                                Price = (int)ticket.Price,
                                PayWithCreditCard = new Random().Next(1) == 0 ? false : true
                            };
                        }
                        else
                        {
                            finance = new Finance()
                            {
                                DateTime = new DateTime(2022, 05, 04),
                                CustomerId = user2.Id,
                                Ticket = ticket,
                                WorkerId = 2,
                                Price = (int)ticket.Price,
                                PayWithCreditCard = new Random().NextDouble() >= 0.5
                            };
                        }

                        db.Finances.Add(finance);
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GenerateWorkers()
        {
            try
            {
                using (TicketSellerDbContext db = new TicketSellerDbContext())
                {
                    foreach (var city in db.Cities)
                    {
                        int workersCount = city.Workers.Count;                     
                        int reaminingCashes = (int)(city.CashCount - workersCount);
                        for (int i = 0; i < reaminingCashes; i++)
                        {
                            Worker worker = new Worker()
                            {
                                City = city,
                                Name = GenerateName(6)
                            };

                            db.Workers.Add(worker);
                        }
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GenerateCustomers(int count)
        {
            try
            {
                using (TicketSellerDbContext db = new TicketSellerDbContext())
                {
                    for (int i = 0; i < count; i++)
                    {
                        Customer customer = new Customer()
                        {
                            Identifier = IdentifierGenerator(),
                            Name = GenerateName(new Random().Next(8)),
                            BirthYear = BirthYearGenerator(),
                            BoughtTicket = BoughtTicketGenerator(),
                            Discount = db.Discounts.Where(d => d.Id == DiscountIdGenerator()).FirstOrDefault()
                        };

                        db.Customers.Add(customer);
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }
        static int BirthYearGenerator()
        {
            int[] years =
            {
                1999,2000,2001,2002,2003,2005,2006
            };
            return years[new Random().Next(years.Length)];
        }
        static int BoughtTicketGenerator() => new Random().Next(10);
        static int DiscountIdGenerator() => new Random().Next(11);
        static int PriceGenerator(int min, int max)
        {
            return new Random().Next(min, max);
        }
        static string IdentifierGenerator()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 7)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
        static int CityIdGenerator() => new Random().Next(5);

        static Ticket GetRandomTicket(List<Ticket> tickets)
        {
            return tickets[new Random().Next(tickets.Count)];
        }

    }
}
