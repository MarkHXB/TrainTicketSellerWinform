using System;
using System.Collections.Generic;

namespace TicketSeller.Model
{
    public partial class Ticket
    {
        public Ticket()
        {
            Customers = new HashSet<Customer>();
            Discounts = new HashSet<Discount>();
            Finances = new HashSet<Finance>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public bool? IsTicket { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual ICollection<Finance> Finances { get; set; }
    }
}
