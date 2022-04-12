using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWithMe.Entities
{
    public class Travel
    {
        public int Id { get; set; }

        public string Name {get; set;}

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string StartDestination { get; set; }

        public string EndDestination { get; set; }

        public string Picture { get; set; }

        public int NumberOfPlaces { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }



 }
}
