using System.Collections.Generic;

namespace Venue.DAL.Entities
{
    public class Place : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }

        public User User { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}
