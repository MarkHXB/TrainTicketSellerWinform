using TicketSeller.Model;

namespace TicketSeller.Repositories.Common
{
    public class DiscountValidator
    {
        //for registered users
        public static void Validate(ref Customer customer, in List<Discount> discounts)
        {
            if (customer == null) return;

            DateTime now = DateTime.Now;
            int age = now.Year - customer.BirthYear;
             
            //hátrányos helyzetű
            if(customer?.Discount?.Type == "Hátrányos helyzetű")
            {
                return;
            }

            //nyugdíjas
            if (age >= 65)
            {
                customer.Discount = discounts.Where(d => d.MinAge >= 65).FirstOrDefault();
            }

            //ha dologozó, akkor nem csinálok semmit
            if (customer?.Discount?.Type == "Dolgozó")
            {
                return;
            }

            //hallgató 26-ig
            else if(age > 18 && age < 26)
            {
                if(now.DayOfWeek == DayOfWeek.Friday || now.DayOfWeek == DayOfWeek.Sunday || now.DayOfWeek == DayOfWeek.Saturday)
                {
                    customer.Discount = discounts.Where(d => d.MinAge >= 19 && d.MaxAge <= 26).FirstOrDefault();
                    switch (now.DayOfWeek)
                    {
                        case DayOfWeek.Friday:
                            customer.Discount.ExpirationDate = new DateTime(now.Year, now.Month, now.Day + 2);
                            break;
                        case DayOfWeek.Saturday:
                            customer.Discount.ExpirationDate = new DateTime(now.Year, now.Month, now.Day + 1);
                            break;
                        case DayOfWeek.Sunday:
                            customer.Discount.ExpirationDate = new DateTime(now.Year, now.Month, now.Day);
                            break;
                        default:
                            break;
                    }
                }
            }
            //felnőtt
            else if(age > 26 && age < 65)
            {
                customer.Discount = discounts.Where(d => d.MinAge >= 26 && d.MaxAge <= 65).FirstOrDefault();
            }
            //diák
            else
            {
                customer.Discount = discounts.Where(d => d.MaxAge <= 18 && age > d.MinAge).FirstOrDefault();
            }
        }

        //for not registered users
        public static bool Validate(in Ticket ticket, in List<Discount> discounts)
        {
            if (ticket == null) return false;

            DateTime now = DateTime.Now;

            //hallgató 26-ig
            if(ticket.Name.ToLower() == "hallgató" && (bool)ticket.IsTicket)
            {
                if (now.DayOfWeek == DayOfWeek.Friday || now.DayOfWeek == DayOfWeek.Sunday || now.DayOfWeek == DayOfWeek.Saturday)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
