using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWithMe.Entities
{
    public class Reservation
    {

        public int Id { get; set; }
       
        public DateTime DateOfReservation {get; set;}

        public int Trip { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }




    }
}
