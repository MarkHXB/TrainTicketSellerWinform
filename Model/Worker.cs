using System;
using System.Collections.Generic;

namespace TicketSeller.Model
{
    public partial class Worker
    {
        public Worker()
        {
            Finances = new HashSet<Finance>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CityId { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual ICollection<Finance> Finances { get; set; }
    }
}
