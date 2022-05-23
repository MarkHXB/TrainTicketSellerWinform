using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketSeller.Model
{
    public partial class Customer
    {
        public Customer()
        {
            Finances = new HashSet<Finance>();
        }

        public string Identifier { get; set; } = null!;

        [MaxLength(15, ErrorMessage = "A felhasználó neve maximum 15 karakter lehet!"), 
            MinLength(3, ErrorMessage = "A felhasználó neve minimum 3 karakternek kell lennie!")]
        public string Name { get; set; } = null!;
        public int BirthYear { get; set; }
        public int? TicketId { get; set; }
        public int Id { get; set; }
        public int BoughtTicket { get; set; }
        public int? DiscountId { get; set; }

        public virtual Discount? Discount { get; set; }
        public virtual Ticket? Ticket { get; set; }
        public virtual ICollection<Finance> Finances { get; set; }
    }
}
