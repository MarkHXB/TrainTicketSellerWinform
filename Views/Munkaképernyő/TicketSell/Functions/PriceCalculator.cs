using TicketSeller.Model;
using TicketSeller.Repositories.Interfaces;
using TicketSeller.Views.Munkaképernyő.TicketSell.Models;

namespace TicketSeller.Views.Munkaképernyő.TicketSell.Functions
{
    public static class PriceCalculator
    {
        public static int Calculate(ChooseUser c_user, ChooseTicket c_ticket, Customer customer,
            Ticket ticket, ITicketSellRepository repository)
        {
            int price = 0;
            int distance = c_ticket.Distance;

            //if user is registered
            if (c_user.IsRegistered)
            {
                //if ticket is ticket
                if ((bool)ticket.IsTicket)
                {
                    //on 0 left tickets to a free ticket
                    if (customer.BoughtTicket >= 10)
                    {
                        c_ticket.Price = 0;
                        return 0;
                    }
                    //on customer has discount
                    else if (customer.Discount != null)
                    {
                        //ezt külön kell, mivel csak nála ennél a kategóriánál kell nézni a jegy akció lejártát
                        if(customer.Discount.Type == "26 éven aluli")
                        {
                            if(customer.Discount?.ExpirationDate != null)
                            {
                                int altPrice = (int)Math.Round(((double)ticket.Price / 100) * customer.Discount.DiscountValue);
                                altPrice = (int)ticket.Price - altPrice;
                                int mult = distance / 10;
                                price = ((int)(mult * altPrice));
                            }
                            else
                            {
                                int mult = distance / 10;
                                price = ((int)(mult * ticket.Price));
                            }
                        }
                        else
                        {
                            int altPrice = (int)Math.Round(((double)ticket.Price / 100) * customer.Discount.DiscountValue);
                            altPrice = (int)ticket.Price - altPrice;
                            int mult = distance / 10;
                            price = ((int)(mult * altPrice));
                        }        
                    }
                    //on customer doesn't have discount
                    else
                    {
                        int mult = distance / 10;
                        price = ((int)(mult * ticket.Price));
                    }
                }
                //if ticket is subscription
                else
                {
                    int altPrice = (int)Math.Round(((double)ticket.Price / 100) * customer.Discount.DiscountValue);
                    altPrice = (int)ticket.Price - altPrice;
                    int mult = distance / 10;
                    price = ((int)(mult * altPrice));
                }
            }
            //if user is NOT registered
            else
            {
                if (customer.Discount == null)
                {
                    int mult = distance / 10;
                    price = ((int)(mult * ticket.Price));
                }
                else
                {
                    if (customer.Discount.Type == "26 éven aluli")
                    {
                        if (customer.Discount?.ExpirationDate != null)
                        {
                            int altPrice = (int)Math.Round(((double)ticket.Price / 100) * customer.Discount.DiscountValue);
                            altPrice = (int)ticket.Price - altPrice;
                            int mult = distance / 10;
                            price = ((int)(mult * altPrice));
                        }
                        else
                        {
                            int mult = distance / 10;
                            price = ((int)(mult * ticket.Price));
                        }
                    }
                    else
                    {
                        int altPrice = (int)Math.Round(((double)ticket.Price / 100) * customer.Discount.DiscountValue);
                        altPrice = (int)ticket.Price - altPrice;
                        int mult = distance / 10;
                        price = ((int)(mult * altPrice));
                    }     
                }
            }
            return price;
        }
    }
}
