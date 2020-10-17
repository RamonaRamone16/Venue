using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Venue.DAL.Entities
{
    public class User : IdentityUser
    {
        public ICollection<Place> Venues { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}
