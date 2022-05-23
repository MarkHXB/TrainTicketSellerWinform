using System;
using System.Collections.Generic;

namespace TicketSeller.Model
{
    public partial class City
    {
        public City()
        {
            DistanceDestinations = new HashSet<Distance>();
            DistanceFromCities = new HashSet<Distance>();
            Workers = new HashSet<Worker>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? CashCount { get; set; }

        public virtual ICollection<Distance> DistanceDestinations { get; set; }
        public virtual ICollection<Distance> DistanceFromCities { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
    }
}
