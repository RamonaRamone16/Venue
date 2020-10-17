using System;
using System.Collections.Generic;
using System.Text;

namespace Venue.DAL.Entities
{
    public class Rating : BaseEntity<int>
    {
        public int Number { get; set; }
        public string UserId { get; set; }
        public int PlaceId { get; set; }

        public User User { get; set; }
        public Place Place { get; set; }
    }
}
