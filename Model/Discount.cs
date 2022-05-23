using System;
using System.Collections.Generic;

namespace TicketSeller.Model
{
    public partial class Discount
    {
        public Discount()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public DateTime? ExpirationDate { get; set; }
        public int DiscountValue { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public bool IsTicket { get; set; }
        public int? TicketId { get; set; }

        public virtual Ticket? Ticket { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
