using System;
using System.Collections.Generic;

namespace TicketSeller.Model
{
    public partial class Distance
    {
        public int Id { get; set; }
        public int FromCityId { get; set; }
        public int DestinationId { get; set; }
        public int Distance1 { get; set; }

        public virtual City Destination { get; set; } = null!;
        public virtual City FromCity { get; set; } = null!;
    }
}
