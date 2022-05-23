using System;
using System.Collections.Generic;

namespace TicketSeller.Model
{
    public partial class Finance
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int? CustomerId { get; set; }
        public int WorkerId { get; set; }
        public int TicketId { get; set; }
        public int Price { get; set; }
        public bool? PayWithCreditCard { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Ticket Ticket { get; set; } = null!;
        public virtual Worker Worker { get; set; } = null!;
    }
}
